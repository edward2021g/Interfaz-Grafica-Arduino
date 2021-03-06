
namespace ControlServoLCD
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pct_cerradura = new System.Windows.Forms.PictureBox();
            this.btnDoor = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonImprimir = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonRefrescar = new System.Windows.Forms.Button();
            this.progressBarConexion = new System.Windows.Forms.ProgressBar();
            this.buttonConectar = new System.Windows.Forms.Button();
            this.comboBoxBaud = new System.Windows.Forms.ComboBox();
            this.comboBoxPuerto = new System.Windows.Forms.ComboBox();
            this.labelBaud = new System.Windows.Forms.Label();
            this.labelPuerto = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.labelInfo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBarServo = new System.Windows.Forms.TrackBar();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.lblRecibo = new System.Windows.Forms.Label();
            this.lblDatosEnviados = new System.Windows.Forms.Label();
            this.Envio = new System.Windows.Forms.Label();
            this.Recibo = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtNuevaPass = new System.Windows.Forms.TextBox();
            this.txtPassActual = new System.Windows.Forms.TextBox();
            this.btnMostrarPassActual = new System.Windows.Forms.Button();
            this.progressBarCambioPass = new System.Windows.Forms.ProgressBar();
            this.btnCambiarPass = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPassAct = new System.Windows.Forms.Label();
            this.txtContrasenia = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pct_cerradura)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarServo)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pct_cerradura);
            this.groupBox1.Controls.Add(this.btnDoor);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(468, 24);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(374, 166);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CONTROL PUERTA";
            // 
            // pct_cerradura
            // 
            this.pct_cerradura.Image = global::ControlServoLCD.Properties.Resources.door_close;
            this.pct_cerradura.Location = new System.Drawing.Point(225, 20);
            this.pct_cerradura.Name = "pct_cerradura";
            this.pct_cerradura.Size = new System.Drawing.Size(130, 134);
            this.pct_cerradura.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pct_cerradura.TabIndex = 7;
            this.pct_cerradura.TabStop = false;
            // 
            // btnDoor
            // 
            this.btnDoor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(141)))), ((int)(((byte)(237)))));
            this.btnDoor.ForeColor = System.Drawing.Color.White;
            this.btnDoor.Location = new System.Drawing.Point(51, 66);
            this.btnDoor.Name = "btnDoor";
            this.btnDoor.Size = new System.Drawing.Size(127, 47);
            this.btnDoor.TabIndex = 6;
            this.btnDoor.Text = "ABRIR";
            this.btnDoor.UseVisualStyleBackColor = false;
            this.btnDoor.Click += new System.EventHandler(this.btnDoor_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtContrasenia);
            this.groupBox2.Controls.Add(this.buttonImprimir);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(468, 408);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(374, 181);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ABRIR CON CONTRASEÑA";
            // 
            // buttonImprimir
            // 
            this.buttonImprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(141)))), ((int)(((byte)(237)))));
            this.buttonImprimir.FlatAppearance.BorderSize = 0;
            this.buttonImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonImprimir.Font = new System.Drawing.Font("Open Sans Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonImprimir.Location = new System.Drawing.Point(228, 73);
            this.buttonImprimir.Margin = new System.Windows.Forms.Padding(2);
            this.buttonImprimir.Name = "buttonImprimir";
            this.buttonImprimir.Size = new System.Drawing.Size(116, 40);
            this.buttonImprimir.TabIndex = 4;
            this.buttonImprimir.Text = "ABRIR";
            this.buttonImprimir.UseVisualStyleBackColor = false;
            this.buttonImprimir.Click += new System.EventHandler(this.buttonImprimir_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonRefrescar);
            this.groupBox3.Controls.Add(this.progressBarConexion);
            this.groupBox3.Controls.Add(this.buttonConectar);
            this.groupBox3.Controls.Add(this.comboBoxBaud);
            this.groupBox3.Controls.Add(this.comboBoxPuerto);
            this.groupBox3.Controls.Add(this.labelBaud);
            this.groupBox3.Controls.Add(this.labelPuerto);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(26, 408);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(410, 181);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "CONEXION SERIAL";
            // 
            // buttonRefrescar
            // 
            this.buttonRefrescar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(12)))), ((int)(((byte)(206)))));
            this.buttonRefrescar.FlatAppearance.BorderSize = 0;
            this.buttonRefrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefrescar.Font = new System.Drawing.Font("Open Sans Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefrescar.Location = new System.Drawing.Point(254, 37);
            this.buttonRefrescar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRefrescar.Name = "buttonRefrescar";
            this.buttonRefrescar.Size = new System.Drawing.Size(130, 40);
            this.buttonRefrescar.TabIndex = 6;
            this.buttonRefrescar.Text = "REFRESCAR";
            this.buttonRefrescar.UseVisualStyleBackColor = false;
            this.buttonRefrescar.Click += new System.EventHandler(this.buttonRefrescar_Click);
            // 
            // progressBarConexion
            // 
            this.progressBarConexion.Location = new System.Drawing.Point(254, 144);
            this.progressBarConexion.Name = "progressBarConexion";
            this.progressBarConexion.Size = new System.Drawing.Size(130, 15);
            this.progressBarConexion.TabIndex = 5;
            // 
            // buttonConectar
            // 
            this.buttonConectar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(141)))), ((int)(((byte)(237)))));
            this.buttonConectar.FlatAppearance.BorderSize = 0;
            this.buttonConectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConectar.Font = new System.Drawing.Font("Open Sans Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConectar.Location = new System.Drawing.Point(254, 89);
            this.buttonConectar.Margin = new System.Windows.Forms.Padding(0);
            this.buttonConectar.Name = "buttonConectar";
            this.buttonConectar.Size = new System.Drawing.Size(130, 40);
            this.buttonConectar.TabIndex = 4;
            this.buttonConectar.Text = "CONECTAR";
            this.buttonConectar.UseVisualStyleBackColor = false;
            this.buttonConectar.Click += new System.EventHandler(this.buttonConectar_Click);
            // 
            // comboBoxBaud
            // 
            this.comboBoxBaud.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBaud.FormattingEnabled = true;
            this.comboBoxBaud.Location = new System.Drawing.Point(107, 95);
            this.comboBoxBaud.Name = "comboBoxBaud";
            this.comboBoxBaud.Size = new System.Drawing.Size(121, 25);
            this.comboBoxBaud.TabIndex = 3;
            // 
            // comboBoxPuerto
            // 
            this.comboBoxPuerto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPuerto.FormattingEnabled = true;
            this.comboBoxPuerto.Location = new System.Drawing.Point(107, 43);
            this.comboBoxPuerto.Name = "comboBoxPuerto";
            this.comboBoxPuerto.Size = new System.Drawing.Size(121, 25);
            this.comboBoxPuerto.TabIndex = 2;
            // 
            // labelBaud
            // 
            this.labelBaud.AutoSize = true;
            this.labelBaud.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBaud.Location = new System.Drawing.Point(23, 99);
            this.labelBaud.Name = "labelBaud";
            this.labelBaud.Size = new System.Drawing.Size(71, 16);
            this.labelBaud.TabIndex = 1;
            this.labelBaud.Text = "Baudrate";
            // 
            // labelPuerto
            // 
            this.labelPuerto.AutoSize = true;
            this.labelPuerto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPuerto.Location = new System.Drawing.Point(23, 48);
            this.labelPuerto.Name = "labelPuerto";
            this.labelPuerto.Size = new System.Drawing.Size(53, 16);
            this.labelPuerto.TabIndex = 0;
            this.labelPuerto.Text = "Puerto";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.labelInfo);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.trackBarServo);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(468, 219);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(374, 181);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "CONTROL SERVO";
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfo.Location = new System.Drawing.Point(169, 125);
            this.labelInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(34, 24);
            this.labelInfo.TabIndex = 8;
            this.labelInfo.Text = "....";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(318, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "180°";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "0°";
            // 
            // trackBarServo
            // 
            this.trackBarServo.LargeChange = 90;
            this.trackBarServo.Location = new System.Drawing.Point(29, 77);
            this.trackBarServo.Maximum = 180;
            this.trackBarServo.Name = "trackBarServo";
            this.trackBarServo.Size = new System.Drawing.Size(316, 45);
            this.trackBarServo.SmallChange = 90;
            this.trackBarServo.TabIndex = 0;
            this.trackBarServo.Tag = "";
            this.trackBarServo.TickFrequency = 90;
            this.trackBarServo.Scroll += new System.EventHandler(this.trackBarServo_Scroll);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // lblRecibo
            // 
            this.lblRecibo.AutoSize = true;
            this.lblRecibo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRecibo.Location = new System.Drawing.Point(201, 202);
            this.lblRecibo.Name = "lblRecibo";
            this.lblRecibo.Size = new System.Drawing.Size(51, 13);
            this.lblRecibo.TabIndex = 7;
            this.lblRecibo.Text = "lblRecibo";
            this.lblRecibo.Click += new System.EventHandler(this.lblRecibo_Click);
            // 
            // lblDatosEnviados
            // 
            this.lblDatosEnviados.AutoSize = true;
            this.lblDatosEnviados.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDatosEnviados.Location = new System.Drawing.Point(623, 202);
            this.lblDatosEnviados.Name = "lblDatosEnviados";
            this.lblDatosEnviados.Size = new System.Drawing.Size(48, 13);
            this.lblDatosEnviados.TabIndex = 8;
            this.lblDatosEnviados.Text = "LblEnvio";
            // 
            // Envio
            // 
            this.Envio.AutoSize = true;
            this.Envio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Envio.Location = new System.Drawing.Point(465, 202);
            this.Envio.Name = "Envio";
            this.Envio.Size = new System.Drawing.Size(37, 13);
            this.Envio.TabIndex = 9;
            this.Envio.Text = "Envio:";
            // 
            // Recibo
            // 
            this.Recibo.AutoSize = true;
            this.Recibo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Recibo.Location = new System.Drawing.Point(23, 202);
            this.Recibo.Name = "Recibo";
            this.Recibo.Size = new System.Drawing.Size(44, 13);
            this.Recibo.TabIndex = 10;
            this.Recibo.Text = "Recibo:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtPass);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.White;
            this.groupBox5.Location = new System.Drawing.Point(26, 24);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox5.Size = new System.Drawing.Size(408, 166);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "CONTRASEÑA LCD";
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.CornflowerBlue;
            this.txtPass.Font = new System.Drawing.Font("DS-Digital", 90F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(48, 23);
            this.txtPass.Margin = new System.Windows.Forms.Padding(2);
            this.txtPass.MaximumSize = new System.Drawing.Size(300, 50);
            this.txtPass.MaxLength = 16;
            this.txtPass.MinimumSize = new System.Drawing.Size(300, 50);
            this.txtPass.Name = "txtPass";
            this.txtPass.ReadOnly = true;
            this.txtPass.Size = new System.Drawing.Size(300, 50);
            this.txtPass.TabIndex = 0;
            this.txtPass.Text = "****";
            this.txtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtNuevaPass);
            this.groupBox6.Controls.Add(this.txtPassActual);
            this.groupBox6.Controls.Add(this.btnMostrarPassActual);
            this.groupBox6.Controls.Add(this.progressBarCambioPass);
            this.groupBox6.Controls.Add(this.btnCambiarPass);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.lblPassAct);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.ForeColor = System.Drawing.Color.White;
            this.groupBox6.Location = new System.Drawing.Point(24, 219);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox6.Size = new System.Drawing.Size(410, 181);
            this.groupBox6.TabIndex = 12;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "CAMBIO DE CONTRASEÑA";
            // 
            // txtNuevaPass
            // 
            this.txtNuevaPass.BackColor = System.Drawing.Color.CornflowerBlue;
            this.txtNuevaPass.Font = new System.Drawing.Font("DS-Digital", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNuevaPass.Location = new System.Drawing.Point(106, 95);
            this.txtNuevaPass.Margin = new System.Windows.Forms.Padding(2);
            this.txtNuevaPass.MaximumSize = new System.Drawing.Size(200, 50);
            this.txtNuevaPass.MaxLength = 4;
            this.txtNuevaPass.Name = "txtNuevaPass";
            this.txtNuevaPass.Size = new System.Drawing.Size(129, 39);
            this.txtNuevaPass.TabIndex = 14;
            this.txtNuevaPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPassActual
            // 
            this.txtPassActual.BackColor = System.Drawing.Color.CornflowerBlue;
            this.txtPassActual.Font = new System.Drawing.Font("DS-Digital", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassActual.Location = new System.Drawing.Point(107, 35);
            this.txtPassActual.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassActual.MaximumSize = new System.Drawing.Size(200, 50);
            this.txtPassActual.MaxLength = 4;
            this.txtPassActual.Name = "txtPassActual";
            this.txtPassActual.ReadOnly = true;
            this.txtPassActual.Size = new System.Drawing.Size(129, 39);
            this.txtPassActual.TabIndex = 13;
            this.txtPassActual.Text = "****";
            this.txtPassActual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnMostrarPassActual
            // 
            this.btnMostrarPassActual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(12)))), ((int)(((byte)(206)))));
            this.btnMostrarPassActual.FlatAppearance.BorderSize = 0;
            this.btnMostrarPassActual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarPassActual.Font = new System.Drawing.Font("Open Sans Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarPassActual.Location = new System.Drawing.Point(254, 24);
            this.btnMostrarPassActual.Margin = new System.Windows.Forms.Padding(2);
            this.btnMostrarPassActual.Name = "btnMostrarPassActual";
            this.btnMostrarPassActual.Size = new System.Drawing.Size(130, 54);
            this.btnMostrarPassActual.TabIndex = 6;
            this.btnMostrarPassActual.Text = "MOSTRAR CONTRASEÑA";
            this.btnMostrarPassActual.UseVisualStyleBackColor = false;
            this.btnMostrarPassActual.Click += new System.EventHandler(this.btnMostrarPassActual_Click);
            // 
            // progressBarCambioPass
            // 
            this.progressBarCambioPass.Location = new System.Drawing.Point(254, 151);
            this.progressBarCambioPass.Name = "progressBarCambioPass";
            this.progressBarCambioPass.Size = new System.Drawing.Size(130, 15);
            this.progressBarCambioPass.TabIndex = 5;
            // 
            // btnCambiarPass
            // 
            this.btnCambiarPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(141)))), ((int)(((byte)(237)))));
            this.btnCambiarPass.FlatAppearance.BorderSize = 0;
            this.btnCambiarPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambiarPass.Font = new System.Drawing.Font("Open Sans Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarPass.Location = new System.Drawing.Point(254, 89);
            this.btnCambiarPass.Margin = new System.Windows.Forms.Padding(0);
            this.btnCambiarPass.Name = "btnCambiarPass";
            this.btnCambiarPass.Size = new System.Drawing.Size(130, 52);
            this.btnCambiarPass.TabIndex = 4;
            this.btnCambiarPass.Text = "CAMBIAR CONTRASEÑA";
            this.btnCambiarPass.UseVisualStyleBackColor = false;
            this.btnCambiarPass.Click += new System.EventHandler(this.btnCambiarPass_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 95);
            this.label3.MaximumSize = new System.Drawing.Size(87, 32);
            this.label3.MinimumSize = new System.Drawing.Size(87, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nueva Contraseña";
            // 
            // lblPassAct
            // 
            this.lblPassAct.AutoSize = true;
            this.lblPassAct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassAct.Location = new System.Drawing.Point(14, 47);
            this.lblPassAct.Name = "lblPassAct";
            this.lblPassAct.Size = new System.Drawing.Size(87, 16);
            this.lblPassAct.TabIndex = 0;
            this.lblPassAct.Text = "Contraseña";
            // 
            // txtContrasenia
            // 
            this.txtContrasenia.BackColor = System.Drawing.Color.CornflowerBlue;
            this.txtContrasenia.Font = new System.Drawing.Font("DS-Digital", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasenia.Location = new System.Drawing.Point(74, 75);
            this.txtContrasenia.Margin = new System.Windows.Forms.Padding(2);
            this.txtContrasenia.MaximumSize = new System.Drawing.Size(200, 50);
            this.txtContrasenia.MaxLength = 4;
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.Size = new System.Drawing.Size(129, 39);
            this.txtContrasenia.TabIndex = 15;
            this.txtContrasenia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(888, 602);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.Recibo);
            this.Controls.Add(this.Envio);
            this.Controls.Add(this.lblDatosEnviados);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblRecibo);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "PC - ARDUINO CONTROL";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pct_cerradura)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarServo)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonImprimir;
        private System.Windows.Forms.ProgressBar progressBarConexion;
        private System.Windows.Forms.Button buttonConectar;
        private System.Windows.Forms.ComboBox comboBoxBaud;
        private System.Windows.Forms.ComboBox comboBoxPuerto;
        private System.Windows.Forms.Label labelBaud;
        private System.Windows.Forms.Label labelPuerto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBarServo;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Button buttonRefrescar;
        private System.Windows.Forms.Button btnDoor;
        private System.Windows.Forms.Label lblRecibo;
        private System.Windows.Forms.Label lblDatosEnviados;
        private System.Windows.Forms.Label Envio;
        private System.Windows.Forms.Label Recibo;
        private System.Windows.Forms.PictureBox pct_cerradura;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtNuevaPass;
        private System.Windows.Forms.TextBox txtPassActual;
        private System.Windows.Forms.Button btnMostrarPassActual;
        private System.Windows.Forms.ProgressBar progressBarCambioPass;
        private System.Windows.Forms.Button btnCambiarPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPassAct;
        private System.Windows.Forms.TextBox txtContrasenia;
    }
}

