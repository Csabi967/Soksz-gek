using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokszogek.Models
{
    public class Teglalap : Negyzet
    {
        public double OldalB { get; protected set; }

        public Teglalap(double oldalA, double oldalB) : base(oldalA)
        {
            OldalB = oldalB;
        }

        public override double Kerulet()
        {
            if (OldalA < 0 || OldalB < 0)
                return double.NaN;

            return 2 * (OldalA + OldalB);
        }

        public override double Terulet()
        {
            if (OldalA < 0 || OldalB < 0)
                return double.NaN;

            return OldalA * OldalB;
        }
    }
}
