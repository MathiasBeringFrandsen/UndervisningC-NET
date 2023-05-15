using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdresseKlient.Models
{
    public class Adresse
    {
        public string id { get; set; }
        public int status { get; set; }
        public int darstatus { get; set; }
        public string vejkode { get; set; }
        public string vejnavn { get; set; }
        public string adresseringsvejnavn { get; set; }
        public string husnr { get; set; }
        public object supplerendebynavn { get; set; }
        public string postnr { get; set; }
        public string postnrnavn { get; set; }
        public object stormodtagerpostnr { get; set; }
        public object stormodtagerpostnrnavn { get; set; }
        public string kommunekode { get; set; }
        public float x { get; set; }
        public float y { get; set; }
        public string href { get; set; }
        public string betegnelse { get; set; }

        public override string ToString()
        {
            return postnr + " " + postnrnavn;
        }
    }

}
