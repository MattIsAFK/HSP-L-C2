using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        /// Erzeugt ein Objekt Kreis mti übergebenem Radius und derProfillänge 0.
        /// </summary>
        /// <param name="pRadius">Radius des Kreises</param>
        public Kreis(double pRadius) : this(pRadius, 0) { }
        /// <summary>
        /// Erzeugt einen neuen Kreis mit den übergebenen Parametern.
        /// </summary>
        /// <param name="pRadius">Radius des Kreises</param>
        /// <param name="pLaenge">Länge der Profilgeometrie</param>
        public Kreis(double pRadius, double pLaenge) : base(pLaenge)
        {
            setRadius(pRadius);
        }

        public override double GetFlaecheninhalt()
        {
            throw new NotImplementedException();
        }

        public override double GetFlachenTraegheit()
        {
            throw new NotImplementedException();
        }

        public override double GetVolumen()
        {
            throw new NotImplementedException();
        }

        public double getRadius()
        {
            throw new NotImplementedException();
        }

        public void setRadius(double pRadius)
        {
            throw new NotImplementedException();
        }


    }
}
