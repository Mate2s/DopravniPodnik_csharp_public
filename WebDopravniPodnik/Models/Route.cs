using System;
using System.Collections.Generic;

namespace WebDopravniPodnik.Models
{
    [Serializable]
    public class Route
    {
        private int _id;
        DateTime _startRoute;
        DateTime _endRoute;
        Driver driver;
        Vehicle _vehicle;
        RouteNumber _routeNumber;
        RouteNumberStation currentStation;
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

        public RouteNumberStation CurrentStation
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
    
                _startRoute = value;
            }
        }

        public DateTime EndRoute
        {
            get { return _endRoute; }
            set
            {
     
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
                _customerJourneys = value;
            }
        }
        

        public static Route Load(object id)
        {
            //return (Route)Mapper.Mapper.Instance.GetMapper(new Route()).Load(id);
            return null;
        }


        public static Route CastTo(RouteService1.Route createRoute)
        {
            Route n = new Route()
            {
                Id = createRoute._id,
                Vehicle = new Vehicle()
                {
                    Id = createRoute._vehicle._id,
                    Name = createRoute._vehicle._name,
                    Capacity = createRoute._vehicle._capacity,
                    Year = createRoute._vehicle._year,
                    Brand = createRoute._vehicle._brand,
                    Spz = createRoute._vehicle._spz
                },
                RouteNumber = new RouteNumber()
                {
                     Id = createRoute._routeNumber._id,
                     Description = createRoute._routeNumber._description,
                     Number = createRoute._routeNumber._number
                },
                Driver = new Driver()
                {
                    Id = createRoute.driver._id,
                    Birthdate = createRoute.driver._birthdate,
                    Firstname = createRoute.driver._firstname,
                    Email = createRoute.driver._email,
                    Lastname = createRoute.driver._lastname,
                    Password = createRoute.driver._password,
                    City = createRoute.driver._city,
                    Adress = createRoute.driver._adress,
                    Login = createRoute.driver._login
                },
                StartRoute = createRoute._startRoute,
                EndRoute = createRoute._endRoute
            };
            return n;
        }
    }
}
