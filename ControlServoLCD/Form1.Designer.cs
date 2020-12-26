
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
            this.checkBoxLedC = new System.Windows.Forms.CheckBox();
            this.checkBoxLedB = new System.Windows.Forms.CheckBox();
            this.checkBoxLedA = new System.Windows.Forms.CheckBox();
            this.pictureLedC = new System.Windows.Forms.PictureBox();
            this.pictureLedB = new System.Windows.Forms.PictureBox();
            this.pictureLedA = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonBorrar = new System.Windows.Forms.Button();
            this.buttonImprimir = new System.Windows.Forms.Button();
            this.textBoxLinea2 = new System.Windows.Forms.TextBox();
            this.labelLinea2 = new System.Windows.Forms.Label();
            this.labelLinea1 = new System.Windows.Forms.Label();
            this.textBoxLinea1 = new System.Windows.Forms.TextBox();
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
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLedC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLedB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLedA)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarServo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxLedC);
            this.groupBox1.Controls.Add(this.checkBoxLedB);
            this.groupBox1.Controls.Add(this.checkBoxLedA);
            this.groupBox1.Controls.Add(this.pictureLedC);
            this.groupBox1.Controls.Add(this.pictureLedB);
            this.groupBox1.Controls.Add(this.pictureLedA);
            this.groupBox1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(24, 24);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(380, 166);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CONTROL LEDS";
            // 
            // checkBoxLedC
            // 
            this.checkBoxLedC.AutoSize = true;
            this.checkBoxLedC.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxLedC.Location = new System.Drawing.Point(265, 116);
            this.checkBoxLedC.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxLedC.Name = "checkBoxLedC";
            this.checkBoxLedC.Size = new System.Drawing.Size(66, 23);
            this.checkBoxLedC.TabIndex = 5;
            this.checkBoxLedC.Text = "LedC";
            this.checkBoxLedC.UseVisualStyleBackColor = true;
            this.checkBoxLedC.CheckedChanged += new System.EventHandler(this.checkBoxLedC_CheckedChanged);
            // 
            // checkBoxLedB
            // 
            this.checkBoxLedB.AutoSize = true;
            this.checkBoxLedB.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxLedB.Location = new System.Drawing.Point(157, 116);
            this.checkBoxLedB.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxLedB.Name = "checkBoxLedB";
            this.checkBoxLedB.Size = new System.Drawing.Size(66, 23);
            this.checkBoxLedB.TabIndex = 4;
            this.checkBoxLedB.Text = "LedB";
            this.checkBoxLedB.UseVisualStyleBackColor = true;
            this.checkBoxLedB.CheckedChanged += new System.EventHandler(this.checkBoxLedB_CheckedChanged);
            // 
            // checkBoxLedA
            // 
            this.checkBoxLedA.AutoSize = true;
            this.checkBoxLedA.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxLedA.Location = new System.Drawing.Point(49, 116);
            this.checkBoxLedA.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxLedA.Name = "checkBoxLedA";
            this.checkBoxLedA.Size = new System.Drawing.Size(66, 23);
            this.checkBoxLedA.TabIndex = 3;
            this.checkBoxLedA.Text = "LedA";
            this.checkBoxLedA.UseVisualStyleBackColor = true;
            this.checkBoxLedA.CheckedChanged += new System.EventHandler(this.checkBoxLedA_CheckedChanged);
            // 
            // pictureLedC
            // 
            this.pictureLedC.Image = global::ControlServoLCD.Properties.Resources.redLedOff;
            this.pictureLedC.Location = new System.Drawing.Point(275, 48);
            this.pictureLedC.Margin = new System.Windows.Forms.Padding(2);
            this.pictureLedC.Name = "pictureLedC";
            this.pictureLedC.Size = new System.Drawing.Size(42, 42);
            this.pictureLedC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureLedC.TabIndex = 2;
            this.pictureLedC.TabStop = false;
            // 
            // pictureLedB
            // 
            this.pictureLedB.Image = global::ControlServoLCD.Properties.Resources.redLedOff;
            this.pictureLedB.Location = new System.Drawing.Point(167, 48);
            this.pictureLedB.Margin = new System.Windows.Forms.Padding(2);
            this.pictureLedB.Name = "pictureLedB";
            this.pictureLedB.Size = new System.Drawing.Size(42, 42);
            this.pictureLedB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureLedB.TabIndex = 1;
            this.pictureLedB.TabStop = false;
            // 
            // pictureLedA
            // 
            this.pictureLedA.Image = global::ControlServoLCD.Properties.Resources.redLedOff;
            this.pictureLedA.Location = new System.Drawing.Point(59, 48);
            this.pictureLedA.Margin = new System.Windows.Forms.Padding(2);
            this.pictureLedA.Name = "pictureLedA";
            this.pictureLedA.Size = new System.Drawing.Size(42, 42);
            this.pictureLedA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureLedA.TabIndex = 0;
            this.pictureLedA.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonBorrar);
            this.groupBox2.Controls.Add(this.buttonImprimir);
            this.groupBox2.Controls.Add(this.textBoxLinea2);
            this.groupBox2.Controls.Add(this.labelLinea2);
            this.groupBox2.Controls.Add(this.labelLinea1);
            this.groupBox2.Controls.Add(this.textBoxLinea1);
            this.groupBox2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(468, 24);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(374, 166);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CONTROL LCD";
            // 
            // buttonBorrar
            // 
            this.buttonBorrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(12)))), ((int)(((byte)(206)))));
            this.buttonBorrar.FlatAppearance.BorderSize = 0;
            this.buttonBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBorrar.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBorrar.Location = new System.Drawing.Point(229, 104);
            this.buttonBorrar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBorrar.Name = "buttonBorrar";
            this.buttonBorrar.Size = new System.Drawing.Size(116, 40);
            this.buttonBorrar.TabIndex = 5;
            this.buttonBorrar.Text = "BORRAR";
            this.buttonBorrar.UseVisualStyleBackColor = false;
            this.buttonBorrar.Click += new System.EventHandler(this.buttonBorrar_Click);
            // 
            // buttonImprimir
            // 
            this.buttonImprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(141)))), ((int)(((byte)(237)))));
            this.buttonImprimir.FlatAppearance.BorderSize = 0;
            this.buttonImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonImprimir.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonImprimir.Location = new System.Drawing.Point(229, 46);
            this.buttonImprimir.Margin = new System.Windows.Forms.Padding(2);
            this.buttonImprimir.Name = "buttonImprimir";
            this.buttonImprimir.Size = new System.Drawing.Size(116, 40);
            this.buttonImprimir.TabIndex = 4;
            this.buttonImprimir.Text = "IMPRIMIR";
            this.buttonImprimir.UseVisualStyleBackColor = false;
            this.buttonImprimir.Click += new System.EventHandler(this.buttonImprimir_Click);
            // 
            // textBoxLinea2
            // 
            this.textBoxLinea2.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLinea2.Location = new System.Drawing.Point(29, 110);
            this.textBoxLinea2.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxLinea2.MaxLength = 16;
            this.textBoxLinea2.Name = "textBoxLinea2";
            this.textBoxLinea2.Size = new System.Drawing.Size(174, 26);
            this.textBoxLinea2.TabIndex = 3;
            // 
            // labelLinea2
            // 
            this.labelLinea2.AutoSize = true;
            this.labelLinea2.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLinea2.Location = new System.Drawing.Point(25, 89);
            this.labelLinea2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLinea2.Name = "labelLinea2";
            this.labelLinea2.Size = new System.Drawing.Size(54, 18);
            this.labelLinea2.TabIndex = 2;
            this.labelLinea2.Text = "Linea2";
            // 
            // labelLinea1
            // 
            this.labelLinea1.AutoSize = true;
            this.labelLinea1.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLinea1.Location = new System.Drawing.Point(25, 30);
            this.labelLinea1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLinea1.Name = "labelLinea1";
            this.labelLinea1.Size = new System.Drawing.Size(51, 18);
            this.labelLinea1.TabIndex = 1;
            this.labelLinea1.Text = "Linea1";
            // 
            // textBoxLinea1
            // 
            this.textBoxLinea1.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLinea1.Location = new System.Drawing.Point(29, 54);
            this.textBoxLinea1.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxLinea1.MaxLength = 16;
            this.textBoxLinea1.Name = "textBoxLinea1";
            this.textBoxLinea1.Size = new System.Drawing.Size(174, 26);
            this.textBoxLinea1.TabIndex = 0;
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
            this.groupBox3.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(24, 219);
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
            this.buttonRefrescar.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefrescar.Location = new System.Drawing.Point(264, 37);
            this.buttonRefrescar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRefrescar.Name = "buttonRefrescar";
            this.buttonRefrescar.Size = new System.Drawing.Size(116, 40);
            this.buttonRefrescar.TabIndex = 6;
            this.buttonRefrescar.Text = "REFRESCAR";
            this.buttonRefrescar.UseVisualStyleBackColor = false;
            this.buttonRefrescar.Click += new System.EventHandler(this.buttonRefrescar_Click);
            // 
            // progressBarConexion
            // 
            this.progressBarConexion.Location = new System.Drawing.Point(264, 144);
            this.progressBarConexion.Name = "progressBarConexion";
            this.progressBarConexion.Size = new System.Drawing.Size(116, 15);
            this.progressBarConexion.TabIndex = 5;
            // 
            // buttonConectar
            // 
            this.buttonConectar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(141)))), ((int)(((byte)(237)))));
            this.buttonConectar.FlatAppearance.BorderSize = 0;
            this.buttonConectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConectar.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConectar.Location = new System.Drawing.Point(264, 89);
            this.buttonConectar.Name = "buttonConectar";
            this.buttonConectar.Size = new System.Drawing.Size(116, 40);
            this.buttonConectar.TabIndex = 4;
            this.buttonConectar.Text = "CONECTAR";
            this.buttonConectar.UseVisualStyleBackColor = false;
            this.buttonConectar.Click += new System.EventHandler(this.buttonConectar_Click);
            // 
            // comboBoxBaud
            // 
            this.comboBoxBaud.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBaud.FormattingEnabled = true;
            this.comboBoxBaud.Location = new System.Drawing.Point(115, 95);
            this.comboBoxBaud.Name = "comboBoxBaud";
            this.comboBoxBaud.Size = new System.Drawing.Size(121, 27);
            this.comboBoxBaud.TabIndex = 3;
            // 
            // comboBoxPuerto
            // 
            this.comboBoxPuerto.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPuerto.FormattingEnabled = true;
            this.comboBoxPuerto.Location = new System.Drawing.Point(115, 43);
            this.comboBoxPuerto.Name = "comboBoxPuerto";
            this.comboBoxPuerto.Size = new System.Drawing.Size(121, 27);
            this.comboBoxPuerto.TabIndex = 2;
            // 
            // labelBaud
            // 
            this.labelBaud.AutoSize = true;
            this.labelBaud.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBaud.Location = new System.Drawing.Point(25, 99);
            this.labelBaud.Name = "labelBaud";
            this.labelBaud.Size = new System.Drawing.Size(76, 16);
            this.labelBaud.TabIndex = 1;
            this.labelBaud.Text = "Baudrate";
            // 
            // labelPuerto
            // 
            this.labelPuerto.AutoSize = true;
            this.labelPuerto.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPuerto.Location = new System.Drawing.Point(25, 48);
            this.labelPuerto.Name = "labelPuerto";
            this.labelPuerto.Size = new System.Drawing.Size(57, 16);
            this.labelPuerto.TabIndex = 0;
            this.labelPuerto.Text = "Puerto";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.labelInfo);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.trackBarServo);
            this.groupBox4.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.labelInfo.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfo.Location = new System.Drawing.Point(169, 125);
            this.labelInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(34, 23);
            this.labelInfo.TabIndex = 8;
            this.labelInfo.Text = "....";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(318, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "180°";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "0°";
            // 
            // trackBarServo
            // 
            this.trackBarServo.LargeChange = 20;
            this.trackBarServo.Location = new System.Drawing.Point(29, 77);
            this.trackBarServo.Maximum = 180;
            this.trackBarServo.Name = "trackBarServo";
            this.trackBarServo.Size = new System.Drawing.Size(316, 45);
            this.trackBarServo.SmallChange = 20;
            this.trackBarServo.TabIndex = 0;
            this.trackBarServo.Tag = "";
            this.trackBarServo.TickFrequency = 20;
            this.trackBarServo.Scroll += new System.EventHandler(this.trackBarServo_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(877, 432);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "PC - ARDUINO CONTROL";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLedC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLedB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLedA)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarServo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxLedC;
        private System.Windows.Forms.CheckBox checkBoxLedB;
        private System.Windows.Forms.CheckBox checkBoxLedA;
        private System.Windows.Forms.PictureBox pictureLedC;
        private System.Windows.Forms.PictureBox pictureLedB;
        private System.Windows.Forms.PictureBox pictureLedA;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelLinea1;
        private System.Windows.Forms.TextBox textBoxLinea1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonImprimir;
        private System.Windows.Forms.TextBox textBoxLinea2;
        private System.Windows.Forms.Label labelLinea2;
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
        private System.Windows.Forms.Button buttonBorrar;
        private System.Windows.Forms.Button buttonRefrescar;
    }
}

