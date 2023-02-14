using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLayer.BusinessLayerClass
{
    [Serializable]
    public class Vehicle:DomainObject
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
                // MarkDirty();
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
                // MarkDirty();
                _name = value;
            }
        }

        public string Spz
        {
            get { return _spz; }
            set
            {
                //MarkDirty();
                _spz = value;
            }
        }

        public int Year
        {
            get { return _year; }
            set
            {
                // MarkDirty();
                _year = value;
            }
        }

        public int Capacity
        {
            get { return _capacity; }
            set
            {
                // MarkDirty();
                _capacity = value;
            }
        }

        public List<Route> Routes
        {
            get { return _routes; }
            set
            {
                // MarkDirty();
                _routes = value;
            }
        }

        public override object GetId()
        {
            return Id;
        }
        public override void SetId(object id)
        {
            _id = (int)id;
        }
        public static Vehicle Load(object id)
        {
            return (Vehicle)Mapper.Mapper.Instance.GetMapper(new Vehicle()).Load(id);
        }
        public static List<Vehicle> GetAll()
        {
            return Mapper.Mapper.Instance.GetMapper(new Vehicle()).LoadAll().Cast<Vehicle>().ToList();
        }

        
    }
}
