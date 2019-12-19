using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using INFITF;
using MECMOD;
using PARTITF;

namespace Profil_Rechner_GUI
{
    class CatiaConnection
    {
        private INFITF.Application _CatiaApplication;
        private MECMOD.PartDocument _PartDocument;
        private MECMOD.Sketch _ProfilSkizze;

        public CatiaConnection()
        {
            _CatiaApplication = null;
            _PartDocument = null;
            _ProfilSkizze = null;
            
        }

        public bool LaeuftCATIA()
        {
            try
            {
                //Kapselung in MEssage Box nur zu Testzwecken
                if(System.Runtime.InteropServices.Marshal.IsComObject(CatiaApplication))return true;
                return false;
            }
            catch (System.Runtime.InteropServices.COMException e)
            {
                MessageBox.Show("Keine Instanz von CATIA gefunden." + Environment.NewLine + e.Message, "Verbindungsfehler", MessageBoxButton.OK, MessageBoxImage.Warning);
                return false;
            }
            catch(Exception)
            {
                MessageBox.Show("Ein unerwarteter Fehler ist aufgetreten", "Fatality", MessageBoxButton.OK, MessageBoxImage.Warning);
                return false;
            }
        }

        public void VerbindeCATIA()
        {
            try
            {
                object catiaObject = System.Runtime.InteropServices.Marshal.GetActiveObject("CATIA.Application");
                CatiaApplication = (INFITF.Application)catiaObject;
            }
            catch (System.Runtime.InteropServices.COMException e)
            {
                MessageBox.Show("Keine Instanz von CATIA gefunden." + Environment.NewLine + e.Message, "Verbindungsfehler", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

        }

        public void PrepareCATIA()
        {
            CreatePart(out PartDocument value);
            PartDocument = value;
            ProfilSkizze = ErstelleLeereSkizze();
            ErzeugeAchsensystem(ref GetProfilSkizze());

        }


        public Sketch ErstelleLeereSkizze()
        {
            // geometrisches Set auswaehlen und umbenennen
            HybridBodies catHybridBodies1 = PartDocument.Part.HybridBodies;
            HybridBody catHybridBody1;
            try
            {
                catHybridBody1 = catHybridBodies1.Item("Geometrisches Set.1");
            }
            catch (Exception)
            {
                MessageBox.Show("Kein geometrisches Set gefunden! " + Environment.NewLine +
                    "Ein PART manuell erzeugen und ein darauf achten, dass 'Geometrisches Set' aktiviert ist.",
                    "Fehler", MessageBoxButton.OK, MessageBoxImage.Information);
                return null;
            }
            catHybridBody1.set_Name("Profile");
            // neue Skizze im ausgewaehlten geometrischen Set anlegen
            Sketches catSketches1 = catHybridBody1.HybridSketches;
            OriginElements catOriginElements = PartDocument.Part.OriginElements;
            Reference catReference1 = (Reference)catOriginElements.PlaneYZ;
            Sketch eSketch = catSketches1.Add(catReference1);

            // Achsensystem in Skizze erstellen 
            ErzeugeAchsensystem(ref eSketch);

            // Part aktualisieren
            //hsp_catiaPart.Part.Update();


            return eSketch;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pPart">The PartDocument that should get a new Part added</param>
        private void CreatePart(out MECMOD.PartDocument pPart)
        {
            INFITF.Documents catDocuments1 = CatiaApplication.Documents;
            pPart = catDocuments1.Add("Part") as MECMOD.PartDocument;
        }

        /// <summary>
        /// Erzeugt ein Achsensystem im geometrischen Set
        /// </summary>
        private void ErzeugeAchsensystem(ref Sketch pSketch)
        {
            if (pSketch != null)
            {
                object[] arr = new object[] {0.0, 0.0, 0.0,
                                         0.0, 1.0, 0.0,
                                         0.0, 0.0, 1.0 };
                pSketch.SetAbsoluteAxisData(arr);
            }
            else throw new ArgumentNullException("Es existiert keine Skizze");
        }

        /// <summary>
        /// Gibt eine Referenz der CATIA-Instanz zurück
        /// </summary>
        /// <returns>CatiaApplication as Reference</returns>
        protected ref INFITF.Application GetCatiaApplication()
        {
            return ref _CatiaApplication;
        }

        /// <summary>
        /// Gibt eine Referenz der ProfilSkizze zurück.
        /// Dies ermöglicht ein direktes bearbeiten, zur Sicherheit nur innerhalb verfügbar
        /// </summary>
        /// <returns>ProfilSkizze as Reference</returns>
        protected ref MECMOD.Sketch GetProfilSkizze()
        {
            return ref _ProfilSkizze;
        }

        //////// GETTER SETTER

        /// <summary>
        /// Represents the instance of the CATIA Application
        /// </summary>
        /// <value>The CatiaApplication Property gets/sets the value of the Application field _CatiaApplication</value>
        public INFITF.Application CatiaApplication
        {
            get
            {
                return _CatiaApplication;
            }
            set
            {
                _CatiaApplication = value;
            }
        }

        /// <summary>
        /// Represents the instance of the PartDocument
        /// </summary>
        /// <value>The PartDocument Property gets/sets the value of the PartDocument field _PartDocument</value>
        public MECMOD.PartDocument PartDocument
        {
            get 
            {
                return _PartDocument;
            }
            set
            {
                _PartDocument = value;
            }
        }

        /// <summary>
        /// Represents the instance of the Sketch
        /// </summary>
        /// <value>The ProfilSkizze Property gets/sets the value of the Sketch field _ProfilSkizze</value>
        public MECMOD.Sketch ProfilSkizze
        {
            get
            {
                return _ProfilSkizze;
            }
            set
            {
                _ProfilSkizze = value;
            }
        }
    }
}
