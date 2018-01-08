using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using ZTP.Class;
using ZTP.Commands;
using ZTP.Helper;

namespace ZTP.ViewModel
{
    enum RefereeType
    {
        Main,
        Technical,
        Linear,
        Observer,
    }

    enum RecordName
    {
        Most_Appearance,
        Best_Scorer,
    }

    enum StaffType
    {
        Assistant,
        Coach,
        Physiotherapist,
        Scout,
    }

    public class MainViewModel : BaseViewModel
    {
        #region Fields

        public ObservableCollection<Stadium> stadium { get; set; }
        public ObservableCollection<Club> club { get; set; }
        public ObservableCollection<Ticket> ticket { get; set; }
        public ObservableCollection<Match> match { get; set; }
        public ObservableCollection<RefereeView> refereeView { get; set; }
        public ObservableCollection<Player> player { get; set; }
        public ObservableCollection<Record> record { get; set; }


        List<Referee> reffere { get; set; }


        object _SelectedRecord;
        public object SelectedRecord
        {
            get
            {
                return _SelectedRecord;
            }
            set
            {
                if (_SelectedRecord != value)
                {
                    _SelectedRecord = value;
                    RaisePropertyChanged("SelectedRecord");
                }
            }
        }

        object _SelectedPlayer;
        public object SelectedPlayer
        {
            get
            {
                return _SelectedPlayer;
            }
            set
            {
                if (_SelectedPlayer != value)
                {
                    _SelectedPlayer = value;
                    RaisePropertyChanged("SelectedPlayer");
                }
            }
        }


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
        public RelayCommand EditStadiumCommand { get; set; }

        public RelayCommand AddMatchCommand { get; set; }
        public RelayCommand RemoveMatchCommand { get; set; }
        public RelayCommand EditMatchCommand { get; set; }

        public RelayCommand AddTicketCommand { get; set; }
        public RelayCommand RemoveTicketCommand { get; set; }
        public RelayCommand EditTicketCommand { get; set; }

        public RelayCommand AddClubCommand { get; set; }
        public RelayCommand RemoveClubCommand { get; set; }
        public RelayCommand EditClubCommand { get; set; }

        public RelayCommand AddReffereCommand { get; set; }
        public RelayCommand RemoveReffereCommand { get; set; }
        public RelayCommand ReleaseRefereesCommand { get; set; }
        public RelayCommand EditRefereeCommand { get; set; }

        public RelayCommand AddPlayerCommand { get; set; }
        public RelayCommand RemovePlayerCommand { get; set; }
        public RelayCommand EditPlayerCommand { get; set; }

   //     public RelayCommand AddStaffCommand { get; set; }
   //     public RelayCommand RemoveStaffCommand { get; set; }
    //    public RelayCommand EditStaffCommand { get; set; }

        public RelayCommand AddRecordCommand { get; set; }
        public RelayCommand RemoveRecordCommand { get; set; }
        public RelayCommand EditRecordCommand { get; set; }

        public RelayCommand SaveData { get; set; }
        public RelayCommand LoadData { get; set; }

        #endregion

        public MainViewModel()
        {
            InitializeCommands();
        }

