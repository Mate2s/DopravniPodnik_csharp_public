using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ORM.XML
{
    public class PaymentXmlMapper<T> : XmlMapper<T>, IPaymentMapper
    {
        protected override string GetPath()
        {
            return "Payment.txt";
        }
    }
}
