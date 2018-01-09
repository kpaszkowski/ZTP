using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZTP.ViewModel
{
    public class HistoricalRecordView : INotifyPropertyChanged
    {

        string _bestScorerName;
        public string BestScorerName
        {
            get
            {
                return _bestScorerName;
            }
            set
            {
                if (_bestScorerName != value)
                {
                    _bestScorerName = value;
                    RaisePropertyChanged("BestScorerName");
                }
            }
        }

        string _mostAppearancesName;
        public string MostAppearancesName
        {
            get
            {
                return _mostAppearancesName;
            }
            set
            {
                if (_mostAppearancesName != value)
                {
                    _mostAppearancesName = value;
                    RaisePropertyChanged("MostAppearancesName");
                }
            }
        }

        string _mostWinsTeam;
        public string MostWinsTeam
        {
            get
            {
                return _mostWinsTeam;
            }
            set
            {
                if (_mostWinsTeam != value)
                {
                    _mostWinsTeam = value;
                    RaisePropertyChanged("MostWinsTeam");
                }
            }
        }

        int _bestScorerGoals;
        public int BestScorerGoals
        {
            get
            {
                return _bestScorerGoals;
            }
            set
            {
                if (_bestScorerGoals != value)
                {
                    _bestScorerGoals = value;
                    RaisePropertyChanged("BestScorerGoals");
                }
            }
        }

        int _mostAppearancesAmount;
        public int MostAppearancesAmount
        {
            get
            {
                return _mostAppearancesAmount;
            }
            set
            {
                if (_mostAppearancesAmount != value)
                {
                    _mostAppearancesAmount = value;
                    RaisePropertyChanged("MostAppearancesAmount");
                }
            }
        }

        int _mostWinsAmount;
        public int MostWinsAmount
        {
            get
            {
                return _mostWinsAmount;
            }
            set
            {
                if (_mostWinsAmount != value)
                {
                    _mostWinsAmount = value;
                    RaisePropertyChanged("MostWinsAmount");
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
