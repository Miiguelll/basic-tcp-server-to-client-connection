using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace tcp
{
    public class ConnectionHandler
    {
        public bool connection = true;
        public static TcpClient client = new TcpClient();

       public TcpListener listener = new TcpListener(IPAddress.Any, 1111);
        public void Listen()
        {
            

            while (true)
            {
                listener.Start();
                listener.AcceptTcpClient();
                MessageBox.Show("Connected!");

                if (connection == false)
                {
                    listener.Stop();

                }
            }


        }
        public void Send(string file)
        {
            listener.Server.SendFile(file);
        }

        public void Disconnect()
        {
            connection = false;
            MessageBox.Show("Disconnected!");
        }

        public void GetData()
        {
        


            
        }



    }
}
