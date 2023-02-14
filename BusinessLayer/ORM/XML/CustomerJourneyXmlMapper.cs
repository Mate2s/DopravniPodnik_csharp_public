using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ORM.XML
{
    public class CustomerJourneyXmlMapper<T> : XmlMapper<T>, ICustomerJourneyMapper
    {
        protected override string GetPath()
        {
            return "CustomerJourney.txt";
        }
    }
}
