using System;
using System.Collections.Generic;

namespace BusinessLayer.BusinessLayerClass
{
    [Serializable]
    public class Employee :DomainObject 
    {
        int _id;
        private string _login;
        private string _password;
        string _firstname;
        string _lastname;
        private DateTime _birthdate;
        string _city;
        string _adress;
        private string _email;
        //string _employment;

        List<Route> _routes;
        public Employee() { }
       
        public Employee(int id, string firstname, string lastname, string city, string adress, string email)
        {
            this._id = id;
            this._firstname = firstname;
            this._lastname = lastname;
            this._city = city;
            this._adress = adress;
            //this._employment = employment;
            this._email = email;
        }

        public Employee(int id, string firstname, string lastname, string city, string adress, List<Route> routes)
        {
            this._id = id;
            this._firstname = firstname;
            this._lastname = lastname;
            this._city = city;
            this._adress = adress;
           // this._employment = employment;
            this._routes = routes;
        }

        public DateTime Birthdate
        {
            get { return _birthdate; }
            set
            {
                //MarkDirty();
                _birthdate = value;
            }
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Login
        {
            get { return _login; }
            set
            {
                // MarkDirty();
                _login = value;
            }
        }

        public string Firstname
        {
            get { return _firstname; }
            set
            {
                // MarkDirty();
                _firstname = value;
            }
        }

        public string Lastname
        {
            get { return _lastname; }
            set
            {
                //MarkDirty();
                _lastname = value;
            }
        }

        public string City
        {
            get { return _city; }
            set
            {
                //MarkDirty();
                _city = value;
            }
        }

        public string Adress
        {
            get { return _adress; }
            set
            {
                //MarkDirty();
                _adress = value;
            }
        }

        public string Email
        {
            get { return _email; }
            set
            {
                //MarkDirty();
                _email = value;
            }
        }

        public string Password
        {
            get { return _password; }
            set
            {
                //MarkDirty();
                _password = value;
            }
        }

        /*  public string Employment
        {
            get { return _employment; }
            set { _employment = value; }
        }
       */
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
                //MarkDirty();
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
    }
}
