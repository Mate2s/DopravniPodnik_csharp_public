using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ORM.XML
{
    public class CouponXmlMapper<T> : XmlMapper<T>, ICouponMapper
    {
        protected override string GetPath()
        {
            return "Coupon.txt";
        }
    }
}
