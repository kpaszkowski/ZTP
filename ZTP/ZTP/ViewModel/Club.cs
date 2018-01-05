using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace ZTP.ViewModel
{
    public class Club : ClubComponent, INotifyPropertyChanged
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
        //string _Name;
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

        List<Player> players = new List<Player>();
        List<StaffMember> staffMembers = new List<StaffMember>();
        List<Record> records = new List<Record>();

        void AddPlayer(Player player)
        {
            players.Add(player);
        }

        void RemovePlayer(Player player)
        {
            players.Remove(player);
        }

        void AddStaffMember(StaffMember sm)
        {
            staffMembers.Add(sm);
        }

        void RemoveStaffMember(StaffMember sm)
        {
            staffMembers.Remove(sm);
        }

        void AddRecord(Record record)
        {
            records.Add(record);
        }

        void RemoveRecord(Record record)
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