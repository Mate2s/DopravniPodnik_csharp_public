using System;
using System.Collections.Generic;
using System.Linq;
using WebDopravniPodnik.VehicleService1;
using WebDopravniPodnik.VehicleService1;

namespace WebDopravniPodnik.Models
{
    [Serializable]
    public class Vehicle
    {
        int _id;
        private string _name;
        private string _brand;
        string _spz;
        int _year;
        int _capacity;
        private List<Route> _routes;

        public Vehicle()
        {
        }
        public Vehicle(Vehicle v)
        {
            this._id = v.Id;
            this._name = v.Name;
            this._brand = v.Brand;
            this._spz = v.Spz;
            this._year = v.Year;
            this._capacity = v.Capacity;
        }
        public Vehicle(int id, string name, string brand, string spz, int year, int capacity)
        {
            this._id = id;
            this._name = name;
            this._brand = brand;
            this._spz = spz;
            this._year = year;
            this._capacity = capacity;
        }

        public string Brand
        {
            get { return _brand; }
            set
            {
            
                _brand = value;
            }
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

        public string Spz
        {
            get { return _spz; }
            set
            {
           
                _spz = value;
            }
        }

        public int Year
        {
            get { return _year; }
            set
            {
               
                _year = value;
            }
        }

        public int Capacity
        {
            get { return _capacity; }
            set
            {
              
                _capacity = value;
            }
        }

        public List<Route> Routes
        {
            get { return _routes; }
            set
            {
                
                _routes = value;
            }
        }
      
        public static Vehicle Load(object id)
        {
            //return (Vehicle)Mapper.Mapper.Instance.GetMapper(new Vehicle()).Load(id);
            return null;
        }
        public static List<Vehicle> GetAll()
        {
            VehicleServiceClient sc = new VehicleServiceClient();
            List<Vehicle> list = new List<Vehicle>();
            foreach (var v in sc.GetAll())
            {
                list.Add(Vehicle.CastTo(v));
            }
            return list;
        }

        public static Vehicle CastTo(VehicleService1.Vehicle vehicle)
        {
            Vehicle n = new Vehicle()
            {
                Id = vehicle._id,
                Brand = vehicle._brand,
                Capacity = vehicle._capacity,
                Name = vehicle._name,
                Spz = vehicle._spz,
                Year = vehicle._year
            };
            return n;
        }

    }
}
