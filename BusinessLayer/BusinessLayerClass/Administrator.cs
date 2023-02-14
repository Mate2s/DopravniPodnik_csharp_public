using System;
using System.Collections.Generic;

namespace BusinessLayer.BusinessLayerClass
{
    [Serializable]
    public class Administrator: Driver
    {
        public Administrator()
        {
        }

        public Administrator(int id, string firstname, string lastname, string city, string adress, string email) : base(id, firstname, lastname, city, adress, email)
        {
        }

        public Administrator(int id, string firstname, string lastname, string city, string adress, List<Route> routes) : base(id, firstname, lastname, city, adress, routes)
        {
        }
    }
}
