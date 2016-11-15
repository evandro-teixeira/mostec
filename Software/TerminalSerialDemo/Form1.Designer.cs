namespace TerminalSerialDemo
{
    partial class TerminalSerial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TerminalSerial));
            this.gBoxConfiguracao = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxHandshake = new System.Windows.Forms.ComboBox();
            this.cbxStopBit = new System.Windows.Forms.ComboBox();
            this.txtComPort = new System.Windows.Forms.Label();
            this.cbxBufferSize = new System.Windows.Forms.ComboBox();
            this.cbxParidade = new System.Windows.Forms.ComboBox();
            this.cbxDataBits = new System.Windows.Forms.ComboBox();
            this.cbxBaudRate = new System.Windows.Forms.ComboBox();
            this.cbxComPort = new System.Windows.Forms.ComboBox();
            this.gBoxConexao = new System.Windows.Forms.GroupBox();
            this.lblStatusConexao = new System.Windows.Forms.Label();
            this.btnDesconectar = new System.Windows.Forms.Button();
            this.btnConectar = new System.Windows.Forms.Button();
            this.TimerRecepcao = new System.Windows.Forms.Timer(this.components);
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnEnviarDados = new System.Windows.Forms.Button();
            this.txtEnviaDados = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnApagarTXTRecepcao = new System.Windows.Forms.Button();
            this.txtRecepcao = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTransmissao = new System.Windows.Forms.TextBox();
            this.ApagarTxTTransmissao = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.button6 = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.radioButton11 = new System.Windows.Forms.RadioButton();
            this.radioButton12 = new System.Windows.Forms.RadioButton();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.radioButton13 = new System.Windows.Forms.RadioButton();
            this.radioButton14 = new System.Windows.Forms.RadioButton();
            this.radioButton15 = new System.Windows.Forms.RadioButton();
            this.radioButton16 = new System.Windows.Forms.RadioButton();
            this.gBoxConfiguracao.SuspendLayout();
            this.gBoxConexao.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBoxConfiguracao
            // 
            this.gBoxConfiguracao.Controls.Add(this.label6);
            this.gBoxConfiguracao.Controls.Add(this.label5);
            this.gBoxConfiguracao.Controls.Add(this.label4);
            this.gBoxConfiguracao.Controls.Add(this.label3);
            this.gBoxConfiguracao.Controls.Add(this.label2);
            this.gBoxConfiguracao.Controls.Add(this.label1);
            this.gBoxConfiguracao.Controls.Add(this.cbxHandshake);
            this.gBoxConfiguracao.Controls.Add(this.cbxStopBit);
            this.gBoxConfiguracao.Controls.Add(this.txtComPort);
            this.gBoxConfiguracao.Controls.Add(this.cbxBufferSize);
            this.gBoxConfiguracao.Controls.Add(this.cbxParidade);
            this.gBoxConfiguracao.Controls.Add(this.cbxDataBits);
            this.gBoxConfiguracao.Controls.Add(this.cbxBaudRate);
            this.gBoxConfiguracao.Controls.Add(this.cbxComPort);
            this.gBoxConfiguracao.Location = new System.Drawing.Point(13, 13);
            this.gBoxConfiguracao.Name = "gBoxConfiguracao";
            this.gBoxConfiguracao.Size = new System.Drawing.Size(227, 318);
            this.gBoxConfiguracao.TabIndex = 0;
            this.gBoxConfiguracao.TabStop = false;
            this.gBoxConfiguracao.Text = "TerminalSerial Configuração";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Buffer Size";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "HandShake";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "StopBits";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Paridade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "DataBits";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "BaudRate";
            // 
            // cbxHandshake
            // 
            this.cbxHandshake.FormattingEnabled = true;
            this.cbxHandshake.Location = new System.Drawing.Point(85, 211);
            this.cbxHandshake.Name = "cbxHandshake";
            this.cbxHandshake.Size = new System.Drawing.Size(121, 21);
            this.cbxHandshake.TabIndex = 7;
            // 
            // cbxStopBit
            // 
            this.cbxStopBit.FormattingEnabled = true;
            this.cbxStopBit.Location = new System.Drawing.Point(85, 176);
            this.cbxStopBit.Name = "cbxStopBit";
            this.cbxStopBit.Size = new System.Drawing.Size(121, 21);
            this.cbxStopBit.TabIndex = 6;
            // 
            // txtComPort
            // 
            this.txtComPort.AutoSize = true;
            this.txtComPort.Location = new System.Drawing.Point(16, 41);
            this.txtComPort.Name = "txtComPort";
            this.txtComPort.Size = new System.Drawing.Size(47, 13);
            this.txtComPort.TabIndex = 5;
            this.txtComPort.Text = "ComPort";
            // 
            // cbxBufferSize
            // 
            this.cbxBufferSize.FormattingEnabled = true;
            this.cbxBufferSize.Location = new System.Drawing.Point(85, 249);
            this.cbxBufferSize.Name = "cbxBufferSize";
            this.cbxBufferSize.Size = new System.Drawing.Size(121, 21);
            this.cbxBufferSize.TabIndex = 4;
            // 
            // cbxParidade
            // 
            this.cbxParidade.FormattingEnabled = true;
            this.cbxParidade.Location = new System.Drawing.Point(85, 140);
            this.cbxParidade.Name = "cbxParidade";
            this.cbxParidade.Size = new System.Drawing.Size(121, 21);
            this.cbxParidade.TabIndex = 3;
            // 
            // cbxDataBits
            // 
            this.cbxDataBits.FormattingEnabled = true;
            this.cbxDataBits.Location = new System.Drawing.Point(85, 108);
            this.cbxDataBits.Name = "cbxDataBits";
            this.cbxDataBits.Size = new System.Drawing.Size(121, 21);
            this.cbxDataBits.TabIndex = 2;
            // 
            // cbxBaudRate
            // 
            this.cbxBaudRate.FormattingEnabled = true;
            this.cbxBaudRate.Location = new System.Drawing.Point(85, 75);
            this.cbxBaudRate.Name = "cbxBaudRate";
            this.cbxBaudRate.Size = new System.Drawing.Size(121, 21);
            this.cbxBaudRate.TabIndex = 1;
            this.cbxBaudRate.SelectedIndexChanged += new System.EventHandler(this.cbxBaudRate_SelectedIndexChanged);
            // 
            // cbxComPort
            // 
            this.cbxComPort.FormattingEnabled = true;
            this.cbxComPort.Location = new System.Drawing.Point(85, 38);
            this.cbxComPort.Name = "cbxComPort";
            this.cbxComPort.Size = new System.Drawing.Size(121, 21);
            this.cbxComPort.TabIndex = 0;
            this.cbxComPort.SelectedIndexChanged += new System.EventHandler(this.cbxComPort_SelectedIndexChanged);
            // 
            // gBoxConexao
            // 
            this.gBoxConexao.Controls.Add(this.lblStatusConexao);
            this.gBoxConexao.Controls.Add(this.btnDesconectar);
            this.gBoxConexao.Controls.Add(this.btnConectar);
            this.gBoxConexao.Location = new System.Drawing.Point(13, 353);
            this.gBoxConexao.Name = "gBoxConexao";
            this.gBoxConexao.Size = new System.Drawing.Size(227, 155);
            this.gBoxConexao.TabIndex = 1;
            this.gBoxConexao.TabStop = false;
            this.gBoxConexao.Text = "Conexão";
            // 
            // lblStatusConexao
            // 
            this.lblStatusConexao.BackColor = System.Drawing.Color.Red;
            this.lblStatusConexao.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStatusConexao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusConexao.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblStatusConexao.Location = new System.Drawing.Point(19, 117);
            this.lblStatusConexao.Name = "lblStatusConexao";
            this.lblStatusConexao.Size = new System.Drawing.Size(187, 23);
            this.lblStatusConexao.TabIndex = 2;
            this.lblStatusConexao.Text = "DESCONECTADO";
            this.lblStatusConexao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDesconectar
            // 
            this.btnDesconectar.Location = new System.Drawing.Point(115, 39);
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.Size = new System.Drawing.Size(91, 60);
            this.btnDesconectar.TabIndex = 1;
            this.btnDesconectar.Text = "Desconectar";
            this.btnDesconectar.UseVisualStyleBackColor = true;
            this.btnDesconectar.Click += new System.EventHandler(this.btnDesconectar_Click);
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(19, 39);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(91, 60);
            this.btnConectar.TabIndex = 0;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // TimerRecepcao
            // 
            this.TimerRecepcao.Tick += new System.EventHandler(this.TimerRecepcao_Tick);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnEnviarDados);
            this.tabPage1.Controls.Add(this.txtEnviaDados);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(561, 292);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "TerminalSerial";
            // 
            // btnEnviarDados
            // 
            this.btnEnviarDados.Location = new System.Drawing.Point(243, 6);
            this.btnEnviarDados.Name = "btnEnviarDados";
            this.btnEnviarDados.Size = new System.Drawing.Size(207, 23);
            this.btnEnviarDados.TabIndex = 3;
            this.btnEnviarDados.Text = "Enviar Dados";
            this.btnEnviarDados.UseVisualStyleBackColor = true;
            this.btnEnviarDados.Click += new System.EventHandler(this.btnEnviarDados_Click);
            // 
            // txtEnviaDados
            // 
            this.txtEnviaDados.Location = new System.Drawing.Point(19, 6);
            this.txtEnviaDados.Name = "txtEnviaDados";
            this.txtEnviaDados.Size = new System.Drawing.Size(218, 20);
            this.txtEnviaDados.TabIndex = 2;
            this.txtEnviaDados.TextChanged += new System.EventHandler(this.txtEnviaDados_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnApagarTXTRecepcao);
            this.groupBox2.Controls.Add(this.txtRecepcao);
            this.groupBox2.Location = new System.Drawing.Point(19, 157);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(532, 126);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados Recebidos";
            // 
            // btnApagarTXTRecepcao
            // 
            this.btnApagarTXTRecepcao.Location = new System.Drawing.Point(437, 17);
            this.btnApagarTXTRecepcao.Name = "btnApagarTXTRecepcao";
            this.btnApagarTXTRecepcao.Size = new System.Drawing.Size(83, 23);
            this.btnApagarTXTRecepcao.TabIndex = 5;
            this.btnApagarTXTRecepcao.Text = "Apagar";
            this.btnApagarTXTRecepcao.UseVisualStyleBackColor = true;
            this.btnApagarTXTRecepcao.Click += new System.EventHandler(this.btnApagarTXTRecepcao_Click);
            // 
            // txtRecepcao
            // 
            this.txtRecepcao.Location = new System.Drawing.Point(7, 19);
            this.txtRecepcao.Multiline = true;
            this.txtRecepcao.Name = "txtRecepcao";
            this.txtRecepcao.Size = new System.Drawing.Size(424, 101);
            this.txtRecepcao.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTransmissao);
            this.groupBox1.Controls.Add(this.ApagarTxTTransmissao);
            this.groupBox1.Location = new System.Drawing.Point(19, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(532, 119);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Transmitidos";
            // 
            // txtTransmissao
            // 
            this.txtTransmissao.Location = new System.Drawing.Point(7, 17);
            this.txtTransmissao.Multiline = true;
            this.txtTransmissao.Name = "txtTransmissao";
            this.txtTransmissao.Size = new System.Drawing.Size(424, 97);
            this.txtTransmissao.TabIndex = 0;
            // 
            // ApagarTxTTransmissao
            // 
            this.ApagarTxTTransmissao.Location = new System.Drawing.Point(437, 11);
            this.ApagarTxTTransmissao.Name = "ApagarTxTTransmissao";
            this.ApagarTxTTransmissao.Size = new System.Drawing.Size(83, 23);
            this.ApagarTxTTransmissao.TabIndex = 4;
            this.ApagarTxTTransmissao.Text = "Apagar";
            this.ApagarTxTTransmissao.UseVisualStyleBackColor = true;
            this.ApagarTxTTransmissao.Click += new System.EventHandler(this.ApagarTxTTransmissao_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(257, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(569, 318);
            this.tabControl1.TabIndex = 2;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(257, 532);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(569, 79);
            this.button6.TabIndex = 4;
            this.button6.Text = "START";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(18, 55);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(75, 17);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "ABSOLUT";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(17, 32);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(80, 17);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "SMIRNOFF";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(17, 78);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(53, 17);
            this.radioButton3.TabIndex = 7;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "SKYY";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(17, 101);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(67, 17);
            this.radioButton4.TabIndex = 8;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "ORLOFF";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton2);
            this.groupBox3.Controls.Add(this.radioButton4);
            this.groupBox3.Controls.Add(this.radioButton1);
            this.groupBox3.Controls.Add(this.radioButton3);
            this.groupBox3.Location = new System.Drawing.Point(257, 353);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(107, 155);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Vodka";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioButton5);
            this.groupBox4.Controls.Add(this.radioButton6);
            this.groupBox4.Controls.Add(this.radioButton7);
            this.groupBox4.Controls.Add(this.radioButton8);
            this.groupBox4.Location = new System.Drawing.Point(411, 353);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(107, 155);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "MEL";
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(17, 32);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(76, 17);
            this.radioButton5.TabIndex = 6;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "NATURAL";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(17, 101);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(85, 17);
            this.radioButton6.TabIndex = 8;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "TUTI-FRUTI";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(18, 55);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(63, 17);
            this.radioButton7.TabIndex = 5;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "MENTA";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(17, 78);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(81, 17);
            this.radioButton8.TabIndex = 7;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "MORANGO";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.radioButton9);
            this.groupBox5.Controls.Add(this.radioButton10);
            this.groupBox5.Controls.Add(this.radioButton11);
            this.groupBox5.Controls.Add(this.radioButton12);
            this.groupBox5.Location = new System.Drawing.Point(719, 353);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(107, 155);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Corante";
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Location = new System.Drawing.Point(17, 32);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(81, 17);
            this.radioButton9.TabIndex = 6;
            this.radioButton9.TabStop = true;
            this.radioButton9.Text = "MORANGO";
            this.radioButton9.UseVisualStyleBackColor = true;
            // 
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.Location = new System.Drawing.Point(17, 101);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(55, 17);
            this.radioButton10.TabIndex = 8;
            this.radioButton10.TabStop = true;
            this.radioButton10.Text = "COCO";
            this.radioButton10.UseVisualStyleBackColor = true;
            // 
            // radioButton11
            // 
            this.radioButton11.AutoSize = true;
            this.radioButton11.Location = new System.Drawing.Point(18, 55);
            this.radioButton11.Name = "radioButton11";
            this.radioButton11.Size = new System.Drawing.Size(63, 17);
            this.radioButton11.TabIndex = 5;
            this.radioButton11.TabStop = true;
            this.radioButton11.Text = "MENTA";
            this.radioButton11.UseVisualStyleBackColor = true;
            // 
            // radioButton12
            // 
            this.radioButton12.AutoSize = true;
            this.radioButton12.Location = new System.Drawing.Point(17, 78);
            this.radioButton12.Name = "radioButton12";
            this.radioButton12.Size = new System.Drawing.Size(70, 17);
            this.radioButton12.TabIndex = 7;
            this.radioButton12.TabStop = true;
            this.radioButton12.Text = "ABACAXI";
            this.radioButton12.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.radioButton13);
            this.groupBox6.Controls.Add(this.radioButton14);
            this.groupBox6.Controls.Add(this.radioButton15);
            this.groupBox6.Controls.Add(this.radioButton16);
            this.groupBox6.Location = new System.Drawing.Point(565, 353);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(107, 155);
            this.groupBox6.TabIndex = 11;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Energetico";
            // 
            // radioButton13
            // 
            this.radioButton13.AutoSize = true;
            this.radioButton13.Location = new System.Drawing.Point(17, 32);
            this.radioButton13.Name = "radioButton13";
            this.radioButton13.Size = new System.Drawing.Size(78, 17);
            this.radioButton13.TabIndex = 6;
            this.radioButton13.TabStop = true;
            this.radioButton13.Text = "RED BULL";
            this.radioButton13.UseVisualStyleBackColor = true;
            // 
            // radioButton14
            // 
            this.radioButton14.AutoSize = true;
            this.radioButton14.Location = new System.Drawing.Point(17, 101);
            this.radioButton14.Name = "radioButton14";
            this.radioButton14.Size = new System.Drawing.Size(49, 17);
            this.radioButton14.TabIndex = 8;
            this.radioButton14.TabStop = true;
            this.radioButton14.Text = "VIBE";
            this.radioButton14.UseVisualStyleBackColor = true;
            // 
            // radioButton15
            // 
            this.radioButton15.AutoSize = true;
            this.radioButton15.Location = new System.Drawing.Point(18, 55);
            this.radioButton15.Name = "radioButton15";
            this.radioButton15.Size = new System.Drawing.Size(47, 17);
            this.radioButton15.TabIndex = 5;
            this.radioButton15.TabStop = true;
            this.radioButton15.Text = "TNT";
            this.radioButton15.UseVisualStyleBackColor = true;
            // 
            // radioButton16
            // 
            this.radioButton16.AutoSize = true;
            this.radioButton16.Location = new System.Drawing.Point(17, 78);
            this.radioButton16.Name = "radioButton16";
            this.radioButton16.Size = new System.Drawing.Size(79, 17);
            this.radioButton16.TabIndex = 7;
            this.radioButton16.TabStop = true;
            this.radioButton16.Text = "MONSTER";
            this.radioButton16.UseVisualStyleBackColor = true;
            // 
            // TerminalSerial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(872, 623);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.gBoxConexao);
            this.Controls.Add(this.gBoxConfiguracao);
            this.Name = "TerminalSerial";
            this.Text = "SerialMES";
            this.Load += new System.EventHandler(this.TerminalSerial_Load);
            this.gBoxConfiguracao.ResumeLayout(false);
            this.gBoxConfiguracao.PerformLayout();
            this.gBoxConexao.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxConfiguracao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxHandshake;
        private System.Windows.Forms.ComboBox cbxStopBit;
        private System.Windows.Forms.Label txtComPort;
        private System.Windows.Forms.ComboBox cbxBufferSize;
        private System.Windows.Forms.ComboBox cbxParidade;
        private System.Windows.Forms.ComboBox cbxDataBits;
        private System.Windows.Forms.ComboBox cbxBaudRate;
        private System.Windows.Forms.ComboBox cbxComPort;
        private System.Windows.Forms.GroupBox gBoxConexao;
        private System.Windows.Forms.Label lblStatusConexao;
        private System.Windows.Forms.Button btnDesconectar;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Timer TimerRecepcao;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnApagarTXTRecepcao;
        private System.Windows.Forms.Button ApagarTxTTransmissao;
        private System.Windows.Forms.Button btnEnviarDados;
        private System.Windows.Forms.TextBox txtEnviaDados;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtRecepcao;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTransmissao;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.RadioButton radioButton10;
        private System.Windows.Forms.RadioButton radioButton11;
        private System.Windows.Forms.RadioButton radioButton12;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton radioButton13;
        private System.Windows.Forms.RadioButton radioButton14;
        private System.Windows.Forms.RadioButton radioButton15;
        private System.Windows.Forms.RadioButton radioButton16;
    }
}

