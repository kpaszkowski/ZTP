using System.ComponentModel;

namespace ZTP.ViewModel
{
    abstract class Referee : INotifyPropertyChanged
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
        string _firstName;
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                if (_firstName != value)
                {
                    _firstName = value;
                    RaisePropertyChanged("FirstName");
                }
            }
        }
        string _lastName;
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                if (_lastName != value)
                {
                    _lastName = value;
                    RaisePropertyChanged("LastName");
                }
            }
        }
        double _salary;
        public double Salary
        {
            get
            {
                return _salary;
            }
            set
            {
                if (_salary != value)
                {
                    _salary = value;
                    RaisePropertyChanged("Salary");
                }
            }
        }
        bool _IsBusy;
        public bool IsBusy
        {
            get
            {
                return _IsBusy;
            }
            set
            {
                if (_IsBusy != value)
                {
                    _IsBusy = value;
                    RaisePropertyChanged("IsBusy");
                }
            }
        }
        string _role;
        public string Role
        {
            get
            {
                return _role;
            }
            set
            {
                if (_role != value)
                {
                    _role = value;
                    RaisePropertyChanged("Role");
                }
            }
        }

        protected Referee next;

        public void SetNextReferee(Referee referee)
        {
            next = referee;
        }
        public abstract void TakePart(RefereeType refereeType,Match match);
        void RaisePropertyChanged(string prop)
        {
            if (PropertyChanged != null) { PropertyChanged(this, new PropertyChangedEventArgs(prop)); }
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}