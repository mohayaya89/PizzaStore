using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace PizzaStore.Library.Models
{
    public class DataHelper
    {
        private static string path = @"./data/store.xml";
        public DataHelper()
        {

        }

        public T Read<T>()
        {
            try
            {
                var xml = new XmlSerializer(typeof(T));
                var reader = new StreamReader(path);

                return (T)xml.Deserialize(reader);
            }
            catch 
            {
                return default(T);
            }
        }

        public bool Save<T>(T data)
        {
            try
            {
                var xml = new XmlSerializer(typeof(T));
                var writer = new StreamWriter(path);

                xml.Serialize(writer, data);
                return true;
            }
            catch
            {
                return false;
            }   
        }
    }
}
