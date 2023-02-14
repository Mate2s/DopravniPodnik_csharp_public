using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.BusinessLayerClass;
using BusinessLayer.map;

namespace BusinessLayer.ORM.XML
{
    public abstract class XmlMapper<T> : IMapper
    {
        protected string path = BusinessLayer.Properties.Resources.xmlPath.ToString();
        
        public List<DomainObject> LoadAll()
        {
            using (StreamReader streamReader = new StreamReader(path + GetPath(), Encoding.UTF8))
            {
                List<DomainObject> list =
                    XmlGenerator.XMLToObject<List<T>>(streamReader.ReadToEnd()).Cast<DomainObject>().ToList();
                foreach (var domainobj in list)
                {
                    if (IdentifyMap.Instance.Find(typeof(T), domainobj.GetId()) == null)
                    {
                        IdentifyMap.Instance.Add(typeof(T), domainobj);
                    }
                }
                return list;
            }
        }

        public DomainObject Load(object id)
        {
            using (StreamReader streamReader = new StreamReader(path + GetPath(), Encoding.UTF8))
            {
                List<DomainObject> list =
                    XmlGenerator.XMLToObject<List<T>>(streamReader.ReadToEnd()).Cast<DomainObject>().ToList();
                foreach (var domainobj in list)
                {
                    if (domainobj.GetId().Equals(id))
                    {
                        if (IdentifyMap.Instance.Find(typeof(T), domainobj.GetId()) == null)
                        {
                            IdentifyMap.Instance.Add(typeof(T), domainobj);
                        }
                        return domainobj;
                    }
                }
            }
            return null;
        }

        public void Insert(DomainObject item)
        {
            List<T> list;
            using (StreamReader streamReader = new StreamReader(path + GetPath(), Encoding.UTF8))
            {
                
                try
                {
                    list = XmlGenerator.XMLToObject<List<T>>(streamReader.ReadToEnd()).Cast<T>().ToList();
                }
                catch (Exception e)
                {
                    list = new List<T>();
                }
                 
                list.Add((T)Convert.ChangeType(item,typeof(T)));
                
            }
            File.WriteAllText(path + GetPath(), XmlGenerator.ObjectToXML(list));
        }

        public void Update(DomainObject item)
        {
            using (StreamReader streamReader = new StreamReader(path + GetPath(), Encoding.UTF8))
            {
                List<DomainObject> list =
                    XmlGenerator.XMLToObject<List<T>>(streamReader.ReadToEnd()).Cast<DomainObject>().ToList();
                DomainObject delete = null;
                foreach (var obj in list)
                {
                    if (item.GetId().Equals(obj.GetId()))
                    {
                        delete = obj;
                    }
                }
                if (delete != null)
                {
                    list.Remove(delete);
                    list.Add(item);
                }
                File.WriteAllText(path + GetPath(), XmlGenerator.ObjectToXML(list));
            }
        }

        public void Delete(DomainObject item)
        {
            using (StreamReader streamReader = new StreamReader(path + GetPath(), Encoding.UTF8))
            {
                List<DomainObject> list =
                    XmlGenerator.XMLToObject<List<T>>(streamReader.ReadToEnd()).Cast<DomainObject>().ToList();
                DomainObject delete = null;
                foreach (var obj in list)
                {
                    if (item.GetId().Equals(obj.GetId()))
                    {
                        delete = obj;
                    }
                }
                if (delete != null)
                {
                    list.Remove(delete);
                }
                File.WriteAllText(path + GetPath(), XmlGenerator.ObjectToXML(list));
            }
        }

        protected abstract string GetPath();
       
    }
}
