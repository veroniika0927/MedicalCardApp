using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalCardApp.Classes
{
    public class Address
    {
        public string ClinicName { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Street { get; set; } = string.Empty;
        public string Building { get; set; } = string.Empty;

        public override string ToString()
        {
            return $"{ClinicName}, г.{City}, ул.{Street}, д.{Building}";
        }
    }
}