        private void InitializeCommands()
        {
            AddStadiumCommand = new RelayCommand(AddStadium);
            RemoveStadiumCommand = new RelayCommand(RemoveStadium);
            EditStadiumCommand = new RelayCommand(EditStadium);

            AddClubCommand = new RelayCommand(AddClub);
            RemoveClubCommand = new RelayCommand(RemoveClub);
            EditClubCommand = new RelayCommand(EditClub);

            AddTicketCommand = new RelayCommand(AddTicket);
            RemoveTicketCommand = new RelayCommand(RemoveTicket);
            EditTicketCommand = new RelayCommand(EditTicket);

            AddMatchCommand = new RelayCommand(AddMatch);
            RemoveMatchCommand = new RelayCommand(RemoveMatch);
            EditMatchCommand = new RelayCommand(EditMatch);

            AddReffereCommand = new RelayCommand(AddReffere);
            RemoveReffereCommand = new RelayCommand(RemoveReffere);
            ReleaseRefereesCommand = new RelayCommand(ReleaseReferees);
            EditRefereeCommand = new RelayCommand(EditReferee);

            AddPlayerCommand = new RelayCommand(AddPlayer);
            RemovePlayerCommand = new RelayCommand(RemovePlayer);
            EditPlayerCommand = new RelayCommand(EditPlayer);

            AddRecordCommand = new RelayCommand(AddRecord);
            RemoveRecordCommand = new RelayCommand(RemoveRecord);
            EditRecordCommand = new RelayCommand(EditRecord);

            SaveData = new RelayCommand(Save);
            LoadData = new RelayCommand(Load);

            stadium = new ObservableCollection<Stadium>();
            club = new ObservableCollection<Club>();
            match = new ObservableCollection<Match>();
            ticket = new ObservableCollection<Ticket>();
            refereeView = new ObservableCollection<RefereeView>();
            player = new ObservableCollection<Player>();
            reffere = new List<Referee>();

        }

        #region Referee

        private void RemoveReffere(object parameter)
        {
            if (!ValidateParamsAsObject(parameter))
            {
                ShowInfoWindow("Nie wybrano sedziego");
                return;
            }
            var values = (RefereeView)parameter;
            long idToRemove = values.ID;
            Referee refereeToRemove = reffere.Where(x => x.ID == idToRemove).FirstOrDefault();
            reffere.Remove(refereeToRemove);
            UpdatRefereeGrid();
        }

        private void EditReferee(object parameter)
        {
            if (!ValidateParams(parameter))
            {
                ShowInfoWindow("Wypełnij pola poprawnie");
                return;
            }
            var values = (object[])parameter;
            double n;
            double salary = 0;
            bool isNumeric = double.TryParse((string)values[2].ToString(), out n);
            if (isNumeric)
            {
                salary = double.Parse((string)values[2].ToString());
            }
            else
            {
                ShowInfoWindow("Wypełnij pola poprawnie");
                return;
            }

            RefereeView currentReferee = (RefereeView)values[4];
            Referee referee = reffere.Where(x => x.ID == currentReferee.ID).FirstOrDefault();
            if (values[3] != null && values[3].ToString() == referee.Role)
            {
                string role = (string)values[3].ToString();
            }
            else if (values[3]!=null)
            {
                ShowInfoWindow("Nie można zmienić typu sędziego");
                return;
            }
            foreach (Referee item in reffere.Where(x=>x.ID== referee.ID))
            {
                item.FirstName = values[0].ToString();
                item.LastName = values[1].ToString();
                item.Salary = salary;
            }
            UpdatRefereeGrid();
        }

        private void AddReffere(object parameter)
        {
            if (!ValidateParams(parameter))
            {
                ShowInfoWindow("Wypełnij pola poprawnie");
                return;
            }
            var values = (object[])parameter;
            double n;
            double salary = 0;
            bool isNumeric = double.TryParse((string)values[2].ToString(), out n);
            if (isNumeric)
            {
                salary = double.Parse((string)values[2].ToString());
            }
            else
            {
                ShowInfoWindow("Wypełnij pola poprawnie");
                return;
            }
            
            string role = (string)values[3].ToString();
            Referee r = null;
            switch (role)
            {
                case "Main":
                    {
                        r = new MainReferee
                        {
                            ID = Helpers.FindMaxValue(reffere, x => x.ID) + 1,
                            FirstName = values[0].ToString(),
                            LastName = values[1].ToString(),
                            IsBusy = false,
                            Salary = salary,
                            Role = role
                        };
                        break;
                    }
                case "Technical":
                    {
                        r = new TechnicalReferee
                        {
                            ID = Helpers.FindMaxValue(reffere, x => x.ID) + 1,
                            FirstName = values[0].ToString(),
                            LastName = values[1].ToString(),
                            IsBusy = false,
                            Salary = salary,
                            Role = role
                        };
                        break;
                    }
                case "Linear":
                    {
                        r = new LinearReferee
                        {
                            ID = Helpers.FindMaxValue(reffere, x => x.ID) + 1,
                            FirstName = values[0].ToString(),
                            LastName = values[1].ToString(),
                            IsBusy = false,
                            Salary = salary,
                            Role = role
                        };
                        break;
                    }
                case "Observer":
                    {
                        r = new ObserverReferee
                        {
                            ID = Helpers.FindMaxValue(reffere, x => x.ID) + 1,
                            FirstName = values[0].ToString(),
                            LastName = values[1].ToString(),
                            IsBusy = false,
                            Salary = salary,
                            Role = role
                        };
                        break;
                    }
            }
            SetNextReferee(r);
            reffere.Add(r);
            UpdatRefereeGrid();
        }

