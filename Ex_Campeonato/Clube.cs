using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Campeonato
{
    class Clube
    {
        public string name;

        public Clube(string name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            return name;
        }
    }
}
