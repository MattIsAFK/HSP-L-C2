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
        protected double breite;
        protected double laenge;
        protected double hoehe;


        public Rechteck()
        {
            breite = 0;
            laenge = 0;
            hoehe = 0;
        }
        
        public override double GetFlaecheninhalt()
        {
            return laenge*breite;
        }

        public double getBreite()
        {
            return breite;
        }

        public double getLaenge()
        {
            return laenge;
        }

        public double getHoehe()
        {
            return hoehe;
        }
    }

}
