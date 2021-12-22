using KantoorInrichtingWPF.Data;
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
        private string _CanvasItemcode;
        private string _canvasImageType;
        private string _canvasImageName;
        private string _canvasImageTag;
        private string _XCoord;
        private string _YCoord;

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
        #endregion
        private void OnPropertyChangedEvent(string propertyName)
        {

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }
        void UpdatePlattegrondenLijstExecute()
        {
            //Dictionary<int, List<string>> outputQuerry= Plattegrond_Database.GetPlattegrondDataDatabase();

            Dictionary<int, List<string>> outputQuerry = new Dictionary<int, List<string>>();
            List<string> testList = new List<string>();
            testList.Add("testprojectnaam");
            testList.Add("testplattegrondnaam");
            testList.Add($"{DateTime.Now}");
            testList.Add("testplattegrondcode");
            testList.Add("testlengte");
            testList.Add("testbreedte");
            testList.Add("testhoogte");
            outputQuerry.Add(0,testList);

            List<Plattegrond> ListPlattegrond = new List<Plattegrond>();
            foreach (var item in outputQuerry)
            {
                var projectnaam = item.Value[0];
                var plattegrondnaam = item.Value[1];
                var datum = item.Value[2];
                var plattegrondcode = item.Value[3];
                var lengte = item.Value[4];
                var breedte = item.Value[5];
                var hoogte= item.Value[6];
                var MeubelsOpCanvas = Plattegrond_Database.GetPlattegrondCanvasDataDatabase(Plattegrondcode);
                Plattegrond plattegrond = new Plattegrond(projectnaam, plattegrondnaam, datum, plattegrondcode, lengte, breedte, hoogte, MeubelsOpCanvas);

                ListPlattegrond.Add(plattegrond);


            }
           

            
            
            PlattegrondLijst = ListPlattegrond;
        }
        void ToevoegenPlattegrondExecute()
        {
            
            Datum = $"{DateTime.Now}";
            Plattegrondcode = $"{PlattegrondNaam[0]}{PlattegrondNaam[1]}{PlattegrondLijst.Count}";
            Plattegrond_Database.ToevoegenAanDatabase(ProjectNaam,PlattegrondNaam,Datum,Plattegrondcode,Lengte,Breedte,Hoogte);//CanvasItemcode,CanvasImageType,CanvasImageName,CanvasImageTag,XCoord,YCoord
            MessageBox.Show("Plattegrond is toegevoegd");
        }
        void VerwijderenPlattegrondExecute()
        {
            Plattegrond_Database.DeleteFromDatabase(Plattegrondcode);
            MessageBox.Show("Item is verwijdert, druk op refresh om de lijst te updaten");
        }
        void ZoekenProjectNaamExecute()
        {
           /* Dictionary<int, List<string>> outputQuerry= Plattegrond_Database;
            List<Plattegrond> ListPlattegrond = new List<Plattegrond>();
            foreach (var item in outputQuerry)
            {
                var projectnaam = item.Value[0];
                var plattegrondnaam = item.Value[1];
                var datum = item.Value[2];
                var plattegrondcode = item.Value[3];
                var lengte = item.Value[4];
                var breedte = item.Value[5];
                var hoogte = item.Value[6];
                var MeubelsOpCanvas = Plattegrond_Database.GetPlattegrondCanvasDataDatabase(Plattegrondcode);
                Plattegrond plattegrond = new Plattegrond(projectnaam, plattegrondnaam, datum, plattegrondcode, lengte, breedte, hoogte, MeubelsOpCanvas);

                ListPlattegrond.Add(plattegrond);


            }




            PlattegrondLijst = ListPlattegrond;*/

        }
        void ZoekenPlattegrondNaamExecute()
        {
            /*Dictionary<int, List<string>> outputQuerry= Plattegrond_Database.;
            List<Plattegrond> ListPlattegrond = new List<Plattegrond>();
            foreach (var item in outputQuerry)
            {
                var projectnaam = item.Value[0];
                var plattegrondnaam = item.Value[1];
                var datum = item.Value[2];
                var plattegrondcode = item.Value[3];
                var lengte = item.Value[4];
                var breedte = item.Value[5];
                var hoogte = item.Value[6];
                var MeubelsOpCanvas = Plattegrond_Database.GetPlattegrondCanvasDataDatabase(Plattegrondcode);
                Plattegrond plattegrond = new Plattegrond(projectnaam, plattegrondnaam, datum, plattegrondcode, lengte, breedte, hoogte, MeubelsOpCanvas);

                ListPlattegrond.Add(plattegrond);


            }




            PlattegrondLijst = ListPlattegrond;*/
        }
        bool CanUpdatePlattegrondenLijstExecute()
        {
            return true;
        }
        public ICommand UpdatePlattegrondenLijst { get { return new RelayCommand(UpdatePlattegrondenLijstExecute, CanUpdatePlattegrondenLijstExecute); } }

        public ICommand ZoekenProjectNaam { get { return new RelayCommand(ZoekenProjectNaamExecute, CanUpdatePlattegrondenLijstExecute); } }
        public ICommand ZoekenPlattegrondNaam { get { return new RelayCommand(ZoekenPlattegrondNaamExecute, CanUpdatePlattegrondenLijstExecute); } }
        public ICommand ToevoegenPlattegrond { get { return new RelayCommand(ToevoegenPlattegrondExecute, CanUpdatePlattegrondenLijstExecute); } }
    }
}
