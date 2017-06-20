using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;


namespace client
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpClient client = new TcpClient("127.0.0.1", 1200);
            Console.WriteLine("[Пытаюсь подключиться к серверу...]");
            NetworkStream n = client.GetStream();
            Console.WriteLine("[Подключено (ура)]");
            string ch = Console.ReadLine();
            byte[] message = Encoding.Unicode.GetBytes(ch);
            n.Write(message, 0, message.Length);
            Console.WriteLine("------получаем------");
            client.Close();
            Console.ReadKey();
        }
    }
}
