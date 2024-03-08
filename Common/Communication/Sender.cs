using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Sender
    {
        private Socket soket;
        private NetworkStream stream;
        private BinaryFormatter formatter;

        public Sender(Socket soket)
        {
            this.soket = soket;
            stream=new NetworkStream(soket);
            formatter = new BinaryFormatter();
        }

        public void Send(object arg)
        {
            formatter.Serialize(stream, arg);
        }
    }
}
