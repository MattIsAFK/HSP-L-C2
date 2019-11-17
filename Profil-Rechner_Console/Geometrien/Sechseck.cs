using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profil_Rechner_Console.Geometrien
{
    class Sechseck:Geometrie 
    {        
        /// Variabeln für Sechseckprofil
        private double zSeitenlaenge;
      
        /// <summary>
        /// Erzeugt ein neues Sechseck bei dem alle Variablen auf 0 gesetzt werden. 
        /// </summary>
        public Sechseck() : this(0,0) { }

        /// <summary>
        /// Erzeugt ein neues Sechseck mit den übergeben Maßen.
        /// Die Länge des Profils wird 0 gesetzt.
        /// </summary>
        /// <param name="pSeitenlaenge"></param>
       
        public Sechseck(double pSeitenlaenge, double plaenge) : this(pSeitenlaenge) { }


        /// <summary>
        /// Erstellt ein neues Sechseck mit den entsprechenden Maßen
        /// </summary>
        /// <param name="pSeitenlaenge">Seitenlaenge des Sechseck</param>
        /// <param name="pLaenge">Länge des Profils</param>
        public Sechseck(double pSeitenlaenge) : base(pSeitenlaenge)
        {
            this.setSeitenlaenge(pSeitenlaenge);
           
        }

        public override double GetFlaecheninhalt()
        {
            double qua = 2;
            double x = 1.5;
            return (Math.Pow(getSeitenlaenge(), qua) * Math.Sqrt(3) *x);
        }

        public override double GetFlachenTraegheit()
        {
            throw new NotImplementedException();
        }

        public override double GetVolumen()
        {
            double eVolumen = GetLaenge() * GetFlaecheninhalt();
            return eVolumen;
        }
    

        /// <summary>
        /// Getter für das Feld Seitenlaenge des Sechseck.
        /// </summary>
        /// <returns>Seitenlaenge des Sechseck</returns>
        public double getSeitenlaenge()
        {
            return zSeitenlaenge;
        }
           /// <summary>
        /// Überprüft, dass der übergebene Parameter nicht negativ ist.
        /// Im positiven Fall wird die Objektvariable entsprechend gesetzt, andernfalls eine Exception geworfen
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <param name="pSeitenlaenge">Seitenlaenge des Sechsecks</param>
        public void setSeitenlaenge(double pSeitenlaenge)
        {
            if (pSeitenlaenge >= 0) zSeitenlaenge = pSeitenlaenge;
            else throw new ArgumentOutOfRangeException("Seitenlaenge muss einen positiven Wert annehmen");
        }
        
    }
    
}
