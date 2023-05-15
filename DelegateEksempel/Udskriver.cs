using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEksempel
{
    public class Udskriver
    {
        public static void UdskrivVhaInterface(string s, IstringFormater formatter)
        {
            string newString = formatter.Format(s);
            Console.WriteLine(newString);
        }

        public static void UdskrivVhaDelegate(string s, IStringFormatterDelegate formatter)
        {
            string newString = formatter(s);
            Console.WriteLine(newString);
        }
    }
}
