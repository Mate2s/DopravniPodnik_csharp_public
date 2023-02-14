using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.BusinessLayerClass;

namespace BusinessLayer.ORM.XML
{
    public class AdministratorXmlMapper<T>  :XmlMapper<T>,IAdministratorMapper
    {
        protected override string GetPath()
        {
            return "Administrator.txt";
        }
    }
}
