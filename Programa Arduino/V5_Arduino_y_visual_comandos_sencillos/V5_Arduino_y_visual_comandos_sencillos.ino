/************************************************************************************************************************
 * TITULO: V4_-_Arduino_y_Visual
 * Descripcion: App de Windows Forms con Arduino - V3 version funcional en arduino incluyendo modulo bt, funciona en c# de manera basica, error al enviar info al display, verificar que se envien y reciban los comandos correctamente
 * cambiar los comandos por letras o = open, c= close
 * AUTOR: JEGZ
 * DESCRIPCION: Este es el código para arduino que permite controlar un lCD 1602A, servo (abrir y cerrar puerta) desde una app en C# windos forms VS
 * © 2021 29/11/2021 
 * **********************************************************************************************************************/
//librerias y configuracion del display LCD
#include <LiquidCrystal_I2C.h>
#include <Servo.h>
#include <Wire.h>
#include <Keypad.h>
LiquidCrystal_I2C lcd(0x27,0x20,0x3f) ; //configuracion correcta para el display JEGZ 

//Variables
int mot_min = 90;              //min servo angle  (puerta cerrada)
int mot_max = 180;          //Max servo angle   (puerta abierta)
int character = 0;              //caracter leido del teclado?
int activated =0;               //estado de la puerta 0 = close, 1 = verificando pass, 2 = open
char Received = 'c';       //dato recibido del modulo bt (por defecto cerrado)
char Str[16] = {' ', ' ', ' ', ' ', ' ', ' ', '-', '*', '*', '*', ' ', ' ', ' ', ' ', ' ', ' '};   

//Configuracion de los Pines
int buzzer=11;     //pin para el buzzer
int external = 12; //pin para boton abrir (o)
int internal = 13; //pin para el boton cerrar (c)
const byte servoPin = 10; //  JEGZ DEBE SER EN EL PIN  10

//Keypad config
const byte ROWS = 4; //4 renglones
const byte COLS = 4; //4 columnas
//definiendo los simbolos de los botones del teclado
char hexaKeys[ROWS][COLS] = {
  {'1','4','7','*'},
  {'2','5','8','0'},
  {'3','6','9','#'},
  {'A','B','C','D'}
};
byte rowPins[ROWS] = {5, 4, 3, 2}; //connect to the row pinouts of the keypad
byte colPins[COLS] = {9, 8, 7, 6}; //connect to the column pinouts of the keypad

//initializando una instancia de la clase NewKeypad
Keypad customKeypad = Keypad( makeKeymap(hexaKeys), rowPins, colPins, ROWS, COLS); 

///------------- Agregado para enviar datos a c# -------------//
// Para el servo
Servo servo1;

// Para el lcd
String lcdMsgRow1 = "";
String lcdMsgRow2 = "";

// Para los Comandos
String inputString = "";     // a String to hold incoming data
bool stringComplete = false; // whether the string is complete

//int num; //variable para mandar datos a c# por cada loop
///-------------                                                              -------------//
void setup()
{
    Serial.begin(9600);
    //num = 0;
    
    lcd.init(); // initialize the lcd
    lcd.clear();
    lcd.backlight();

  //configurando el Servomotor
  servo1.attach(servoPin);
  servo1.write(mot_min); //inicializa en 90 grados

  pinMode(buzzer,OUTPUT); 
  pinMode(external,INPUT);
  pinMode(internal,INPUT); 

  lcd.print("    PASSWORD");
  lcd.setCursor(0,1);
  lcd.print("      -***     ");
} // eof setup


