using Exporter.Resolver;
using Exporter.Interface;
using Exporter.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExporterLab
{
    class Program
    {
        
        static void Main(string[] args)
        {
            

            var list = new List<IEntity>();
            list.Add(new Student {Name="Ирина", Surname="Теплова", Characteristic = "Молодец" });
            list.Add(new Student { Name = "Анастасия", Surname = "Шипицына", Characteristic = "Умница"});

            var e = new Kernel();
            var exporter = e.Get<IExporter>();

            System.Diagnostics.Process.Start(exporter.Export(list));
        }
    }
}
