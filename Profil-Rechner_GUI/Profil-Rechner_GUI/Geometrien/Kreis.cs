﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MECMOD;


namespace Profil_Rechner_GUI.Geometrien

{
    class Kreis : Geometrie
    {
        private double zRadius;
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
        public Kreis(double pRadius, double pLaenge) : base(pLaenge)
        {
            SetRadius(pRadius);
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
        public override double[] GetFlaechenTraegheit()
        {
            double[] FlaechenTraegheit = new double[4];
            FlaechenTraegheit [0] =  Math.Pow(2 * GetRadius(), 4) * Math.PI / 64;
            return FlaechenTraegheit;
        }

        /// <summary>
        /// Aus den gegeben Werten wird die Flächenträgheit des Kreisprofils berechnet.
        /// </summary>
        /// <returns>Flächenträgheit des Kreises</returns>
        public override double GetFlaechenTraegheit_Ix()
        {
            return (Math.Pow(2 * GetRadius(), 4) * Math.PI) / 64; 
        }

        /// <summary>
        /// Flächenträgheit Ix undIy sind identisch beim Kreis.
        /// </summary>
        /// <returns>Flächenträgheit des Kreises</returns>
        public override double GetFlaechenTraegheit_Iy()
        {
            return GetFlaechenTraegheit_Ix();
        }

        public override double GetBiegeWiderstandsMoment_Wx()
        {
            return (Math.Pow(2 * GetRadius(), 3) * Math.PI) / 32;
        }

        public override double GetBiegeWiderstandsMoment_Wy()
        {
            return GetBiegeWiderstandsMoment_Wx();
        }

        /// <summary>
        /// Aus den gegebenen Parametern wird die Mantelflaeche eines Kreisprofils berechnet.
        /// </summary>
        /// <returns>Mantelflache</returns>
        public override double GetMantelflaeche()
        {

            double eMantelflaeche = 2 * Math.PI * GetRadius() * GetLaenge();
            return eMantelflaeche;
        }



        /////////////////////////////////////////////////////////////////////////////
        /// CATIA-Part


        /// <summary>
        /// Erzeuge ein Kreisprofil in CATIA
        /// </summary>
    
        internal void ErzeugeProfilKreis(ref Sketch sketch)
        {
            throw new NotImplementedException();
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

    }
}
