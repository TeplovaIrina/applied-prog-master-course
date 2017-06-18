using System;
using Exporter.Interface;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exporter.Resolver
{
    public class Kernel
    {
        private Dictionary <Type, Object> _dict;

        public Kernel()
        {
            next:;
            object a = new TxtExporter.TxtExporter();           
            Console.WriteLine("Какой формат иcпользуем(txt,exel,json)?");
            string str = Console.ReadLine();

            if (str == "txt")
            { a = new TxtExporter.TxtExporter(); }
            else if (str == "exel")
            { a = new XlsExporter.XlsExporter(); }
            else if (str == "json")
            { a = new JsonExporter.JsonExporter(); }
            else
            { Console.WriteLine("Неверный формат");
                goto next;
            }
            this._dict = new Dictionary<Type, object>();
            this._dict.Add(typeof(IExporter), a);
        }

        public T Get<T>()
        {
            var res = this._dict[typeof(T)];
            return (T)res;
        }
    }
}
