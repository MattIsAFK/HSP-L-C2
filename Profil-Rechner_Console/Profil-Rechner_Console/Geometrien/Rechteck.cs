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


 
        /// <summary>
        /// Erzeugt ein neues Rechteck bei dem alle Variablen auf 0 gesetzt werden. 
        /// </summary>
        public Rechteck() : this(0, 0, 0) { }

        /// <summary>
        /// Erzeugt ein neues Rechteck mit den übergeben Maßen.
        /// Die Länge des Profils wird 0 gesetzt.
        /// </summary>
        /// <param name="pBreite"></param>
        /// <param name="pHoehe"></param>
        public Rechteck(double pBreite, double pHoehe) : this(pBreite, pHoehe, 0) { }

        /// <summary>
        /// Erstellt ein neues Rechteck mit den entsprechenden Maßen
        /// </summary>
        /// <param name="pBreite">Breite des Rechtecks</param>
        /// <param name="pHoehe">Höhe des Rechtecks</param>
        /// <param name="pLaenge">Länge des Profils</param>
        public Rechteck(double pBreite, double pHoehe, double pLaenge) : base(pLaenge)
        {
            if (pBreite >= 0) zBreite = pBreite; else throw new Exception(); 
            zHoehe = pHoehe;
        }

        
        /// <summary>
        /// Berechnet den Flächeninhalt des Rechtecks mit den global verfügbaren Parametern der Klasse.
        /// </summary>
        /// <returns>Flächeninhalt</returns>
        public override double GetFlaecheninhalt()
        {
            return zLaenge*zBreite;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>Flächenträgheit des Rechteckprofils</returns>
        public override double GetFlachenTraegheit()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Aus den gegeben Parametern wird das Volumen berechnet.
        /// 
        /// </summary>
        /// <returns>Volumen</returns>
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
