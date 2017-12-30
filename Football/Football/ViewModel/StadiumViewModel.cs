using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    public class StadiumViewModel : INotifyPropertyChanged
    {

        string _Name;
        string _City;
        string _Country;
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
                    RaisePropertyChanged("Name");
                }
            }
        }
        public string City
        {
            get
            {
                return _City;
            }
            set
            {
                if (_City != value)
                {
                    _City = value;
                    RaisePropertyChanged("City");
                }
            }
        }
        public string Country
        {
            get
            {
                return _Country;
            }
            set
            {
                if (_Country != value)
                {
                    _Country = value;
                    RaisePropertyChanged("Country");
                }
            }
        }

        public void UpdateFromModel(Stadium stadium)
        {
            this.Name = stadium.name;
            this.City = stadium.city;
            this.Country = stadium.country;
        }

        void RaisePropertyChanged(string prop)
        {
            if (PropertyChanged != null) { PropertyChanged(this, new PropertyChangedEventArgs(prop)); }
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
