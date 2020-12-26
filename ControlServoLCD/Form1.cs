using System;
using System.Windows.Forms;
using System.IO.Ports;

namespace ControlServoLCD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                disableComponents();

                // comboboxPuerto
                string[] ports = SerialPort.GetPortNames();
                comboBoxPuerto.DataSource = ports;             

                // comboBoxBaud
                string[] rates = { "9600", "38400", "115200" };
                comboBoxBaud.DataSource = rates;
                labelInfo.Text = "";
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

        private void checkBoxLedA_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (checkBoxLedA.Checked)
                {
                    // activar led A
                    pictureLedA.Image = Properties.Resources.redLedOn;
                    serialPort1.WriteLine("$Aon");
                }
                else
                {
                    pictureLedA.Image = Properties.Resources.redLedOff;
                    serialPort1.WriteLine("$Aoff");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);     
            }
        }


        private void checkBoxLedB_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (checkBoxLedB.Checked)
                {
                    // activar led B
                    pictureLedB.Image = Properties.Resources.redLedOn;
                    serialPort1.WriteLine("$Bon");

                }
                else
                {
                    pictureLedB.Image = Properties.Resources.redLedOff;
                    serialPort1.WriteLine("$Boff");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }


        private void checkBoxLedC_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (checkBoxLedC.Checked)
                {
                    // activar led C
                    pictureLedC.Image = Properties.Resources.redLedOn;
                    serialPort1.WriteLine("$Con");

                }
                else
                {
                    pictureLedC.Image = Properties.Resources.redLedOff;
                    serialPort1.WriteLine("$Coff");
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
                    serialPort1.PortName = comboBoxPuerto.Text;
                    serialPort1.Open();

                    progressBarConexion.Value = 100;
                    buttonConectar.Text = "Desconectar";
                    buttonRefrescar.Enabled = false;

                    // habilitar componentes del form
                    enableComponents();
                }
                else
                {
                    // restablecer y desabilitar componentes
                    checkBoxLedA.Checked = false;
                    checkBoxLedB.Checked = false;
                    checkBoxLedC.Checked = false;
                            // empty lines
                    textBoxLinea1.Text = "";
                    textBoxLinea2.Text = "";

                    disableComponents();                    
                    progressBarConexion.Value = 0;
                    buttonConectar.Text = "Conectar";
                    buttonRefrescar.Enabled = true;
                    borrarLCD();
                    labelInfo.Text = "0";
                    serialPort1.WriteLine($"$S0");

                    serialPort1.Close();
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
                labelInfo.Text = trackBarServo.Value.ToString();
                serialPort1.WriteLine($"$S{labelInfo.Text}");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }            
        }


        /*******  helper methods *********/
        private void disableComponents()
        {
            // check boxes desactivados
            checkBoxLedA.Enabled = false;
            checkBoxLedB.Enabled = false;
            checkBoxLedC.Enabled = false;

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
            // check boxes activados
            checkBoxLedA.Enabled = true;
            checkBoxLedB.Enabled = true;
            checkBoxLedC.Enabled = true;

            // textboxes activados
            textBoxLinea1.Enabled = true;
            textBoxLinea2.Enabled = true;
            buttonImprimir.Enabled = true;
            buttonBorrar.Enabled = true;

            // trackbar activado
            trackBarServo.Enabled = true;
        }

        private void borrarLCD()
        {
            // borrar l1 y l2 en la app y en el display lCD
            textBoxLinea1.Text = "";
            textBoxLinea2.Text = "";

            serialPort1.WriteLine($"$L");
        }

    } // eof class
} // eof namespace
