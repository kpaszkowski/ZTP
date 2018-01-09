using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZTP.ViewModel
{
    public abstract class StaffMember : ClubComponent, INotifyPropertyChanged
    {

        string _Name;
        int _age;
        double _salary;
        string _role;
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
                    RaisePropertyChanged("StaffName");
                }
            }
        }

        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (_age != value)
                {
                    _age = value;
                    RaisePropertyChanged("StaffAge");
                }
            }
        }


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
                    RaisePropertyChanged("StaffSalary");
                }
            }
        }


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
                    RaisePropertyChanged("StaffRole");
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
