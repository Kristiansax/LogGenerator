using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogGenerator
{
    class Sensor
    {
        public string Type { get; set; }
        public string ID { get; set; }

        public Sensor(string Type, string ID)
        {
            this.Type = Type;
            this.ID = ID;
        }

        public Sensor()
        {

        }
    }
}
