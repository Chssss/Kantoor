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
        private string _testString;
        private int _canvasItemCount;
        private string _zoekbalk;

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
        #endregion
        #endregion
        private void OnPropertyChangedEvent(string propertyName)
        {

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }
        void UpdatePlattegrondenLijstExecute()
        {
            Dictionary<int, List<string>> outputQuerry= Plattegrond_Database.GetPlattegrondDataDatabase();

            /*Dictionary<int, List<string>> outputQuerry = new Dictionary<int, List<string>>();
            List<string> testList = new List<string>();
            testList.Add("testprojectnaam");
            testList.Add("testplattegrondnaam");
            testList.Add($"{DateTime.Now}");
            testList.Add("testplattegrondcode");
            testList.Add("testlengte");
            testList.Add("testbreedte");
            testList.Add("testhoogte");
            outputQuerry.Add(0, testList);*/

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
                var MeubelsOpCanvas = Plattegrond_Database.GetPlattegrondCanvasDataDatabase(plattegrondcode);

               /* var MeubelsOpCanvas = new Dictionary<int, List<string>>();
                List<string> list1 = new List<string>();
                list1.Add("code");//canvasItemcode
                list1.Add(plattegrondcode);//plattegrondcode
                list1.Add("tafel");//image type(type image)
                list1.Add("tafel");//image name(naam meubel)
                list1.Add("2,6");//image tag(prijs)
                list1.Add("200,0");//x coord
                list1.Add("20,0");//y coord
                List<string> list2 = new List<string>();
                list2.Add("code");//canvasItemcode
                list2.Add(plattegrondcode);//plattegrondcode
                list2.Add("stoel");//image type(type image)
                list2.Add("stoel");//image name(naam meubel)
                list2.Add("1,7");//image tag(prijs)
                list2.Add("200,0");//x coord
                list2.Add("50,0");//y coord
                MeubelsOpCanvas.Add(0, list1);
                MeubelsOpCanvas.Add(1, list2);*/
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
        void UpdatePlattegrond(string projectNaam, string plattegrondNaam,  string plattegrondcode, string lengte, string breedte, string hoogte) 
        {
            string datum = $"{DateTime.Now}";
            Plattegrond_Database.UpdateDatabase( projectNaam, plattegrondNaam,  datum, plattegrondcode,  lengte,  breedte,  hoogte);
        }
        public bool CheckPlattegrondcode(string plattegrondcode, string projectNaam, string plattegrondNaam,   string lengte, string breedte, string hoogte)
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

            Plattegrond_Database.UpdateCanvasDataDatabase(Plattegrondcode, CanvasItemcode, CanvasImageType, CanvasImageName, CanvasImageTag, XCoord, YCoord);
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
            
            Plattegrond_Database.ToevoegenCanvasDataAanDatabase(Plattegrondcode, CanvasItemcode, CanvasImageType, CanvasImageName, CanvasImageTag, XCoord, YCoord);
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
        void ZoekenProjectNaamExecute()
        {
            Dictionary<int, List<string>> outputQuerry = Plattegrond_Database.ZoekenNaamProjectDatabase(Zoekbalk);
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
                var MeubelsOpCanvas = Plattegrond_Database.GetPlattegrondCanvasDataDatabase(plattegrondcode);
                Plattegrond plattegrond = new Plattegrond(projectnaam, plattegrondnaam, datum, plattegrondcode, lengte, breedte, hoogte, MeubelsOpCanvas);

                ListPlattegrond.Add(plattegrond);


            }




            PlattegrondLijst = ListPlattegrond;

        }
        void ZoekenPlattegrondNaamExecute()
        {
            Dictionary<int, List<string>> outputQuerry = Plattegrond_Database.ZoekenNaamPlattegrondDatabase(Zoekbalk);
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
                var MeubelsOpCanvas = Plattegrond_Database.GetPlattegrondCanvasDataDatabase(plattegrondcode);
                Plattegrond plattegrond = new Plattegrond(projectnaam, plattegrondnaam, datum, plattegrondcode, lengte, breedte, hoogte, MeubelsOpCanvas);

                ListPlattegrond.Add(plattegrond);


            }




            PlattegrondLijst = ListPlattegrond;
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
