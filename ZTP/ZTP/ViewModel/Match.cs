using System;
using System.Collections.Generic;
using System.ComponentModel;
using ZTP.Interfaces;

namespace ZTP.ViewModel
{
    public class Match : INotifyPropertyChanged ,IObservable
    {
        #region Properties
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
        string _Stadium;
        public string Stadium_Name
        {
            get
            {
                return _Stadium;
            }
            set
            {
                if (_Stadium != value)
                {
                    _Stadium = value;
                    RaisePropertyChanged("Stadium");
                }
            }
        }
        string _Host;
        public string Host_Name
        {
            get
            {
                return _Host;
            }
            set
            {
                if (_Host != value)
                {
                    _Host = value;
                    RaisePropertyChanged("Host");
                }
            }
        }
        string _Guest;
        public string Guest_Name
        {
            get
            {
                return _Guest;
            }
            set
            {
                if (_Guest != value)
                {
                    _Guest = value;
                    RaisePropertyChanged("Guest");
                }
            }
        }
        string _MainReffere;
        public string MainReffere
        {
            get
            {
                return _MainReffere;
            }
            set
            {
                if (_MainReffere != value)
                {
                    _MainReffere = value;
                    RaisePropertyChanged("MainReffere");
                }
            }
        }
        string _TechnicalReffere;
        public string TechnicalReffere
        {
            get
            {
                return _TechnicalReffere;
            }
            set
            {
                if (_TechnicalReffere != value)
                {
                    _TechnicalReffere = value;
                    RaisePropertyChanged("TechnicalReffere");
                }
            }
        }
        string _LinearReffere;
        public string LinearReffere
        {
            get
            {
                return _LinearReffere;
            }
            set
            {
                if (_LinearReffere != value)
                {
                    _LinearReffere = value;
                    RaisePropertyChanged("LinearReffere");
                }
            }
        }
        string _ObserverReffere;
        public string ObserverReffere
        {
            get
            {
                return _ObserverReffere;
            }
            set
            {
                if (_ObserverReffere != value)
                {
                    _ObserverReffere = value;
                    RaisePropertyChanged("ObserverReffere");
                }
            }
        }
        long _HostGoals;
        public long HostGoals
        {
            get
            {
                return _HostGoals;
            }
            set
            {
                if (_HostGoals != value)
                {
                    _HostGoals = value;
                    RaisePropertyChanged("HostGoals");
                }
            }
        }
        long _GuestGoals;
        public long GuestGoals
        {
            get
            {
                return _GuestGoals;
            }
            set
            {
                if (_GuestGoals != value)
                {
                    _GuestGoals = value;
                    RaisePropertyChanged("GuestGoals");
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
        #endregion

        List<Ticket> ticketList = new List<Ticket>();

        public void Attach(Ticket ticket)
        {
            ticketList.Add(ticket);
        }

        public void Detach(Ticket ticket)
        {
            ticketList.Remove(ticket);
        }

        public void Notify(Nullable<DateTime> dateTime)
        {
            foreach (Ticket item in ticketList)
            {
                item.Update(this.Date);
            }
        }

        void RaisePropertyChanged(string prop)
        {
            if (PropertyChanged != null) { PropertyChanged(this, new PropertyChangedEventArgs(prop)); }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}