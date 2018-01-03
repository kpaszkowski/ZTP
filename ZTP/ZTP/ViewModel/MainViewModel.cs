using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZTP.Commands;

namespace ZTP.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        #region Fields

        public ObservableCollection<Stadium> stadium { get; set; }
        public ObservableCollection<Club> club { get; set; }
        public ObservableCollection<Ticket> ticket { get; set; }
        public ObservableCollection<Match> match { get; set; }
        public ObservableCollection<Reffere> reffere { get; set; }
        object _SelectedStadium;
        public object SelectedStadium
        {
            get
            {
                return _SelectedStadium;
            }
            set
            {
                if (_SelectedStadium != value)
                {
                    _SelectedStadium = value;
                    RaisePropertyChanged("SelectedStadium");
                }
            }
        }
        object _SelectedClub;
        public object SelectedClub
        {
            get
            {
                return _SelectedClub;
            }
            set
            {
                if (_SelectedClub != value)
                {
                    _SelectedClub = value;
                    RaisePropertyChanged("SelectedClub");
                }
            }
        }
        object _SelectedClub2;
        public object SelectedClub2
        {
            get
            {
                return _SelectedClub2;
            }
            set
            {
                if (_SelectedClub2 != value)
                {
                    _SelectedClub2 = value;
                    RaisePropertyChanged("SelectedClub2");
                }
            }
        }
        object _SelectedMatch;
        public object SelectedMatch
        {
            get
            {
                return _SelectedMatch;
            }
            set
            {
                if (_SelectedMatch != value)
                {
                    _SelectedMatch = value;
                    RaisePropertyChanged("SelectedMatch");
                }
            }
        }
        object _SelectedTicket;
        public object SelectedTicket
        {
            get
            {
                return _SelectedTicket;
            }
            set
            {
                if (_SelectedTicket != value)
                {
                    _SelectedTicket = value;
                    RaisePropertyChanged("SelectedTicket");
                }
            }
        }
        object _SelectedReffere;
        public object SelectedReffere
        {
            get
            {
                return _SelectedReffere;
            }
            set
            {
                if (_SelectedReffere != value)
                {
                    _SelectedReffere = value;
                    RaisePropertyChanged("SelectedReffere");
                }
            }
        }
        object _SelectedReffere2;
        public object SelectedReffere2
        {
            get
            {
                return _SelectedReffere2;
            }
            set
            {
                if (_SelectedReffere2 != value)
                {
                    _SelectedReffere2 = value;
                    RaisePropertyChanged("SelectedReffere2");
                }
            }
        }
        object _SelectedReffere3;
        public object SelectedReffere3
        {
            get
            {
                return _SelectedReffere3;
            }
            set
            {
                if (_SelectedReffere3 != value)
                {
                    _SelectedReffere3 = value;
                    RaisePropertyChanged("SelectedReffere3");
                }
            }
        }
        object _SelectedReffere4;
        public object SelectedReffere4
        {
            get
            {
                return _SelectedReffere4;
            }
            set
            {
                if (_SelectedReffere4 != value)
                {
                    _SelectedReffere4 = value;
                    RaisePropertyChanged("SelectedReffere4");
                }
            }
        }

        public RelayCommand AddStadiumCommand { get; set; }
        public RelayCommand RemoveStadiumCommand { get; set; }
        public RelayCommand AddMatchCommand { get; set; }
        public RelayCommand RemoveMatchCommand { get; set; }
        public RelayCommand AddTicketCommand { get; set; }
        public RelayCommand RemoveTicketCommand { get; set; }
        public RelayCommand AddClubCommand { get; set; }
        public RelayCommand RemoveClubCommand { get; set; }
        public RelayCommand AddReffereCommand { get; set; }
        public RelayCommand RemoveReffereCommand { get; set; }

        #endregion

        public MainViewModel()
        {
            InitializeCommands();
        }
        private void InitializeCommands()
        {
            AddStadiumCommand = new RelayCommand(AddStadium);
            RemoveStadiumCommand = new RelayCommand(RemoveStadium);
            AddClubCommand = new RelayCommand(AddClub);
            RemoveClubCommand = new RelayCommand(RemoveClub);
            AddTicketCommand = new RelayCommand(AddTicket);
            RemoveTicketCommand = new RelayCommand(RemoveTicket);
            AddMatchCommand = new RelayCommand(AddMatch);
            RemoveMatchCommand = new RelayCommand(RemoveMatch);
            AddReffereCommand = new RelayCommand(AddReffere);
            RemoveReffereCommand = new RelayCommand(RemoveReffere);

            stadium = new ObservableCollection<Stadium>();
            club = new ObservableCollection<Club>();
            match = new ObservableCollection<Match>();
            ticket = new ObservableCollection<Ticket>();
            reffere = new ObservableCollection<Reffere>();

        }

        #region Referee

        private void RemoveReffere(object parameter)
        {
            if (parameter == null) return;
            var values = (Reffere)parameter;
        }

        private void AddReffere(object parameter)
        {
            if (parameter == null) return;
            var values = (object[])parameter;
            double salary = double.Parse((string)values[2].ToString());
            string role = (string)values[3].ToString();
        }

        #endregion

        #region Match

        private void RemoveMatch(object parameter)
        {
            if (parameter == null) return;
            var values = (Match)parameter;
        }

        private void AddMatch(object parameter)
        {
            if (parameter == null) return;
            var values = (object[])parameter;
            string stadionName = values[0].ToString();
            string hostName = values[1].ToString();
            string guestName = values[2].ToString();
            string mainReffere = values[3].ToString();
            string technicalReffere = values[4].ToString();
            string linearReffere = values[5].ToString();
            string observerReffere = values[6].ToString();
            int hostGoals = Int32.Parse((string)values[7].ToString());
            int guestGoals = Int32.Parse((string)values[8].ToString());
            var date = (Nullable<DateTime>)values[9];
        }

        #endregion

        #region Ticket

        private void RemoveTicket(object parameter)
        {
            if (parameter == null) return;
            var values = (Ticket)parameter;
        }

        private void AddTicket(object parameter)
        {
            if (parameter == null) return;
            var values = (object[])parameter;
            int matchID = Int32.Parse(values[0].ToString());
            string PESEL = values[1].ToString();
        }

        #endregion

        #region Club

        private void RemoveClub(object parameter)
        {
            if (parameter == null) return;
            var values = (Club)parameter;
        }

        private void AddClub(object parameter)
        {
            if (parameter == null) return;
            var values = (object[])parameter;
        }

        #endregion

        #region Stadium

        private void RemoveStadium(object parameter)
        {
            if (parameter == null) return;
            var values = (Stadium)parameter;
        }

        private void AddStadium(object parameter)
        {
            if (parameter == null) return;
            var values = (object[])parameter;
            Stadium s = new Stadium
            {
                Name = values[0].ToString(),
                City = values[1].ToString(),
                Country = values[2].ToString()
            };
        }

        #endregion
    }
}
