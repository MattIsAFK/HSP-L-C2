using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profil_Rechner_Console
{
    class Kreis : Geometrie
    {
        private double zRadius;
        private double zLaenge;
        /// <summary>
        /// Erzeugt einen neuen Kreis mit allen Feldwerten 0
        /// </summary>
        public Kreis() : this(0, 0) { }
        /// <summary>
        /// Erzeugt ein Objekt Kreis mti übergebenem Radius und derProfillaenge 0.
        /// </summary>
        /// <param name="pRadius">Radius des Kreisprofils</param>
        public Kreis(double pRadius):this(pRadius,0) { }
        /// <summary>
        /// Erzeugt einen neuen Kreis mit den übergebenen Parametern.
        /// </summary>
        /// <param name="pRadius">Radius des Kreises</param>
        /// <param name="pLaenge">Laenge der Profilgeometrie</param>
        public Kreis(double pRadius, double pLaenge):base(pLaenge)
        {
            setRadius(pRadius);
        }

        /// <summary>
        /// Berechnet den Flaecheninhalt des Kreises mit den global verfuegbaren Parametern der Klasse.
        /// </summary>
        /// <return>Flaecheninhalt des Kreisprofils</return>
        public override double GetFlaecheninhalt()
        {

            return GetRadius() * GetRadius() * Math.PI;

        }
        /// <summary>
        /// Berechnet die Flaechentraegheit des Kreisprofils mit den global verfügbaren Parametern der Klasse.
        /// </summary>
        /// <return>Flaechentraegheit des Kreisprofils</return>
        public override double GetFlaechenTraegheit()
        {
            double FlaechenTraegheit = Math.Pow(2 * GetRadius(), 4) * Math.PI / 64;
            return FlaechenTraegheit;
        }
        /// <summary>
        /// Aus den gegeben Parametern wird das Volumen eines Kreisprofils berechnet.
        /// </summary>
        /// <returns>Volumen</returns>
        public override double GetVolumen()
        {
            double eVolumen = Math.PI * GetRadius() * GetRadius() * GetLaenge();
            return eVolumen;
        }
        /// <summary>
        /// Aus den gegebenen Paramnetern wird die Oberflaeche eines Kreisprofils berechnet.
        /// </summary>
        /// <returns>Oberflaeche</returns>
        public double GetOberflaeche()
        {

            double eOberflaeche = 2 * Math.PI * GetRadius() * (GetRadius() + GetLaenge());
            return eOberflaeche;
        }
        /// <summary>
        /// Aus den gegebenen Parametern wird die Mantelflaeche eines Kreisprofils berechnet.
        /// </summary>
        /// <returns>Mantelflache</returns>
        public double GetMantelflaeche()
        {

            double eMantelflaeche = 2 * Math.PI * GetRadius() * GetLaenge();
            return eMantelflaeche;
        }

        /////////////////////////////////////////////////////////////////////////////
        /// GET and SET

        /// <summary>
        /// Getter für das Feld Radius des Kreisprofils.
        /// </summary>
        /// <returns>Radius des Kreisprofils</returns>
        public double GetRadius()
        {
            return zRadius;
        }

        /// <summary>
        /// Überprüft, dass der übergebene Parameter nicht negativ ist.
        /// Im positiven Fall wird die Objektvariable entsprechend gesetzt, andernfalls eine Exception geworfen
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <param name="pRadius">Radius des Kreisprofils</param>
        /// 

        public void SetRadius(double pRadius)
        {
            if (pRadius >= 0) zRadius = pRadius;
            else throw new ArgumentOutOfRangeException("Radius muss einen positiven Wert annehmen");

        }

        /// <summary>
        /// Getter für das Feld Laenge des Kreisprofils.
        /// </summary>
        /// <returns>Laenge des Kreisprofils</returns>
        /// 

        public double GetLaenge()
        {
            return zLaenge;
        }

        /// <summary>
        /// Überprüft, dass der übergebene Parameter nicht negativ ist.
        /// Im positiven Fall wird die Objektvariable entsprechend gesetzt, andernfalls eine Exception geworfen
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <param name="pLaenge">Laenge des Kreisprofils</param>
        ///

        public void SetLaenge(double pLaenge)
        {
            if (pLaenge >= 0) zLaenge = pLaenge;
            else throw new ArgumentOutOfRangeException("Laenge muss einen positiven Wert annehmen");
        }
    }
}
