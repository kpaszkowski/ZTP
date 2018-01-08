using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace ZTP.ViewModel
{
   public class Record : ClubComponent, INotifyPropertyChanged
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

        long _OwnerID;
        public long OwnerID
        {
            get
            {
                return _OwnerID;
            }
            set
            {
                if (_OwnerID != value)
                {
                    _OwnerID = value;
                    RaisePropertyChanged("OwnerID");
                }
            }
        }

        //private string _type;
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
                    RaisePropertyChanged("RecordName");
                }
            }
        }

        private int _val;
        public int Val
        {
            get
            {
                return _val;
            }
            set
            {
                if (_val != value)
                {
                    _val = value;
                    RaisePropertyChanged("RecordVal");
                }
            }
        }

        public void Display(string s)
        {
            sClubDisplay = s + " >" + _Name + " - " + _val + Environment.NewLine;
            RaisePropertyChanged("Display");
        }

        void RaisePropertyChanged(string prop)
        {
            if (PropertyChanged != null) { PropertyChanged(this, new PropertyChangedEventArgs(prop)); }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
