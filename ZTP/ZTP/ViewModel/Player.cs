using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace ZTP.ViewModel
{
    public class Player : ClubComponent, INotifyPropertyChanged
    {

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

        private string _firstName;
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
                    RaisePropertyChanged("PlayerFirstName");
                }
            }
        }
        private string _lastName;
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
                    RaisePropertyChanged("PlayerLastName");
                }
            }
        }

        private int _age;
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
                    RaisePropertyChanged("PlayerAge");
                }
            }
        }

        private double _salary;
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
                    RaisePropertyChanged("PlayerSalary");
                }
            }
        }

        List<Record> records = new List<Record>();

        public void addRecord (Record record)
        {
            records.Add(record);
        }

        public void removeRecord(Record record)
        {
            records.Remove(record);
        }

        void RaisePropertyChanged(string prop)
        {
            if (PropertyChanged != null) { PropertyChanged(this, new PropertyChangedEventArgs(prop)); }
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
