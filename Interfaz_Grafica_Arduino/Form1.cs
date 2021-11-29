using System;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace ControlServoLCD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //bool bln_Puerta_Abierta;
        //Thread Hilo;
        private string strbufferingIn; //> Agregado JEGZ 28/11/2021 - Control del Puerto Serial con C# en Visual Studio 2015 Community
        //private char strbufferingIn;
        private string strbufferingOut;
        private string strPassword = "****";
        //char[] charArrayPass;
        char[] charArrayPass = new char[4] { '*','*','*','*'};

        public object Interfaz_Grafica_Arduino { get; private set; }

        private delegate void DelegadoAcceso(string accion);
        
        private void LimpiarPass()
        {
            charArrayPass[0] = '*';
            charArrayPass[1] = '*';
            charArrayPass[2] = '*';
            charArrayPass[3] = '*';
            strPassword = "****";
            txtPass.Text = strPassword;
        }
        private void AccesoForm(string accion)
        {
            Thread.Sleep(500);
            strbufferingIn = accion;
            //--------------------------
            lblRecibo.Text = strbufferingIn;
            //convirtiendo la cadena en arreglo de char
            char[] charArray = strbufferingIn.ToCharArray();
            char first = charArray[0];
            if (first == 'o')
            {
                //MessageBox.Show("Puerta abierta");
                btnDoor.Text = "CLOSE";
                pct_cerradura.Image = Properties.Resources.door_open;
                LimpiarPass();
            }
            if (first == 'c')
            {
                //MessageBox.Show("Puerta cerrada");
                btnDoor.Text = "OPEN";
                pct_cerradura.Image = Properties.Resources.door_close;
                LimpiarPass();
            }
            if (first == 'e')
            {
                //MessageBox.Show("Error en contraseña");
                lblRecibo.Text = "Error en contraseña";
                LimpiarPass();
            }
            //-------Agregado para recibir la contraseña 
            if(first == '0' || first == '1' || first == '2' || first == '3' || first == '4' || 
                first == '5' || first == '6' || first == '7' || first == '8' || first == '9' || 
                first == 'A' || first == 'B' || first == 'C' || first == 'D')
            {
                for(int i=0; i<4; i++)
                {
                    if (charArrayPass[i] == '*')
                    {
                        charArrayPass[i] = first;
                        break;
                    }
                    /*
                    charArrayPass[i] = first;
                    if (i == 5)
                    {
                        break;
                    }*/
                }
            }
            string s = new string(charArrayPass);
            strPassword = s;
            txtPass.Text = strPassword;
            //-------
            //---------------------------
        }

        private void AccesoInterrupcion(string accion)
        {
            DelegadoAcceso VarDelegadoAcceso;
            VarDelegadoAcceso = new DelegadoAcceso(AccesoForm);
            object[] arg = { accion };
            base.Invoke(VarDelegadoAcceso,arg);
        }
        //< Agregado JEGZ 28/11/2021 

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                disableComponents();

                // comboboxPuerto
                string[] ports = SerialPort.GetPortNames();
                comboBoxPuerto.DataSource = ports;             

                // comboBoxBaud
                string[] rates = { "9600", "38400", "57600", "115200" };
                comboBoxBaud.DataSource = rates;
                labelInfo.Text = "";

                btnDoor.Enabled = false;

                //bool bln_Puerta_Abierta;

                //codigo para evitar mensaje de error: Cross-thread operation not valid
                //TextBox.CheckForIllegalCrossThreadCalls = false;
                //Label.CheckForIllegalCrossThreadCalls = false;

                //Agrego un hilo para el metodo EscucharSerial() 24/11/2021
                //Thread Hilo = new Thread(EscucharSerial);
                //Hilo.Start();

                strbufferingIn = ""; //> Agregado JEGZ 28/11/2021 - Control del Puerto Serial con C# en Visual Studio 2015 Community
                strbufferingOut = ""; //< Agregado JEGZ 28/11/2021 

                lblRecibo.Visible = false;
                Recibo.Visible = false;
                Envio.Visible = false;
                lblDatosEnviados.Visible = false;
    }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Close();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }



        private void buttonConectar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!serialPort1.IsOpen)
                {
                    serialPort1.BaudRate = Convert.ToInt32(comboBoxBaud.Text);
                    //>Agregado JEGZ - Control del Puerto Serial con C# en Visual Studio 2015 Community
                    serialPort1.DataBits = 8; 
                    serialPort1.Parity = Parity.None;  
                    serialPort1.StopBits = StopBits.One; 
                    serialPort1.Handshake = Handshake.None;
                    textBoxLinea1.Text = "";
                    textBoxLinea2.Text = "";
                    //<JEGZ 27/11/2021
                    serialPort1.PortName = comboBoxPuerto.Text;
                    serialPort1.Open();

                    labelInfo.Text = "90°";//>JEGZ 27/11/2021
                    serialPort1.DiscardOutBuffer();
                    //strbufferingOut = $"$S90";
                    strbufferingOut = "c"; //JEGZ 6:34 28/11/2021
                    pct_cerradura.Image = Properties.Resources.door_close;
                    serialPort1.WriteLine(strbufferingOut);
                    lblDatosEnviados.Text = strbufferingOut;//<JEGZ 27/11/2021

                    progressBarConexion.Value = 100;
                    buttonConectar.Text = "DESCONECTAR";
                    buttonRefrescar.Enabled = false;

                    // habilitar componentes del form
                    enableComponents();

                    //Agrego un hilo para el metodo EscucharSerial() 24/11/2021
                    //Thread Hilo = new Thread(EscucharSerial);
                    //Hilo = new Thread(EscucharSerial);
                    //Hilo.Start();
                }
                else
                {
                    // empty lines
                    textBoxLinea1.Text = "";
                    textBoxLinea2.Text = "";

                    disableComponents();                    
                    progressBarConexion.Value = 0;
                    buttonConectar.Text = "CONECTAR";
                    buttonRefrescar.Enabled = true;
                    borrarLCD();

                    //labelInfo.Text = "90°";
                    //serialPort1.WriteLine($"$S90");
                    labelInfo.Text = "90°";//>JEGZ 27/11/2021
                    serialPort1.DiscardOutBuffer();
                    //strbufferingOut = $"$S90";
                    strbufferingOut = "c"; //JEGZ 6:34 28/11/2021
                    serialPort1.WriteLine(strbufferingOut);
                    lblDatosEnviados.Text = strbufferingOut;//<JEGZ 27/11/2021

                    serialPort1.Close();

                    //Hilo.Abort();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }


        private void buttonRefrescar_Click(object sender, EventArgs e)
        {
            // vuelve a verificara los puertos disponibles para comboboxPuerto
            string[] ports = SerialPort.GetPortNames();
            comboBoxPuerto.DataSource = ports;
            strbufferingIn = ""; //> Agregado JEGZ 28/11/2021 - Control del Puerto Serial con C# en Visual Studio 2015 Community
            strbufferingOut = ""; //< Agregado JEGZ 28/11/2021 
        }
        

        private void buttonImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                // leer las lineas de texto
                string l1 = textBoxLinea1.Text;
                string l2 = textBoxLinea2.Text;

                // rellenar a 16 caracteres la linea1
                int n = l1.Length;
                if (n < 16)
                {
                    for (int i = 0; i < (16 - n); i++)
                    {
                        // agregar un espacio en blanco
                        l1 += " ";
                    }
                }

                // enviar comando a arduino para imprimir en el mensaje
                serialPort1.WriteLine($"$L{l1}{l2}");

                l1 = "";
                l2 = "";
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }            
        }


        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                borrarLCD();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }


        private void trackBarServo_Scroll(object sender, EventArgs e)
        {
            try
            {
                // enviar comando de grados al servo
                labelInfo.Text = trackBarServo.Value + "°";
                //serialPort1.WriteLine($"$S{labelInfo.Text}");
                if(trackBarServo.Value == 90)
                {
                    btnDoor.Text = "OPEN";
                    labelInfo.Text = $"90°";
                    textBoxLinea1.Text = "";
                    textBoxLinea2.Text = "";
                    serialPort1.DiscardOutBuffer();
                    strbufferingOut = "c"; 
                    pct_cerradura.Image = Properties.Resources.door_close;
                    lblDatosEnviados.Text = strbufferingOut;
                    serialPort1.WriteLine(strbufferingOut);
                }else if(trackBarServo.Value == 180 || trackBarServo.Value == 0)
                {
                    btnDoor.Text = "CLOSE";
                    labelInfo.Text = $"180°";
                    textBoxLinea1.Text = "";
                    textBoxLinea2.Text = "";
                    serialPort1.DiscardOutBuffer();
                    strbufferingOut = "o";
                    pct_cerradura.Image = Properties.Resources.door_close;
                    lblDatosEnviados.Text = strbufferingOut;
                    serialPort1.WriteLine(strbufferingOut);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }            
        }


        /*******  helper methods *********/
        private void disableComponents()
        {
            // textboxes desactivados
            textBoxLinea1.Enabled = false;
            textBoxLinea2.Enabled = false;
            buttonImprimir.Enabled = false;
            buttonBorrar.Enabled = false;

            // trackbar desactivado
            trackBarServo.Value = 0;
            trackBarServo.Enabled = false;
            
        }

        private void enableComponents()
        {
            // textboxes activados
            textBoxLinea1.Enabled = true;
            textBoxLinea2.Enabled = true;
            buttonImprimir.Enabled = true;
            buttonBorrar.Enabled = true;

            // trackbar activado
            trackBarServo.Enabled = true;

            btnDoor.Enabled = true; //JEGZ ACTIVA BOON ABRIR
        }

        private void borrarLCD()
        {
            // borrar l1 y l2 en la app y en el display lCD
            textBoxLinea1.Text = "";
            textBoxLinea2.Text = "";

            serialPort1.WriteLine($"$L");
        }

        private void btnDoor_Click(object sender, EventArgs e)
        {
            if (btnDoor.Text == "OPEN")
            {
                //serialPort1.WriteLine("$S180");
                //trackBarServo.Value = 180;
                trackBarServo.Value = trackBarServo.Maximum;
                //abelInfo.Text = "180°";
                //serialPort1.WriteLine("$S180");
                labelInfo.Text = "0°";
                btnDoor.Text = "CLOSE";

                //>Agregado JEGZ 28/11/2021 - Control del Puerto Serial con C# en Visual Studio 2015 Community
                textBoxLinea1.Text = "";
                textBoxLinea2.Text = "";
                serialPort1.DiscardOutBuffer();
                //strbufferingOut = $"$S0";
                strbufferingOut = "o"; //JEGZ 6:34 28/11/2021
                pct_cerradura.Image = Properties.Resources.door_open;
                lblDatosEnviados.Text = strbufferingOut;
                serialPort1.Write(strbufferingOut);
                //<Agregado JEGZ 28/11/2021
                LimpiarPass();
            }
            else
            {
                if (btnDoor.Text == "CLOSE")
                {
                    btnDoor.Text = "OPEN";
                    //serialPort1.WriteLine("$S90");
                    labelInfo.Text = $"90°";
                    trackBarServo.Value = 90;
                    //trackBarServo.Value = trackBarServo.Minimum;

                    //>Agregado JEGZ 28/11/2021 - Control del Puerto Serial con C# en Visual Studio 2015 Community
                    textBoxLinea1.Text = "";
                    textBoxLinea2.Text = "";
                    serialPort1.DiscardOutBuffer();
                    //strbufferingOut = "$S90";
                    strbufferingOut = "c"; //JEGZ 6:34 28/11/2021
                    pct_cerradura.Image = Properties.Resources.door_close;
                    lblDatosEnviados.Text = strbufferingOut;
                    serialPort1.WriteLine(strbufferingOut);
                    //<Agregado JEGZ 28/11/2021
                    LimpiarPass();
                }
            }
        }
        /*
        private void EscucharSerial() //Metodo que escucha los comandos ejecutados en el arduino 24-11-2021
        {
            while (serialPort1.IsOpen)
            {
                try
                {
                    string cadena = serialPort1.ReadLine();

                    label3.Invoke(new MethodInvoker(
                        delegate{
                                    label3.Text = cadena;
                                }
                        ));
                }
                catch(Exception x)
                {
                    //MessageBox.Show(x.Message);
                }
            }
        }*/
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            /*
            try
            {
                string str_valor_recivido;
                //Recibe datos del arduino
                while (serialPort1.IsOpen && serialPort1.BytesToRead > 0)
                {
                    str_valor_recivido = serialPort1.ReadLine();
                    label3.Text = str_valor_recivido;

                    //if(str_valor_recivido == "$12")
                    if (str_valor_recivido == "$12")
                    {
                        bln_Puerta_Abierta = true;
                        btnDoor.Text = "Close";
                    }

                    //if (str_valor_recivido == "$13")
                    if (str_valor_recivido == "$13")
                    {
                        bln_Puerta_Abierta = false;
                        btnDoor.Text = "Open";
                    }
                }
            } catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }*/

            /*
            string Data_in = serialPort1.ReadExisting();
            MessageBox.Show(Data_in);
            label3.Text = Data_in;*/
            AccesoInterrupcion(serialPort1.ReadExisting());
        }

        private void lblRecibo_Click(object sender, EventArgs e)
        {

        }
    } // eof class
} // eof namespace
