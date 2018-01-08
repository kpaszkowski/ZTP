using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace ZTP.ViewModel
{
    class MatchPanel : INotifyPropertyChanged
    {
        public void addName()
        {

        }

        public void addStadium()
        {

        }

        public void addHostClub()
        {

        }

        public void addGuestClub()
        {

        }

        void RaisePropertyChanged(string prop)
        {
                  if (PropertyChanged != null) { PropertyChanged(this, new PropertyChangedEventArgs(prop)); }
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
