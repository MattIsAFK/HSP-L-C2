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
            // Auswahl Variable
            int auswahlProfil = 0;
            Boolean checkmate = true;

            Console.WriteLine("Bitte wählen Sie einen Profiltyp aus. Tippen Sie '1' für Rechteck oder '2' für Kreis");
            do
            {
                try
                {
                    auswahlProfil = Convert.ToInt32(Console.ReadLine());

                    switch (auswahlProfil)
                    {
                        case 1:
                            Rechteck();
                            break;
                        case 2:
                            Kreis();
                            break;
                        default:
                            throw new ArgumentOutOfRangeException("Eingabe muss '1' oder '2' sein!");
                    }
                    checkmate = false;
                }
                catch (FormatException) { Console.WriteLine("Numerische Eingabe erforderlich"); }
                catch (ArgumentOutOfRangeException e) { Console.WriteLine(e.Message); }
            }while (checkmate);
        }

        static void Rechteck()
        {

            Rechteck myRechteck = new Rechteck();
            Boolean checkmate = true;
            // Eingabe Vierkantprofil
            Console.WriteLine("Bitte geben Sie die Werte in Meter für Ihr Rechteckprofil ein.");
            do
            {
                Console.Write("Breite:");
                try
                {
                    myRechteck.SetBreite(Convert.ToDouble(Console.ReadLine()));
                    checkmate = false;
                }
                catch (FormatException) { Console.WriteLine("Ungültige Eingabe. Nur numerische Zahlenwerte!"); }
                catch (ArgumentOutOfRangeException e) { Console.WriteLine(e.Message); }
            } while (checkmate);
            checkmate = true;
            do
            {
                Console.Write("Länge:");
                try
                {   
                    myRechteck.SetLaenge(Convert.ToDouble(Console.ReadLine()));
                    checkmate = false;
                }
                catch (FormatException) { Console.WriteLine("Ungültige Eingabe. Nur numerische Zahlenwerte!"); }
            } while (checkmate);
            checkmate = true;
            do
            {
                Console.Write("Höhe:");
                try
                {
                    myRechteck.SetHoehe(Convert.ToDouble(Console.ReadLine()));
                    checkmate = false;
                }
                catch (FormatException) { Console.WriteLine("Ungültige Eingabe. Nur numerische Zahlenwerte!"); }
                 
            } while (checkmate);
            
            Console.ReadLine();       

          
  

            // Ausgabe Vierkantprofil

            Console.WriteLine("Ergebnisse");

            try { Console.WriteLine("Fläche:" + myRechteck.GetFlaecheninhalt() + " m²"); } catch (Exception) {}
            try { Console.WriteLine("Volumen:" + myRechteck.GetVolumen() + " m³"); } catch (Exception) { }
            //Console.WriteLine("Oberfläche:" + VierKantOberflächenRechner(zBreite, zLänge, zHöhe) + " m²");
            //Console.WriteLine("Gewicht:" + VierKantGewichtRechner(zBreite, zLänge, zHöhe, 7900) + " kg");
            Console.ReadLine();


        }
 

        ///////////////////////////////////////////////////////////////////////////////////////////
        //// Methoden

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

        // Volumen berechnen Kreisprofil
        static double KreisVolumenRechner(double kRadius, double kLänge)
        {
            double eVolumen;
            return eVolumen = Math.PI * (kRadius * kRadius) * kLänge;

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