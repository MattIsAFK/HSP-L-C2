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
        /// <summary>
        /// Erzeugt eine neue Geometrie der Länge 0.
        /// Kann nur von "Kindern" aufgerufen werden da Klasse abstract.
        /// </summary>
        public Geometrie():this(0) {}

        /// <summary>
        /// Erzeugt eine neue Geometrie von entsprechender Länge.
        /// Wird nur von "Kindern" in deren Konstruktoren aufgerufen.
        /// </summary>
        /// <param name="pLaenge">Länge des zu erzeugenden Profils</param>
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
