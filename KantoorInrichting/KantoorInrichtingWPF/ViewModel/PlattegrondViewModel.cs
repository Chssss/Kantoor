using KantoorInrichtingWPF.Data;
using KantoorInrichtingWPF.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows;
using System.Windows.Input;

namespace KantoorInrichtingWPF.ViewModel
{
    class PlattegrondViewModel : INotifyPropertyChanged
    {
        private List<Plattegrond> _plattegrondLijst = new List<Plattegrond>();
        private string _projectNaam;
        private string _plattegrondNaam;
        private decimal _lengte=0.0m;
        private decimal _breedte=0.0m;
        private decimal _hoogte=0.0m;
        private string _plattegrondcode;
        private string _datum;
        private string _CanvasItemcode;
        private string _canvasImageType;
        private string _canvasImageName;
        private string _canvasImageTag;
        private string _XCoord;
        private string _YCoord;
        private string _testString;
        private int _canvasItemCount;
        private string _zoekbalk;
        private List<GebruikteMeubels> _gebruikteMeubelsLijst = new List<GebruikteMeubels>();
        private string _canvasImageLeverancier;
        private string _canvasImageProductcode;
        private string _projectbalk;
        private string _canvasImageRotation;

        public event PropertyChangedEventHandler PropertyChanged;
        
        public PlattegrondViewModel() 
        {
            UpdatePlattegrondenLijstExecute();
            
        }
        #region prop
       /* public string TestString
        {
            get
            {
                return _testString;
            }
            set
            {
                _testString = value;
                OnPropertyChangedEvent("Test");
            }
        }*/
       public List<GebruikteMeubels> GebruikteMeubelsLijst 
        {
            get
            {
                return _gebruikteMeubelsLijst;
            }
            set
            {
                _gebruikteMeubelsLijst = value;
                OnPropertyChangedEvent("GebruikteMeubelsLijst ");
            }
        }
        public List<Plattegrond> PlattegrondLijst
        {
            get
            {
                return _plattegrondLijst;
            }
            set
            {
                _plattegrondLijst = value;
                OnPropertyChangedEvent("plattegrondLijst");
            }
        }
        public string ProjectNaam
        {
            get
            {
                return _projectNaam;
            }
            set
            {
                _projectNaam = value;
               
            }
        }
        public string PlattegrondNaam
        {
            get
            {
                return _plattegrondNaam;
            }
            set
            {
                _plattegrondNaam = value;

            }
        }
        public decimal Lengte
        {
            get
            {
                return _lengte;
            }
            set
            {
                _lengte = value;

            }
        }
        public decimal Breedte
        {
            get
            {
                return _breedte;
            }
            set
            {
                _breedte = value;

            }
        }
        public decimal Hoogte
        {
            get
            {
                return _hoogte;
            }
            set
            {
                _hoogte = value;

            }
        }
        public string Plattegrondcode
        {
            get
            {
                return _plattegrondcode;
            }
            set
            {
                _plattegrondcode = value;

            }
        }
        
        public string Datum
        {
            get
            {
                return _datum;
            }
            set
            {
                _datum = value;

            }
        }
        public string Zoekbalk
        {
            get
            {
                return _zoekbalk;
            }
            set
            {
                _zoekbalk = value;

            }
        }
        public string Projectbalk
        {
            get
            {
                return _projectbalk;
            }
            set
            {
                _projectbalk = value;

            }
        }
        #region canvas item
        public string CanvasItemcode
        {
            get
            {
                return _CanvasItemcode;
            }
            set
            {
                _CanvasItemcode = value;

            }
        }
        public string CanvasImageType
        {
            get
            {
                return _canvasImageType;
            }
            set
            {
                _canvasImageType = value;

            }
        }
        public string CanvasImageName
        {
            get
            {
                return _canvasImageName;
            }
            set
            {
                _canvasImageName = value;

            }
        }
        public string CanvasImageTag
        {
            get
            {
                return _canvasImageTag;
            }
            set
            {
                _canvasImageTag = value;

            }
        }
        public string CanvasImageLeverancier
        {
            get
            {
                return _canvasImageLeverancier;
            }
            set
            {
                _canvasImageLeverancier = value;

            }
        }
        public string CanvasImageProductcode
        {
            get
            {
                return _canvasImageProductcode;
            }
            set
            {
                _canvasImageProductcode = value;

            }
        }
        public int CanvasItemCount
        {
            get
            {
                return _canvasItemCount;
            }
            set
            {
                _canvasItemCount = value;

            }
        }
        public string XCoord
        {
            get
            {
                return _XCoord;
            }
            set
            {
                _XCoord = value;

            }
        }
        public string YCoord
        {
            get
            {
                return _YCoord;
            }
            set
            {
                _YCoord = value;

            }
        }
        public string CanvasImageRotation
        {
            get
            {
                return _canvasImageRotation;
            }
            set
            {
                _canvasImageRotation = value;

            }
        }
        #endregion
        #endregion
        private void OnPropertyChangedEvent(string propertyName)
        {

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }

