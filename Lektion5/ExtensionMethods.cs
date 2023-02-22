using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion5
{
    internal static class ExtensionMethods
    {
        public static void SetAccepted(this List<Person> lst, Predicate<Person> pred)
        {
            List<Person> accepted = lst.FindAll(pred);
            accepted.ForEach(p => p.Accepted = true);
        }
    }
}
