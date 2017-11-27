using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogGenerator
{
    class Personale
    {
        public string Navn { get; set; }
        public string ID { get; set; }

        public Personale(string Navn, string ID)
        {
            this.Navn = Navn;
            this.ID = ID;
        }

        public Personale()
        {

        }
    }
}
