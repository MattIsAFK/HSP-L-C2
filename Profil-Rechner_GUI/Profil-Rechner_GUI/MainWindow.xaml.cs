using System;
using System.Windows;
using System.Windows.Controls;
using Profil_Rechner_GUI.Geometrien;

namespace Profil_Rechner_GUI
{
    public partial class MainWindow
    {
        private Geometrie _Geo;
                

        private static double SafeCast(string text)
        {
            if (!double.TryParse(text, out double result)) return 0;
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        private void HideControls()
        {
            // Auswahl der ImageBox
            IBKasten.Visibility = Visibility.Hidden;
            IBRechteck.Visibility = Visibility.Hidden;
            IBSechseck.Visibility = Visibility.Hidden;
            IBDreieck.Visibility = Visibility.Hidden;
            IBTräger.Visibility = Visibility.Hidden;
            IBKreis.Visibility = Visibility.Hidden;


            // ***Anpassen des Fensters***

            // *Textboxen*
            txt1.Visibility = Visibility.Hidden;
            txt2.Visibility = Visibility.Hidden;
            txt3.Visibility = Visibility.Hidden;
            txt4.Visibility = Visibility.Hidden;
            txtLäng.Visibility = Visibility.Visible;
            txtVol.Visibility = Visibility.Visible;

            // *Label*
            lbZahl1.Visibility = Visibility.Hidden;
            lbZahl2.Visibility = Visibility.Hidden;
            lbZahl3.Visibility = Visibility.Hidden;
            lbZahl4.Visibility = Visibility.Hidden;
            lbLänge.Visibility = Visibility.Hidden;
            lbVol.Visibility = Visibility.Hidden;
        }

        public void trvProfil_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            TreeViewItem selectedItem = (TreeViewItem)trvProfil.SelectedItem;

            switch (selectedItem.Name)
            {
                case "itmRechteck":
                    {
                        HideControls();

                        // Auswahl der ImageBox
                        IBRechteck.Visibility = Visibility.Visible;

                        // ***Anpassen des Fensters***

                        // *Textboxen*
                        txt1.Visibility = Visibility.Visible;
                        txt2.Visibility = Visibility.Visible;
                        txtLäng.Visibility = Visibility.Visible;
                        txtVol.Visibility = Visibility.Visible;

                        // *Label*
                        lbZahl1.Visibility = Visibility.Visible;
                        lbZahl2.Visibility = Visibility.Visible;
                        lbLänge.Visibility = Visibility.Visible;
                        lbVol.Visibility = Visibility.Visible;

                        // *Content der Label*
                        lbZahl1.Content = "h";
                        lbZahl2.Content = "b";

                        // *Tooltips der Textboxen*
                        txt1.ToolTip = "Wert für 'h' eingeben";
                        txt2.ToolTip = "Wert für 'b' eingeben";
                        txtLäng.ToolTip = "Wert für die Länge eingeben";

                        break;
                    }

                case "itmDreieck":
                    {
                        HideControls();

                        // Auswahl der ImageBox
                        IBDreieck.Visibility = Visibility.Visible;

                        // ***Anpassen des Fensters***

                        // *Textboxen*
                        txt1.Visibility = Visibility.Visible;
                        txt2.Visibility = Visibility.Visible;
                        txtLäng.Visibility = Visibility.Visible;
                        txtVol.Visibility = Visibility.Visible;

                        // *Label*
                        lbZahl1.Visibility = Visibility.Visible;
                        lbZahl2.Visibility = Visibility.Visible;
                        lbLänge.Visibility = Visibility.Visible;
                        lbVol.Visibility = Visibility.Visible;

                        // *Content der Label*
                        lbZahl1.Content = "b";
                        lbZahl2.Content = "h";

                        // *Tooltips der Textboxen*
                        txt1.ToolTip = "Wert für 'b' eingeben";
                        txt2.ToolTip = "Wert für 'h' eingeben";
                        txtLäng.ToolTip = "Wert für die Länge eingeben";

                        break;
                    }

                case "itmKasten":
                    {
                        HideControls();


                        // Auswahl der ImageBox
                        IBKasten.Visibility = Visibility.Visible;

                        // ***Anpassen des Fensters***

                        // *Textboxen*
                        txt1.Visibility = Visibility.Visible;
                        txt2.Visibility = Visibility.Visible;
                        txt3.Visibility = Visibility.Visible;
                        txt4.Visibility = Visibility.Visible;
                        txtLäng.Visibility = Visibility.Visible;
                        txtVol.Visibility = Visibility.Visible;

                        // *Label*
                        lbZahl1.Visibility = Visibility.Visible;
                        lbZahl2.Visibility = Visibility.Visible;
                        lbZahl3.Visibility = Visibility.Visible;
                        lbZahl4.Visibility = Visibility.Visible;
                        lbLänge.Visibility = Visibility.Visible;
                        lbVol.Visibility = Visibility.Visible;

                        // *Content der Label*
                        lbZahl1.Content = "B";
                        lbZahl2.Content = "H";
                        lbZahl3.Content = "b";
                        lbZahl4.Content = "h";

                        // *Tooltips der Textboxen*
                        txt1.ToolTip = "Wert für 'B' eingeben";
                        txt2.ToolTip = "Wert für 'H' eingeben";
                        txt3.ToolTip = "Wert für 'b' eingeben";
                        txt4.ToolTip = "Wert für 'h' eingeben";
                        txtLäng.ToolTip = "Wert für die Länge des Profils eingeben";

                        break;
                    }

                case "itmSechseck":
                    {
                        HideControls();


                        // Auswahl der ImageBox
                        IBSechseck.Visibility = Visibility.Visible;

                        // ***Anpassen des Fensters***

                        // *Textboxen*
                        txt1.Visibility = Visibility.Visible;
                        txtLäng.Visibility = Visibility.Visible;
                        txtVol.Visibility = Visibility.Visible;

                        // *Label*
                        lbZahl1.Visibility = Visibility.Visible;
                        lbLänge.Visibility = Visibility.Visible;
                        lbVol.Visibility = Visibility.Visible;

                        // *Content der Label*
                        lbZahl1.Content = "R";
                        lbLänge.Content = "Länge";

                        // *Tooltips der Textboxen*
                        txt1.ToolTip = "Wert für 'R' eingeben";
                        txtLäng.ToolTip = "Wert für die Länge eingeben";

                        break;
                    }

                case "itmTräger":
                    {
                        HideControls();


                        // Auswahl der ImageBox
                        IBTräger.Visibility = Visibility.Visible;

                        // ***Anpassen des Fensters***

                        // *Textboxen*
                        txt1.Visibility = Visibility.Visible;
                        txt2.Visibility = Visibility.Visible;
                        txt3.Visibility = Visibility.Visible;
                        txt4.Visibility = Visibility.Visible;
                        txtLäng.Visibility = Visibility.Visible;
                        txtVol.Visibility = Visibility.Visible;

                        // *Label*
                        lbZahl1.Visibility = Visibility.Visible;
                        lbZahl2.Visibility = Visibility.Visible;
                        lbZahl3.Visibility = Visibility.Visible;
                        lbZahl4.Visibility = Visibility.Visible;
                        lbLänge.Visibility = Visibility.Visible;
                        lbVol.Visibility = Visibility.Visible;

                        // *Content der Label*
                        lbZahl1.Content = "B";
                        lbZahl2.Content = "H";
                        lbZahl3.Content = "b";
                        lbZahl4.Content = "h";
                        lbLänge.Content = "Länge";

                        // *Tooltips der Textboxen*
                        txt1.ToolTip = "Wert für 'B' eingeben";
                        txt2.ToolTip = "Wert für 'H' eingeben";
                        txt3.ToolTip = "Wert für 'b' eingeben";
                        txt4.ToolTip = "Wert für 'h' eingeben";
                        txtLäng.ToolTip = "Wert für die Länge eingeben";

                        break;
                    }
                case "itmKreis":
                    {
                        HideControls();


                        // Auswahl der ImageBox
                        IBKreis.Visibility = Visibility.Visible;

                        // ***Anpassen des Fensters***

                        // *Textboxen*
                        txt1.Visibility = Visibility.Visible;
                        txtLäng.Visibility = Visibility.Visible;
                        txtVol.Visibility = Visibility.Visible;

                        // *Label*
                        lbZahl1.Visibility = Visibility.Visible;
                        lbLänge.Visibility = Visibility.Visible;
                        lbVol.Visibility = Visibility.Visible;

                        // *Content der Label*
                        lbZahl1.Content = "R";

                        // *Tooltips der Textboxen*
                        txt1.ToolTip = "Wert für R (Radius) eingeben";
                        txtLäng.ToolTip = "Wert für die Länge eingeben";

                        break;
                    }
                default:
                    {
                        lbProfil.Visibility = Visibility.Hidden;
                        bnRechne.IsEnabled = false;

                        bnCatia.IsEnabled = false;

                        MessageBox.Show("Dieses Profil wurde noch nicht programmiert.", "Work in Progress", MessageBoxButton.OK, MessageBoxImage.Error);
                        return;
                    }
            }
            // ***Leeren der Textboxen***
            txt1.Clear();
            txt2.Clear();
            txt3.Clear();
            txt4.Clear();
            txtLäng.Clear();
            txtVol.Clear();

            // **Überschrift einstellen
            lbProfil.Visibility = Visibility.Visible;
            lbProfil.Content = ((TreeViewItem)trvProfil.SelectedItem).Header;

            // **Button "Berechnen" aktiv und default setzen
            bnRechne.IsEnabled = true;
            bnRechne.IsDefault = true;

            // **Buton CATIA deaktivieren
            bnCatia.IsEnabled = false;
        }

