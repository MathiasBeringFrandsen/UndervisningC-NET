using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEksempel
{
    internal class UppercaseFormatter : IstringFormater
    {
        public string Format(string s)
        {
            return s.ToUpper();
        }
    }
}
