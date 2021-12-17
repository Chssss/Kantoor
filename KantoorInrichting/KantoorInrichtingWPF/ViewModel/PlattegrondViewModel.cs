using KantoorInrichtingWPF.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        private string _lengte;
        private string _breedte;
        private string _hoogte;
        private string _plattegrondcode;
        private string _datum;

        public event PropertyChangedEventHandler PropertyChanged;
        
        public PlattegrondViewModel() 
        {
            UpdatePlattegrondenLijstExecute();
        }
        #region prop
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
        public string Lengte
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
        public string Breedte
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
        public string Hoogte
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
        public string Platterondcode
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
        #endregion
        private void OnPropertyChangedEvent(string propertyName)
        {

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }
        void UpdatePlattegrondenLijstExecute()
        {

            List<Plattegrond> LijstVanPlattegronden = new List<Plattegrond>();
            List<List<string>> MeubelsOpCanvas = new List<List<string>>();
            List<string> MeubelOpCanvas = new List<string>();
            
            MeubelOpCanvas.Add("Image name(image type tafel)");
            MeubelOpCanvas.Add("image tag(prijst 1,0)");
            MeubelOpCanvas.Add("x coord");
            MeubelOpCanvas.Add("y coord");
            MeubelsOpCanvas.Add(MeubelOpCanvas);

            //
            Datum = $"{DateTime.Now}";
            //
            Plattegrond plattegrond = new Plattegrond("testProject", "testPlattegrondNaam", Datum,"testPlattegrondcode" ,"plategrond lengte", "plategrond breedte", "plategrond hoogte", MeubelOpCanvas);
            LijstVanPlattegronden.Add(plattegrond);
            PlattegrondLijst = LijstVanPlattegronden;
        }
        void ToevoegenPlattegrondExecute()
        {
            
           MessageBox.Show("Plattegrond is toegevoegd");
        }
        void VerwijderenMeubelExecute()
        {
            MessageBox.Show("Item is verwijdert, druk op refresh om de lijst te updaten");
        }
        void ZoekenProjectNaamExecute()
        {

            
        }
        void ZoekenPlattegrondNaamExecute()
        {


        }
        bool CanUpdateCatalogusExecute()
        {
            return true;
        }
        public ICommand UpdatePlattegrondenLijst { get { return new RelayCommand(UpdatePlattegrondenLijstExecute, CanUpdateCatalogusExecute); } }

        public ICommand ZoekenProjectNaam { get { return new RelayCommand(ZoekenProjectNaamExecute, CanUpdateCatalogusExecute); } }
        public ICommand ZoekenPlattegrondNaam { get { return new RelayCommand(ZoekenPlattegrondNaamExecute, CanUpdateCatalogusExecute); } }
        public ICommand ToevoegenPlattegrond { get { return new RelayCommand(ToevoegenPlattegrondExecute, CanUpdateCatalogusExecute); } }
    }
}
