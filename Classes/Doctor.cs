using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MedicalCardApp.Classes
{
    public class Doctor
    {
        public int Id { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string Specialization { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public Address WorkAddress { get; set; } = new Address();
        public List<string> WorkingDays { get; set; } = new List<string>();

        [XmlIgnore]
        public string WorkAddressString => WorkAddress?.ToString() ?? "Не указан";

        [XmlIgnore]
        public string WorkingDaysString => WorkingDays != null && WorkingDays.Any()
            ? string.Join(", ", WorkingDays)
            : "Не указаны";
    }
}