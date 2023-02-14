using BusinessLayer.ORM;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLayer.BusinessLayerClass
{
    [Serializable]
    public class Customer:DomainObject
    {
        private int _id;
        private string _login;
        private string _password;
        string _firstname;
        string _lastname;
        DateTime _birthDate;
        string _city;
        private string _adress;
        string _email;
        private List<CustomerJourney> _customerJourneys;
        private List<Coupon> _coupons;

        public Customer()
        {
        }

 

        public Customer(int id, string login, string password, string firstname, string lastname, DateTime birthDate, string city, string adress, string email)
        {
            this._id = id;
            this._login = login;
            this._password = password;
            this._firstname = firstname;
            this._lastname = lastname;
            this._birthDate = birthDate;
            this._city = city;
            this._adress = adress;
            this._email = email;
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
                //MarkDirty();
                _login = value;
            }
        }
        
        public string Password
        {
            get { return _password; }
            set { _password = value; }
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

        public DateTime BirthDate
        {
            get { return _birthDate; }
            set
            {
               // MarkDirty();
                _birthDate = value;
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
               // MarkDirty();
                _email = value;
            }
        }

        public List<CustomerJourney> CustomerJourneys
        {
            get
            {
                if (_customerJourneys == null)
                {
                    //_customerJourneys = datamapper.GetCustomerJourneys(_customer.Id, _routeB.Id)
                }
                return _customerJourneys;
            }
            set
            {
                //MarkDirty();
                _customerJourneys = value;
            }
        }

        public List<Coupon> Coupons
        {
            get
            {
                if (_coupons == null)
                {
                    //_coupons = datamapper.GetCoupons(_customer.Id, _routeB.Id)
                }
                return _coupons;
            }
            set
            {
                //MarkDirty();
                _coupons = value;
            }
        }

        public override object GetId()
        {
            return Id;
        }

        public static Customer DoLogin(string login, string password)
        {
            ICustomerMapper mapper = Mapper.Mapper.Instance.GetMapper(new Customer()) as ICustomerMapper;
            Customer customer = mapper?.LoadByLogin(login);
            if (customer != null)
            {
                if (customer.CheckPassword(password))
                    return customer;
            }
            return null;
        }

        private bool CheckPassword(string password)
        {
            if (password == this.Password)
                return true;
            return false;
        }

        public override void SetId(object id)
        {
            _id = (int)id;
        }

        public static List<Customer> GetAll()
        {
            return Mapper.Mapper.Instance.GetMapper(new Customer()).LoadAll().Cast<Customer>().ToList();
        }

        public static Customer Load(int customerId)
        {
            return (Customer)Mapper.Mapper.Instance.GetMapper(new Customer()).Load(customerId);
        }

        public void DoNew()
        {
            MarkNew();
            UnitOfWork.UnitOfWork.Instance.Commit();
        }

    }
}
