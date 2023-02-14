using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ORM.XML
{
    public class RouteNumberXmlMapper<T> : XmlMapper<T>, IRouteNumberMapper
    {
        protected override string GetPath()
        {
            return "RouterNumber.txt";
        }
    }
}
