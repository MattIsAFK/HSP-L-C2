using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profil_Rechner_Console
{
    class Rechteck : Geometrie
    {
        /// Variabeln für Vierkantprofil
        private double zBreite;
        private double zHoehe;



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
            this.setBreite(pBreite);
            this.setHoehe(pHoehe);
        }


        /// <summary>
        /// Berechnet den Flächeninhalt des Rechtecks mit den global verfügbaren Parametern der Klasse.
        /// </summary>
        /// <returns>Flächeninhalt</returns>
        public override double GetFlaecheninhalt()
        {
            return getHoehe() * getBreite();
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
            double eVolumen = getBreite() * getLaenge() * getHoehe();
            return eVolumen;
        }

        /// <summary>
        /// Getter für das Feld Breite des Rechtecks.
        /// </summary>
        /// <returns>Breite des Rechtecks</returns>
        public double getBreite()
        {
            return zBreite;
        }

        /// <summary>
        /// Überprüft, dass der übergebene Parameter nicht negativ ist.
        /// Im positiven Fall wird die Objektvariable entsprechend gesetzt, andernfalls eine Exception geworfen
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <param name="pBreite">Breite des Rechtecks</param>
        public void setBreite(double pBreite)
        {
            if (pBreite >= 0) zBreite = pBreite;
            else throw new ArgumentOutOfRangeException("Breite muss einen positiven Wert annehmen");
        }



        public double getHoehe()
        {
            return zHoehe;
        }

        /// <summary>
        /// Überprüft, dass der übergebene Parameter nicht negativ ist.
        /// Im positiven Fall wird die Objektvariable entsprechend gesetzt, andernfalls eine Exception geworfen
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <param name="pHoehe">Höhe des Rechtecks</param>
        public void setHoehe(double pHoehe)
        {
            if (pHoehe >= 0) zHoehe = pHoehe;
            else throw new ArgumentOutOfRangeException("Höhe muss einen positiven Wert annehmen");
        }
    }

}
