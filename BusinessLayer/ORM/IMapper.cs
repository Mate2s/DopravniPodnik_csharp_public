using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.BusinessLayerClass;

namespace BusinessLayer.ORM
{
    public interface IMapper
    {
        List<DomainObject> LoadAll();
        DomainObject Load(Object id);
        void Insert(DomainObject item);
        void Update(DomainObject item);
        void Delete(DomainObject item);
    }
}