        public void UpdatePlattegrondenLijstExecute()
        {
            var outputQuerry= Plattegrond_Database.GetPlattegrondDataDatabase();

            PlattegrondLijst = outputQuerry;
        }

        void ToevoegenPlattegrondExecute()
        {

            if (Lengte is 0 || Breedte is 0 || Hoogte is 0 || ProjectNaam is null || PlattegrondNaam is null)
            {
                MessageBox.Show("Vul alle velden in om een plattegrond te kunnen toevoegen");
            }
            else
            {
                if (Lengte is 0 || Breedte is 0 || Hoogte is 0)
                {
                    MessageBox.Show("Lengte, Breedte en Hoogte moet een getal zijn");
                }
                else
                {
                    Datum = $"{DateTime.Now}";
                    Plattegrondcode = $"{PlattegrondNaam[0]}{PlattegrondNaam[1]}{PlattegrondLijst.Count}";
                    Plattegrond_Database.ToevoegenAanDatabase(ProjectNaam, PlattegrondNaam, Datum, Plattegrondcode, Lengte, Breedte, Hoogte);//CanvasItemcode,CanvasImageType,CanvasImageName,CanvasImageTag,XCoord,YCoord

                    MessageBox.Show("Plattegrond is toegevoegd");
                }
            }
        }
        void UpdatePlattegrond(string projectNaam, string plattegrondNaam,  string plattegrondcode, decimal lengte, decimal breedte, decimal hoogte) 
        {
            string datum = $"{DateTime.Now}";
            Plattegrond_Database.UpdateDatabase( projectNaam, plattegrondNaam,  datum, plattegrondcode,  lengte,  breedte,  hoogte);
        }
        public void ToevoegenGebruikteMeubel(string naamMeubel, int aantalMeubels, decimal prijsEnkelMeubel, string leverancier,string productcode) 
        {
            decimal totaalprijs = 0;
            totaalprijs = prijsEnkelMeubel * aantalMeubels;
            GebruikteMeubels gebruikte = new GebruikteMeubels(naamMeubel, aantalMeubels, prijsEnkelMeubel, totaalprijs,leverancier,productcode);
            GebruikteMeubelsLijst.Add(gebruikte);
        }
        public void LeegGebruikteMeubelLijst() 
        {
            GebruikteMeubelsLijst.Clear();
        }
        public bool CheckPlattegrondcode(string plattegrondcode, string projectNaam, string plattegrondNaam,   decimal lengte, decimal breedte, decimal hoogte)
        {
            bool boolOutput = false;
            bool check= false;
            string output = Plattegrond_Database.GetPlattegrondcodeDataDatabase(plattegrondcode);
            if (output.Equals(plattegrondcode))
            {
                check = true;
                UpdatePlattegrond(projectNaam,  plattegrondNaam,    plattegrondcode, lengte,  breedte,  hoogte);
            }
            if (output.Equals("leeg"))
            {
                check = false;
            }
            if (check==false)
            {
                MessageBox.Show("Sla plattegrond eerst op via opslaan als");
                boolOutput= false;
            }
            if (check == true)
            {
                MessageBox.Show("Plattegrond is opgeslagen");
                boolOutput = true;
                
            }
            return boolOutput;
        }
        public void UpdateCanvasItems()
        {

            Plattegrond_Database.UpdateCanvasDataDatabase(Plattegrondcode, CanvasItemcode, CanvasImageType, CanvasImageName, Convert.ToDecimal( CanvasImageTag), XCoord, YCoord,CanvasImageLeverancier,CanvasImageProductcode);
        }
        public bool CheckCanvasitemcode(string canvasitemcode) 
        {
            bool check = false; 
            string output =Plattegrond_Database.GetCanvasItemcodeDatabase(canvasitemcode);
            if (output.Equals("leeg"))
            {
                check = false;
            }
            if (output.Equals(canvasitemcode))
            {
                check = true;
            }
            return check;
        }
        public void ToevoegenCanvasItems()
        {
            
            Plattegrond_Database.ToevoegenCanvasDataAanDatabase(Plattegrondcode, CanvasItemcode, CanvasImageType, CanvasImageName, Convert.ToDecimal(CanvasImageTag), XCoord, YCoord, CanvasImageLeverancier,CanvasImageProductcode,Convert.ToInt32( CanvasImageRotation));
        }
       public void VerwijderenPlattegrond(string plattegrondcode)
        {
            Plattegrond_Database.DeletePlategrondFromDatabase(plattegrondcode);
            MessageBox.Show("Item is verwijdert, druk op refresh om de lijst te updaten");
        }
        public void VerwijderenCanvasitem(string plattegrondcode)
        {
            Plattegrond_Database.DeleteCanvasitemFromDatabase(plattegrondcode);
            
        }
        public void MakeBestelling(List<GebruikteMeubels> gebruikteMeubels, string plattegrondnaam) 
        {
            List<string> Leveranciers = new List<string>();
            foreach (var item in gebruikteMeubels)
            {
                if (!Leveranciers.Contains(item.Leverancier))
                {
                    Leveranciers.Add(item.Leverancier);
                }
               
            }
            foreach (var leverancier in Leveranciers)
            {
                var LeverancierData = Leverancier_Database.GetleverancierDataDatabase(leverancier);
                string datum = DateTime.Now.ToString();
                string[] bestelling = new string[gebruikteMeubels.Count+6];
                bestelling[0] = $"Leverancier: {leverancier}";
                bestelling[1] = $"Email: {LeverancierData.Email}";
                bestelling[2] = $"Telefoonnummer: {LeverancierData.TelefoonNR}";
                bestelling[3] = $"Datum:{datum}";
                bestelling[5] = $"Lijst met gebruikte meubels:";
                int count = 6;
                decimal totaalprijs = 0;
                foreach (var item in gebruikteMeubels)
                {
                    if (item.Leverancier.Equals(leverancier))
                    {
                        totaalprijs = totaalprijs + item.Totaalprijs;
                        bestelling[count] = $"Naam:{item.Naam} Aantal:{item.Aantal} Prijs enkele meubel:{item.Prijs} Totaalprijs:{item.Totaalprijs} Productcode:{item.Productcode}";
                        count++;
                    }
                }
                bestelling[4] = $"Totaalprijs:{totaalprijs}€";
               
                string path= Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string datum2 = datum.Replace(':', '.');
                string bestelling_path = $"{path}\\bestelling {plattegrondnaam} {leverancier} {datum2}.txt";
                if (!File.Exists(bestelling_path))
                {
                    // Create a file to write to.
                    using (StreamWriter sw = File.CreateText(bestelling_path))
                    {
                        
                    }
                }
                File.WriteAllLines(bestelling_path,bestelling);
              

            }
           
        }
        void ZoekenProjectNaamExecute()
        {
            var outputQuerry = Plattegrond_Database.ZoekenNaamProjectDatabase(Zoekbalk);
            
            PlattegrondLijst = outputQuerry;

        }
        void ZoekenPlattegrondNaamExecute()
        {
            var outputQuerry = Plattegrond_Database.ZoekenNaamPlattegrondDatabase(Zoekbalk);
            
            PlattegrondLijst = outputQuerry;
        }
        void MakeProjectBestellingExecute() 
        {

            List<string> PlattegrondcodeList = Plattegrond_Database.GetPlattegrondcode(Projectbalk);
            List<GebruikteMeubels> ListgebruikteMeubels = new List<GebruikteMeubels>();
            string datum = DateTime.Now.ToString();
            #region Get Meubels van de plattegrond
            foreach (var plattegrondcode in PlattegrondcodeList)
            {
                var CanvasItems = Plattegrond_Database.GetPlattegrondCanvasDataDatabase(plattegrondcode);
                Dictionary<string, List<string>> Gebruiktemeubels = new Dictionary<string, List<string>>();
                foreach (var canvasitem in CanvasItems)
                {
                    if (Gebruiktemeubels.ContainsKey(canvasitem.imageType))//Value[3]
                    {
                        int count = Convert.ToInt32(Gebruiktemeubels[canvasitem.imageType][1]);
                        count++;
                        Gebruiktemeubels[canvasitem.imageType][1] = $"{count}";
                    }


                    if (Gebruiktemeubels.ContainsKey(canvasitem.imageType) == false)
                    {
                        if (canvasitem.imageType.Equals("deur") || canvasitem.imageType.Equals("raam")|| canvasitem.imageType.Equals("muur") || canvasitem.imageType.Equals("notitie"))
                        {

                        }
                        else
                        {
                            List<string> listPrijsAantal = new List<string>();
                            listPrijsAantal.Add(canvasitem.naamMeubel);
                            listPrijsAantal.Add("1");
                            listPrijsAantal.Add(canvasitem.leverancier);
                            listPrijsAantal.Add(canvasitem.productcode);
                            Gebruiktemeubels.Add(canvasitem.imageType, listPrijsAantal);
                        }

                    }
                }
                #endregion
                #region maak lijst met de gebruikte meubels
                foreach (var item in Gebruiktemeubels)
                {
                    //plattegrondview.ToevoegenGebruikteMeubel(item.Key,Convert.ToInt32(item.Value[1]), Convert.ToDecimal(item.Value[0]),item.Value[2],item.Value[3]);
                    //string naamMeubel, int aantalMeubels, decimal prijsEnkelMeubel, string leverancier,string productcode
                    decimal prijsEnkelMeubel = Convert.ToDecimal(item.Value[0]);
                    int aantalMeubels= Convert.ToInt32(item.Value[1]);
                    string naamMeubel= item.Key;
                    string leverancier= item.Value[2];
                    string productcode= item.Value[3];
                    decimal totaalprijs = 0;
                    totaalprijs = prijsEnkelMeubel * aantalMeubels;
                    GebruikteMeubels gebruikte = new GebruikteMeubels(naamMeubel, aantalMeubels, prijsEnkelMeubel, totaalprijs, leverancier, productcode);
                    ListgebruikteMeubels.Add(gebruikte);
                }
                #endregion
                #region bestelling schrijven
                List<string> Leveranciers = new List<string>();
                foreach (var item in ListgebruikteMeubels)
                {
                    if (!Leveranciers.Contains(item.Leverancier))
                    {
                        Leveranciers.Add(item.Leverancier);
                    }

                }
                foreach (var leverancier in Leveranciers)
                {
                    var LeverancierData = Leverancier_Database.GetleverancierDataDatabase(leverancier);
                    
                    string[] bestelling = new string[ListgebruikteMeubels.Count + 6];
                    bestelling[0] = $"Leverancier: {leverancier}";
                    bestelling[1] = $"Email: {LeverancierData.Email}";
                    bestelling[2] = $"Telefoonnummer: {LeverancierData.TelefoonNR}";
                    bestelling[3] = $"Datum:{datum}";
                    bestelling[5] = $"Lijst met gebruikte meubels:";
                    int count = 6;
                    decimal totaalprijs = 0;
                    foreach (var item in ListgebruikteMeubels)
                    {
                        if (item.Leverancier.Equals(leverancier))
                        {
                            totaalprijs = totaalprijs + item.Totaalprijs;
                            bestelling[count] = $"Naam:{item.Naam} Aantal:{item.Aantal} Prijs enkele meubel:{item.Prijs} Totaalprijs:{item.Totaalprijs} Productcode:{item.Productcode}";
                            count++;
                        }
                    }
                    bestelling[4] = $"Totaalprijs:{totaalprijs}€";

                    string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    string datum2 = datum.Replace(':', '.');
                    string bestelling_path = $"{path}\\bestelling {Projectbalk} {leverancier} {datum2}.txt";
                    if (!File.Exists(bestelling_path))
                    {
                        // Create a file to write to.
                        using (StreamWriter sw = File.CreateText(bestelling_path))
                        {

                        }
                    }
                    File.WriteAllLines(bestelling_path, bestelling);
                 
                }
                #endregion
            }
            MessageBox.Show($"Bestelling is gemaakt", "Bestelling Project");
        }
        bool CanUpdatePlattegrondenLijstExecute()
        {
            return true;
        }
        public ICommand BestellenProject { get { return new RelayCommand(MakeProjectBestellingExecute, CanUpdatePlattegrondenLijstExecute); } }


        public ICommand UpdatePlattegrondenLijst { get { return new RelayCommand(UpdatePlattegrondenLijstExecute, CanUpdatePlattegrondenLijstExecute); } }

        public ICommand ZoekenProjectNaam { get { return new RelayCommand(ZoekenProjectNaamExecute, CanUpdatePlattegrondenLijstExecute); } }
        public ICommand ZoekenPlattegrondNaam { get { return new RelayCommand(ZoekenPlattegrondNaamExecute, CanUpdatePlattegrondenLijstExecute); } }
        public ICommand ToevoegenPlattegrond { get { return new RelayCommand(ToevoegenPlattegrondExecute, CanUpdatePlattegrondenLijstExecute); } }
    }
}
