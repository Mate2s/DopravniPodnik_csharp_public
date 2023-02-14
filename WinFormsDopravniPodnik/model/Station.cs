using System;
using System.Collections.Generic;

namespace WinFormsDopravniPodnik.model
{
    [Serializable]
    public class Station
    {

        private int _id;
        string _name;
        float _gpslat;
        float _gpslng;
        List<RouteNumberStation> _routeNumberStations;

        public Station()
        { }
        public Station(Station s)
        {
            this._id = s.Id;
            this._name = s.Name;
            this._gpslat = s.Gpslat;
            this._gpslng = s.Gpslng;

        }
        public Station(int id, string name, float gpslat, float gpslng)
        {
            this._id = id;
            this._name = name;
            this._gpslat = gpslat;
            this._gpslng = gpslng;

        }


        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set
            { 
                _name = value;
            }
        }

        public float Gpslat
        {
            get { return _gpslat; }
            set
            {
              
                _gpslat = value;
            }
        }

        public float Gpslng
        {
            get { return _gpslng; }
            set
            {
              
                _gpslng = value;
            }
        }

        public List<RouteNumberStation> RouteNumberStations
        {
            get
            {
                if (_routeNumberStations == null)
                {
                    //_routeNumberStations = datamapper.GetCoupon(_customer.Id, _routeB.Id)
                }
                return _routeNumberStations;
            }
            set
            {
              
                _routeNumberStations = value;
            }
        }

        public static Station CastTo(RouteNumberService1.Station station)
        {
            Station n = new Station()
            {
                Id = station._id,
                Gpslat = station._gpslat,
                Gpslng = station._gpslng,
                Name = station._name
            };
            return n;

        }
    }
}
