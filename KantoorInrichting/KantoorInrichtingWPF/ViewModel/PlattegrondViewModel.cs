using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace KantoorInrichtingWPF.ViewModel
{
    class PlattegrondViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        
        public PlattegrondViewModel() 
        {

        }
        private void OnPropertyChangedEvent(string propertyName)
        {

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }
    }
}
