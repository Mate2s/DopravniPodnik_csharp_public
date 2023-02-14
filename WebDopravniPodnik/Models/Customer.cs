using System;
using System.Collections.Generic;

namespace WebDopravniPodnik.Models
{
    [Serializable]
    public class Customer
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
               
                _firstname = value;
            }
        }

        public string Lastname
        {
            get { return _lastname; }
            set
            {
               
                _lastname = value;
            }
        }

        public DateTime BirthDate
        {
            get { return _birthDate; }
            set
            {
               
                _birthDate = value;
            }
        }

        public string City
        {
            get { return _city; }
            set
            {
               
                _city = value;
            }
        }

        public string Adress
        {
            get { return _adress; }
            set
            {
               
                _adress = value;
            }
        }

        public string Email
        {
            get { return _email; }
            set
            {
              
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
              
                _coupons = value;
            }
        }
        
        public static Customer DoLogin(string login, string password)
        {/*
            ICustomerMapper mapper = Mapper.Mapper.Instance.GetMapper(new Customer()) as ICustomerMapper;
            Customer customer = mapper?.LoadByLogin(login);
            if (customer != null)
            {
                if (customer.CheckPassword(password))
                    return customer;
            }*/
            return null;
        }

        private bool CheckPassword(string password)
        {
            if (password == this.Password)
                return true;
            return false;
        }

        public static List<Customer> GetAll()
        {
            WebDopravniPodnik.CustomerService1.CusomerServiceClient sc = new WebDopravniPodnik.CustomerService1.CusomerServiceClient();
            List<Customer> list = new List<Customer>();
            foreach (var v in sc.GetAll())
            {
                list.Add(Customer.CastTo(v));
            }
            return list;
        }

        public static Customer CastTo(CustomerService1.Customer customer)
        {
            Customer n = new Customer()
            {
                Id = customer._id,
                Adress = customer._adress,
                BirthDate = customer._birthDate,
                City = customer._city,
                Email = customer._email,
                Firstname = customer._firstname,
                Lastname = customer._lastname,
                Login = customer._login,
                Password = customer._password
            };
            return n;
        }
    }
}
