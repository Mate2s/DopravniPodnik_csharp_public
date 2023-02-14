using System;
using System.Collections.Generic;

namespace BusinessLayer.BusinessLayerClass
{
    [Serializable]
    public class Station:DomainObject
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
                // MarkDirty();
                _name = value;
            }
        }

        public float Gpslat
        {
            get { return _gpslat; }
            set
            {
                //MarkDirty();
                _gpslat = value;
            }
        }

        public float Gpslng
        {
            get { return _gpslng; }
            set
            {
                //MarkDirty();
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
                //MarkDirty();
                _routeNumberStations = value;
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

        public static Station Load(int id)
        {
            return (Station)Mapper.Mapper.Instance.GetMapper(new Station()).Load(id);
        }

        public void DoNew()
        {
            MarkNew();
            UnitOfWork.UnitOfWork.Instance.Commit();
        }
    }
}