        private void SetNextReferee(Referee referee)
        {
            long lastRefereeID = Helpers.FindMaxValue(reffere, x => x.ID);
            foreach (Referee item in reffere.Where(x => x.ID == lastRefereeID))
            {
                item.SetNextReferee(referee);
            }
        }

        public void UpdatRefereeGrid()
        {
            refereeView.Clear();
            foreach (Referee item in reffere)
            {
                refereeView.Add(new RefereeView
                {
                    ID = item.ID,
                    FirstName = item.FirstName,
                    LastName = item.LastName,
                    IsBusy = item.IsBusy,
                    Role = item.Role,
                    Salary = item.Salary,
                    MatchID=item.MatchID
                });
            }
        }

        private void UpdatRefereeBase()
        {
            reffere.Clear();
            Referee r = null;
            foreach (RefereeView item in refereeView)
            {
                switch (item.Role)
                {
                    case "Main":
                        {
                            r = new MainReferee
                            {
                                ID = item.ID,
                                FirstName = item.FirstName,
                                LastName = item.LastName,
                                IsBusy = item.IsBusy,
                                Role = item.Role,
                                Salary = item.Salary,
                                MatchID=item.MatchID
                            };
                            break;
                        }
                    case "Technical":
                        {
                            r = new TechnicalReferee
                            {
                                ID = item.ID,
                                FirstName = item.FirstName,
                                LastName = item.LastName,
                                IsBusy = item.IsBusy,
                                Role = item.Role,
                                Salary = item.Salary,
                                MatchID = item.MatchID
                            };
                            break;
                        }
                    case "Linear":
                        {
                            r = new LinearReferee
                            {
                                ID = item.ID,
                                FirstName = item.FirstName,
                                LastName = item.LastName,
                                IsBusy = item.IsBusy,
                                Role = item.Role,
                                Salary = item.Salary,
                                MatchID = item.MatchID
                            };
                            break;
                        }
                    case "Observer":
                        {
                            r = new ObserverReferee
                            {
                                ID = item.ID,
                                FirstName = item.FirstName,
                                LastName = item.LastName,
                                IsBusy = item.IsBusy,
                                Role = item.Role,
                                Salary = item.Salary,
                                MatchID = item.MatchID
                            };
                            break;
                        }
                }
                SetNextReferee(r);
                reffere.Add(r);
            }
        }

        private void ReleaseReferees(object parameter)
        {
            if (!ValidateParamsAsObject(parameter))
            {
                ShowInfoWindow("Nie wybrano meczu");
                return;
            }
            var values = (Match)parameter;
            values.IsRefereeRelease = true;
            foreach (var item in reffere.Where(x=>x.MatchID==values.ID))
            {
                item.IsBusy = false;
                item.MatchID = 0;
            }
            UpdatRefereeGrid();
        }

        private void ReleaseRefereesAfterRemoveMatch(Match match)
        {
            foreach (var item in reffere.Where(x => x.MatchID == match.ID))
            {
                item.IsBusy = false;
                item.MatchID = 0;
            }
            UpdatRefereeGrid();
        }

        #endregion

        #region Match

