using System;
using System.Collections.Generic;

namespace BusinessLayer.BusinessLayerClass
{
    [Serializable]
    public class Route:DomainObject
    {
        private int _id;
        DateTime _startRoute;
        DateTime _endRoute;
        Driver driver;
        Vehicle _vehicle;
        RouteNumber _routeNumber;
        Station currentStation;
        List<CustomerJourney> _customerJourneys;

        public Route()
        {
        }

       /* public Route(Route r)
        {
            this._id = r.Id;
            this._startRoute = r.StartRoute;
            this._endRoute = r.EndRoute;
            this._vehicle = new Vehicle(r.Vehicle);
            this.driver = new Employee(r.Employee);
            this._routeNumber = new RouteNumber(r.RouteNumber);
        }*/
        public Route(int id, DateTime startRoute, DateTime endRoute, Vehicle vehicle, Driver driverr, RouteNumber routeNumber)
        {
            this._id = id;
            this._startRoute = startRoute;
            this._endRoute = endRoute;
            this._vehicle = vehicle;
            this.driver = driverr;
            this._routeNumber = routeNumber;
        }

        public Station CurrentStation
        {
            get { return currentStation; }
            set { currentStation = value; }
        }

        public RouteNumber RouteNumber
        {
            get
            {
                if (_routeNumber == null)
                {
                    //_routeNumber = datamapper.GetCoupon(_customer.Id, _routeB.Id)
                }
                return _routeNumber;
            }
            set
            {
                //MarkDirty();
                _routeNumber = value;
            }
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public DateTime StartRoute
        {
            get { return _startRoute; }
            set
            {
                //MarkDirty();
                _startRoute = value;
            }
        }

        public DateTime EndRoute
        {
            get { return _endRoute; }
            set
            {
                //MarkDirty();
                _endRoute = value;
            }
        }

        public Vehicle Vehicle
        {
            get
            {
                if (_vehicle == null)
                {
                    //_vehicle = datamapper.GetCoupon(_customer.Id, _routeB.Id)
                }
                return _vehicle;
            }
            set
            {
                // MarkDirty();
                _vehicle = value;
            }
        }

        public Driver Driver
        {
            get
            {
                if (driver == null)
                {
                    //driver = datamapper.GetCoupon(_customer.Id, _routeB.Id)
                }
                return driver;
            }
            set
            {
                //MarkDirty();
                driver = value;
            }
        }

        public List<CustomerJourney> CustomerJourneys
        {
            get
            {
                if (_customerJourneys == null)
                {
                    //_customerJourneys = datamapper.GetCoupon(_customer.Id, _routeB.Id)
                }
                return _customerJourneys;
            }
            set
            {
                MarkDirty();
                _customerJourneys = value;
            }
        }

        public void DoNew()
        {
            MarkNew();
            UnitOfWork.UnitOfWork.Instance.Commit();
        }

        public void DoUpdate()
        {
            MarkDirty();
            UnitOfWork.UnitOfWork.Instance.Commit();
        }
        public static Route Load(object id)
        {
            return (Route)Mapper.Mapper.Instance.GetMapper(new Route()).Load(id);
        }

        public override object GetId()
        {
            return Id;
        }

        public override void SetId(object id)
        {
            _id = (int)id;
        }
    }
}
