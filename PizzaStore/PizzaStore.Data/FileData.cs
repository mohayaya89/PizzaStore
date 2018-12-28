using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace PizzaStore.Data
{
    public class FileData  //intergration tests (not there yet)
    {
        public FileData()
        {
        }

        public T ReadFromFile<T>(string path) where T : class
        {
            T result = default(T);
            if (File.Exists(path))
            {
                using (var reader = new StreamReader(path))
                {
                    var xml = new XmlSerializer(typeof(T));

                    result = (T)xml.Deserialize(reader); //typeof, equal()
                    result = xml.Deserialize(reader) as T; //new(), same()
                }
            }
            return result;
        }

        public void SaveToFile<T>(string path, T data)
        {
            try
            {
                if (!File.Exists(path))
                {
                    File.Create(path);
                }
                using (var writer = new StreamWriter(path))
                {
                    var xml = new XmlSerializer(typeof(T));

                    xml.Serialize(writer, data);
                }

            }
            catch
            {
                return;
            }
        }
    }
}