        private void EditMatch(object parameter)
        {
            if (!ValidateParams(parameter))
            {
                ShowInfoWindow("Wypełnij pola poprawnie");
                return;
            }
            var values = (object[])parameter;
            var selectedMatch = (Match)values[0];
            var newDate = (Nullable<DateTime>)values[1];
            Stadium stadium = (Stadium)values[2];
            Club hostClub = (Club)values[3];
            Club guestClub = (Club)values[4];
            int hostGoals = Int32.Parse((string)values[5].ToString());
            int guestGoals = Int32.Parse((string)values[6].ToString());
            foreach (Match item in match.Where(x=>x.ID== selectedMatch.ID))
            {
                item.Stadium_Name = stadium.Name;
                item.Host_Name = hostClub.Name;
                item.Guest_Name = guestClub.Name;
                item.HostGoals = hostGoals;
                item.GuestGoals = guestGoals;
                item.Date = newDate;
            }
            selectedMatch.Notify(newDate);
            
        }

        private void RemoveMatch(object parameter)
        {
            if (!ValidateParamsAsObject(parameter))
            {
                ShowInfoWindow("Nie wybrano meczu");
                return;
            }
            var values = (Match)parameter;
            match.Remove(values);
            RemoveAllTickerByMattchID(values.ID);

            ReleaseRefereesAfterRemoveMatch(values);
        }

        private void AddMatch(object parameter)
        {
            if (!ValidateParams(parameter))
            {
                ShowInfoWindow("Wypełnij pola poprawnie");
                return;
            }
            var values = (object[])parameter;
            string stadionName = values[0].ToString();
            string hostName = values[1].ToString();
            string guestName = values[2].ToString();
            int hostGoals = Int32.Parse((string)values[3].ToString());
            int guestGoals = Int32.Parse((string)values[4].ToString());
            var date = (Nullable<DateTime>)values[5];

            Match m = new Match
            {
                ID = Helpers.FindMaxValue(match, x => x.ID) + 1,
                Stadium_Name = stadionName,
                Host_Name = hostName,
                Guest_Name = guestName,
                HostGoals = hostGoals,
                GuestGoals = guestGoals,
                Date = date
            };
            if (CheckIfRefereeExists() && GetRefereeForMatch(m))
            {
                match.Add(m);
            }
            else
            {
                ShowInfoWindow("Brak wolnych sędziów");
            }
            UpdatRefereeGrid();
        }

        private bool GetRefereeForMatch(Match match)
        {
            int count = 0;
            List<RefereeType> neededReferee = new List<RefereeType>
            {
                RefereeType.Main,
                RefereeType.Technical,
                RefereeType.Linear,
                RefereeType.Observer
            };
            foreach (var item in neededReferee)
            {
                reffere.FirstOrDefault().TakePart(item, match, ref count);
            }
            if (count!=4)
            {
                ReleaseRefereesAfterRemoveMatch(match);
                return false;
            }
            return true;
        }

        private bool CheckIfRefereeExists()
        {
            if (!reffere.Any())
            {
                return false;
            }
            return true;
        }

        #endregion

        #region Ticket

        private void RemoveAllTickerByMattchID(long matchID)
        {
            List<Ticket> ticketToRemoveList = new List<Ticket>();
            ticketToRemoveList = ticket.Where(x => x.MatchID == matchID).ToList();
            foreach (Ticket item in ticketToRemoveList)
            {
                ticket.Remove(item);
                //match.Where(x => x.ID == matchID).FirstOrDefault().Detach(item);
            }
        }

        private void RemoveTicket(object parameter)
        {
            if (!ValidateParamsAsObject(parameter))
            {
                ShowInfoWindow("Nie wybrano biletu");
                return;
            }
            var values = (Ticket)parameter;
            ticket.Remove(values);
            match.Where(x => x.ID == values.MatchID).FirstOrDefault().Detach(values);
        }

