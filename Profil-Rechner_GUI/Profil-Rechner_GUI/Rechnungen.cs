using System;
using System.Windows;
using Testat;

namespace Profil_Rechner_GUI
{
    static class Rechnungen
    {
        public static bool Ueberpruefen(string strZahl)
        {
            if (strZahl.Contains("."))
            {
                MessageBox.Show("Die Eingabe darf kein Punkt enthalten.", "Falsche Eingabe", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }

            if (!int.TryParse(strZahl, out var number))
            {
                MessageBox.Show("Die Eingabe muss nummerisch sein.", "Falsche Eingabe", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }

            if (number < 0)
            {
                MessageBox.Show("Die Eingabe muss positiv sein.", "Falsche Eingabe", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }

            return true;
        }


        private static MainWindow MW;


        public static double fRechteck(string strZahl1, string strZahl2, string strZahl3)
        {
            //eingaben überprüfen
            if (!Ueberpruefen(strZahl1)) return 0;
            if (!Ueberpruefen(strZahl2)) return 0;
            if (!Ueberpruefen(strZahl3)) return 0;

            //cast in double
            double dZahl1R = double.Parse(strZahl1);
            double dZahl2R = double.Parse(strZahl2);
            double dZahl3R = double.Parse(strZahl3);


            // Deklaration der Variabeln
            double volRechteck = dZahl1R * dZahl2R * dZahl3R;

            return volRechteck;
        }

        public static double fKasten(string strZahl1, string strZahl2, string strZahl3, string strZahl4, string strZahl5)
        {

            //eingaben überprüfen
            if (!Ueberpruefen(strZahl1)) return 0;
            if (!Ueberpruefen(strZahl2)) return 0;
            if (!Ueberpruefen(strZahl3)) return 0;
            if (!Ueberpruefen(strZahl4)) return 0;
            if (!Ueberpruefen(strZahl5)) return 0;

            //cast in double
            double dZahl1K = double.Parse(strZahl1);
            double dZahl2K = double.Parse(strZahl2);
            double dZahl3K = double.Parse(strZahl3);
            double dZahl4K = double.Parse(strZahl4);
            double dZahl5K = double.Parse(strZahl5);

            if (dZahl3K > dZahl1K)
                MessageBox.Show("Der Wert  für b ist größer als der Wert für B.", "Ungültiger Wert", MessageBoxButton.OK, MessageBoxImage.Warning);
            else if (dZahl4K > dZahl2K)
                MessageBox.Show("Der Wert  für > h < ist größer als der Wert für > H <.", "Ungültiger Wert", MessageBoxButton.OK, MessageBoxImage.Warning);

            // Volumen berechnen
            var vol1 = dZahl1K * dZahl2K * dZahl5K; // Großes Rechteck
            var vol2 = dZahl3K * dZahl4K * dZahl5K; // kleines Rechteck
            var volKasten = vol1 - vol2; // Großes minus kleines Rechteck

            return volKasten;
        }

        public static double fSechseck(string strZahl1, string strZahl2)
        {
            //eingaben überprüfen
            if (!Ueberpruefen(strZahl1)) return 0;
            if (!Ueberpruefen(strZahl2)) return 0;

            //cast in double
            double r = double.Parse(strZahl1);
            double l = double.Parse(strZahl2);

            var vol = r * r * 3d / 2d * Math.Sqrt(3) * l;
            return vol;
        }

        public static double fKreis(string strZahl1, string strZahl2)
        {
            //eingaben überprüfen
            if (!Ueberpruefen(strZahl1)) return 0;
            if (!Ueberpruefen(strZahl2)) return 0;

            //cast in double
            double r = double.Parse(strZahl1);
            double l = double.Parse(strZahl2);

            var vol = Math.PI * r * r * l;
            return vol;
        }

        public static double fDreieck(string strZahl1, string strZahl2, string strZahl3)
        {
            //eingaben überprüfen
            if (!Ueberpruefen(strZahl1)) return 0;
            if (!Ueberpruefen(strZahl2)) return 0;
            if (!Ueberpruefen(strZahl3)) return 0;

            //cast in double
            double b = double.Parse(strZahl1);
            double h = double.Parse(strZahl2);
            double l = double.Parse(strZahl3);

            var vol = b * h / 2 * l;
            return vol;
        }

        //="itmTräger" 
        //de Profile" F

    }
}
