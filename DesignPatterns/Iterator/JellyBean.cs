using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Iterator
{
    public class JellyBean
    {
        private string flavor;

        public string Flavor { get; }

        public JellyBean(string flavor)
        {
            Flavor = flavor;
        }

    }
}
