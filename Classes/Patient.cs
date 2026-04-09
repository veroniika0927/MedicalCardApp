using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MedicalCardApp.Classes
{
    public class Patient
    {
        public int Id { get; set; }
        public string FullName { get; set; } = string.Empty;
        public DateTime BirthDate { get; set; }
        public string Phone { get; set; } = string.Empty;
        public Address HomeAddress { get; set; } = new Address();
        public string BloodType { get; set; } = string.Empty;
        public string PassportNumber { get; set; } = string.Empty;

        [XmlIgnore]
        public string HomeAddressString => HomeAddress?.ToString() ?? "Не указан";

        [XmlIgnore]
        public string BirthDateString => BirthDate.ToString("dd.MM.yyyy");

        [XmlIgnore]
        public int Age => DateTime.Now.Year - BirthDate.Year;
    }
}