using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion8.Model
{
    class Performer
    {
        public int PerformerID { get; set; }
        public string Name { get; set; }
        public bool Band { get; set; }

        public Performer() { }

        public Performer(string name, bool band)
        {
            Name = name;
            Band = band;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
