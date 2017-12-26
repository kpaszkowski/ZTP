using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football.ViewModel
{
    public class ClubViewModel : INotifyPropertyChanged
    {
        //public int ID
        //{
        //    get
        //    {
        //        return ID;
        //    }
        //    set
        //    {
        //        if (ID != value)
        //        {
        //            ID = value;
        //            RaisePropertyChanged("ID");
        //        }
        //    }
        //}
        public string Name
        {
            get
            {
                return Name;
            }
            set
            {
                if (Name != value)
                {
                    Name = value;
                    RaisePropertyChanged("Name");
                }
            }
        }

        public void UpdateFromModel(Club club)
        {
            //this.ID = club.id;
            this.Name = club.name;
        }

        void RaisePropertyChanged(string prop)
        {
            if (PropertyChanged != null) { PropertyChanged(this, new PropertyChangedEventArgs(prop)); }
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
