using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.BusinessLayerClass;

namespace BusinessLayer.ORM.XML
{
    public class RouteNumberStationXmlMapper<T> : XmlMapper<T>, IRouteNumberStationMapper
    {
        protected override string GetPath()
        {
            return "RouteNumberStation.txt";
        }

        public List<RouteNumberStation> LoadStationsByDirection(object id, bool direction)
        {
            throw new NotImplementedException();
        }
    }
}
