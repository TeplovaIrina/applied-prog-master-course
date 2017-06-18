using Exporter.Interface;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TxtExporter
{
    public class TxtExporter:IExporter
    {
        public string Export(List<IEntity> items)
        {
            var filename = "TxtExport.txt";
            List<string> txt = new List<string>();
            foreach (var item in items)
            {
                txt.Add(item.Name + ' ' + item.Surname + ' ' + item.Characteristic.ToString());
            }
            File.WriteAllLines(filename, txt);
            return filename;
        }
    }
}