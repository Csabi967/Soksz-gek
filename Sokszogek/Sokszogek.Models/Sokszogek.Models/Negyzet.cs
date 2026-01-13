using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokszogek.Models
{
    public class Negyzet : Sokszog
    {
        public Negyzet(double oldalA) : base(oldalA)
        {
        }

        public override double Kerulet()
        {
            if (OldalA < 0)
                return double.NaN;

            return 4 * OldalA;
        }

        public override double Terulet()
        {
            if (OldalA < 0)
                return double.NaN;

            return OldalA * OldalA;
        }
    }
}