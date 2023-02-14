using System;
using System.Collections.Generic;


namespace WinFormsDopravniPodnik.model
{
    [Serializable]
    public class Driver: Employee
    {
        public Driver()
        {
        }

        public Driver(int id, string firstname, string lastname, string city, string adress, string email) : base(id, firstname, lastname, city, adress, email)
        {
        }

        public Driver(int id, string firstname, string lastname, string city, string adress, List<Route> routes) : base(id, firstname, lastname, city, adress, routes)
        {
        }

        public static Driver castFrom(WinFormsDopravniPodnik.DriverService1.Driver dr)
        {
            if(dr!=null)
            {
                return new Driver()
                {
                    Adress = dr._adress,
                    Birthdate = dr._birthdate,
                    City = dr._city,
                    Email = dr._email,
                    Firstname = dr._firstname,
                    Id = dr._id,
                    Lastname = dr._lastname,
                    Login = dr._login,
                    Password = dr._password
                };
            }
            return null;
            
        }

        private bool CheckPassword(string password)
        {
            if (password == this.Password)
                return true;
            return false;
        }

        public static Driver Load(object id)
        {
            //return (Driver)Mapper.Mapper.Instance.GetMapper(new Driver()).Load(id);
            return null;
        }

        public static Driver DoLogin(string login,string password)
        {
            WinFormsDopravniPodnik.DriverService1.DriverServiceClient dwc = new WinFormsDopravniPodnik.DriverService1.DriverServiceClient();
            Driver driver = Driver.castFrom(dwc.Login(login, password));
            return driver;
        }
    }
}
