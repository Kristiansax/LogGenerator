using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogGenerator
{
    class Institution
    {
        public string Afdeling { get; set; }
        public string Bolig { get; set; }

        public Institution(string Afdeling, string Bolig)
        {
            this.Afdeling = Afdeling;
            this.Bolig = Bolig;
        }

        public Institution()
        {

        }
    }
}
