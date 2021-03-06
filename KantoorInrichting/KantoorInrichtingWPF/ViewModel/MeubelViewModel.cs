using KantoorInrichtingWPF.Data;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;
using System.Xml;
using System.Data.SqlClient;
using System.IO;
using System;
using System.Reflection;

namespace KantoorInrichtingWPF.ViewModel
{
    public class MeubelViewModel: INotifyPropertyChanged
    {
        private Meubel _meubel;
        private List<Meubel> _catalogus;
        public event PropertyChangedEventHandler PropertyChanged;
        private string _zoekbalk;
        private string _verwijderbalk;

        bool _stoel;
        bool _tafel;
        bool _lamp;
        bool _kast;
        bool _plant;
        bool _apparaten;
        bool _deur;
        bool _raam;
        bool _tapijt;

        private string _naam;
        private decimal _prijs;
        private decimal _lengte;
        private decimal _breedte;
        private string _categorie;
        private string _tag;
        private string _image;
        private decimal _hoogte;
        private List<string> _leverancieren = new List<string>();
        private string _leverancier;

        private  decimal _totalPrijs = 0;

        private List<string> _categorieen = new List<string>();
        private string _testString;
        private string _productcode;

        public MeubelViewModel() 
        {
            //_meubel = new Meubel("🚧",  "test", 1.0M,  1.0M,  1.0M, "TestTag",  "Testcategorie", 1.0M);//img = "🚧", naam = "test", prijs = 1.2M, lengte = 2.5M, breedte = 3.5M, tag = "TestTag", categorie = "Testcategorie", hoogte = 2.8M
            UpdateCatalogusExecute();
            
            _categorieen.Add("Kantoor");
            _categorieen.Add("Lokaal");
            _leverancieren.Add("MeubelBV");
            _leverancieren.Add("Ikea");
        }
        #region prop
        public string TestString
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
        }
        public List<string> Categorieen
        {
            get
            {
                return _categorieen;
            }
            set
            {
                _categorieen= value;
            }
        }
        public List<string> Leveranciers
        {
            get
            {
                return _leverancieren;
            }
            set
            {
                _leverancieren = value;
            }
        }
        public string Leverancier
        {
            get
            {
                return _leverancier;
            }
            set
            {
                _leverancier = value;
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
        public string Image
        {
            get
            {
                return _image;
            }
            set
            {
               _image  = value;
            }
        }
        public string Tag
        {
            get
            {
                return _tag;
            }
            set
            {
               _tag  = value;
            }
        }
        public string Categorie
        {
            get
            {
                return _categorie;
            }
            set
            {
                _categorie = value;
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
               _breedte  = value;
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
               _lengte  = value;
            }
        }
        public decimal Prijs
        {
            get
            {
                return _prijs;
            }
            set
            {
               _prijs  = value;
            }
        }
        public string Naam
        {
            get
            {
                return _naam;
            }
            set
            {
              _naam   = value;
            }
        }

        
        public string Productcode
        {
            get
            {
                return _productcode;
            }
            set
            {
                _productcode = value;
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
        public string Verwijderbalk
        {
            get
            {
                return _verwijderbalk;
            }
            set
            {
                _verwijderbalk = value;
            }
        }
       
        public Meubel Meubel 
        {
            get 
            {
                return _meubel;
            }
            set 
            {
                _meubel = value;
            }
        }
        public List<Meubel> Catalogus 
        {
            get 
            {
                return _catalogus;
            }
            set 
            {
                _catalogus = value;
                OnPropertyChangedEvent("catalogus");
            }
        }
        
        public  decimal TotalPrijs
        {
            get
            {
                return _totalPrijs;
            }
            set
            {
                _totalPrijs = value;
                OnPropertyChangedEvent("Totalprijs");
            }
        }
        #endregion

        private string GetTag()
        {
            string tag = "";
            if (_stoel == true)
            {
                tag = "stoel";
            }
            if (_tafel == true)
            {
                tag = "tafel";
            }
            if (_kast == true)
            {
                tag = "kast";
            }
            if (_plant == true)
            {
                tag = "plant";
            }
            if (_deur == true)
            {
                tag = "deur";
            }
            if (_raam == true)
            {
                tag = "raam";
            }
            if (_tapijt == true)
            {
                tag = "tapijt";
            }
            if (_lamp == true)
            {
                tag = "lamp";
            }
            if (_apparaten == true)
            {
                tag = "apparaten";
            }
            return tag;
        }
   
        private string GetImage()
        {
            string image = "";
            if (_tag.Equals("stoel"))
            {
                image = "🦼";
            }
            if (_tag.Equals("tafel"))
            {
                image = "|¯¯|";
            }
            if (_tag.Equals("lamp"))
            {
                image = "💡";
            }
            if (_tag.Equals("kast"))
            {
                image = "🗄";
            }
            if (_tag.Equals("plant"))
            {
                image = "🌲";
            }
            if (_tag.Equals("apparaten"))
            {
                image = "🖥";
            }
            if (_tag.Equals("deur"))
            {
                image = "🚪";
            }
            if (_tag.Equals("raam"))
            {
                image = "⬜";
            }
            if (_tag.Equals("tapijt"))
            {
                image = "🔴";
            }
            return image;
        }
        private void MakeFalse()
        {
            _tafel = false;
            _stoel = false;
            _lamp = false;
            _kast = false;
            _plant = false;
            _apparaten = false;
            _deur = false;
            _raam = false;
            _tapijt = false;
        }
        #region radiobuttons code
        void TafelExecute() 
        {
            MakeFalse();
            _tafel = true;
        }
        void StoelExecute() 
        {
            MakeFalse();
            _stoel = true;
        }
        void LampExecute() 
        {
            MakeFalse();
            _lamp = true;
        }
        void PlantExecute() 
        {
            MakeFalse();
            _plant = true;

        }
        void KastExecute() 
        {
            MakeFalse();
            _kast = true;
        }
        void ApparaatExecute() 
        {
            MakeFalse();
            _apparaten = true;
        }
        void DeurExecute() 
        {
            MakeFalse();
            _deur = true;
        }
        void RaamExecute() 
        {
            MakeFalse();
            _raam = true;
        }
        void TapijtExecute() 
        {
            MakeFalse();
            _tapijt = true;
        }
        #endregion
        private void OnPropertyChangedEvent(string propertyName) 
        {
            
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
           
        }
        
        void ToevoegenMeubelExecute() 
        {
            Tag = GetTag();
            Image = GetImage();
            if ((Naam is null) || (Prijs is 0) || Lengte is 0 || Breedte is 0 || Categorie is null || Tag.Equals("") || Image.Equals("") || Hoogte is 0 || Leverancier is null)
            {
                MessageBox.Show("Vul alle velden in om meubels te kunnen toevoegen");
            }
            else
            {
                if (Prijs is 0|| Lengte is 0 || Breedte is 0 || Hoogte is 0)
                {
                    MessageBox.Show("Prijs, Lengte, Breedte en Hoogte moet een getal zijn");
                }
                else
                {

                    Productcode = $"{Leverancier[0]}{Leverancier[1]}{Catalogus.Count}";
                    Meubel_Database.ToevoegenAanDatabase(Naam, Prijs, Lengte, Breedte, Categorie, Tag, Image, Hoogte, Leverancier, Productcode);
                    MessageBox.Show("Meubel is toegevoegd");
                    
                }
            }
            UpdateCatalogusExecute();
        }
       
        void UpdateCatalogusExecute() 
        {
            var outputQuerry = Meubel_Database.GetDatabase();
           
            Catalogus = outputQuerry;
            
         }
        void VerwijderenMeubelExecute() 
        {
            bool check = false;
            foreach (var item in Catalogus)
            {
                if (item.Productcode.Equals(Verwijderbalk))
                {
                    check = true;
                    break;
                }
            }
            if (check)
            {
                Meubel_Database.DeleteFromDatabase(Verwijderbalk);
                MessageBox.Show("Meubel is verwijderd");
                UpdateCatalogusExecute();
            }
            else
            {
                MessageBox.Show("ProductCode bestaad niet");
            }

        }
      void ZoekenNaamInCatalogusExecute()
        {
           
            var outputQuerry = Meubel_Database.ZoekenDatabase(Zoekbalk);//_naamZoekbalk
           
            Catalogus = outputQuerry;
        }
       void ZoekenCategorieInCatalogusExecute()
        {
            var outputQuerry = Meubel_Database.ZoekenDatabseCategorie(Zoekbalk); //_categorieZoekbalk
           
            Catalogus = outputQuerry;
        }
       
        bool CanUpdateCatalogusExecute() 
        {
            return true;
        }

        public void XmlInvoegen()
        {
            // string fileName = "XMLFile1.xml";
            // Uri path = new Uri(@"/Xml/XMLTEST.xml", UriKind.RelativeOrAbsolute);
            //xdoc.Load(@"C:\Users\Jelle\Documents\GitHub\Kantoor\KantoorInrichting\KantoorInrichtingWPF\Xml\XMLTEST.xml");
            //hier liever dus een selectiewindow
            //https://docs.microsoft.com/en-us/dotnet/desktop/winforms/controls/how-to-open-files-using-the-openfiledialog-component?view=netframeworkdesktop-4.8
            // xdoc.Load(path);
            
            XmlDocument xdoc = new XmlDocument();

            string outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);//bin\\Debug\\netcoreapp3.1

            if (outPutDirectory.Contains("bin\\Debug\\netcoreapp3.1"))//"file:\\C:\\Users\\stoff\\Documents\\School\\jaar 2\\semester 1\\kbs\\Kantoor\\KantoorInrichting\\KantoorInrichtingWPF\\bin\\Debug\\netcoreapp3.1"
            {
                var test = outPutDirectory.Replace("bin\\Debug\\netcoreapp3.1", "");
                var Bestandsnaam = "XMLTEST" + ".xml";
                var stringBestandNaam = $"Xml\\" + $"{Bestandsnaam}";
                var xmlPath = Path.Combine(test, stringBestandNaam);//"Xml\\XMLTEST.xml"
                string xml_path = new Uri(xmlPath).LocalPath;
                xdoc.Load(xml_path);
                //xdoc.Load(@"C:\Users\Jelle\Documents\GitHub\Kantoor\KantoorInrichting\KantoorInrichtingWPF\Xml\XMLTEST.xml");

            }
            

            XmlNodeList nodes = xdoc.SelectNodes("//meubels/meubel");
            foreach (XmlNode node in nodes)
            {
                string _productcode = "0";
                string _leverancier = "0";
                string _img = "0";
                string _naam = "0";
                string _prijs = "0";
                string _lengte = "0";
                string _breedte = "0";
                string _tag = "0";
                string _categorie = "0";
                string _hoogte = "0";



                XmlNode productcode = node.SelectSingleNode("productcode");

                if (productcode != null)
                {
                    _productcode = $"{productcode.InnerText}";

                }


                XmlNode leverancier = node.SelectSingleNode("leverancier");
                if (leverancier != null)
                {
                    _leverancier = $"{leverancier.InnerText}";
                }

                XmlNode img = node.SelectSingleNode("img");
                if (img != null)
                {
                    _img = $"{img.InnerText}";
                }

                XmlNode naam = node.SelectSingleNode("naam");
                if (naam != null)
                {
                    _naam = $"{naam.InnerText}";
                }

                XmlNode prijs = node.SelectSingleNode("prijs");
                if (prijs != null)
                {
                    _prijs = $"{prijs.InnerText}";
                }

                XmlNode lengte = node.SelectSingleNode("lengte");
                if (lengte != null)
                {
                    _lengte = $"{lengte.InnerText}";
                }

                XmlNode breedte = node.SelectSingleNode("breedte");
                if (breedte != null)
                {
                    _breedte = $"{breedte.InnerText}";
                }

                XmlNode tag = node.SelectSingleNode("tag");
                if (tag != null)
                {
                    _tag = $"{tag.InnerText}";
                }

                XmlNode categorie = node.SelectSingleNode("categorie");
                if (categorie != null)
                {
                    _categorie = $"{categorie.InnerText}";
                }

                XmlNode hoogte = node.SelectSingleNode("hoogte");
                if (hoogte != null)
                {
                    _hoogte = $"{hoogte.InnerText}";
                }

                

                if (Meubel_Database.UpdateCheck(_productcode) == 0)
                {
                    Meubel_Database.ToevoegenAanDatabase(_naam,Convert.ToDecimal( _prijs), Convert.ToDecimal(_lengte),Convert.ToDecimal(_breedte), _categorie, _tag, _img,Convert.ToDecimal(_hoogte), _leverancier, _productcode);
                }
                else
                {
                    Meubel_Database.UpdateDatabase(_naam, Convert.ToDecimal(_prijs), Convert.ToDecimal(_lengte),Convert.ToDecimal(_breedte), _categorie, _tag, _img,Convert.ToDecimal(_hoogte), _leverancier, _productcode);
                }
                //MeubelDatabase.DeleteFromDatabase(_productcode);
            }
            
        }
        


        public ICommand UpdateCatalogus { get { return new RelayCommand(UpdateCatalogusExecute, CanUpdateCatalogusExecute); } }
        public ICommand VerwijderMeubel { get { return new RelayCommand(VerwijderenMeubelExecute, CanUpdateCatalogusExecute); } }
        public ICommand ZoekNaamInCatalogus { get { return new RelayCommand(ZoekenNaamInCatalogusExecute, CanUpdateCatalogusExecute); } }
        public ICommand ZoekCategorieInCatalogus { get { return new RelayCommand(ZoekenCategorieInCatalogusExecute, CanUpdateCatalogusExecute); } }
        public ICommand ToevoegenMeubel { get { return new RelayCommand(ToevoegenMeubelExecute, CanUpdateCatalogusExecute); } }

        public ICommand TafelCommand { get { return new RelayCommand(TafelExecute, CanUpdateCatalogusExecute); } }
        public ICommand StoelCommand{ get { return new RelayCommand(StoelExecute, CanUpdateCatalogusExecute); } }
        public ICommand KastCommand { get { return new RelayCommand(KastExecute, CanUpdateCatalogusExecute); } }
        public ICommand LampCommand { get { return new RelayCommand(LampExecute, CanUpdateCatalogusExecute); } }
        public ICommand PlantCommand { get { return new RelayCommand(PlantExecute, CanUpdateCatalogusExecute); } }
        public ICommand ApparaatCommand { get { return new RelayCommand(ApparaatExecute, CanUpdateCatalogusExecute); } }
        public ICommand DeurCommand { get { return new RelayCommand(DeurExecute, CanUpdateCatalogusExecute); } }
        public ICommand RaamCommand { get { return new RelayCommand(RaamExecute, CanUpdateCatalogusExecute); } }
        public ICommand TapijtCommand { get { return new RelayCommand(TapijtExecute, CanUpdateCatalogusExecute); } }
    }
}
