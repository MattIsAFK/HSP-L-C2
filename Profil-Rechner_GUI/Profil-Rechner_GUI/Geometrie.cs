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

        /// <summary>
        /// Ermöglicht die sichere Verwendung eines entsprechenden Textfeldes.
        /// Nicht alle Profile haben einen Wert dafür, daher ist eine Implementation auf jeder Subklasse unnötig.
        /// Sollte dennoch eine Funktion aus versehen aufgerufen werden, ist eine Fehelrbehandlung möglich.
        /// </summary>
        public virtual double GetFlaechenTraegheit_Ix()
        {
            throw new NotImplementedException("Schade! :(");
        }
        /// <summary>
        /// Ermöglicht die sichere Verwendung eines entsprechenden Textfeldes.
        /// Nicht alle Profile haben einen Wert dafür, daher ist eine Implementation auf jeder Subklasse unnötig.
        /// Sollte dennoch eine Funktion aus versehen aufgerufen werden, ist eine Fehelrbehandlung möglich.
        /// </summary>
        public virtual double GetFlaechenTraegheit_Iy()
        {
            throw new NotImplementedException("Schade! :(");
        }
        /// <summary>
        /// Ermöglicht die sichere Verwendung eines entsprechenden Textfeldes.
        /// Nicht alle Profile haben einen Wert dafür, daher ist eine Implementation auf jeder Subklasse unnötig.
        /// Sollte dennoch eine Funktion aus versehen aufgerufen werden, ist eine Fehelrbehandlung möglich.
        /// </summary>
        public virtual double GetBiegeWiderstandsMoment_Wx()
        {
            throw new NotImplementedException("Schade! :(");
        }

        /// <summary>
        /// Ermöglicht die sichere Verwendung eines entsprechenden Textfeldes.
        /// Nicht alle Profile haben einen Wert dafür, daher ist eine Implementation auf jeder Subklasse unnötig.
        /// Sollte dennoch eine Funktion aus versehen aufgerufen werden, ist eine Fehelrbehandlung möglich.
        /// </summary>
        public virtual double GetBiegeWiderstandsMoment_Wy()
        {
            throw new NotImplementedException("Schade! :(");
        }

        /// <summary>
        /// Berechnet das (Material-)Volumen des Profils mithilfe gegebener Methoden der Subklassen.
        /// </summary>
        /// <returns>(Material-)Volmumen des Profils</returns>
        virtual public double GetVolumen()
        {
            return GetFlaecheninhalt() * GetLaenge();
        }

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
