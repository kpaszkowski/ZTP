using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football.ViewModel
{
    public class ReffereViewModel
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

        void RaisePropertyChanged(string prop)
        {
            if (PropertyChanged != null) { PropertyChanged(this, new PropertyChangedEventArgs(prop)); }
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
