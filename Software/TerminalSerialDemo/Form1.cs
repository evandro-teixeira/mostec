using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace TerminalSerialDemo
{
    public partial class TerminalSerial : Form
    {


        byte start, tipo, comando, checksum, stop;

        SerialPort SerialComPort = new SerialPort(); //criei o objeto SerialComPort - hipe
        int StatusFlagRecepcao = 0;

        string ResultadoBuffer = string.Empty;
        public delegate void FundDelegate(string a);
        public TerminalSerial()
        {
            InitializeComponent();
            SerialComPort.DataReceived += new SerialDataReceivedEventHandler(SerialComPort_DataReceived);

        }

        void SerialComPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

            ResultadoBuffer = SerialComPort.ReadExisting();
            FundDelegate EnviaTextBox = new FundDelegate(EscreveTXT);
            EnviaTextBox.Invoke(ResultadoBuffer);

        }

        public void EscreveTXT(string a)
        {


            if (this.txtRecepcao.InvokeRequired)
            {
                FundDelegate d = new FundDelegate(EscreveTXT);
                this.Invoke(d, new object[] { a });
            }
            else
            {
                this.txtRecepcao.Text += a;

            }

        }

        private void TerminalSerial_Load(object sender, EventArgs e)
        {

            #region Configuração Serial do Terminal
            String[] ListCom = SerialPort.GetPortNames();

            string NameCom;
            int x = 0;
            for (int i = 0; i < ListCom.Length; i++)
            {

                NameCom = ListCom[i];
                cbxComPort.Items.Add(NameCom);
                if (NameCom == "COM1")
                {
                    x = i;

                }

            }

            if (ListCom.Length > 0)
                cbxComPort.SelectedIndex = x;
            #endregion

            #region Carrega valores de BaudRate no ComboBox
            Int32[] BaudRateValores = { 100,300,600,1200,2400,4800,9600,14400,19200,
                                        38400,56000,57600,115200,128000,256000
                                       };
            int x1 = 0;
            for (int i = 0; i < BaudRateValores.Length; i++)
            {
                cbxBaudRate.Items.Add(BaudRateValores[i].ToString());
                if (BaudRateValores[i] == 9600)
                {
                    x1 = i;
                }
            }
            cbxBaudRate.SelectedIndex = x1;
            #endregion

            #region Carrega valores DataBits no ComboBox
            cbxDataBits.Items.Add("5"); //indice 0
            cbxDataBits.Items.Add("6");
            cbxDataBits.Items.Add("7");
            cbxDataBits.Items.Add("8"); //indice 3
            cbxDataBits.SelectedIndex = 3;
            #endregion

            #region carrega valores de Paridade no comboBox
            foreach (string s in Enum.GetNames(typeof(Parity)))
            {
                cbxParidade.Items.Add(s);
            }
            cbxParidade.SelectedIndex = 0;
            #endregion

            #region Carrega Valores de StopBits no ComboBox
            foreach (string s in Enum.GetNames(typeof(StopBits)))
            {
                cbxStopBit.Items.Add(s);
            }
            cbxStopBit.SelectedIndex = 1;
            #endregion

            #region Carrega valores de HandShake no comboBox
            foreach (string s in Enum.GetNames(typeof(Handshake)))
            {
                cbxHandshake.Items.Add(s);
            }
            cbxHandshake.SelectedIndex = 0;
            #endregion

            #region Carrega valores do BufferSize no comboBox
            cbxBufferSize.Items.Add("1024");
            cbxBufferSize.Items.Add("2048");
            cbxBufferSize.Items.Add("8192");
            cbxBufferSize.Items.Add("16384");
            cbxBufferSize.SelectedIndex = 0;
            #endregion

            btnDesconectar.Enabled = false;

        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            SerialComPort.PortName = cbxComPort.Text;
            SerialComPort.BaudRate = Int32.Parse(cbxBaudRate.Text);
            SerialComPort.DataBits = Int32.Parse(cbxDataBits.Text);
            SerialComPort.Parity = (Parity)cbxParidade.SelectedIndex;
            SerialComPort.StopBits = (StopBits)cbxStopBit.SelectedIndex;
            SerialComPort.Handshake = (Handshake)cbxHandshake.SelectedIndex;
            SerialComPort.WriteTimeout = 500;
            SerialComPort.ReadTimeout = 500;
            System.Text.ASCIIEncoding AsCII = new System.Text.ASCIIEncoding();
            SerialComPort.Encoding = AsCII;

            try
            {
                SerialComPort.Open();
                lblStatusConexao.Text = "CONECTADO";
                lblStatusConexao.BackColor = Color.DarkGreen;
                btnDesconectar.Enabled = true;
                btnConectar.Enabled = false;
                gBoxConfiguracao.Enabled = false;
                //TimerRecepcao.Enabled = true; 

            }
            catch
            {

                MessageBox.Show("Não foi possível abrir a porta COM selecionada");

            }


        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {

            try
            {
                while (SerialComPort.BytesToWrite > 0) ;
                SerialComPort.Dispose();  //fecha a porta e libera o recurso da memória
                SerialComPort.Close();    //fecha a porta COM
                TimerRecepcao.Enabled = false;
                btnDesconectar.Enabled = false;
                btnConectar.Enabled = true;
                lblStatusConexao.Text = "DESCONECTADO";
                lblStatusConexao.BackColor = Color.DarkRed;
                gBoxConfiguracao.Enabled = true;

            }
            catch
            {
                MessageBox.Show("Não foi possível fechar a porta COM selecionada");

            }
        }

        private void btnEnviarDados_Click(object sender, EventArgs e)
        {
            if (isOpen)
            {

                try
                {
                    SerialComPort.Write(txtEnviaDados.Text);
                    txtTransmissao.Text += txtEnviaDados.Text;
                    txtTransmissao.Focus();

                }
                catch (Exception w)
                {
                    MessageBox.Show(w.ToString());

                }
            }
        }

        //verifica se a porta COM esta aberta ou fechada 
        public bool isOpen
        {
            get
            {
                return SerialComPort.IsOpen;

            }

        }

        private void ApagarTxTTransmissao_Click(object sender, EventArgs e)
        {
            txtTransmissao.Text = "";
        }

        private void btnApagarTXTRecepcao_Click(object sender, EventArgs e)
        {
            txtRecepcao.Text = "";
        }

        string TextoRecepcao;
        private void TimerRecepcao_Tick(object sender, EventArgs e)
        {

            if (isOpen)
            {
                try
                {
                    TextoRecepcao = SerialComPort.ReadExisting();
                    // Decodificar(TextoRecepcao);

                }
                catch (Exception w)
                {

                    MessageBox.Show(w.ToString());
                }


            }
        }






        private void cbxComPort_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtEnviaDados_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isOpen)
            {

                try
                {
                    //SerialComPort.Write("[0110285]");
                    //txtTransmissao.Text += "[0110285]";
                    // APLICAÇÃO DEMO 
                    // VERSÃO DO HARDWARE                 
                    SerialComPort.Write("[15 10 00 00]");
                    txtTransmissao.Text += "[15 10 00 00]";
                    txtTransmissao.Focus();

                }
                catch (Exception w)
                {
                    MessageBox.Show(w.ToString());

                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (isOpen)
            {

                try
                {
                    //SerialComPort.Write("[0111286]");
                    //txtTransmissao.Text += "[0111286]";
                    // APLICAÇÃO DEMO 
                    // VERSÃO DO SOFTWARE                 
                    SerialComPort.Write("[15 11 00 00]");
                    txtTransmissao.Text += "[15 11 00 00]";
                    txtTransmissao.Focus();

                }
                catch (Exception w)
                {
                    MessageBox.Show(w.ToString());

                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (isOpen)
            {

                try
                {
                    SerialComPort.Write("[0112287]");
                    txtTransmissao.Text += "[0112287]";
                    txtTransmissao.Focus();

                }
                catch (Exception w)
                {
                    MessageBox.Show(w.ToString());

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (isOpen)
            {

                try
                {
                    byte dado = 0;
                    dado = 10;
                    // SerialComPort.Write("[0113288]");
                   // SerialComPort.Write("%d",dado);
                    //txtTransmissao.Text += "[0113288]";
                    //txtTransmissao.Focus();
                    
                    // byte[] dados = new byte[4]; // total de dados a ser enviados

                }
                catch (Exception w)
                {
                    MessageBox.Show(w.ToString());

                }
            }

        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (isOpen)
            {

                try
                {
                    //SerialComPort.Write("[0220287]");
                    //txtTransmissao.Text += "[0220287]";

                    SerialComPort.Write("[15 20 101 111]");
                    txtTransmissao.Text += "[15 20 101 111]";
                    //txtTransmissao.Focus();
                    txtTransmissao.Focus();

                }
                catch (Exception w)
                {
                    MessageBox.Show(w.ToString());

                }
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            /*
            if (isOpen)
            {

                try
                {
                    //SerialComPort.Write("[0221288]");
                    //txtTransmissao.Text += "[0221288]";

                    SerialComPort.Write("15 21 00 00]");
                    txtTransmissao.Text += "[15 21 00 00]";
                    txtTransmissao.Focus();

                }
                catch (Exception w)
                {
                    MessageBox.Show(w.ToString());

                }
            }
            */
            if (isOpen)
            {

                try
                {
                    //SerialComPort.Write("[0220287]");
                    //txtTransmissao.Text += "[0220287]";

                    SerialComPort.Write("[15 21 00 00]");
                    txtTransmissao.Text += "[15 21 00 00]";
                    //txtTransmissao.Focus();
                    txtTransmissao.Focus();

                }
                catch (Exception w)
                {
                    MessageBox.Show(w.ToString());

                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {

            if (isOpen)
            {

                try
                {
                    SerialComPort.Write("[0222289]");
                    txtTransmissao.Text += "[0222289]";
                    txtTransmissao.Focus();

                }
                catch (Exception w)
                {
                    MessageBox.Show(w.ToString());

                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {

            if (isOpen)
            {

                try
                {
                    //SerialComPort.Write("[0223290]");
                    //txtTransmissao.Text += "[0223290]";
                    SerialComPort.Write("[15 23 00 00]");
                    txtTransmissao.Text += "[15 23 00 00]";
                    txtTransmissao.Focus();

                }
                catch (Exception w)
                {
                    MessageBox.Show(w.ToString());

                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {

            if (isOpen)
            {

                try
                {
                    //SerialComPort.Write("[0224291]");
                    //txtTransmissao.Text += "[0224291]";
                    SerialComPort.Write("[15 24 00 00]");
                    txtTransmissao.Text += "[15 24 00 00]";
                    txtTransmissao.Focus();

                }
                catch (Exception w)
                {
                    MessageBox.Show(w.ToString());

                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {

            if (button13.Text == "OFF")
            {
                if (isOpen)
                {

                    try
                    {
                        //SerialComPort.Write("[RL01]");
                        //txtTransmissao.Text += "[RL01]";
                        SerialComPort.Write("[15 30 01 01]");
                        txtTransmissao.Text += "[15 30 01 01]";
                        txtTransmissao.Focus();
                        button13.Text = "ON";
                        label7.BackColor = Color.DarkGreen;

                    }
                    catch (Exception w)
                    {
                        MessageBox.Show(w.ToString());

                    }
                }

            }
            else
            {
                if (isOpen)
                {

                    try
                    {
                        //SerialComPort.Write("[RL01]");
                        //txtTransmissao.Text += "[RL01]";
                        SerialComPort.Write("[15 30 01 00]");
                        txtTransmissao.Text += "[15 30 01 00]";
                        txtTransmissao.Focus();
                        button13.Text = "OFF";
                        label7.BackColor = Color.Red;

                    }
                    catch (Exception w)
                    {
                        MessageBox.Show(w.ToString());

                    }
                }
            }

        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (button14.Text == "OFF")
            {
                if (isOpen)
                {

                    try
                    {
                        //SerialComPort.Write("[RL02]");
                        //txtTransmissao.Text += "[RL02]";
                        SerialComPort.Write("[15 30 02 01]");
                        txtTransmissao.Text += "[15 30 02 01]";
                        txtTransmissao.Focus();
                        button14.Text = "ON";
                        label8.BackColor = Color.DarkGreen;

                    }
                    catch (Exception w)
                    {
                        MessageBox.Show(w.ToString());

                    }
                }

            }
            else
            {
                if (isOpen)
                {

                    try
                    {
                        //SerialComPort.Write("[RL02]");
                        //txtTransmissao.Text += "[RL02]";
                        SerialComPort.Write("[15 30 02 00]");
                        txtTransmissao.Text += "[15 30 02 00]";
                        txtTransmissao.Focus();
                        button14.Text = "OFF";
                        label8.BackColor = Color.Red;

                    }
                    catch (Exception w)
                    {
                        MessageBox.Show(w.ToString());

                    }
                }

            }



        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (button15.Text == "OFF")
            {
                if (isOpen)
                {

                    try
                    {
                        //SerialComPort.Write("[RL03]");
                        //txtTransmissao.Text += "[RL03]";
                        SerialComPort.Write("[15 30 03 01]");
                        txtTransmissao.Text += "[15 30 03 01]";
                        txtTransmissao.Focus();
                        button15.Text = "ON";
                        label9.BackColor = Color.DarkGreen;

                    }
                    catch (Exception w)
                    {
                        MessageBox.Show(w.ToString());

                    }
                }

            }
            else
            {
                if (isOpen)
                {

                    try
                    {
                        //SerialComPort.Write("[RL03]");
                        //txtTransmissao.Text += "[RL03]";
                        SerialComPort.Write("[15 30 03 00]");
                        txtTransmissao.Text += "[15 30 03 00]";
                        txtTransmissao.Focus();
                        button15.Text = "OFF";
                        label9.BackColor = Color.Red;

                    }
                    catch (Exception w)
                    {
                        MessageBox.Show(w.ToString());

                    }
                }
            }

        }


        private void button16_Click(object sender, EventArgs e)
        {
            if (button16.Text == "OFF")
            {
                if (isOpen)
                {

                    try
                    {
                        //SerialComPort.Write("[RL04]");
                        //txtTransmissao.Text += "[RL04]";
                        SerialComPort.Write("[15 30 04 01]");
                        txtTransmissao.Text += "[15 30 04 01]";
                        txtTransmissao.Focus();
                        button16.Text = "ON";
                        label10.BackColor = Color.DarkGreen;

                    }
                    catch (Exception w)
                    {
                        MessageBox.Show(w.ToString());

                    }
                }

            }
            else
            {
                if (isOpen)
                {

                    try
                    {
                        //SerialComPort.Write("[RL04]");
                        //txtTransmissao.Text += "[RL04]";
                        SerialComPort.Write("[15 30 04 00]");
                        txtTransmissao.Text += "[15 30 04 00]";
                        txtTransmissao.Focus();
                        button16.Text = "OFF";
                        label10.BackColor = Color.Red;

                    }
                    catch (Exception w)
                    {
                        MessageBox.Show(w.ToString());

                    }
                }
            }

        }


        private void button17_Click(object sender, EventArgs e)
        {
            if (button17.Text == "OFF")
            {
                if (isOpen)
                {

                    try
                    {
                        //SerialComPort.Write("[RL05]");
                        //txtTransmissao.Text += "[RL05]";
                        SerialComPort.Write("[15 30 05 01]");
                        txtTransmissao.Text += "[15 30 05 01]";
                        txtTransmissao.Focus();
                        button17.Text = "ON";
                        label11.BackColor = Color.DarkGreen;

                    }
                    catch (Exception w)
                    {
                        MessageBox.Show(w.ToString());

                    }
                }

            }
            else
            {
                if (isOpen)
                {

                    try
                    {
                        //SerialComPort.Write("[RL05]");
                        //txtTransmissao.Text += "[RL05]";
                        SerialComPort.Write("[15 30 05 00]");
                        txtTransmissao.Text += "[15 30 05 00]";
                        txtTransmissao.Focus();
                        button17.Text = "OFF";
                        label11.BackColor = Color.Red;

                    }
                    catch (Exception w)
                    {
                        MessageBox.Show(w.ToString());

                    }
                }
            }

        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (button18.Text == "OFF")
            {
                if (isOpen)
                {

                    try
                    {
                        //SerialComPort.Write("[RL06]");
                        //txtTransmissao.Text += "[RL06]";
                        SerialComPort.Write("[15 30 06 01]");
                        txtTransmissao.Text += "[15 30 06 01]";
                        txtTransmissao.Focus();
                        button18.Text = "ON";
                        label12.BackColor = Color.DarkGreen;

                    }
                    catch (Exception w)
                    {
                        MessageBox.Show(w.ToString());

                    }
                }

            }
            else
            {
                if (isOpen)
                {

                    try
                    {
                        //SerialComPort.Write("[RL06]");
                        //txtTransmissao.Text += "[RL06]";
                        SerialComPort.Write("[15 30 06 00]");
                        txtTransmissao.Text += "[15 30 06 00]";
                        txtTransmissao.Focus();
                        button18.Text = "OFF";
                        label12.BackColor = Color.Red;

                    }
                    catch (Exception w)
                    {
                        MessageBox.Show(w.ToString());

                    }
                }
            }

        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (isOpen)
            {

                try
                {
                    //SerialComPort.Write("[0220]");
                    //txtTransmissao.Text += "[0220]";
                    SerialComPort.Write("[15 31 00 00]");
                    txtTransmissao.Text += "[15 31 00 00]";
                    txtTransmissao.Focus();

                }
                catch (Exception w)
                {
                    MessageBox.Show(w.ToString());

                }
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (isOpen)
            {

                try
                {
                    //SerialComPort.Write("[0221]");
                    //txtTransmissao.Text += "[0221]";
                    SerialComPort.Write("[15 32 00 00]");
                    txtTransmissao.Text += "[15 32 00 00]";
                    txtTransmissao.Focus();

                }
                catch (Exception w)
                {
                    MessageBox.Show(w.ToString());

                }
            }
        }

        private void cbxBaudRate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (isOpen)
            {

                try
                {
                    //SerialComPort.Write("[0222]");
                    //txtTransmissao.Text += "[0222]";
                    SerialComPort.Write("[15 33 00 00]");
                    txtTransmissao.Text += "[15 33 00 00]";
                    txtTransmissao.Focus();

                }
                catch (Exception w)
                {
                    MessageBox.Show(w.ToString());

                }
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (isOpen)
            {

                try
                {
                    //SerialComPort.Write("[0223]");
                    //txtTransmissao.Text += "[0223]";
                    SerialComPort.Write("[15 34 00 00]");
                    txtTransmissao.Text += "[15 34 00 00]";
                    txtTransmissao.Focus();

                }
                catch (Exception w)
                {
                    MessageBox.Show(w.ToString());

                }
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {

        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (isOpen)
            {

                try
                {
                    //SerialComPort.Write("[0224]");
                    //txtTransmissao.Text += "[0224]";
                    SerialComPort.Write("[15 35 00 00]");
                    txtTransmissao.Text += "[15 35 00 00]";
                    txtTransmissao.Focus();

                }
                catch (Exception w)
                {
                    MessageBox.Show(w.ToString());

                }
            }
        }

        private void button23_Click_1(object sender, EventArgs e)
        {
            if (isOpen)
            {

                try
                {
                    //SerialComPort.Write("[0225]");
                    //txtTransmissao.Text += "[0225]";
                    SerialComPort.Write("[15 36 00 00]");
                    txtTransmissao.Text += "[15 36 00 00]";
                    txtTransmissao.Focus();

                }
                catch (Exception w)
                {
                    MessageBox.Show(w.ToString());

                }
            }
        }

    }
}