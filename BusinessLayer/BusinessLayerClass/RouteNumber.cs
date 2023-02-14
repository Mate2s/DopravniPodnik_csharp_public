using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using BusinessLayer.ORM;

namespace BusinessLayer.BusinessLayerClass
{
    
    [Serializable]
    
    public class RouteNumber:DomainObject
    {
        int _id;
        int _number;
        private string _description;
        private List<Route> _routes;
        List<RouteNumberStation> _routeNumberStationsDirectionOne;
        List<RouteNumberStation> _routeNumberStationsDirectionTwo;

        public RouteNumber() { }
        public RouteNumber(RouteNumber r)
        {
            this._id = r.Id;
            this._number = r.Number;
            this._description = r.Description;
        }
        public RouteNumber(int id, int number)
        {
            this._id = id;
            this._number = number;
        }

        public string Description
        {
            get { return _description; }
            set
            {
                //MarkDirty();
                _description = value;
            }
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public int Number
        {
            get { return _number; }
            set
            {
                // MarkDirty();
                _number = value;
            }
        }

        public List<Route> Routes
        {
            get
            {
                if (_routes == null)
                {
                    //_routes = datamapper.GetRoutes(_customer.Id, _routeB.Id)
                }
                return _routes;
            }
            set
            {
                // MarkDirty();
                _routes = value;
            }
        }

        public List<RouteNumberStation> RouteNumberStationsDirectionOne
        {
            get
            {
                if (_routeNumberStationsDirectionOne == null)
                {
                    IRouteNumberStationMapper mapper = Mapper.Mapper.Instance.GetMapper(new RouteNumberStation()) as IRouteNumberStationMapper;
                    _routeNumberStationsDirectionOne = mapper?.LoadStationsByDirection(_id,false);
                }
                return _routeNumberStationsDirectionOne;
            }
            set
            {
                // MarkDirty();
                _routeNumberStationsDirectionOne = value;
            }
        }

        public List<RouteNumberStation> RouteNumberStationsDirectionTwo
        {
            get
            {
                if (_routeNumberStationsDirectionTwo == null)
                {
                    IRouteNumberStationMapper mapper = Mapper.Mapper.Instance.GetMapper(new RouteNumberStation()) as IRouteNumberStationMapper;
                    _routeNumberStationsDirectionTwo = mapper?.LoadStationsByDirection(_id, true);
                }
                return _routeNumberStationsDirectionTwo;
            }
            set
            {
                //MarkDirty();
                _routeNumberStationsDirectionTwo = value;
            }
        }

        public override object GetId()
        {
            return Id;
        }

        public static RouteNumber Load(object id)
        {
            return (RouteNumber)Mapper.Mapper.Instance.GetMapper(new RouteNumber()).Load(id);
        }
        public static List<RouteNumber> GetAll()
        {
            return Mapper.Mapper.Instance.GetMapper(new RouteNumber()).LoadAll().Cast<RouteNumber>().ToList();
        }

        public override void SetId(object id)
        {
            _id = (int)id;
        }
    }
}
