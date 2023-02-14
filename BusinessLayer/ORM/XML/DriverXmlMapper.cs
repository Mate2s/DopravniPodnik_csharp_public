using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.BusinessLayerClass;

namespace BusinessLayer.ORM.XML
{
    public class DriverXmlMapper<T> : XmlMapper<T>, IDriverMapper
    {
        protected override string GetPath()
        {
            return "Driver.txt";
        }

        public Driver LoadByLogin(string login)
        {
            throw new NotImplementedException();
        }
    }
}
