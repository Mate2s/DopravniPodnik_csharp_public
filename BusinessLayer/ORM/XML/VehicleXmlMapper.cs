using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ORM.XML
{
    public class VehicleXmlMapper<T> : XmlMapper<T>, IVehicleMapper
    {
        protected override string GetPath()
        {
            return "Vehicle.txt";
        }
    }
}
