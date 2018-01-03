﻿using System;
using System.ComponentModel;

namespace ZTP.ViewModel
{
    public class Ticket : INotifyPropertyChanged
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
        DateTime _date;
        public DateTime Date
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

        void RaisePropertyChanged(string prop)
        {
            if (PropertyChanged != null) { PropertyChanged(this, new PropertyChangedEventArgs(prop)); }
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
