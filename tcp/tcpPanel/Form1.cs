using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Diagnostics;
using System.Runtime.Remoting.Messaging;

namespace tcpPanel
{
    public partial class Panel : Form
    {
       public static TcpClient client = new TcpClient();
       

        public Panel()
        {
            InitializeComponent();

           
        }

        private void Panel_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            
            IPAddress ip = IPAddress.Parse("192.168.0.21");
            IPEndPoint epRemote = new IPEndPoint(ip, 1111);
            try
            {
                client.Connect(epRemote);
                MessageBox.Show("Connected!");
                button1.Enabled = false;
                button2.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Server Is Down!");
                Process.GetCurrentProcess().Kill();
            }
           

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            client.Close();
            MessageBox.Show("Disconnected!");
            button1.Enabled = true;
            button2.Enabled = false;
        }
    }
}