        private void AddTicket(object parameter)
        {
            if (!ValidateParams(parameter))
            {
                ShowInfoWindow("Wypełnij pola poprawnie");
                return;
            }
            var values = (object[])parameter;
            int matchID = Int32.Parse(values[0].ToString());
            string PESEL = values[1].ToString();
            Ticket t = new Ticket
            {
                ID = Helpers.FindMaxValue(ticket, x => x.ID) + 1,
                Date = match.Where(x => x.ID == matchID).Select(x => x.Date).FirstOrDefault(),
                PESEL = PESEL,
                MatchID=matchID
            };
            ticket.Add(t);
            match.Where(x => x.ID == matchID).FirstOrDefault().Attach(t);

        }

        private void EditTicket(object parameter)
        {
            if (!ValidateParams(parameter))
            {
                ShowInfoWindow("Wypełnij pola poprawnie");
                return;
            }
            var values = (object[])parameter;
            Ticket currentTicket = (Ticket)values[2];
            long newMatchID = Int32.Parse(values[0].ToString());
            match.Where(x => x.ID == currentTicket.MatchID).FirstOrDefault().Detach(currentTicket);
            foreach (Ticket item in ticket.Where(x=>x.ID==currentTicket.ID))
            {
                item.MatchID = newMatchID;
                item.PESEL = values[1].ToString();
                item.Date = match.Where(x => x.ID == item.MatchID).Select(x => x.Date).FirstOrDefault();
                match.Where(x => x.ID == newMatchID).FirstOrDefault().Attach(item);
            }
        }

        #endregion

        #region Player
 
         private void RemovePlayer(object parameter)
         {
             if (!ValidateParamsAsObject(parameter))
             {
                 ShowInfoWindow("Nie wybrano gracza");
                 return;
             }
             var values = (Player)parameter;
             player.Remove(values);
         }
 
         private void AddPlayer(object parameter)
         {
             if (!ValidateParams(parameter))
             {
                 ShowInfoWindow("Wypełnij pola poprawnie");
                 return;
             }
 
             var values = (object[])parameter;
 
             int iNumber;
             int age = 0;
             bool isNumeric1 = int.TryParse((string)values[2].ToString(), out iNumber);
             if (isNumeric1)
             {
                 age = int.Parse((string)values[2].ToString());
             }
             else
             {
                 ShowInfoWindow("Wypełnij pola poprawnie");
                 return;
             }
 
             double dNumber;
             double salary = 0;
             bool isNumeric2 = double.TryParse((string)values[3].ToString(), out dNumber);
             if (isNumeric2)
             {
                 salary = double.Parse((string)values[3].ToString());
             }
             else
             {
                 ShowInfoWindow("Wypełnij pola poprawnie");
                 return;
             }
 
             Player p = new Player
             {
                 ID = Helpers.FindMaxValue(player, x => x.ID) + 1,
                 FirstName = values[0].ToString(),
                 LastName = values[1].ToString(),
                 Age = age,
                 Salary = salary,
             };
             player.Add(p);
         }
 
         private void EditPlayer(object parameter)
         {
             if (!ValidateParams(parameter))
             {
                 ShowInfoWindow("Wypełnij pola poprawnie");
                 return;
             }
 
             var values = (object[])parameter;
 
             int iNumber;
             int age = 0;
             bool isNumeric1 = int.TryParse((string)values[2].ToString(), out iNumber);
             if (isNumeric1)
             {
                 age = int.Parse((string)values[2].ToString());
             }
             else
             {
                 ShowInfoWindow("Wypełnij pola poprawnie");
                 return;
             }
 
             double dNumber;
             double salary = 0;
             bool isNumeric2 = double.TryParse((string)values[3].ToString(), out dNumber);
             if (isNumeric2)
             {
                 salary = double.Parse((string)values[3].ToString());
             }
             else
             {
                 ShowInfoWindow("Wypełnij pola poprawnie");
                 return;
             }
 
             Player currentPlayer = (Player)values[4];
             foreach (Player item in player.Where(x => x.ID == currentPlayer.ID))
             {
                 item.FirstName = values[0].ToString();
                 item.LastName = values[1].ToString();
                 item.Age = age;
                 item.Salary = salary;
             }
         }

        #endregion

