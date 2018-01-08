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

        private string _type;
        public string Type
        {
            get
            {
                return _type;
            }
            set
            {
                if (_type != value)
                {
                    _type = value;
                    RaisePropertyChanged("RecordType");
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

        void RaisePropertyChanged(string prop)
        {
            if (PropertyChanged != null) { PropertyChanged(this, new PropertyChangedEventArgs(prop)); }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
