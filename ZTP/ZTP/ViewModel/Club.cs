using System.ComponentModel;

namespace ZTP.ViewModel
{
    public class Club : INotifyPropertyChanged
    {
        int _ID;
        public int ID
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
        string _Name;
        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                if (_Name != value)
                {
                    _Name = value;
                    RaisePropertyChanged("Name");
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

        long _StadiumID;
        public long StadiumID
        {
            get
            {
                return _StadiumID;
            }
            set
            {
                if (_StadiumID != value)
                {
                    _StadiumID = value;
                    RaisePropertyChanged("StadiumID");
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