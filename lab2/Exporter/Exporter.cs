using Exporter.Interface;
using Newtonsoft.Json;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exporter
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

    public class TxtExporter : IExporter
    {
        public string Export(List<IEntity> items)
        {
            var filename = "TxtExport.txt";
            List<string> txt = new List<string>();
            foreach (var item in items)
            {
                txt.Add(item.Name + ' ' + item.Surname + ' ' + item.Age.ToString());
            }
            File.WriteAllLines(filename, txt);
            return filename;
        }

        public class XlsExporter : IExporter
        {
            public string Export(List<IEntity> items)
            {
                var filename = "XlsExport.txt";



                List<string> txt = new List<string>();
                foreach (var item in items)
                {
                    txt.Add(item.Name + ' ' + item.Surname + ' ' + item.Age.ToString());
                }
                File.WriteAllLines(filename, txt);
                return filename;
            }
        }
    }
}