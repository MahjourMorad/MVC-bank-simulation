using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCSimulation2.Models
{
    public class LoanBusinessLayer
    {
        public double CalculMensualite(double c, double duree, double taux)
        {
            double t = taux / 100;
            double t1 = c * t / 12;
            double t2 = 1 - Math.Pow(1 + t / 12, -1 * duree);
            return t1 / t2;
        }
    }
}
