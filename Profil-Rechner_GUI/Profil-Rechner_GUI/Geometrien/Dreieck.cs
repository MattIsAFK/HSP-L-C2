using System;
using MECMOD;

namespace Profil_Rechner_GUI.Geometrien
{
    class Dreieck:Geometrie
    {
        /// Variabeln für Dreiecksprofil
        private double zBreite;
        private double zHoehe;

        /// <summary>
        /// Erzeugt ein neues Dreieck bei dem alle Variablen auf 0 gesetzt werden. 
        /// </summary>
        public Dreieck() : this(0, 0, 0) { }

        /// <summary>
        /// Erzeugt ein neues Dreieck mit den übergebenen Maßen.
        /// Die Länge des Profils wird 0 gesetzt.
        /// </summary>
        /// <param name="pBreite"></param>
        /// <param name="pHoehe"></param>
        public Dreieck(double pBreite, double pHoehe) : this(pBreite, pHoehe, 0) { }

        /// <summary>
        /// Erstellt ein neues Dreieck mit den entsprechenden Maßen
        /// </summary>
        /// <param name="pBreite">Breite des Dreiecks</param>
        /// <param name="pHoehe">Höhe des Dreiecks</param>
        /// <param name="pLaenge">Länge des Profils</param>
        public Dreieck(double pBreite, double pHoehe, double pLaenge) : base(pLaenge)
        {
            this.SetBreite(pBreite);
            this.SetHoehe(pHoehe);
        }
        
        /// <summary>
        /// Berechnet den Flächeninhalt des Dreiecks mit den Parametern der Klasse.
        /// </summary>
        /// <returns>Flächeninhalt</returns>
        public override double GetFlaecheninhalt()
        {
            return (GetHoehe() * GetBreite())/2;
        }

        public override double GetMantelflaeche()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Berechnet die Flaechentraegheit des Dreieckprofils mit den global verfügbaren Parametern der Klasse.
        /// </summary>
        /// <return>Flaechentraegheit des Dreieckprofils</return>
        public override double[] GetFlaechenTraegheit()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gibt das axiale Flächenträgheitsmeoment zweiten Grades: Ix zurück.
        /// </summary>
        /// <returns>Flaechenträgheit I x</returns>
        public override double GetFlaechenTraegheit_Ix()
        {
            return ((GetBreite() * Math.Pow(GetHoehe(), 3)) / 36);

        }
        /// <summary>
        /// Gibt das axiale Flächenträgheitsmeoment zweiten Grades: Iy zurück.
        /// </summary>
        /// <returns>Flaechenträgheit I y</returns>
        public override double GetFlaechenTraegheit_Iy()
        {
            return ((GetHoehe() * Math.Pow(GetBreite(), 3)) / 48);
        }

        public override double GetBiegeWiderstandsMoment_Wx()
        {
            return GetBreite()*Math.Pow(GetHoehe(),2);
        }

        /////////////////////////////////////////////////////////////////////////////
        /// CATIA-Part


        /// <summary>
        /// Erzeuge ein Dreieckprofil in CATIA
        /// </summary>

        internal void ErzeugeProfilDreieck(ref Sketch sketch)
        {
            throw new NotImplementedException();
        }



        /////////////////////////////////////////////////////////////////////////////
        /// GET and SET

        /// <summary>
        /// Getter für das Feld Breite des Dreiecks.
        /// </summary>
        /// <returns>Breite des Dreiecks</returns>
        public double GetBreite()
        {
            return zBreite;
        }

        /// <summary>
        /// Überprüft, dass der übergebene Parameter nicht negativ ist.
        /// Im positiven Fall wird die Objektvariable entsprechend gesetzt, andernfalls eine Exception geworfen
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <param name="pBreite">Breite des Dreiecks</param>
        public void SetBreite(double pBreite)
        {
            if (pBreite >= 0) zBreite = pBreite;
            else throw new ArgumentOutOfRangeException("Breite muss einen positiven Wert annehmen");
        }

        /// <summary>
        /// Getter der Höhe des Dreiecks.
        /// </summary>
        /// <returns>Höhe des Dreiecks</returns>
        public double GetHoehe()
        {
            return zHoehe;
        }

        /// <summary>
        /// Überprüft, dass der übergebene Parameter nicht negativ ist.
        /// Im positiven Fall wird die Objektvariable entsprechend gesetzt, andernfalls eine Exception geworfen
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <param name="pHoehe">Höhe des Dreiecks</param>
        public void SetHoehe(double pHoehe)
        {
            if (pHoehe >= 0) zHoehe = pHoehe;
            else throw new ArgumentOutOfRangeException("Höhe muss einen positiven Wert annehmen");
        }

    }
}
