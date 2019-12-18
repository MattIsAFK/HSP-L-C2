using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profil_Rechner_GUI.Geometrien
{
    class Traeger : Geometrie
    {
        /// Variabeln für ein Traegerprofil

        private double zBreite;
        private double zHoehe;

        /// Erzeugt einen Traeger mit allen Variablen 0

        public Traeger() : this(0, 0, 0) { }

        /// <summary>
        /// Erzeugt einen neuen Traeger mit den vorherigen Maßen und der Laenge 0
        /// </summary>
        /// <param name="pBreite"></param>
        /// <param name="pHoehe"></param>

        public Traeger(double pBreite, double pHoehe) : this(pBreite, pHoehe, 0) { }

        /// <summary>
        /// Erzeugt einen neuen Traeger mit den jeweiligen Maßen
        /// </summary>
        /// <param name="pBreite"></param>
        /// <param name="pHoehe"></param>
        /// <param name="pLaenge"></param>

        public Traeger(double pBreite, double pHoehe, double pLaenge) : base(pLaenge)
        {
            this.SetBreite(pBreite);
            this.SetHoehe(pHoehe);
        }

        /// <summary>
        /// Berechnet den Flaecheninhalt des Traegers mit den global verfuegbaren Parametern der Klasse.
        /// </summary>
        /// <return>Flaecheninhalt des Traegerprofils</return>

        public override double GetFlaecheninhalt()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Berechnet die Flaechentraegheit des Traegerprofils mit den global verfügbaren Parametern der Klasse.
        /// </summary>
        /// <return>Flaechentraegheit des Traegerprofils</return>

        public override double[] GetFlaechenTraegheit()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Aus den gegebenen Paramnetern wird die Oberflaeche eines Traegerprofils berechnet.
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
