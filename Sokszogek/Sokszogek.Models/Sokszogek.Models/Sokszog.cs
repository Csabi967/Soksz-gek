using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokszogek.Models
{
    public abstract class Sokszog
    {
        public double OldalA { get; protected set; }

        protected Sokszog(double oldalA)
        {
            OldalA = oldalA;
        }

        public abstract double Kerulet();
        public abstract double Terulet();
    }
}