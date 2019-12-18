using System;
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
        private double zHoehe;
        private double zLaenge;

        /// Erzeugt ein Sechseck mit allen Variablen 0

        public Sechseck() : this(0, 0, 0) { }

        /// <summary>
        /// Erzeugt ein neues Sechseck mit den vorherigen Maßen und der Laenge 0
        /// </summary>
        /// <param name="pBreite"></param>
        /// <param name="pHoehe"></param>

        public Sechseck(double pBreite, double pHoehe) : this(pBreite, pHoehe, 0) { }

        /// <summary>
        /// Erzeugt ein neues Sechseck mit den jeweiligen Maßen
        /// </summary>
        /// <param name="pBreite"></param>
        /// <param name="pHoehe"></param>
        /// <param name="pLaenge"></param>

        public Sechseck(double pBreite, double pHoehe, double pLaenge) : base(pLaenge)
        {
            this.SetBreite(pBreite);
            this.SetHoehe(pHoehe);
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
        /// Aus den gegebenen Paramnetern wird die Oberflaeche eines Kreisprofils berechnet.
        /// </summary>
        /// <returns>Oberflaeche</returns>
        public double GetOberflaeche()
        {
            throw new NotImplementedException();
        }

        public void SetBreite(double pBreite)
        {
            throw new NotImplementedException();
        }

        public void SetHoehe(double pHoehe)
        {
            throw new NotImplementedException();
        }

    }
}
