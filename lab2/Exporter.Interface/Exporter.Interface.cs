using System;
using Exporter;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exporter.Interface
{
    public interface IExporter
    {
        string Export(List<IEntity> items);
    }

    public interface IEntity
    {
        string Name { get; }
        string Surname { get; }
        string Characteristic { get; }

    }
}
