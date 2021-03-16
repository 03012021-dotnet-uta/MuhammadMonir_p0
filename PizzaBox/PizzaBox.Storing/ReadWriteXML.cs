using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Singletons;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;


namespace PizzaBox.Storing
{
    public class ReadWriteXML
    {
        private static string _path = "Stores.xml";
        
        public static void WriteStoreXML()
        {
            StreamWriter writer = new StreamWriter(_path);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<AStore>));
            StoreSingleton ss = new StoreSingleton();
            List<AStore> stores = ss.stores;
            xmlSerializer.Serialize(writer, stores);

        }

        public static List<AStore> ReadStoreXML()
        {
            StreamReader reader = new StreamReader(_path);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<AStore>));
            List<AStore> stores = (List<AStore>)xmlSerializer.Deserialize(reader);
            return stores;
        }

    }
}
