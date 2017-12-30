using Football.Commands;
using Football.Service;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football.ViewModel.Window
{
    public class MainViewModel : BaseViewModel
    {
        #region Service
        StadiumService stadiumService;
        ClubService clubService;
        TicketService ticketService;
        MatchService matchService;
        ReffereService reffereService;
        #endregion

        #region Field
        public ObservableCollection<StadiumViewModel> stadium { get; set; }
        public ObservableCollection<ClubViewModel> club { get; set; }
        public ObservableCollection<TicketViewModel> ticket { get; set; }
        public ObservableCollection<MatchViewModel> match { get; set; }
        public ObservableCollection<ReffereViewModel> reffere { get; set; }
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
                if(_SelectedMatch != value)
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
                if(_SelectedTicket != value)
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
            UpdateStadiumGrid();
            UpdateClubGrid();
            UpdateReffereGrid();
            UpdateMatchGrid();
            UpdateTicketGrid();
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

            stadium = new ObservableCollection<StadiumViewModel>();
            club = new ObservableCollection<ClubViewModel>();
            match = new ObservableCollection<MatchViewModel>();
            ticket = new ObservableCollection<TicketViewModel>();
            reffere = new ObservableCollection<ReffereViewModel>();

            stadiumService = new StadiumService();
            clubService = new ClubService();
            ticketService = new TicketService();
            matchService = new MatchService();
            reffereService = new ReffereService();
        }

        #region Reffere

        private void RemoveReffere(object parameter)
        {
            if (parameter == null) return;
            var values = (ReffereViewModel)parameter;
            if (reffereService.RemoveReffere(values.ID))
            {
                UpdateReffereGrid();
            }
            else
            {
                AlertWindow alert = new AlertWindow();
                alert.ShowDialog();
            }
        }

        private void AddReffere(object parameter)
        {
            if (parameter == null) return;
            var values = (object[])parameter;
            double salary = double.Parse((string)values[2].ToString());
            reffereService.AddReffere(values[0].ToString(), values[1].ToString(), salary);
            UpdateReffereGrid();
        }

        void UpdateReffereGrid()//Bieda update , czysci grida i od nowa laduje
        {
            var r = reffereService.GetAllReffere();
            reffere.Clear();
            foreach (ReffereViewModel item in r)
            {
                reffere.Add(item);
            }
        }

        #endregion

        #region Match
        private void RemoveMatch(object parameter)
        {
            if (parameter == null) return;
            var values = (MatchViewModel)parameter;
            if (matchService.RemoveMatch(values.ID))
            {
                UpdateMatchGrid();
                UpdateTicketGrid();
            }
            else
            {
                AlertWindow alert = new AlertWindow();
                alert.ShowDialog();
            }
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

            matchService.AddMatchByTagName(stadionName, hostName, guestName, mainReffere, technicalReffere, linearReffere, observerReffere, hostGoals, guestGoals);
            UpdateMatchGrid();
        }

        void UpdateMatchGrid()//Bieda update , czysci grida i od nowa laduje
        {
            var m = matchService.GetAllMatches();
            match.Clear();
            foreach (MatchViewModel item in m)
            {
                match.Add(item);
            }
        }
        #endregion

        #region Ticket

        private void RemoveTicket(object parameter)
        {
         
        }

        private void AddTicket(object parameter)
        {
            if (parameter == null) return;
            var values = (object[])parameter;
            int matchID = Int32.Parse(values[0].ToString());
            string PESEL = values[1].ToString();
            var date = (Nullable<DateTime>)values[2];
            ticketService.AddTicket(PESEL, matchID, date.Value.ToShortDateString());
            UpdateTicketGrid();
            
        }

        void UpdateTicketGrid()//Bieda update , czysci grida i od nowa laduje
        {
            var t = ticketService.GetAllTicket();
            ticket.Clear();
            foreach (TicketViewModel item in t)
            {
                ticket.Add(item);
            }
        }
        #endregion

        #region Stadium

        void AddStadium(object parameter)
        {
            if (parameter == null) return;
            var values = (object[])parameter;
            Stadium s = new Stadium
            {
                name = values[0].ToString(),
                city = values[1].ToString(),
                country = values[2].ToString()
            };
            stadiumService.AddStadium(s);
            UpdateStadiumGrid();
        }

        void RemoveStadium(object parameter)//usuwanie po wyszukiwaniu
        {
            if (parameter == null) return;
            var values = (StadiumViewModel)parameter;
            if (stadiumService.RemoveStadium(values.ID))
            {
                UpdateStadiumGrid();
            }
            else
            {
                AlertWindow alert = new AlertWindow();
                alert.ShowDialog();
            }

        }

        void UpdateStadiumGrid()//Bieda update , czysci grida i od nowa laduje
        {
            var s = stadiumService.GetAllStadium();
            stadium.Clear();
            foreach (Stadium item in s)
            {
                stadium.Add(new StadiumViewModel {ID=item.id, Name = item.name, City = item.city, Country = item.country });
            }
        }

        #endregion

        #region Club

        void AddClub(object parameter)
        {
            if (parameter == null) return;
            var values = (object[])parameter;
            if (true)
            {
                clubService.AddClub(values[0].ToString(), values[1].ToString());
            }
            else
            {
                //clubService.AddClub()
            }
            UpdateClubGrid();

        }

        void RemoveClub(object parameter)
        {
            if (parameter == null) return;
            var values = (ClubViewModel)parameter;
            if (clubService.RemoveClub(values.ID))
            {
                UpdateClubGrid();
            }
            else
            {
                AlertWindow alert = new AlertWindow();
                alert.ShowDialog();
            }
        }

        void UpdateClubGrid()//Bieda update , czysci grida i od nowa laduje
        {
            var c = clubService.GetAllClub();
            club.Clear();
            foreach (ClubViewModel item in c)
            {
                club.Add(item);
            }
        }
        #endregion
    }
}
