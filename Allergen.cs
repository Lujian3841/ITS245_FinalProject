using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITS245_FinalProject
{
    internal class Allergen
    {
        public int AllergenID { get; set; }
        public int PID { get; set; }

        public string allergen { get; set; }
        public string AllergenStart { get; set; }
        public string AllergenEnd { get; set; }
        public string AllergenDescription { get; set; }

    }
}
