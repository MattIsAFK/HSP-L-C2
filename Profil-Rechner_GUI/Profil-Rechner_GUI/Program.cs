using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Profil_Rechner_GUI.Geometrien;

namespace Profil_Rechner_Console
{
    class Program
    {
        /*
        static void Main(string[] args)
        {
            // Auswahl Variable
            int auswahlProfil = 0;
            int runOrHide = 0; 
            bool masterCheck = true;
            bool checkmate = true;

            do {

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
                } while (checkmate);

                checkmate = true;
                Console.WriteLine("Tippen Sie '1' für ein neues Profil oder '2' um das Programm zu beenden");

                do
                {
                    try
                    {
                        runOrHide = Convert.ToInt32(Console.ReadLine());

                        switch (runOrHide)
                        {
                            case 1:
                                checkmate = false;
                                break;
                            case 2:
                                checkmate = false;
                                masterCheck = false;
                                break;
                            default:
                                throw new ArgumentOutOfRangeException("Eingabe muss '1' oder '2' sein!");
                        }
                    }
                    catch (FormatException) { Console.WriteLine("Numerische Eingabe erforderlich"); }
                    catch (ArgumentOutOfRangeException e) { Console.WriteLine(e.Message); }
                } while (checkmate);
            } while (masterCheck);
        }
        */

        static void Rechteck()
        {

            Rechteck myRechteck = new Rechteck();
            bool checkmate = true;
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
 

        /// <summary>
        /// Kreisprofil
        /// </summary>
        
        static void Kreis()
        {
            Kreis myKreis = new Kreis();
            bool checkmate = true;

         ///Eingabe der Parameter des Kreisprofils
         ///

            Console.WriteLine("Bitte geben Sie die Werte in Meter für Ihr Kreisprofil ein.");
            do
            {
                Console.Write("Radius:");
                try
                {
                    myKreis.SetRadius(Convert.ToDouble(Console.ReadLine()));
                    checkmate = false;
                }
                catch (FormatException) { Console.WriteLine("Ungültige Eingabe. Nur numerische Zahlenwerte!"); }
                catch (ArgumentOutOfRangeException e) { Console.WriteLine(e.Message); }
            } while (checkmate);

            checkmate = true;
            do
            {
                Console.Write("Laenge:");
                try
                {
                    myKreis.SetLaenge(Convert.ToDouble(Console.ReadLine()));
                    checkmate = false;
                }
                catch (FormatException) { Console.WriteLine("Ungueltige Eingabe. Nur numerische Zahlenwerte!"); }
            } while (checkmate);
           
            Console.ReadLine();


            /// Ausgabe der Parameter des Kreisprofils
            /// 

            try
            {
                Console.WriteLine("Flaeche:" + myKreis.GetFlaecheninhalt() + " m²");

            }
            catch (Exception) { }

                
            try
            {
                Console.WriteLine("Flaechentraegheit:" + myKreis.GetFlaechenTraegheit() + "m^4");
            }
            catch (Exception) { }

            try
            {
                Console.WriteLine("Volumen:" + myKreis.GetVolumen() + "m³");
            }
            catch (Exception) { }

            try
            {
                Console.WriteLine("Oberflaeche:" + myKreis.GetOberflaeche() + "m²");
            }
            catch (Exception) { }

            try
            {
                Console.WriteLine("Mantelflaeche:" + myKreis.GetMantelflaeche() + "m²");
            }
            catch (Exception) { }

          
       
        }

        ///<summary>
        /// Sechseckprofil
        /// </summary>

        static void Sechseck()
        {
            Sechseck mySechseck = new Sechseck();
            bool checkmate = true;

            ///Eingabe der Parameter des Sechseckprofils
            ///

            Console.WriteLine("Bitte geben Sie die Werte in Meter für Ihr Sechseckprofil ein.");
            do
            {
                Console.Write("Breite:");
                try
                {
                    mySechseck.SetBreite(Convert.ToDouble(Console.ReadLine()));
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
                    mySechseck.SetLaenge(Convert.ToDouble(Console.ReadLine()));
                    checkmate = false;
                }
                catch (FormatException) { Console.WriteLine("Ungültige Eingabe. Nur numerische Zahlenwerte!"); }
            } while (checkmate);
            
            Console.ReadLine();


            /// Ausgabe der Parameter des Sechseckprofils
            /// 

            try
            {
                Console.WriteLine("Flaeche:" + mySechseck.GetFlaecheninhalt() + " m²");

            }
            catch (Exception) { }


            try
            {
                Console.WriteLine("Flaechentraegheit:" + mySechseck.GetFlaechenTraegheit() + "m^4");
            }
            catch (Exception) { }

            try
            {
                Console.WriteLine("Volumen:" + mySechseck.GetVolumen() + "m³");
            }
            catch (Exception) { }

            try
            {
                Console.WriteLine("Oberflaeche:" + mySechseck.GetOberflaeche() + "m²");
            }
            catch (Exception) { }


        }


    }


}