using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MedicalCardApp.Classes
{
    public static class DataManager
    {
        public static MedicalDataContainer LoadFromXml(string filePath)
        {
            if (!File.Exists(filePath))
                throw new FileNotFoundException($"Файл {filePath} не найден!");

            XmlSerializer serializer = new XmlSerializer(typeof(MedicalDataContainer));
            using (FileStream fs = new FileStream(filePath, FileMode.Open))
            {
                return (MedicalDataContainer)serializer.Deserialize(fs) ?? new MedicalDataContainer();
            }
        }

        public static MedicalDataContainer LoadFromJson(string filePath)
        {
            if (!File.Exists(filePath))
                throw new FileNotFoundException($"Файл {filePath} не найден!");

            string json = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<MedicalDataContainer>(json) ?? new MedicalDataContainer();
        }
    }
}