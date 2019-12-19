using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MECMOD;

namespace Profil_Rechner_GUI.Geometrien
{
    class Traeger : Geometrie
    {
        /// Variabeln für ein Traegerprofil

        private double zBreite1;
        private double zBreite2;
        private double zHoehe1;
        private double zHoehe2;

        /// Erzeugt einen Traeger mit allen Variablen 0

        public Traeger() : this(0, 0, 0, 0, 0) { }

        /// <summary>
        /// Erzeugt einen neuen Traeger mit den vorherigen Maßen und der Laenge 0
        /// </summary>
        /// <param name="pBreite"></param>
        /// <param name="pHoehe"></param>

        public Traeger(double pBreite1, double pHoehe1, double pBreite2, double pHoehe2) : this(pBreite1, pHoehe1, pBreite2, pHoehe2, 0) { }

        /// <summary>
        /// Erzeugt einen neuen Traeger mit den jeweiligen Maßen
        /// </summary>
        /// <param name="pBreite"></param>
        /// <param name="pHoehe"></param>
        /// <param name="pLaenge"></param>
        /// <param name="pHoehe2"></param>
        /// <param name="pLaenge"></param>

        public Traeger(double pBreite1, double pHoehe1, double pBreite2, double pHoehe2, double pLaenge) : base(pLaenge)
        {
            this.SetBreite1(pBreite1);
            this.SetHoehe1(pHoehe1);
            this.SetBreite2(pBreite2);
            this.SetHoehe2(pHoehe2);
        }

        /// <summary>
        /// Berechnet den Flaecheninhalt des Traegers mit den global verfuegbaren Parametern der Klasse.
        /// </summary>
        /// <return>Flaecheninhalt des Traegerprofils</return>

        public override double GetFlaecheninhalt()
        {
            return (GetHoehe1() * GetBreite1() - GetHoehe2() * (2 * GetBreite2() ) );
        }

        /// <summary>
        /// Berechnet die Flaechentraegheit des Kastenprofils mit den global verfügbaren Parametern der Klasse.
        /// </summary>
        /// <return>Flaechentraegheit des Kastenprofils</return>

        public override double[] GetFlaechenTraegheit()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gibt das axiale Flächenträgheitsmeoment zweiten Grades: Ix zurück.
        /// </summary>
        /// <returns>Flaechenträgheit Ix</returns>
        public override double GetFlaechenTraegheit_Ix()
        {
            double eFlaechenTraegheit_Ix = (((GetBreite1() * Math.Pow(GetHoehe1(), 3)) - ((2 * GetBreite2()) * Math.Pow(GetHoehe2(), 3))) / 12);

            return eFlaechenTraegheit_Ix;
        }

        /// <summary>
        /// Berechnet das axiale Biegewiderstandsmoment Wx aus den gegebenen, globalen Feldwerten.
        /// </summary>
        /// <returns>Biegewiderstandsmoment Wx</returns>
        public override double GetBiegeWiderstandsMoment_Wx()
        {
            double eBiegeWiderStand_Wx = (((GetBreite1() * Math.Pow(GetHoehe1(), 3)) - (( 2 * GetBreite2()) * Math.Pow(GetHoehe2(), 3))) / (6 * GetHoehe1()));

            return eBiegeWiderStand_Wx;
        }

        /// <summary>
        /// Aus den gegebenen Paramnetern wird die Mantelflaeche eines Traegerprofils berechnet.
        /// </summary>
        /// <returns>Oberflaeche</returns>
        public override double GetMantelflaeche()
        {
            double eMantelflaeche = 0;

            eMantelflaeche += 2 * GetBreite1() * GetLaenge();
            eMantelflaeche += 2 * GetHoehe1() * GetLaenge();
            eMantelflaeche += 4 * GetBreite2() * GetLaenge();

            return eMantelflaeche;
        }

        /////////////////////////////////////////////////////////////////////////////
        /// CATIA-Part

        /// <summary>
        /// Erzeuge ein Traegerprofil in CATIA
        /// </summary>

        internal void ErzeugeProfilTraeger(ref Sketch sketch)
        {
            throw new NotImplementedException();
        }

        /////////////////////////////////////////////////////////////////////////////
        /// GET and SET

        /// <summary>
        /// Getter für die Felder Breite des Kastens.
        /// </summary>
        /// <returns>Breiten des Traegers</returns>
        public double GetBreite1()
        {
            return zBreite1;
        }

        public double GetBreite2()
        {
            return zBreite2;
        }

        /// <summary>
        /// Überprüft, dass der übergebene Parameter nicht negativ ist.
        /// Im positiven Fall wird die Objektvariable entsprechend gesetzt, andernfalls eine Exception geworfen
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <param name="pBreite1">Breite des Traegers</param>
        /// /// <param name="pBreite2">Breite des Traegers</param>
        public void SetBreite1(double pBreite1)
        {
            if (pBreite1 >= 0) zBreite1 = pBreite1;
            else throw new ArgumentOutOfRangeException("'B' muss einen positiven Wert annehmen");
        }
        public void SetBreite2(double pBreite2)
        {
            if (!(pBreite2 >= 0)) throw new ArgumentOutOfRangeException("'b' muss einen positiven Wert annehmen");

            if (pBreite2 < GetBreite1()) zBreite2 = pBreite2;
            else throw new ConsistencyException("'b'muss einen kleineren Wert als 'B' annehmen");
        }



        /// <summary>
        /// Getter der Höhe des Traegers.
        /// </summary>
        /// <returns>Höhe des Traegers</returns>
        public double GetHoehe1()
        {
            return zHoehe1;
        }
        public double GetHoehe2()
        {
            return zHoehe2;
        }

        /// <summary>
        /// Überprüft, dass der übergebene Parameter nicht negativ ist.
        /// Im positiven Fall wird die Objektvariable entsprechend gesetzt, andernfalls eine Exception geworfen
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <param name="pHoehe1">Höhe des Traegers</param>
        /// <param name="pHoehe2">Höhe des Traegers</param>
        public void SetHoehe1(double pHoehe1)
        {
            if (pHoehe1 >= 0) zHoehe1 = pHoehe1;
            else throw new ArgumentOutOfRangeException("'H' muss einen positiven Wert annehmen");
        }

        public void SetHoehe2(double pHoehe2)
        {
            if (!(pHoehe2 >= 0)) throw new ArgumentOutOfRangeException("'h' muss einen positiven Wert annehmen");

            if (pHoehe2 < GetHoehe1()) zHoehe2 = pHoehe2;
            else throw new ConsistencyException("'h'muss einen kleineren Wert als 'H' annehmen");
        }
    }
}
