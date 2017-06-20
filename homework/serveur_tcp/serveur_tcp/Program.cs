using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;


namespace serveur_tcp
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpListener listen = new TcpListener(IPAddress.Any, 1200);
            Console.WriteLine("[Подключаюсь...]");
            listen.Start();
            TcpClient client = listen.AcceptTcpClient();
            Console.WriteLine("[Клиент подключен ура]");
            NetworkStream stream = client.GetStream();
            byte[] buffer = new byte[client.ReceiveBufferSize];
            int data = stream.Read(buffer, 0, client.ReceiveBufferSize);
            string ch = Encoding.Unicode.GetString(buffer, 0, data);
            Console.WriteLine("Сообщение получено (ура), а именно:" + ch);
            client.Close();
            Console.ReadKey();
        }
    }
}
