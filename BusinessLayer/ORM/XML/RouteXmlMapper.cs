using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ORM.XML
{
   public class RouteXmlMapper<T> : XmlMapper<T>, IRouteMapper
    {
        protected override string GetPath()
        {
            return "Route.txt";
        }
    }
}
