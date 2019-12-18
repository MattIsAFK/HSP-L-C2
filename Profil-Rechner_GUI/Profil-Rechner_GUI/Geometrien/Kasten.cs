using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profil_Rechner_GUI.Geometrien
{
    class Kasten:Geometrie
    {

        /// Variabeln für ein Kastenprofil

        private double zBreite;
        private double zHoehe;

        /// Erzeugt einen Kasten mit allen Variablen 0

        public Kasten() : this(0, 0, 0) { }

        /// <summary>
        /// Erzeugt einen neuen Kasten mit den vorherigen Maßen und der Laenge 0
        /// </summary>
        /// <param name="pBreite"></param>
        /// <param name="pHoehe"></param>

        public Kasten(double pBreite, double pHoehe) : this(pBreite, pHoehe, 0) { }

        /// <summary>
        /// Erzeugt einen neuen Kasten mit den jeweiligen Maßen
        /// </summary>
        /// <param name="pBreite"></param>
        /// <param name="pHoehe"></param>
        /// <param name="pLaenge"></param>

        public Kasten(double pBreite, double pHoehe, double pLaenge) : base(pLaenge)
        {
            this.SetBreite(pBreite);
            this.SetHoehe(pHoehe);
        }


        /// <summary>
        /// Berechnet den Flaecheninhalt des Kastens mit den global verfuegbaren Parametern der Klasse.
        /// </summary>
        /// <return>Flaecheninhalt des Kastenprofils</return>

        public override double GetFlaecheninhalt()
        {
            throw new NotImplementedException();
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
        /// Aus den gegebenen Paramnetern wird die Oberflaeche eines Kastenprofils berechnet.
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
