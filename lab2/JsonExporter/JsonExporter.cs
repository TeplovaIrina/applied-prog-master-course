using Exporter.Interface;
using Newtonsoft.Json;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonExporter
{
    public class JsonExporter : IExporter
    {
        public string Export(List<IEntity> items)
        {
            var filename = "JsonExport.json";
            string[] json = new string[] { JsonConvert.SerializeObject(items, Formatting.Indented) };
            File.WriteAllLines(filename, json);
            return filename;
        }
    }
}
