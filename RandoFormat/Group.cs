using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandoFormat
{
    public class Group
    {
        public List<string> entries = new List<string>();
        public string name = null;

        public Group(string n)
        {
            name = n;
        }

        public Group(string n, List<string> e)
        {
            entries = e;
            name = n;
        }
    }
}