        #region Record
        /*
         * 0 - name(poprzednio type) rekordu
         * 1 - val
         * 2 - id playera do ktorego jest przypisany rekord (OwnerID)
         */
        private void RemoveRecord(object parameter)
        {
            if (!ValidateParamsAsObject(parameter))
            {
                ShowInfoWindow("Nie wybrano rekordu");
                return;
            }
            var values = (Record)parameter;
            record.Remove(values);
            player.Where(x => x.ID == values.OwnerID).FirstOrDefault().removeRecord(values);
        }

        private void AddRecord(object parameter)
        {
            if (!ValidateParams(parameter))
            {
                ShowInfoWindow("Wypełnij pola poprawnie");
                return;
            }

            var values = (object[])parameter;

            string name = (string)values[0].ToString();

            int iNumber;
            int val = 0;         
            bool isNumeric1 = int.TryParse((string)values[1].ToString(), out iNumber);
            if (isNumeric1)
            {
                val = int.Parse((string)values[1].ToString());
            }

            int ownerID = Int32.Parse(values[2].ToString());

            Record r = null;
            switch (name)
            {
                case "Most_Apearance":
                    {
                        r = new Record
                        {
                            ID = Helpers.FindMaxValue(record, x => x.ID) + 1,
                            Name = name,
                            Val = val,
                            OwnerID = ownerID
                        };
                        break;
                    }
                case "Best_Scorer":
                    {
                        r = new Record
                        {
                            ID = Helpers.FindMaxValue(record, x => x.ID) + 1,
                            Name = name,
                            Val = val,
                            OwnerID = ownerID
                        };
                        break;
                    }
            }

            record.Add(r);
            player.Where(x => x.ID == ownerID).FirstOrDefault().addRecord(r);
        }

        private void EditRecord(object parameter)
        {
            if (!ValidateParams(parameter))
            {
                ShowInfoWindow("Wypełnij pola poprawnie");
                return;
            }
            /*
            var values = (object[])parameter;

            int iNumber;
            int val = 0;
            bool isNumeric1 = int.TryParse((string)values[2].ToString(), out iNumber);
            if (isNumeric1)
            {
                val = int.Parse((string)values[2].ToString());
            }
            else
            {
                ShowInfoWindow("Wypełnij pola poprawnie");
                return;
            }
            Record currentRecord = (Record)values[3];
            if (values[1] != null && values[1].ToString() == currentRecord.Name)
            {
                string role = (string)values[1].ToString();
            }
            else if (values[3] != null)
            {
                ShowInfoWindow("Nie można zmienić nazwy");
                return;
            }


            foreach (Record item in record.Where(x => x.ID == currentRecord.ID))
            {
                item.Val = int.Parse((string)values[2].ToString());
            }
            */
            ///
            var values = (object[])parameter;

            int iNumber;
            int val = 0;
            bool isNumeric1 = int.TryParse((string)values[1].ToString(), out iNumber);
            if (isNumeric1)
            {
                val = int.Parse((string)values[1].ToString());
            }
            else
            {
                ShowInfoWindow("Wypełnij pola poprawnie");
                return;
            }

            Record currentRecord = (Record)values[3];
            long newOwnerID = Int32.Parse(values[2].ToString());
            player.Where(x => x.ID == currentRecord.OwnerID).FirstOrDefault().removeRecord(currentRecord);
            foreach (Record item in record.Where(x => x.ID == currentRecord.ID))
            {
                item.Name = values[0].ToString();
                item.Val = val;
                item.OwnerID = newOwnerID;
                player.Where(x => x.ID == newOwnerID).FirstOrDefault().addRecord(item);
            }

        }

        #endregion

        #region Club

        private void RemoveClub(object parameter)
        {
            if (!ValidateParamsAsObject(parameter))
            {
                ShowInfoWindow("Nie wybrano klubu");
                return;
            }
            var values = (Club)parameter;
            club.Remove(values);
        }