        private void bnRechne_Click(object sender, RoutedEventArgs e)
        {
            var selectedItem = (TreeViewItem)trvProfil.SelectedItem;

            /* Deklaration der Variabeln
            string strZahl1;
            string strZahl2;
            string strZahl3;
            string strZahl4;
            string strZahl5;
            */

            txtVol.Visibility = Visibility.Visible; // Textbox vom Volumen sichtbar machen

            // Starten der Berechnungen
            try
            {
                switch (selectedItem.Name)
                {
                    case "itmKasten":
                        {
                            /*
                            strZahl1 = txt1.Text; // B
                            strZahl2 = txt2.Text; // H
                            strZahl3 = txt3.Text; // b
                            strZahl4 = txt4.Text; // h
                            strZahl5 = txtLäng.Text; // Höhe

                            // Ausgabe
                            txtVol.Text = Rechnungen.fKasten(strZahl1, strZahl2, strZahl3, strZahl4, strZahl5).ToString("#.###");

                            */

                            //Klasse Kasten existiert noch nicht
                            //Geo = new Kasten(Convert.ToDouble(txt1.Text),Convert.ToDouble(txt2.Text),Convert.ToDouble(txt3.Text),Convert.ToDouble(txt4.Text), Convert.ToDouble(txtLäng.Text));

                            break;
                        }

                    case "itmRechteck":
                        {

                            /*
                            strZahl1 = txt1.Text; // a
                            strZahl2 = txt2.Text; // b
                            strZahl3 = txtLäng.Text; // Höhe



                            // Ausgabe
                            txtVol.Text = Rechnungen.fRechteck(strZahl1, strZahl2, strZahl3).ToString("#.###");
                            */
                            Geo = new Rechteck(Convert.ToDouble(txt1.Text),Convert.ToDouble(txt2.Text), Convert.ToDouble(txtLäng.Text));
                            break;
                        }
                    case "itmDreieck":
                        {
                            /*
                            strZahl1 = txt1.Text; // b
                            strZahl2 = txt2.Text; // h
                            strZahl3 = txtLäng.Text; // Höhe

                            txtVol.Text = Rechnungen.fDreieck(strZahl1, strZahl2, strZahl3).ToString("#.###");
                            */

                           //Klasse Dreieck existiert noch nicht 
                           //Geo = new Dreieck(Convert.ToDouble(txt1.Text),Convert.ToDouble(txt2.Text), Convert.ToDouble(txtLäng.Text));
                           

                            break;
                        }
                    case "itmKreis":
                        {
                            /*
                            strZahl1 = txt1.Text; // r
                            strZahl2 = txtLäng.Text; // Höhe

                            txtVol.Text = Rechnungen.fKreis(strZahl1, strZahl2).ToString("#.###");
                            */

                            Geo = new Kreis(Convert.ToDouble(txt1.Text), Convert.ToDouble(txtLäng.Text));
                            break;
                        }
                    case "itmSecheck":
                        {
                            /*
                            strZahl1 = txt1.Text; // R
                            strZahl2 = txtLäng.Text; // Höhe

                            txtVol.Text = Rechnungen.fSechseck(strZahl1, strZahl2).ToString("#.###");
                            */

                            Geo = new Sechseck(Convert.ToDouble(txt1.Text), Convert.ToDouble(txtLäng.Text));
                            break;
                        }
                    default: return;
 
                }
                // throw new ConsistencyException("Was für ein Blödsinn");
            }
            catch(FormatException ex)
            {
                MessageBox.Show("Die Eingabe muss nummerisch sein."+Environment.NewLine+ex.Message,"Falsche Eingabe", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            catch(ArgumentOutOfRangeException ex)
            {
                MessageBox.Show( ex.Message, "Falsche Eingabe", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            catch(ConsistencyException ex)
            {
                MessageBox.Show(ex.Message, "Falsche Eingabe", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            txtVol.Text = Geo.GetVolumen().ToString();
            bnCatia.IsEnabled = true;
        }

        private void bnEnde_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Wollen Sie das Programm wirklich beenden ?", "Programmende", MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.No) == MessageBoxResult.Yes)
                System.Environment.Exit(0);
        }

        private void txt1_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtVol.Visibility = Visibility.Hidden;
        }

        private void bnCatia_Click(object sender, RoutedEventArgs e)
        {
            BalkenInCatia objBalkeninCatia = new BalkenInCatia();   // Objekt der class BalkeninCatia

            if (!objBalkeninCatia.CATIAläuft())
                MessageBox.Show("CATIA muss gestartet sein.", "CATIA-Fehler", MessageBoxButton.OK, MessageBoxImage.Error);
            else
            {
                // neues Part erstellen
                objBalkeninCatia.ErzeugePart();

                // neue Skizze im geometrischen Set des Part erzeugen
                objBalkeninCatia.ErzeugeSkizze();

                var selectedItem = (TreeViewItem)trvProfil.SelectedItem;

                // Profil in Skizze zeichnen
                switch (selectedItem.Name)
                {
                    case "itmRechteck":
                        {
                            double dHöhe = SafeCast(txt1.Text);
                            double dBreite = SafeCast(txt2.Text);

                            objBalkeninCatia.ErzeugeProfilRechteck(dHöhe, dBreite);
                            break;
                        }

                    case "itmKasten":
                        {
                            double dBreiteGroß = SafeCast(txt1.Text); // B
                            double dHöheGroß = SafeCast(txt2.Text); // H
                            double dBreiteKlein = SafeCast(txt3.Text); // b
                            double dHöheKlein = SafeCast(txt4.Text); // h

                            objBalkeninCatia.ErzeugeProfilKasten(dBreiteGroß, dHöheGroß, dBreiteKlein, dHöheKlein);
                            break;
                        }
                }

                switch (selectedItem.Name)
                {
                    case "itmRechteck":
                    case "itmKasten":
                    case "itmSechseck":
                        {
                            double dLänge = SafeCast(txtLäng.Text);
                            objBalkeninCatia.ErzeugeBlock(dLänge);
                            break;
                        }

                    default:
                        {
                            MessageBox.Show("Profil noch nicht unterstützt.", "CATIA-Fehler", MessageBoxButton.OK, MessageBoxImage.Warning);
                            break;
                        }
                }
            }
        }

        internal Geometrie Geo { get => _Geo; set => _Geo = value; }
    }
}