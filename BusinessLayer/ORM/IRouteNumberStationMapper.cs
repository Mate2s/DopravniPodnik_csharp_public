using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.BusinessLayerClass;

namespace BusinessLayer.ORM
{
    public interface IRouteNumberStationMapper : IMapper
    {
        List<RouteNumberStation> LoadStationsByDirection(object id, bool direction);
    }
}