        private void AddClub(object parameter)
        {
            if (!ValidateParams(parameter))
            {
                ShowInfoWindow("Wypełnij pola poprawnie");
                return;
            }
            var values = (object[])parameter;
            Stadium stadium = (Stadium)values[1];
            Club c=new Club{
                ID=Helpers.FindMaxValue(club,x=>x.ID)+1,
                Name=values[0].ToString(),
                StadiumID=stadium.ID,
            };
            club.Add(c);

        }

        private void EditClub(object parameter)
        {
            if (!ValidateParams(parameter))
            {
                ShowInfoWindow("Wypełnij pola poprawnie");
                return;
            }
            var values = (object[])parameter;
            Stadium stadium = (Stadium)values[1];
            Club currentClub = (Club)values[2];
            foreach (Club item in club.Where(x=>x.ID==currentClub.ID))
            {
                item.Name = values[0].ToString();
                item.StadiumID = stadium.ID;
            }

        }

        #endregion

        #region Stadium

        private void RemoveStadium(object parameter)
        {
            if (!ValidateParamsAsObject(parameter))
            {
                ShowInfoWindow("Nie wybrano stadionu");
                return;
            }
            var values = (Stadium)parameter;
            stadium.Remove(values);
        }

        private void AddStadium(object parameter)
        {
            if (!ValidateParams(parameter))
            {
                ShowInfoWindow("Wypełnij pola poprawnie");
                return;
            }
            var values = (object[])parameter;
            Stadium s = new Stadium
            {
                ID= Helpers.FindMaxValue(stadium, x => x.ID)+1,
                Name = values[0].ToString(),
                City = values[1].ToString(),
                Country = values[2].ToString()
            };
            stadium.Add(s);
        }

        private void EditStadium(object parameter)
        {
            if (!ValidateParams(parameter))
            {
                ShowInfoWindow("Wypełnij pola poprawnie");
                return;
            }
            var values = (object[])parameter;
            Stadium currentStadium = (Stadium)values[3];
            foreach (Stadium item in stadium.Where(x => x.ID == currentStadium.ID))
            {
                item.Name = values[0].ToString();
                item.City = values[1].ToString();
                item.Country = values[2].ToString();
            }
        }

        #endregion

        #region File Operation

        #region Save

        public void Save(object parameters)
        {
            SaveStadium();
            SaveClub();
            SaveMatch();
            SaveTicket();
            SaveReferee();
            SavePlayer();
            SaveRecord();
        }

        private void SaveReferee()
        {
            string json = JsonConvert.SerializeObject(reffere);
            string fileName = "referee.txt";
            string path = Path.Combine(Environment.CurrentDirectory, fileName);
            System.IO.File.WriteAllText(path, json);
        }

        private void SaveTicket()
        {
            string json = JsonConvert.SerializeObject(ticket);
            string fileName = "ticket.txt";
            string path = Path.Combine(Environment.CurrentDirectory, fileName);
            System.IO.File.WriteAllText(path, json);
        }

        private void SaveMatch()
        {
            string json = JsonConvert.SerializeObject(match);
            string fileName = "match.txt";
            string path = Path.Combine(Environment.CurrentDirectory, fileName);
            System.IO.File.WriteAllText(path, json);
        }

        private void SavePlayer()
        {
            string json = JsonConvert.SerializeObject(player);
            string fileName = "player.txt";
            string path = Path.Combine(Environment.CurrentDirectory, fileName);
            System.IO.File.WriteAllText(path, json);
        }

        private void SaveRecord()
        {
            string json = JsonConvert.SerializeObject(record);
            string fileName = "record.txt";
            string path = Path.Combine(Environment.CurrentDirectory, fileName);
            System.IO.File.WriteAllText(path, json);
        }

        private void SaveClub()
        {
            string json = JsonConvert.SerializeObject(club);
            string fileName = "club.txt";
            string path = Path.Combine(Environment.CurrentDirectory, fileName);
            System.IO.File.WriteAllText(path, json);
        }