void loop()
{
///////////////Android OPEN/CLOSE/////////  
  if(Serial.available()>0)
 { 
    char Received = Serial.read();

    if (Received == 'c') //si recibe una c desde la app
    {
      CerrarPuerta();
    }
    if (Received == 'o')
    {
        AbrirPuerta();
    }
 } //EOF ANDROID OPEN/CLOSE

 ///////////////EMERGENCY OPEN/CLOSE/////////
  if (digitalRead(external))
  {
      lcd.clear();
      lcd.setCursor(2,0);
      lcd.print("INSIDE  OPEN");
      activated = 2;

    AbrirPuerta();
  }

  if (digitalRead(internal))
  {
    CerrarPuerta();
  } //EOF EMERGENCY OPEN/CLOSE

  ///////////////KEYPAD OPEN/CLOSE////////////  
  char customKey = customKeypad.getKey(); //this function reads the presed key
  
  if (customKey){
  analogWrite(buzzer,200);
    if (character ==0)
    {  
    Serial.println(char(customKey));
    Str[6]= customKey;   
    MuestraPass();
    }

    if (character ==1)
    {  
    Serial.println(char(customKey));
    Str[7]= customKey;   
    MuestraPass();
    }

    if (character ==2)
    {  
    Serial.println(char(customKey));
    Str[8]= customKey;   
    MuestraPass();
    }

    if (character ==3)
    {  
    Serial.println(char(customKey));
    Str[9]= customKey;   
    MuestraPass();
    }

    if (character ==4)
    {  
    Serial.println(char(customKey));
    delay(500);//JEGZ delay agregado para MANDAR A C#
    Str[10]= customKey;
    activated=1;
    }
    character=character+1;
    delay(100);
    analogWrite(buzzer,LOW);
  }

  if (activated == 1)
    {
    if(Str[10]='A' && character==5 && Str[6]=='3' && Str[7]=='0' && Str[8]=='0' && Str[9]=='7' )
    {
     AbrirPuerta();
    }
    else
    {
      Serial.println("e"); //JEGZ MANDAR A C#
      lcd.clear();    
      lcd.setCursor(1,0);
      lcd.print("PASSWORD ERROR");
      lcd.setCursor(3,1);
      lcd.print("TRY  AGAIN");
      analogWrite(buzzer,150);
      delay(3000);
      analogWrite(buzzer,LOW);
      character=0;
      Str[6]= '-';
      Str[7]= '*'; 
      Str[8]= '*'; 
      Str[9]= '*';
      Str[10]= ' ';
      activated = 0;
      lcd.clear();    
      lcd.setCursor(4,0);
      lcd.print("PASSWORD");
      lcd.setCursor(0,1);
      lcd.print(Str);   
    }
  }
  if (activated == 2)
    {
    if(customKey == 'B' )
    {
        CerrarPuerta();
    }
  }  //EOF KEYPAD 
 
} // eof loop


/**** Helper Functions ****/
void serialEvent() //funcion que lee datos del puerto serial
{
    while (Serial.available()) //mientras el puerto este disponibles
    {
        char inChar = (char)Serial.read(); //obtiene el caracter
        
        if (inChar == 'o'){ //$S90     
        //MoveServo(180);
        AbrirPuerta();
        }
        else if  (inChar == 'c'){ //$S90
        //MoveServo(90);
        CerrarPuerta();
    }
    }
} // EOF serialEvent

void MoveServo(int turn)
{
    servo1.write(turn);
   //delay(1000);
}

void AbrirPuerta(){
      Serial.println("o"); //JEGZ MANDAR A C#
      delay(500);//JEGZ delay agregado para MANDAR A C#
      servo1.write(mot_max);
      lcd.clear();
      lcd.setCursor(4,0);
      lcd.print("ACCEPTED");
      activated = 2;
      analogWrite(buzzer,240);
      delay(250);
      analogWrite(buzzer,200);
      delay(250);
      analogWrite(buzzer,180);
      delay(250);
      analogWrite(buzzer,250);
      delay(250);
      analogWrite(buzzer,LOW);
      delay(1000);
      
      lcd.clear();    
      lcd.setCursor(4,0);
      lcd.print("WELLCOME");
      delay(500);
      lcd.setCursor(2,1);
      lcd.print("BIENVENIDO");
      delay(1000);

      lcd.clear();    
      lcd.setCursor(3,0);
      lcd.print("DOOR  OPEN");
      lcd.setCursor(2,1);
      lcd.print("PUERTA ABIERTA");
}

void CerrarPuerta(){
Serial.println("c"); //JEGZ MANDAR A C#
delay(500);//JEGZ delay agregado para MANDAR A C#
servo1.write(mot_min);
activated = 0;
character=0;
Str[6]= '-';
Str[7]= '*'; 
Str[8]= '*'; 
Str[9]= '*';
Str[10]= ' ';   
lcd.clear();
lcd.setCursor(0,0);
lcd.print("    PASSWORD");    
lcd.setCursor(0,1);
lcd.print(Str);
}

void MuestraPass(){ //metodo que muestra la contraseña que se esta tecleando actualmente
      lcd.clear();
    lcd.setCursor(0,0);
    lcd.print("    PASSWORD");    
    lcd.setCursor(0,1);
    lcd.print(Str);
}
