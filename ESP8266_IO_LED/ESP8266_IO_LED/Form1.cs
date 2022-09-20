using System;
using System.Text;
using System.Windows.Forms;
using SimpleTCP;

namespace ESP8266_Potensio
{
    public partial class Form1 : Form
    {
        SimpleTcpClient client;
        string DataIn;
        sbyte indexOfB;
        sbyte indexOfA;
        sbyte indexOfZ;
        string led1, led2, pote;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            client.Connect(tbIP.Text, Convert.ToInt32(tbPort.Text));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            client = new SimpleTcpClient();
            client.StringEncoder = Encoding.UTF8;
            client.DataReceived += led1_DataReceived;
            DataIn = "";
        }

        private void led1_DataReceived(object sender, SimpleTCP.Message e)
        {
            
            tbLed1.Invoke((MethodInvoker)delegate ()
            {
                DataIn = e.MessageString;
                if (DataIn == "ON1" || DataIn == "OFF1")
                {
                    indexOfA = Convert.ToSByte(DataIn.IndexOf("1"));
                    led1 = DataIn.Substring(0, indexOfA);
                    tbLed1.Text = led1;
                }
                else if (DataIn == "ON2" || DataIn == "OFF2")
                {
                    indexOfB = Convert.ToSByte(DataIn.IndexOf("2"));
                    led2 = DataIn.Substring(0, indexOfB);
                    tbLed2.Text = led2;
                }
                else
                {
                    return;
                }
                
            });
        }

        private void btnON1_Click(object sender, EventArgs e)
        {
            try
            {
                client.Write("ON1#");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnOFF1_Click(object sender, EventArgs e)
        {
            try
            {
                client.Write("OFF1#");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnON2_Click(object sender, EventArgs e)
        {
            try
            {
                client.Write("ON2#");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnOFF2_Click(object sender, EventArgs e)
        {
            try
            {
                client.Write("OFF2#");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }       
    }
}
