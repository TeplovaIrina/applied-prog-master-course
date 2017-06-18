using Exporter.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exporter.Entity
{
    public class Student : IEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Characteristic { get; set; }
    }
}
