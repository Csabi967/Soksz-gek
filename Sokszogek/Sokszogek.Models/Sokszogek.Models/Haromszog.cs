using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokszogek.Models
{
    public class Haromszog : Teglalap
    {
        public double OldalC { get; protected set; }

        public Haromszog(double oldalA, double oldalB, double oldalC)
            : base(oldalA, oldalB)
        {
            OldalC = oldalC;
        }

        public override double Kerulet()
        {
            if (OldalA < 0 || OldalB < 0 || OldalC < 0)
                return double.NaN;

            return OldalA + OldalB + OldalC;
        }

        public override double Terulet()
        {
            if (OldalA < 0 || OldalB < 0 || OldalC < 0)
                return double.NaN;

            
            double s = Kerulet() / 2;
            return Math.Sqrt(s * (s - OldalA) * (s - OldalB) * (s - OldalC));
        }
    }
}