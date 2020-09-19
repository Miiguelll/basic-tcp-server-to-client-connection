using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tcp
{
    class Program
    {
        private static NetworkStream stream { get; set; }
        static void Main(string[] args)
        {
            
            ConnectionHandler handler = new ConnectionHandler();


            handler.Listen();


            
           
          

         








        }
       
    }

}
