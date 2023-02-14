using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.BusinessLayerClass;

namespace BusinessLayer.map
{
     public class IdentifyMap
    {
        private static IdentifyMap instance;

        private List<Map> map = new List<Map>();

        public IdentifyMap()
        {
        }

        public static IdentifyMap Instance
        {
            get { return instance ?? (instance = new IdentifyMap()); }
        }

        public void Add(Type t, DomainObject domainObject)
        {
            foreach (var map1 in map)
            {
                if (map1.Type == t)
                {
                    map1.List.Add(domainObject);
                    return;
                }
            }
            Map m = new Map() {Type = t, List = new HashSet<DomainObject>()};
            m.List.Add(domainObject);
            Map.Add(m);
        }

        public DomainObject Find(Type t, object id)
        {
            foreach (var map1 in map)
            {
                if (map1.Type == t)
                    
                {
                    foreach (var domainObject in map1.List)
                    {
                        if (domainObject.GetId().Equals(id))
                        {
                            return domainObject;
                        }
                    }
                }
            }
            return null;
        }

        public void Remove(object obj)
        {
            Type t = TypeFromDomainObject(obj);
            foreach (var map1 in map)
            {
                if (map1.Type == t)
                {
                    map1.List.Remove(obj as DomainObject);
                }
            }
        }
        public List<Map> Map
        {
            get { return map; }
            set { map = value; }
        }

        public Type TypeFromDomainObject(object obj)
        {
            var domainObject = (DomainObject) obj;

            if (domainObject is Administrator)
                return new Administrator().GetType();
            if (domainObject is Driver)
                return new Driver().GetType();
            if (domainObject is Coupon)
                return new Coupon().GetType();
            if (domainObject is Customer)
                return new Customer().GetType();
            if (domainObject is CustomerJourney)
                return new CustomerJourney().GetType();
            if (domainObject is Payment)
                return new Payment().GetType();
            if (domainObject is Route)
                return new Route().GetType();
            if (domainObject is RouteNumber)
                return new RouteNumber().GetType();
            if (domainObject is RouteNumberStation)
                return new RouteNumberStation().GetType();
            if (domainObject is Station)
                return new Station().GetType();
            if (domainObject is Vehicle)
                return new Vehicle().GetType();
            return null;
        }
    }
}
