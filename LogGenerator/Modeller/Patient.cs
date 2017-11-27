using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogGenerator
{
    class Patient
    {
        public string Navn { get; set; }
        public string Lokation { get; set; }
        public string ID { get; set; }

        public Patient(string Navn, string Lokation, string PatientID)
        {
            this.Navn = Navn;
            this.Lokation = Lokation;
            this.ID = PatientID;
        }

        public Patient()
        {
            
        }
    }
}
