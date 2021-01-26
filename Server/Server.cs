using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public class Server
    {
        private Socket serverskiSocket;

        public void PokreniServer()
        {
            serverskiSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            serverskiSocket.Bind(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8000));
            serverskiSocket.Listen(10);
            try
            {
                while (true)
                {
                    Socket klijentskiSoket = serverskiSocket.Accept();
                    KlijentHendler hendler = new KlijentHendler(klijentskiSoket);
                    Thread nit = new Thread(hendler.ObradiZahteve);
                    nit.IsBackground = true;
                    nit.Start();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
