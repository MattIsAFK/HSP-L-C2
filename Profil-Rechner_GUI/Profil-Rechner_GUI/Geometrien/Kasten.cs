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

        private double zBreite1;
        private double zBreite2;
        private double zHoehe1;
        private double zHoehe2;

        /// Erzeugt einen Kasten mit allen Variablen 0

        public Kasten() : this(0, 0, 0, 0, 0) { }

        /// <summary>
        /// Erzeugt einen neuen Kasten mit den vorherigen Maßen und der Laenge 0
        /// </summary>
        /// <param name="pBreite1"></param>
        /// <param name="pHoehe1"></param>
        /// <param name="pBreite2"></param>
        /// <param name="pHoehe2"></param> 

        public Kasten(double pBreite1, double pHoehe1, double pBreite2, double pHoehe2) : this(pBreite1, pHoehe1, pBreite2, pHoehe2, 0) { }

        /// <summary>
        /// Erzeugt einen neuen Kasten mit den jeweiligen Maßen
        /// </summary>
        /// <param name="pBreite1"></param>
        /// <param name="pHoehe1"></param>
        /// <param name="pBreite2"></param>
        /// <param name="pHoehe2"></param>
        /// <param name="pLaenge"></param>

        public Kasten(double pBreite1, double pHoehe1, double pBreite2, double pHoehe2, double pLaenge) : base(pLaenge)
        {
            this.SetBreite1(pBreite1);
            this.SetHoehe1(pHoehe1);
            this.SetBreite2(pBreite2);
            this.SetHoehe2(pHoehe2);
        }


        /// <summary>
        /// Berechnet den Flaecheninhalt des Kastens mit den global verfuegbaren Parametern der Klasse.
        /// </summary>
        /// <return>Flaecheninhalt des Kastenprofils</return>

        public override double GetFlaecheninhalt()
        {

            return (GetHoehe1() *  )


            //throw new NotImplementedException();
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
        /// Aus den gegebenen Paramnetern wird die Mantelflaeche eines Kastenprofils berechnet.
        /// </summary>
        /// <returns>Oberflaeche</returns>
        public double Mantelflaeche()
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

        public void SetBreite1(double pBreite1)
        {
            throw new NotImplementedException();
        }

        public void SetHoehe1(double pHoehe1)
        {
            throw new NotImplementedException();
        }
        public void SetBreite2(double pBreite2)
        {
            throw new NotImplementedException();
        }

        public void SetHoehe2(double pHoehe2)
        {
            throw new NotImplementedException();
        }

    }
}
