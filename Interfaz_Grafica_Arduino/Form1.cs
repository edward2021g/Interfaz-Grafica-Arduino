using System;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using System.Drawing;

namespace ControlServoLCD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string strbufferingIn; //> Agregado JEGZ 28/11/2021 - Control del Puerto Serial con C# en Visual Studio 2015 Community
        private string strbufferingOut;
        private string strPassword = "****";
        char[] charArrayPass = new char[4] { '*','*','*','*'};
        char[] charArrayPassNueva = new char[4] { '*', '*', '*', '*' }; //Agregado 29/11/2021 para cambiar contraseña
        bool blnErrorEnPassword; //Agregado 29/11/2021 para cambiar contraseña
        private string strContra = "3007"; //Contraseña por defecto - Agregado 29/11/2021 para cambiar contraseña

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
                btnDoor.Text = "CERRAR";
                btnDoor.BackColor = Color.FromArgb(197, 12, 206); //ROSA
                pct_cerradura.Image = Properties.Resources.door_open;
                LimpiarPass();
            }
            if (first == 'c')
            {
                btnDoor.Text = "ABRIR";
                btnDoor.BackColor = Color.FromArgb(7, 141, 237);//AZUL
                pct_cerradura.Image = Properties.Resources.door_close;
                LimpiarPass();
            }
            if (first == 'e')
            {
                LimpiarPass();
            }
            //-------Agregado para recibir la contraseña 
            if (first == '0' || first == '1' || first == '2' || first == '3' || first == '4' || 
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
                trackBarServo.Value = 90;

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
                    //<JEGZ 27/11/2021
                    serialPort1.PortName = comboBoxPuerto.Text;
                    serialPort1.Open();

                    labelInfo.Text = "90°";//>JEGZ 27/11/2021
                    serialPort1.DiscardOutBuffer();
                    strbufferingOut = "c"; //JEGZ 6:34 28/11/2021
                    pct_cerradura.Image = Properties.Resources.door_close;
                    serialPort1.WriteLine(strbufferingOut);
                    lblDatosEnviados.Text = strbufferingOut;//<JEGZ 27/11/2021

                    progressBarConexion.Value = 100;
                    buttonConectar.Text = "DESCONECTAR";
                    buttonRefrescar.Enabled = false;

                    // habilitar componentes del form
                    enableComponents();
                    comboBoxPuerto.Enabled = false;
                    comboBoxBaud.Enabled = false;
                }
                else
                {
                    disableComponents();                    
                    progressBarConexion.Value = 0;
                    buttonConectar.Text = "CONECTAR";
                    buttonRefrescar.Enabled = true;

                    labelInfo.Text = "90°";//>JEGZ 27/11/2021
                    serialPort1.DiscardOutBuffer();
                    strbufferingOut = "c"; //JEGZ 6:34 28/11/2021
                    serialPort1.WriteLine(strbufferingOut);
                    lblDatosEnviados.Text = strbufferingOut;//<JEGZ 27/11/2021

                    serialPort1.Close();

                    comboBoxPuerto.Enabled = true;
                    comboBoxBaud.Enabled = true;
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
                //valido la cadena de la nueva contraseña
                if (txtContrasenia.Text != strContra)
                {
                    MessageBox.Show("La contraseña es incorrecta.", "Error");
                    txtContrasenia.Text = "";
                }
                else
                {
                    txtContrasenia.Text = "";
                    //----- Enviando el comando a Arduino
                    serialPort1.DiscardOutBuffer();
                    strbufferingOut = "o";
                    lblDatosEnviados.Text = strbufferingOut;
                    serialPort1.Write(strbufferingOut);
                    btnDoor.Text = "CERRAR";
                    txtContrasenia.Enabled = false;
                    buttonImprimir.Enabled = false;
                    trackBarServo.Value = trackBarServo.Maximum;
                    btnDoor.BackColor = Color.FromArgb(197, 12, 206);
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }


        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                //borrarLCD();
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
                if(trackBarServo.Value == 90)
                {
                    btnDoor.Text = "ABRIR";
                    txtContrasenia.Enabled = true;
                    buttonImprimir.Enabled = true;
                    labelInfo.Text = $"90°";
                    serialPort1.DiscardOutBuffer();
                    strbufferingOut = "c"; 
                    pct_cerradura.Image = Properties.Resources.door_close;
                    lblDatosEnviados.Text = strbufferingOut;
                    serialPort1.WriteLine(strbufferingOut);
                    btnDoor.BackColor = Color.FromArgb(7, 141, 237);
                }
                else if(trackBarServo.Value == 180 || trackBarServo.Value == 0)
                {
                    btnDoor.Text = "CERRAR";
                    txtContrasenia.Enabled = false;
                    buttonImprimir.Enabled = false;
                    labelInfo.Text = $"180°";
                    serialPort1.DiscardOutBuffer();
                    strbufferingOut = "o";
                    pct_cerradura.Image = Properties.Resources.door_close;
                    lblDatosEnviados.Text = strbufferingOut;
                    serialPort1.WriteLine(strbufferingOut);
                    btnDoor.BackColor = Color.FromArgb(197, 12, 206);
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
            buttonImprimir.Enabled = false;
            txtContrasenia.Enabled = false;

            // trackbar desactivado
            trackBarServo.Value = 0;
            trackBarServo.Enabled = false;

            //botones de cambio de contraseña desactivados
            btnMostrarPassActual.Enabled = false;
            btnCambiarPass.Enabled = false;
            txtNuevaPass.Enabled = false;
            txtPassActual.Enabled = false;
            txtPass.Enabled = false;
            btnDoor.Enabled = false;
        }

        private void enableComponents()
        {
            // textboxes activados
            buttonImprimir.Enabled = true;
            txtContrasenia.Enabled = true;

            // trackbar activado
            trackBarServo.Enabled = true;
            trackBarServo.Value = 90;

            //botones de cambio de contraseña desactivados
            btnMostrarPassActual.Enabled = true;
            btnCambiarPass.Enabled = true;
            txtNuevaPass.Enabled = true;

            btnDoor.Enabled = true; //JEGZ ACTIVA BOON ABRIR
        }

        private void btnDoor_Click(object sender, EventArgs e)
        {
            if (btnDoor.Text == "ABRIR")
            {
                trackBarServo.Value = trackBarServo.Maximum;
                btnDoor.BackColor = Color.FromArgb(197, 12, 206); //ROSA
                labelInfo.Text = "0°";
                btnDoor.Text = "CERRAR";

                //>Agregado JEGZ 28/11/2021 - Control del Puerto Serial con C# en Visual Studio 2015 Community
                serialPort1.DiscardOutBuffer();
                strbufferingOut = "o"; //JEGZ 6:34 28/11/2021
                pct_cerradura.Image = Properties.Resources.door_open;
                lblDatosEnviados.Text = strbufferingOut;
                serialPort1.Write(strbufferingOut);
                //<Agregado JEGZ 28/11/2021
                LimpiarPass();
                txtContrasenia.Enabled = false;
                buttonImprimir.Enabled = false;
            }
            else
            {
                if (btnDoor.Text == "CERRAR")
                {
                    btnDoor.Text = "ABRIR";
                    btnDoor.BackColor = Color.FromArgb(7, 141, 237);//AZUL
                    labelInfo.Text = $"90°";
                    trackBarServo.Value = 90;

                    //>Agregado JEGZ 28/11/2021 - Control del Puerto Serial con C# en Visual Studio 2015 Community
                    serialPort1.DiscardOutBuffer();
                    strbufferingOut = "c"; //JEGZ 6:34 28/11/2021
                    pct_cerradura.Image = Properties.Resources.door_close;
                    lblDatosEnviados.Text = strbufferingOut;
                    serialPort1.WriteLine(strbufferingOut);
                    //<Agregado JEGZ 28/11/2021
                    LimpiarPass();
                    txtContrasenia.Enabled = true;
                    buttonImprimir.Enabled = true;
                }
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                AccesoInterrupcion(serialPort1.ReadExisting());
            }catch(Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void lblRecibo_Click(object sender, EventArgs e)
        {

        }

        private void btnCambiarPass_Click(object sender, EventArgs e)
        {
            try
            {
                string strNuevaPass = txtNuevaPass.Text;
                char[] charArrayPassNueva = strNuevaPass.ToCharArray();

                for (int i = 0; i < 4; i++) //valida que contenga caracteres validos
                {
                    if(!(charArrayPassNueva[i] == '0' || charArrayPassNueva[i] == '1' || charArrayPassNueva[i] == '2' || charArrayPassNueva[i] == '3'
                        || charArrayPassNueva[i] == '4' || charArrayPassNueva[i] == '5' || charArrayPassNueva[i] == '6' || charArrayPassNueva[i] == '7'
                        || charArrayPassNueva[i] == '8' || charArrayPassNueva[i] == '9' || charArrayPassNueva[i] == 'A' || charArrayPassNueva[i] == 'B'
                        || charArrayPassNueva[i] == 'C' || charArrayPassNueva[i] == 'D' || charArrayPassNueva[i] == '*' || charArrayPassNueva[i] == '#'))
                    {
                        char charCaracter = charArrayPassNueva[i];
                        blnErrorEnPassword = true;
                    }
                }

                //valido la cadena de la nueva contraseña
                if (txtNuevaPass.Text == "" || txtNuevaPass.TextLength < 4 || blnErrorEnPassword == true)
                {
                    MessageBox.Show("La contraseña esta incompleta o no es valida. Ingrese una contraseña valida", "Error");
                    txtNuevaPass.Text = "";
                    blnErrorEnPassword = false;
                }
                else
                { //Cambio la contraseña...
                    txtNuevaPass.Text = "";
                    strContra = strNuevaPass;
                    //----- Enviando el comando a Arduino
                    serialPort1.DiscardOutBuffer();
                    strbufferingOut = "p";
                    lblDatosEnviados.Text = strbufferingOut;
                    serialPort1.Write(strbufferingOut);

                    //////ENVIANDO CARACTER POR CARACTER
                    serialPort1.DiscardOutBuffer();
                    strbufferingOut = charArrayPassNueva[0].ToString();
                    lblDatosEnviados.Text = strbufferingOut;
                    serialPort1.Write(strbufferingOut);
                    ///CARACTER 2
                    serialPort1.DiscardOutBuffer();
                    strbufferingOut = charArrayPassNueva[1].ToString();
                    lblDatosEnviados.Text = strbufferingOut;
                    serialPort1.Write(strbufferingOut);
                    ///CARACTER 3
                    serialPort1.DiscardOutBuffer();
                    strbufferingOut = charArrayPassNueva[2].ToString();
                    lblDatosEnviados.Text = strbufferingOut;
                    serialPort1.Write(strbufferingOut);
                    ///CARACTER 4
                    serialPort1.DiscardOutBuffer();
                    strbufferingOut = charArrayPassNueva[3].ToString();
                    lblDatosEnviados.Text = strbufferingOut;
                    serialPort1.Write(strbufferingOut);
                    //////ENVIANDO CARACTER POR CARACTER

                    //Agregando un segundo caracter para indicar contraseña se envio
                    Thread.Sleep(2500);
                    serialPort1.DiscardOutBuffer();
                    strbufferingOut = "q";
                    lblDatosEnviados.Text = strbufferingOut;
                    serialPort1.Write(strbufferingOut);
                    //-----
                    progressBarCambioPass.Value = 100;
                    MessageBox.Show("Contraseña cambiada exitosamente.", "Contraseña Cambiada");
                    progressBarCambioPass.Value = 0;
                    txtPassActual.Text = "****";
                    btnMostrarPassActual.Text = "MOSTRAR CONTRASEÑA";
                }
            }
            catch(Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void btnMostrarPassActual_Click(object sender, EventArgs e)
        {
            try
            {
                if(btnMostrarPassActual.Text == "MOSTRAR CONTRASEÑA")
                {
                    //mostrar contraseña actual
                    txtPassActual.Text = strContra;
                    btnMostrarPassActual.Text = "OCULTAR CONTRASEÑA";

                    //----- Enviando el comando a Arduino
                    serialPort1.DiscardOutBuffer();
                    strbufferingOut = "r";
                    lblDatosEnviados.Text = strbufferingOut;
                    serialPort1.Write(strbufferingOut);
                }
                else if (btnMostrarPassActual.Text == "OCULTAR CONTRASEÑA")
                {
                    //Ocultar contraseña actual
                    txtPassActual.Text = "****";
                    btnMostrarPassActual.Text = "MOSTRAR CONTRASEÑA";
                    progressBarCambioPass.Value = 0;

                    //----- Enviando el comando a Arduino
                    serialPort1.DiscardOutBuffer();
                    strbufferingOut = "w";
                    lblDatosEnviados.Text = strbufferingOut;
                    serialPort1.Write(strbufferingOut);
                }
            }
            catch(Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }
    } // eof class
} // eof namespace
