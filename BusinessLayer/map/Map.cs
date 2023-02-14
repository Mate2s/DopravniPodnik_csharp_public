using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.BusinessLayerClass;

namespace BusinessLayer.map
{
    public class Map
    {
        private Type type;
        private HashSet<DomainObject> list;

        public Type Type
        {
            get { return type; }
            set { type = value; }
        }

        public HashSet<DomainObject> List
        {
            get { return list; }
            set { list = value; }
        }
    }
}
