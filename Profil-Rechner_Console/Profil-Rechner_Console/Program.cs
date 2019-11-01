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
            // Auswahl Variabeln
            int AuswahlProfil;



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
            /// Variabeln für Vierkantprofil
            double zBreite;
            double zLänge;
            double zHöhe;
         


                // Eingabe Vierkantprofil
                Console.WriteLine("Bitte geben Sie die Werte in Meter für Ihr Rechteckprofil ein.");
                Console.Write("Breite:");
                zBreite = Convert.ToDouble(Console.ReadLine());
                Console.Write("Länge:");
                zLänge = Convert.ToDouble(Console.ReadLine());
                Console.Write("Höhe:");
                zHöhe = Convert.ToDouble(Console.ReadLine());
                Console.ReadLine();

                // Ausgabe Vierkantprofil

                Console.WriteLine("Ergebnisse");
                Console.ReadLine();
                Console.WriteLine("Fläche:" + VierKantFlächenRechner(zBreite, zLänge) + " m²");
                Console.WriteLine("Volumen:" + VierKantVolumenRechner(zBreite, zLänge, zHöhe) + " m³");
                Console.WriteLine("Oberfläche:" + VierKantOberflächenRechner(zBreite, zLänge, zHöhe) + " m²");
                Console.WriteLine("Gewicht:" + VierKantGewichtRechner(zBreite, zLänge, zHöhe, 7900) + " kg");
                Console.ReadLine();


        }
 

        ///////////////////////////////////////////////////////////////////////////////////////////
        //// Methoden
        // Fläche errechnen lassen Vierkantprofil
        static double VierKantFlächenRechner(double zBreite, double zLänge)
        {
            double eFläche;
            return eFläche = zBreite * zLänge;
        }


        //TODO WiP
        static void Kreis()
        {
        double kRadius;
        double kLänge;
        /// Eingabe Kreisprofil
        /// 
        Console.WriteLine("Bitte geben Sie die Werte in Meter für Ihr Kreisprofil ein.");
        Console.Write("Radius:");
        kRadius = Convert.ToDouble(Console.ReadLine());
        Console.Write("Länge:");
        kLänge = Convert.ToDouble(Console.ReadLine());
        Console.ReadLine();

        ///Ausgabe Kreisprofil

        Console.WriteLine("Ergebnisse");
        Console.ReadLine();

        Console.WriteLine("Volumen:" + KreisVolumenRechner(kRadius, kLänge) + " m³");
        Console.WriteLine("Oberfläche:" + KreisOberflächenRechner(kRadius, kLänge) + " m²");
        Console.WriteLine("Mantelfläche:" + KreisMantelflächeRechner(kRadius, kLänge) + " m²");
        Console.WriteLine("Grundfläche:" + KreisGrundflächeRechner(kRadius) + " m²");
        Console.WriteLine("Gewicht:" + KreisGewichtRechner(kRadius, kLänge) + " kg");
        Console.ReadLine();
    }


        // volumen berechnen Vierkantprofil
        static double VierKantVolumenRechner(double zBreite, double zLänge, double zHöhe)
        {
            double eVolumen;
            return eVolumen = zBreite * zLänge * zHöhe;
        }
        //Gewicht berechnen Vierkantprofil
        static double VierKantGewichtRechner(double zBreite, double zLänge, double zHöhe, double zDichte)
        {
            double eGewicht;
            return eGewicht = zBreite * zLänge * zHöhe * zDichte;
        }
        // Oberfläche berechnen lassen Vierkantprofil
        static double VierKantOberflächenRechner(double zBreite, double zLänge, double zHöhe)
        {
            double eOber;
            return eOber = 2 * (zBreite * zLänge + zLänge * zHöhe + zBreite * zHöhe);
        }
        // Volumen berechnen Kreisprofil
        static double KreisVolumenRechner(double kRadius, double kLänge)
        {
            double eVolumen;
            double Pi = 3.141592;
            return eVolumen = Pi * (kRadius * kRadius) * kLänge;

        }
        // Oberfläche berechnen Kreiprofil
        static double KreisOberflächenRechner(double kRadius, double kLänge)
        {
            double eOber;
            double Pi = 3.141592;
            return eOber = 2 * Pi * kRadius * (kRadius + kLänge);
        }
        // Mantelfläche berechnen Kreisprofil
        static double KreisMantelflächeRechner(double kRadius, double kLänge)
        {
            double eMantel;
            double Pi = 3.141592;
            return eMantel = 2 * Pi * kRadius * kLänge;
        }
        // Grundfläche berechnen Kreisprofil
        static double KreisGrundflächeRechner(double kRadius )
        {
            double eGrund;
            double Pi = 3.141592;
            return eGrund =  Pi * kRadius * kRadius;
        }
        //Gewicht berechnen Kreisprofil
        static double KreisGewichtRechner(double kRadius, double kLänge)
        {
            double eGewicht;
            double Pi = 3.141592;
            return eGewicht = (Pi * (kRadius * kRadius) * kLänge) *7900;
        }
    }
}