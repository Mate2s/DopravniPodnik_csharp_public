using System;
using System.Collections.Generic;
using BusinessLayer.ORM;

namespace BusinessLayer.BusinessLayerClass
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

        private bool CheckPassword(string password)
        {
            if (password == this.Password)
                return true;
            return false;
        }

        public static Driver Load(object id)
        {
            return (Driver)Mapper.Mapper.Instance.GetMapper(new Driver()).Load(id);
        }

        public static Driver DoLogin(string login,string password)
        {
            IDriverMapper mapper = Mapper.Mapper.Instance.GetMapper(new Driver()) as IDriverMapper;
            Driver driver = mapper?.LoadByLogin(login);
            if (driver != null)
            {
                if (driver.CheckPassword(password))
                    return driver;
            }
            return null;
        }
    }
}
