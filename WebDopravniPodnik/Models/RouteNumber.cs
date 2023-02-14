using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using WebDopravniPodnik.RouteNumberService1;



namespace WebDopravniPodnik.Models
{
    
    public class RouteNumber
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
          
                _number = value;
            }
        }

        public List<Route> Routes
        {
            get
            {
                if (_routes == null)
                {
                   
                }
                return _routes;
            }
            set
            {
        
                _routes = value;
            }
        }

        public List<RouteNumberStation> RouteNumberStationsDirectionOne
        {
            get
            {
                if (_routeNumberStationsDirectionOne == null)
                {
                    RouteNumberServiceClient sc = new RouteNumberServiceClient();
                    List<RouteNumberStation> list =new List<RouteNumberStation>();
                    try
                    {
                        foreach (var v in sc.GetRNSDirectionOne(Id))
                        {
                            RouteNumberStation a = RouteNumberStation.CastTo(v);
                            list.Add(a);
                        }
                    }
                    catch (Exception e)
                    {
                    }

                    _routeNumberStationsDirectionOne = list;
                }
                return _routeNumberStationsDirectionOne;
            }
            set
            {
                _routeNumberStationsDirectionOne = value;
            }
        }

        public List<RouteNumberStation> RouteNumberStationsDirectionTwo
        {
            get
            {
                if (_routeNumberStationsDirectionTwo == null)
                {
                    RouteNumberServiceClient sc = new RouteNumberServiceClient();
                    List<RouteNumberStation> list = new List<RouteNumberStation>();
                    try
                    {
                        foreach (var v in sc.GetRNSDirectionTwo(Id))
                        {
                            RouteNumberStation a = RouteNumberStation.CastTo(v);
                            list.Add(a);
                        }
                    }catch(Exception e) { }
                    _routeNumberStationsDirectionTwo = list;
                }
                return _routeNumberStationsDirectionTwo;
            }
            set
            {
                _routeNumberStationsDirectionTwo = value;
            }
        }
   

        public static RouteNumber Load(object id)
        {
            RouteNumberServiceClient sc = new RouteNumberServiceClient();
            return RouteNumber.CastTo(sc.Load((int) id));
        }
        public static List<RouteNumber> GetAll()
        {
            RouteNumberServiceClient sc = new RouteNumberServiceClient();
            List<RouteNumber> list = new List<RouteNumber>();
            foreach (var v in sc.GetAll())
            {
                list.Add(RouteNumber.CastTo(v));
            }
            return list;
        }

        public static RouteNumber CastTo(RouteNumberService1.RouteNumber routeNumber)
        {
            RouteNumber n = new RouteNumber()
            {
                Id = routeNumber._id,
                Description = routeNumber._description,
                Number = routeNumber._number,
            };
            return n;
        }
    }
}