        private void SaveStadium()
        {
            string json = JsonConvert.SerializeObject(stadium);
            string fileName = "stadium.txt";
            string path = Path.Combine(Environment.CurrentDirectory, fileName);
            System.IO.File.WriteAllText(path, json);
        }

        #endregion

        #region Load

        public void Load(object parameters)
        {
            LoadStadium();
            LoadClub();
            LoadMatch();
            LoadTicket();
            LoadReferee();
            LoadPlayer();
            LoadRecord();
        }

        private void LoadReferee()
        {
            string fileName = "referee.txt";
            string path = Path.Combine(Environment.CurrentDirectory, fileName);
            string json = System.IO.File.ReadAllText(path);
            var result = JsonConvert.DeserializeObject<ObservableCollection<RefereeView>>(json);
            if (result != null)
            {
                foreach (var item in result)
                {
                    refereeView.Add(item);
                }
            }
            UpdatRefereeBase();
            UpdatRefereeGrid();
        }

        private void LoadTicket()
        {
            string fileName = "ticket.txt";
            string path = Path.Combine(Environment.CurrentDirectory, fileName);
            string json = System.IO.File.ReadAllText(path);
            var result = JsonConvert.DeserializeObject<ObservableCollection<Ticket>>(json);
            if (result != null)
            {
                foreach (var item in result)
                {
                    ticket.Add(item);
                    match.Where(x => x.ID == item.MatchID).FirstOrDefault().Attach(item);
                }
            }
        }

        private void LoadMatch()
        {
            string fileName = "match.txt";
            string path = Path.Combine(Environment.CurrentDirectory, fileName);
            string json = System.IO.File.ReadAllText(path);
            var result = JsonConvert.DeserializeObject<ObservableCollection<Match>>(json);
            if (result != null)
            {
                foreach (var item in result)
                {
                    match.Add(item);
                }
            }
        }

        private void LoadRecord()
        {
            string fileName = "record.txt";
            string path = Path.Combine(Environment.CurrentDirectory, fileName);
            string json = System.IO.File.ReadAllText(path);
            var result = JsonConvert.DeserializeObject<ObservableCollection<Record>>(json);
            if (result != null)
            {
                foreach (var item in result)
                {
                    record.Add(item);
                }
            }
        }

        private void LoadPlayer()
        {
            string fileName = "player.txt";
            string path = Path.Combine(Environment.CurrentDirectory, fileName);
            string json = System.IO.File.ReadAllText(path);
            var result = JsonConvert.DeserializeObject<ObservableCollection<Player>>(json);
            if (result != null)
            {
                foreach (var item in result)
                {
                    player.Add(item);
                }
            }
        }

        private void LoadClub()
        {
            string fileName = "club.txt";
            string path = Path.Combine(Environment.CurrentDirectory, fileName);
            string json = System.IO.File.ReadAllText(path);
            var result = JsonConvert.DeserializeObject<ObservableCollection<Club>>(json);
            if (result != null)
            {
                foreach (var item in result)
                {
                    club.Add(item);
                }
            }
        }

        private void LoadStadium()
        {
            string fileName = "stadium.txt";
            string path = Path.Combine(Environment.CurrentDirectory, fileName);
            string json = System.IO.File.ReadAllText(path);
            var result = JsonConvert.DeserializeObject<ObservableCollection<Stadium>>(json);
            if (result != null)
            {
                foreach (var item in result)
                {
                    stadium.Add(item);
                }
            }
        }

        #endregion

        #endregion

        #region Other

        public void ShowInfoWindow(string info)
        {
            InfoWindow infoWindow = new InfoWindow(info);
            infoWindow.ShowDialog();
        }

        public bool ValidateParams(object parameter)
        {
            if (parameter == null)
            {
                return false;
            }
            var values = (object[])parameter;
            foreach (var item in values)
            {
                if (item==null)
                {
                    return false;
                }
                if (item as String == string.Empty)
                {
                    return false;
                }
            }
            return true;
        }

        public bool ValidateParamsAsObject(object parameter)
        {
            if (parameter == null)
            {
                return false;
            }
            return true;
        }

        #endregion
    }
}
