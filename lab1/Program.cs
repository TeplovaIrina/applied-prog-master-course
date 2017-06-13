
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Exc = Microsoft.Office.Interop.Excel;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            exel cl = new exel();
            cl.GetIn();
            
            Console.ReadLine();
        }
    }
}