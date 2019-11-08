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
        protected double zHoehe;


        public Rechteck():base()
        {
            zBreite = 0;
            zHoehe = 0;
        }

        public Rechteck(double pBreite, double pHoehe) : this(pBreite, pHoehe, 0) { }
      

        public Rechteck(double pBreite, double pHoehe, double pLaenge):base(pLaenge)
        {
            zBreite = pBreite;
            zHoehe = pHoehe;
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
