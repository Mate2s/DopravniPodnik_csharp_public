using System;


namespace WinFormsDopravniPodnik.model
{
    [Serializable]
    public class RouteNumberStation
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

        public bool Direction
        {
            get { return direction; }
            set { direction = value; }
        }

        public string Desc
        {
            get { return desc; }
            set
            {
     
                desc = value;
            }
        }
        public double KmToNextStation
        {
            get { return kmToNextStation; }
            set
            {
             
                kmToNextStation = value;
            }
        }

        public static RouteNumberStation CastTo(RouteNumberService1.RouteNumberStation routeNumberStation)
        {
            RouteNumberStation n = new RouteNumberStation()
            {
                Order = routeNumberStation.Order,
                
                Station = model.Station.CastTo(routeNumberStation.Station),
                Desc = routeNumberStation.Desc,
                Direction = routeNumberStation.Direction,
                KmToNextStation = routeNumberStation.KmToNextStation
            };
            return n;
        }
    }
}
