using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MECMOD;

namespace Profil_Rechner_GUI.Geometrien
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
        /// Erzeugt ein neues Rechteck mit den übergebenen Maßen.
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
            this.SetBreite(pBreite);
            this.SetHoehe(pHoehe);
        }


        /// <summary>
        /// Berechnet den Flächeninhalt des Rechtecks mit den global verfügbaren Parametern der Klasse.
        /// </summary>
        /// <returns>Flächeninhalt</returns>
        public override double GetFlaecheninhalt()
        {
            return GetHoehe() * GetBreite();
        }

        /// <summary>
        /// Zusammenfassung der einzelnen Methoden für Ausgabe in Array 
        /// </summary>
        /// <returns>Array mit Flächenträgheiten des Rechteckprofils</returns>
        public override double[] GetFlaechenTraegheit()
        {
            ///Lösungsvorschlag für die Problematik der multiplen Werte
            ///Methodenname allerdings irreführend
  
            double[] flaechentraegheiten = new double[4];
            flaechentraegheiten[0] = GetFlaechenTraegheit_Ix();
            flaechentraegheiten[1] = GetFlaechenTraegheit_Iy();
            flaechentraegheiten[2] = GetBiegeWiderstandsMoment_Wx();
            flaechentraegheiten[3] = GetBiegeWiderstandsMoment_Wy();

            return flaechentraegheiten;
        }
        /// <summary>
        /// Gibt das axiale Flächenträgheitsmeoment zweiten Grades: Ix zurück.
        /// </summary>
        /// <returns>Flaechenträgheit I x</returns>
        public override double GetFlaechenTraegheit_Ix()
        {
            double eFlaechenTraegheit_Ix = ((GetBreite() * Math.Pow(GetHoehe(), 3)) / 12);

            return eFlaechenTraegheit_Ix;
        }
        /// <summary>
        /// Gibt das axiale Flächenträgheitsmeoment zweiten Grades: Iy zurück.
        /// </summary>
        /// <returns>Flaechenträgheit I y</returns>
        public override double GetFlaechenTraegheit_Iy()
        {
            double eFlaechenTraegheit_Iy = ((GetHoehe() * Math.Pow(GetBreite(), 3)) / 12);

            return eFlaechenTraegheit_Iy;
        }
        /// <summary>
        /// Berechnet das axiale Biegewiderstandsmoment Wx aus den gegebenen, globalen, Feldwerten.
        /// </summary>
        /// <returns>Biegewiderstandsmoment Wx</returns>
        public override double GetBiegeWiderstandsMoment_Wx()
        {
            double eBiegeWiderStand_Wx = ((GetBreite()*Math.Pow(GetHoehe(),2))/6);
            return eBiegeWiderStand_Wx;
        }
        /// <summary>
        /// Berechnet das axiale Biegewiderstandsmoment Wy aus den gegebenen, globalen, Feldwerten.
        /// </summary>
        /// <returns>Biegewiderstandsmoment Wy</returns>
        public override double GetBiegeWiderstandsMoment_Wy()
        {
            double eBiegeWiderStand_Wy = ((GetHoehe() * Math.Pow(GetBreite(), 2)) / 6);
            return eBiegeWiderStand_Wy;
        }

        /// <summary>
        /// Berechnet aus den vorhandenen Feldwerten sowie der übergebenen Dichte das Gewicht des Profils.
        /// </summary>
        /// <param name="pDichte">Dichte des Profils</param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <returns>Gewicht des Profils</returns>
        public double GetGewicht(double pDichte)
        {
            double eGewicht;

            if (pDichte >= 0) eGewicht = GetVolumen() * pDichte;
            else { throw new ArgumentOutOfRangeException("Dichte muss einen positiven Wert annehmen"); }

            return eGewicht;
        }

        /// <summary>
        /// Berechnet die Oberfläche des Profils aus den gegebenen, globalen, Feldwerten.
        /// </summary>
        /// <returns>Oberfläche des Profils</returns>
        public double GetOberflaeche()
        {
            double eOberflaeche = 0;

            eOberflaeche += 2 * GetFlaecheninhalt();
            eOberflaeche += 2 * GetBreite() * GetLaenge();
            eOberflaeche += 2 * GetHoehe() * GetLaenge();

            return eOberflaeche;
        }

        /////////////////////////////////////////////////////////////////////////////
        /// CATIA-Part


        /// <summary>
        /// Erzeuge ein Rechteckprofil in CATIA
        /// </summary>

        internal void ErzeugeProfilRechteck(ref Sketch sketch) 
        {
            throw new NotImplementedException();
        }

        /////////////////////////////////////////////////////////////////////////////
        /// GET and SET

        /// <summary>
        /// Getter für das Feld Breite des Rechtecks.
        /// </summary>
        /// <returns>Breite des Rechtecks</returns>
        public double GetBreite()
        {
            return zBreite;
        }

        /// <summary>
        /// Überprüft, dass der übergebene Parameter nicht negativ ist.
        /// Im positiven Fall wird die Objektvariable entsprechend gesetzt, andernfalls eine Exception geworfen
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <param name="pBreite">Breite des Rechtecks</param>
        public void SetBreite(double pBreite)
        {
            if (pBreite >= 0) zBreite = pBreite;
            else throw new ArgumentOutOfRangeException("Breite muss einen positiven Wert annehmen");
        }


        /// <summary>
        /// Getter der Höhe des Rechtecks.
        /// </summary>
        /// <returns>Höhe des Rechtecks</returns>
        public double GetHoehe()
        {
            return zHoehe;
        }

        /// <summary>
        /// Überprüft, dass der übergebene Parameter nicht negativ ist.
        /// Im positiven Fall wird die Objektvariable entsprechend gesetzt, andernfalls eine Exception geworfen
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <param name="pHoehe">Höhe des Rechtecks</param>
        public void SetHoehe(double pHoehe)
        {
            if (pHoehe >= 0) zHoehe = pHoehe;
            else throw new ArgumentOutOfRangeException("Höhe muss einen positiven Wert annehmen");
        }
    }

}
