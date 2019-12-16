using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profil_Rechner_GUI
{
    public abstract class Geometrie
    {
        /// <summary>
        /// Länge der Profilgeometrie
        /// </summary>
        private double zLaenge;
        /// <summary>
        /// Erzeugt eine neue Geometrie der Länge 0.
        /// Kann nur von "Kindern" aufgerufen werden da Klasse abstract.
        /// </summary>
        public Geometrie() : this(0) { }

        /// <summary>
        /// Erzeugt eine neue Geometrie von entsprechender Länge.
        /// Wird nur von "Kindern" in deren Konstruktoren aufgerufen.
        /// </summary>
        /// <param name="pLaenge">Länge des zu erzeugenden Profils</param>
        public Geometrie(double pLaenge)
        {
            this.SetLaenge(pLaenge);
        }

        public abstract double GetFlaecheninhalt();

        public abstract double[] GetFlaechenTraegheit();

        public abstract double GetVolumen();

        /// <summary>
        /// Getter der Profillänge
        /// </summary>
        /// <returns>Profillänge</returns>
        public double GetLaenge()
        {
            return zLaenge;
        }

        /// <summary>
        /// Überprüft den Wert für die Länge daruf, dass dieser nicht negativ wird und Setzt die Objektvariable entsprechend.
        /// </summary>
        /// <param name="pLaenge">Länge der Profilgeometrie</param>
        public void SetLaenge(double pLaenge)
        {
            if (pLaenge >= 0) zLaenge = pLaenge;
            else throw new ArgumentOutOfRangeException("Länge muss einen positiven Wert oder 0 annehmen");
        }


    }

}
