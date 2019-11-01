using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profil_Rechner_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            int option =0;

            Console.WriteLine("Bitte wählen Sie einen Profiltyp aus. Tippen Sie '1' für Rechteck oder '2' für Kreis");
            option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Rechteck();
                    break;
                case 2:
                    Kreis();
                    break;
                default:
                    Console.WriteLine("Eingabe ungültig");
                    Console.ReadLine();
                    break;
            }

        }

        static void Rechteck()
        {
            double zBreite;
            double zLänge;
            double zHöhe;

            // Eingabe
            Console.WriteLine("Bitte geben Sie die Werte in Meter für Ihr Rechteckprofil ein.");
            Console.Write("Breite:");
            zBreite = Convert.ToDouble(Console.ReadLine());
            Console.Write("Länge:");
            zLänge = Convert.ToDouble(Console.ReadLine());
            Console.Write("Höhe:");
            zHöhe = Convert.ToDouble(Console.ReadLine());
            Console.ReadLine();

            // Ausgabe

            Console.WriteLine("Ergebnisse");
            Console.ReadLine();
            Console.WriteLine("Fläche:" + FlächenRechner(zBreite, zLänge) + " m²");
            Console.WriteLine("Volumen:" + VolumenRechner(zBreite, zLänge, zHöhe) + " m³");
            Console.WriteLine("Oberfläche:" + OberflächenRechner(zBreite, zLänge, zHöhe) + " m²");
            Console.WriteLine("Gewicht:" + GewichtRechner(zBreite, zLänge, zHöhe, 7900) + " kg");
            Console.ReadLine();
        }

        //TODO WiP
        static void Kreis()
        {
            Console.WriteLine("Schade, noch nicht da :(");
            Console.ReadLine();
        }

        // Fläche errechnen lassen
        static double FlächenRechner (double zBreite, double zLänge)
        {
            double eFläche;
            return eFläche = zBreite * zLänge;
        }
        // volumen berechnen
        static double VolumenRechner(double zBreite, double zLänge, double zHöhe)
        {
            double eVolumen;
            return eVolumen = zBreite * zLänge * zHöhe ;
        }
        //Gewicht berechnen
        static double GewichtRechner(double zBreite, double zLänge, double zHöhe, double zDichte)
        {
            double eGewicht;
            return eGewicht = zBreite * zLänge * zHöhe * zDichte ;
        }
        // Oberfläche berechnen lassen
        static double OberflächenRechner(double zBreite, double zLänge, double zHöhe)
        {
            double eOber;
            return eOber = 2*(zBreite * zLänge + zLänge * zHöhe + zBreite * zHöhe) ;
        }
    }
}
