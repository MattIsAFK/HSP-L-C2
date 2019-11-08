using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profil_Rechner_Console
{
    class Rechteck:Geometrie
    {
        /// Variabeln für Vierkantprofil
        protected double zBreite;
        protected double zLaenge;
        protected double zHoehe;


        public Rechteck()
        {
            zBreite = 0;
            zLaenge = 0;
            zHoehe = 0;
        }
        
        public override double GetFlaecheninhalt()
        {
            return zLaenge*zBreite;
        }

        public override double GetFlachenTraegheit()
        {
            throw new NotImplementedException();
        }

        public override double GetVolumen()
        {
            double eVolumen= zBreite * zLaenge * zHoehe;
            return eVolumen;
        }

        public double getBreite()
        {
            return zBreite;
        }

        public void setBreite(double pBreite)
        {
            zBreite = pBreite;
        }

        public double getLaenge()
        {
            return zLaenge;
        }

        public void setLaenge(double pLaenge)
        {
            zLaenge = pLaenge;
        }

        public double getHoehe()
        {
            return zHoehe;
        }

        public void setHoehe(double pHoehe)
        {
            zHoehe = pHoehe;
        }
    }

}
