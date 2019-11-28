﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profil_Rechner_GUI.Geometrien
{
    class Sechseck : Geometrie 
    {

        /// Variabeln für ein Sechseckprofil

        private double zBreite;

        /// Erzeugt ein Sechseck mit allen Variablen 0

        public Sechseck() : this(0, 0) { }

        /// <summary>
        /// Erzeugt ein neues Sechseck mit den vorherigen Maßen und der Laenge 0
        /// </summary>
        /// <param name="pBreite"></param>

        public Sechseck(double pBreite) : this(pBreite, 0) { }

        /// <summary>
        /// Erzeugt ein neues Sechseck mit den jeweiligen Maßen
        /// </summary>
        /// <param name="pBreite"></param>
        /// <param name="pLaenge"></param>

        public Sechseck(double pBreite, double pLaenge) : base(pLaenge)
        {
            this.SetBreite(pBreite);
            this.SetLaenge(pLaenge);
        }

        /// <summary>
        /// Berechnet den Flaecheninhalt des Sechsecks mit den global verfuegbaren Parametern der Klasse.
        /// </summary>
        /// <return>Flaecheninhalt des Sechseckprofils</return>

        public override double GetFlaecheninhalt()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Berechnet die Flaechentraegheit des Sechseckprofils mit den global verfügbaren Parametern der Klasse.
        /// </summary>
        /// <return>Flaechentraegheit desSechseckprofils</return>

        public override double[] GetFlaechenTraegheit()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Aus den gegeben Parametern wird das Volumen eines Sechseckprofils berechnet.
        /// </summary>
        /// <returns>Volumen</returns>
        public override double GetVolumen()
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Aus den gegebenen Paramnetern wird die Oberflaeche eines Kreisprofils berechnet.
        /// </summary>
        /// <returns>Oberflaeche</returns>
        public double GetOberflaeche()
        {
            throw new NotImplementedException();
        }


        /////////////////////////////////////////////////////////////////////////////
        /// GET and SET

        /// <summary>
        /// Getter für das Feld Breite des Sechsecks bzw. der Sechseckseiten.
        /// </summary>
        /// <returns>Breite des Sechseckseiten</returns>
        public double GetBreite()
        {
            return zBreite;
        }

        /// <summary>
        /// Überprüft, dass der übergebene Parameter nicht negativ ist.
        /// Im positiven Fall wird die Objektvariable entsprechend gesetzt, andernfalls eine Exception geworfen.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <param name="pBreite">Breite des Rechtecks</param>
        public void SetBreite(double pBreite)
        {
            if (pBreite >= 0) zBreite = pBreite;
            else throw new ArgumentOutOfRangeException("Breite muss einen positiven Wert annehmen");
        }

    }
}
