using System;
using System.Collections.Generic;
using System.ComponentModel;
using ZTP.Interfaces;

namespace ZTP.ViewModel
{
    public class Bracket : INotifyPropertyChanged, IStrategy
    {

        private IStrategy computerPlayer;

        public IStrategy ComputerPlayer
        {
            get { return computerPlayer; }
            set { computerPlayer = value; }
        }
        public void MakeBracket()
        {
            computerPlayer.MakeBracket();
        }


        void RaisePropertyChanged(string prop)
        {
            if (PropertyChanged != null) { PropertyChanged(this, new PropertyChangedEventArgs(prop)); }
        }



        public event PropertyChangedEventHandler PropertyChanged;
    }

}
