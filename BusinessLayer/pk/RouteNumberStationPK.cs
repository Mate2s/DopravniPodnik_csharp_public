using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.BusinessLayerClass;

namespace BusinessLayer.pk
{
    public class RouteNumberStationPK
    {
        private bool direction;
        RouteNumber _routeNumber;
        Station _station;
        int _order;

        public RouteNumberStationPK(bool direction, RouteNumber routeNumber, Station station, int order)
        {
            this.direction = direction;
            _routeNumber = routeNumber;
            _station = station;
            _order = order;
        }

        public bool Direction
        {
            get { return direction; }
            set { direction = value; }
        }

        public RouteNumber RouteNumber
        {
            get { return _routeNumber; }
            set { _routeNumber = value; }
        }

        public Station Station
        {
            get { return _station; }
            set { _station = value; }
        }

        public int Order
        {
            get { return _order; }
            set { _order = value; }
        }

        public override bool Equals(object obj)
        {
            var a = obj as RouteNumberStationPK;
            if (a == null)
                return false;
            if (a.Direction == this.Direction && a.Station.Id == this.Station.Id && a.Order == this.Order &&
                a.RouteNumber.Id == this.RouteNumber.Id)
                return true;
            return false;
        }
    }
}
