using KantoorInrichtingWPF.Data;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;

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
        private string _prijs;
        private string _lengte;
        private string _breedte;
        private string _categorie;
        private string _tag;
        private string _image;
        private string _hoogte;
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
        public string Hoogte
        {
            get
            {
                return _hoogte;
            }
            set
            {
              _hoogte   = value;
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
        public string Breedte
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
        public string Lengte
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
        public string Prijs
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

            Productcode = $"{Leverancier[0]}{Leverancier[1]}{Catalogus.Count}";
            Meubel_Database.ToevoegenAanDatabase(Naam, Prijs, Lengte, Breedte, Categorie, Tag, Image, Hoogte,Leverancier,Productcode);
            MessageBox.Show("Item is toegevoegd, druk op refresh om de lijst te updaten");
        }
       
        void UpdateCatalogusExecute() 
        {
            var outputQuerry = Meubel_Database.GetDatabase();
            List<Meubel> listMeubels = new List<Meubel>();
            foreach (var item in outputQuerry)
            {
                var productcode = item.Value[0];
                var leverancier = item.Value[1];
                var afbeelding = item.Value[2];
                var naam = item.Value[3];
                var prijs = System.Convert.ToDecimal(item.Value[4]);
                var lengte = System.Convert.ToDecimal(item.Value[5]);
                var breedte = System.Convert.ToDecimal(item.Value[6]);
                var hoogte = System.Convert.ToDecimal(item.Value[9]);
                var tag = item.Value[7];
                var categorie = item.Value[8];
                Meubel meubel = new Meubel(afbeelding, naam, prijs, lengte, breedte, tag, categorie, hoogte,leverancier,productcode);

                listMeubels.Add(meubel);


            }
            Catalogus = listMeubels;
            
         }
        void VerwijderenMeubelExecute() 
        {
            Meubel_Database.DeleteFromDatabase(Verwijderbalk);
            MessageBox.Show("Item is verwijdert, druk op refresh om de lijst te updaten"); 
        }
      void ZoekenNaamInCatalogusExecute()
        {
           
            var outputQuerry = Meubel_Database.ZoekenDatabase(Zoekbalk);//_naamZoekbalk
            List<Meubel> listMeubels = new List<Meubel>();
            foreach (var item in outputQuerry)
            {

                var productcode = item.Value[0];
                var leverancier = item.Value[1];
                var afbeelding = item.Value[2];
                var naam = item.Value[3];
                var prijs = System.Convert.ToDecimal(item.Value[4]);
                var lengte = System.Convert.ToDecimal(item.Value[5]);
                var breedte = System.Convert.ToDecimal(item.Value[6]);
                var hoogte = System.Convert.ToDecimal(item.Value[9]);
                var tag = item.Value[7];
                var categorie = item.Value[8];
                Meubel meubel = new Meubel(afbeelding, naam, prijs, lengte, breedte, tag, categorie, hoogte,leverancier,productcode);

                listMeubels.Add(meubel);


            }
            Catalogus = listMeubels;
        }
       void ZoekenCategorieInCatalogusExecute()
        {
            var outputQuerry = Meubel_Database.ZoekenDatabseCategorie(Zoekbalk); //_categorieZoekbalk
            List<Meubel> listMeubels = new List<Meubel>();
            foreach (var item in outputQuerry)
            {

                var productcode = item.Value[0];
                var leverancier = item.Value[1];
                var afbeelding = item.Value[2];
                var naam = item.Value[3];
                var prijs = System.Convert.ToDecimal(item.Value[4]);
                var lengte = System.Convert.ToDecimal(item.Value[5]);
                var breedte = System.Convert.ToDecimal(item.Value[6]);
                var hoogte = System.Convert.ToDecimal(item.Value[9]);
                var tag = item.Value[7];
                var categorie = item.Value[8];
                Meubel meubel = new Meubel(afbeelding, naam, prijs, lengte, breedte, tag, categorie, hoogte,leverancier,productcode);

                listMeubels.Add(meubel);


            }
            Catalogus = listMeubels;
        }
       
        bool CanUpdateCatalogusExecute() 
        {
            return true;
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
