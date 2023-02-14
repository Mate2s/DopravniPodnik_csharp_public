using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using BusinessLayer.BusinessLayerClass;

namespace BusinessLayer.ORM.XML
{
    public class XmlGenerator
    {
        public static String ObjectToXML<T>(T filter)
        {

            string xml = null;
            using (StringWriter sw = new StringWriter())
            {

                XmlSerializer xs = new XmlSerializer(typeof(T));
                xs.Serialize(sw, filter);
                try
                {
                    xml = sw.ToString();

                }
                catch (Exception e)
                {
                    throw e;
                }
            }
            return xml;
        }
        public static T XMLToObject<T>(string xml)
        {

            var serializer = new XmlSerializer(typeof(T));

            using (var textReader = new StringReader(xml))
            {
                using (var xmlReader = XmlReader.Create(textReader))
                {
                    try
                    {
                        return (T) serializer.Deserialize(xmlReader);
                    }
                    catch (Exception e)
                    {
                        return default(T);
                    }
                }
            }
        }
    }
}
