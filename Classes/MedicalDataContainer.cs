using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MedicalCardApp.Classes
{
    [XmlRoot("MedicalData")]
    public class MedicalDataContainer
    {
        [XmlArray("Doctors"), XmlArrayItem("Doctor")]
        public List<Doctor> Doctors { get; set; } = new List<Doctor>();

        [XmlArray("Patients"), XmlArrayItem("Patient")]
        public List<Patient> Patients { get; set; } = new List<Patient>();

        [XmlArray("Diseases"), XmlArrayItem("Disease")]
        public List<Disease> Diseases { get; set; } = new List<Disease>();
    }
}