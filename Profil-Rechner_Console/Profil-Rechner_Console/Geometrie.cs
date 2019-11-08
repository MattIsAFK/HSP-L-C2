using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profil_Rechner_Console
{
    abstract class Geometrie
    {
        protected double zLaenge;
        public Geometrie():this(0) {}

        public Geometrie(double pLaenge)
        {
            zLaenge = pLaenge;
        }

        public abstract double GetFlaecheninhalt();

        public abstract double GetFlachenTraegheit();

        public abstract double GetVolumen();

        public double getLaenge()
        {
            return zLaenge;
        }

        public void setLaenge(double pLaenge)
        {
            zLaenge = pLaenge;
        }


    }

}
