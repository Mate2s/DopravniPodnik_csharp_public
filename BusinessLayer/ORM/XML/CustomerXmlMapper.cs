using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.BusinessLayerClass;

namespace BusinessLayer.ORM.XML
{
    public class CustomerXmlMapper<T> : XmlMapper<T>, ICustomerMapper
    {
        public Customer LoadByLogin(string login)
        {
            List<Customer> list = LoadAll().Cast<Customer>().ToList();
            return list.Where(x => x.Login == login).FirstOrDefault();
        }

        protected override string GetPath()
        {
            return "Customer.txt";
        }
    }
}
