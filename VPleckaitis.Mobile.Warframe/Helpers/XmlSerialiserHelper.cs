using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace VPleckaitis.Mobile.Warframe.Helpers
{
    public class XmlSerialiserHelper
    {
        public static T ConvertNode<T>(XmlNode node) where T : class
        {
            XmlSerializer ser = new XmlSerializer(typeof(T));
            T result = (ser.Deserialize(new XmlNodeReader(node)) as T);
            return result;
        }
    }
}
