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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button18 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.button17 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.button16 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.button15 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.button14 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.button13 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
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
            this.gBoxConexao.Location = new System.Drawing.Point(13, 337);
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Controls.Add(this.button6);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Location = new System.Drawing.Point(257, 346);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(268, 146);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Comandos Gerais";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(140, 102);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(118, 34);
            this.button5.TabIndex = 5;
            this.button5.Text = "xxx";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(6, 102);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(118, 34);
            this.button6.TabIndex = 4;
            this.button6.Text = "#12 - Estado Equip.";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(140, 59);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 34);
            this.button3.TabIndex = 3;
            this.button3.Text = "xxx";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 59);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(118, 34);
            this.button4.TabIndex = 2;
            this.button4.Text = "#11 - Ver. Firmware";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(140, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 34);
            this.button2.TabIndex = 1;
            this.button2.Text = "#13 - Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "#10 - Ver. Hardware";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button7);
            this.groupBox4.Controls.Add(this.button8);
            this.groupBox4.Controls.Add(this.button9);
            this.groupBox4.Controls.Add(this.button10);
            this.groupBox4.Controls.Add(this.button11);
            this.groupBox4.Controls.Add(this.button12);
            this.groupBox4.Location = new System.Drawing.Point(531, 346);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(287, 146);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Comandos Gerais";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(140, 102);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(118, 34);
            this.button7.TabIndex = 5;
            this.button7.Text = "xxx";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(6, 102);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(118, 34);
            this.button8.TabIndex = 4;
            this.button8.Text = "#22 - Turno";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(140, 59);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(118, 34);
            this.button9.TabIndex = 3;
            this.button9.Text = "#24 - Peças Prod.";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(6, 59);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(118, 34);
            this.button10.TabIndex = 2;
            this.button10.Text = "#21 - Nº Operador";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(140, 19);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(118, 34);
            this.button11.TabIndex = 1;
            this.button11.Text = "#23 - Qde. Peças OD";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(6, 19);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(118, 34);
            this.button12.TabIndex = 0;
            this.button12.Text = "#20 - OD. Produção";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button18);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.button17);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.button16);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.button15);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.button14);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.button13);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Location = new System.Drawing.Point(13, 498);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(375, 100);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Sáidas - Reles";
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(308, 19);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(51, 34);
            this.button18.TabIndex = 15;
            this.button18.Text = "OFF";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Red;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Location = new System.Drawing.Point(308, 60);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 23);
            this.label12.TabIndex = 14;
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(251, 19);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(51, 34);
            this.button17.TabIndex = 13;
            this.button17.Text = "OFF";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Red;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Location = new System.Drawing.Point(251, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 23);
            this.label11.TabIndex = 12;
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(194, 19);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(51, 34);
            this.button16.TabIndex = 11;
            this.button16.Text = "OFF";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Red;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(194, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 23);
            this.label10.TabIndex = 10;
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(137, 19);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(51, 34);
            this.button15.TabIndex = 9;
            this.button15.Text = "OFF";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Red;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(137, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 23);
            this.label9.TabIndex = 8;
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(80, 19);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(51, 34);
            this.button14.TabIndex = 7;
            this.button14.Text = "OFF";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Red;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(80, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 23);
            this.label8.TabIndex = 6;
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(23, 19);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(51, 34);
            this.button13.TabIndex = 5;
            this.button13.Text = "OFF";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Red;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(23, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 23);
            this.label7.TabIndex = 3;
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.button23);
            this.groupBox6.Controls.Add(this.button24);
            this.groupBox6.Controls.Add(this.button22);
            this.groupBox6.Controls.Add(this.button21);
            this.groupBox6.Controls.Add(this.button20);
            this.groupBox6.Controls.Add(this.button19);
            this.groupBox6.Location = new System.Drawing.Point(397, 498);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(421, 100);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Comandos Mód. I/O";
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(226, 54);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(96, 34);
            this.button23.TabIndex = 7;
            this.button23.Text = "#36 - Em Manut.";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.button23_Click_1);
            // 
            // button24
            // 
            this.button24.Location = new System.Drawing.Point(226, 19);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(96, 34);
            this.button24.TabIndex = 6;
            this.button24.Text = "#35 - Em Prod.";
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Click += new System.EventHandler(this.button24_Click);
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(124, 54);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(96, 34);
            this.button22.TabIndex = 4;
            this.button22.Text = "#34 - Aguad. OD";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.button22_Click);
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(124, 19);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(96, 34);
            this.button21.TabIndex = 3;
            this.button21.Text = "#33 - MaqSetup";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(10, 54);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(108, 34);
            this.button20.TabIndex = 2;
            this.button20.Text = "#32 - MaqParada";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(10, 19);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(108, 34);
            this.button19.TabIndex = 1;
            this.button19.Text = "#31 -MaqLivre";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // TerminalSerial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 623);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
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
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button23;
    }
}

