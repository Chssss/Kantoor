﻿using KantoorInrichtingWPF.Data;
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
        public MeubelViewModel() 
        {
            //_meubel = new Meubel("🚧",  "test", 1.0M,  1.0M,  1.0M, "TestTag",  "Testcategorie", 1.0M);//img = "🚧", naam = "test", prijs = 1.2M, lengte = 2.5M, breedte = 3.5M, tag = "TestTag", categorie = "Testcategorie", hoogte = 2.8M
            UpdateCatalogusExecute();
               
        }
        #region prop
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
        #endregion

        private void OnPropertyChangedEvent(string propertyName) 
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
           
        }
        void ToevoegenMeubelExecute() 
        {
            Meubel_Database.ToevoegenAanDatabase(Naam, Prijs, Lengte, Breedte, Categorie, Tag, Image, Hoogte);
        }
        void UpdateCatalogusExecute() 
        {
            var outputQuerry = Meubel_Database.GetDatabase();
            List<Meubel> listMeubels = new List<Meubel>();
            foreach (var item in outputQuerry)
            {

                var afbeelding = item.Value[0];
                var naam = item.Value[1];
                var prijs = System.Convert.ToDecimal(item.Value[2]);
                var lengte = System.Convert.ToDecimal(item.Value[3]);
                var breedte = System.Convert.ToDecimal(item.Value[4]);
                var hoogte = System.Convert.ToDecimal(item.Value[7]);
                var tag = item.Value[5];
                var categorie = item.Value[6];
                Meubel meubel = new Meubel(afbeelding, naam, prijs, lengte, breedte, tag, categorie, hoogte);

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

                var afbeelding = item.Value[0];
                var naam = item.Value[1];
                var prijs = System.Convert.ToDecimal(item.Value[2]);
                var lengte = System.Convert.ToDecimal(item.Value[3]);
                var breedte = System.Convert.ToDecimal(item.Value[4]);
                var hoogte = System.Convert.ToDecimal(item.Value[7]);
                var tag = item.Value[5];
                var categorie = item.Value[6];
                Meubel meubel = new Meubel(afbeelding, naam, prijs, lengte, breedte, tag, categorie, hoogte);

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

                var afbeelding = item.Value[0];
                var naam = item.Value[1];
                var prijs = System.Convert.ToDecimal(item.Value[2]);
                var lengte = System.Convert.ToDecimal(item.Value[3]);
                var breedte = System.Convert.ToDecimal(item.Value[4]);
                var hoogte = System.Convert.ToDecimal(item.Value[7]);
                var tag = item.Value[5];
                var categorie = item.Value[6];
                Meubel meubel = new Meubel(afbeelding, naam, prijs, lengte, breedte, tag, categorie, hoogte);

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
    }
}