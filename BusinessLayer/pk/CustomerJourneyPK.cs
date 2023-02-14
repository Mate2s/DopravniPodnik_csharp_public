using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.BusinessLayerClass;

namespace BusinessLayer.pk
{
    public class CustomerJourneyPK
    {
        Route _route;
        Customer _customer;

        public CustomerJourneyPK(Route route, Customer customer)
        {
            _route = route;
            _customer = customer;
        }

        public Route Route
        {
            get { return _route; }
            set { _route = value; }
        }

        public Customer Customer
        {
            get { return _customer; }
            set { _customer = value; }
        }

        public override bool Equals(object obj)
        {
            var a = obj as CustomerJourneyPK;
            if (a==null)
            {
                return false;
            }
            if (a.Route.Id == this.Route.Id && a.Customer.Id == this.Customer.Id)
                return true;

            return false;
        }
    }
}
