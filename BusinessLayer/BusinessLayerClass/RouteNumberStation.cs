using System;
using System.Runtime.Serialization;
using BusinessLayer.pk;

namespace BusinessLayer.BusinessLayerClass
{
    [DataContract]
    public class RouteNumberStation:DomainObject
    {
        private bool direction;
       
        RouteNumber _routeNumber;
        Station _station;
        int _order;
        private string desc;
        private double kmToNextStation;

        public RouteNumberStation()
        {
        }

        public RouteNumberStation(RouteNumberStation r)
        {
            _routeNumber = new RouteNumber(r.RouteNumber);
            this._station = new Station(r.Station);
            this._order = r.Order;
        }
        public RouteNumberStation(RouteNumber routeNumber, Station station, int order)
        {
            _routeNumber = routeNumber;
            this._station = station;
            this._order = order;
        }
       
        public RouteNumber RouteNumber
        {
            get { return _routeNumber; }
            set { _routeNumber = value; }
        }

        [DataMember]
        public Station Station
        {
            get { return _station; }
            set { _station = value; }
        }

        [DataMember]
        public int Order
        {
            get { return _order; }
            set { _order = value; }
        }

        [DataMember]
        public bool Direction
        {
            get { return direction; }
            set { direction = value; }
        }

        [DataMember]
        public string Desc
        {
            get { return desc; }
            set
            {
                //MarkDirty();
                desc = value;
            }
        }

        [DataMember]
        public double KmToNextStation
        {
            get { return kmToNextStation; }
            set
            {
                // MarkDirty();
                kmToNextStation = value;
            }
        }

        public override object GetId()
        {
            return new RouteNumberStationPK(direction,_routeNumber,_station,_order);
        }

        public override void SetId(object id)
        {
            throw new NotImplementedException();
        }
    }
}
