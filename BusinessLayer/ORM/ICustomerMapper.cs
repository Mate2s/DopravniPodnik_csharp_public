using BusinessLayer.BusinessLayerClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ORM
{
    public interface ICustomerMapper : IMapper
    {
        Customer LoadByLogin(string login);
    }
}
