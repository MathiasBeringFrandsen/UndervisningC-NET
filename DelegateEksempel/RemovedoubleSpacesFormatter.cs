using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DelegateEksempel
{
    internal class RemovedoubleSpacesFormatter : IstringFormater
    {
        public string Format(string s)
        {
            return s.Replace("  ", " ");
        }
    }
}
