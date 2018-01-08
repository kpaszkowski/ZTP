using System;
using System.ComponentModel;
using ZTP.Interfaces;

namespace ZTP.ViewModel
{
    public class Ticket : INotifyPropertyChanged , IObserver
    {
        long _ID;
        public long ID
        {
            get
            {
                return _ID;
            }
            set
            {
                if (_ID != value)
                {
                    _ID = value;
                    RaisePropertyChanged("ID");
                }
            }
        }
        string _PESEL;
        public string PESEL
        {
            get
            {
                return _PESEL;
            }
            set
            {
                if (_PESEL != value)
                {
                    _PESEL = value;
                    RaisePropertyChanged("PESEL");
                }
            }
        }
        Nullable<DateTime> _date;
        public Nullable<DateTime> Date
        {
            get
            {
                return _date;
            }
            set
            {
                if (_date != value)
                {
                    _date = value;
                    RaisePropertyChanged("Date");
                }
            }
        }
        long _MatchID;
        public long MatchID
        {
            get
            {
                return _MatchID;
            }
            set
            {
                if (_MatchID != value)
                {
                    _MatchID = value;
                    RaisePropertyChanged("MatchID");
                }
            }
        }

        void RaisePropertyChanged(string prop)
        {
            if (PropertyChanged != null) { PropertyChanged(this, new PropertyChangedEventArgs(prop)); }
        }

        public void Update(Nullable<DateTime> date)
        {
            this.Date = date;
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
