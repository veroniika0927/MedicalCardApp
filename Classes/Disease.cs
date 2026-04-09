using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MedicalCardApp.Classes
{
    public class Disease
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Severity { get; set; } = string.Empty;
        public int DurationDays { get; set; }
        public List<string> Symptoms { get; set; } = new List<string>();
        public string Treatment { get; set; } = string.Empty;
        public string IcdCode { get; set; } = string.Empty;

        [XmlIgnore]
        public string SymptomsString => Symptoms != null && Symptoms.Any()
            ? string.Join(", ", Symptoms)
            : "Не указаны";
    }
}