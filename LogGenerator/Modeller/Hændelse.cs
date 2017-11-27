using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogGenerator
{
    class Hændelse
    {
        public string AlarmBeskrivelse { get; set; }
        public DateTime StartTid { get; set; }
        public DateTime SlutTid { get; set; }

        public Hændelse(string AlarmBeskrivelse, DateTime StartTid, DateTime SlutTid)
        {
            this.AlarmBeskrivelse = AlarmBeskrivelse;
            this.StartTid = StartTid;
            this.SlutTid = StartTid;
        }

        public Hændelse()
        {

        }

    }
}
