using Football.Commands;
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
        #endregion

        public ObservableCollection<StadiumViewModel> stadium { get; set; }
        public ObservableCollection<ClubViewModel> club { get; set; }
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
        public RelayCommand AddStadiumCommand { get; set; }
        public RelayCommand RemoveStadiumCommand { get; set; }
        public RelayCommand AddClubCommand { get; set; }
        public RelayCommand RemoveClubCommand { get; set; }

        public MainViewModel()
        {
            InitializeCommands();
            UpdateStadiumGrid();
            UpdateClubGrid();
        }

        private void InitializeCommands()
        {
            AddStadiumCommand = new RelayCommand(AddStadium);
            RemoveStadiumCommand = new RelayCommand(RemoveStadium);
            AddClubCommand = new RelayCommand(AddClub);
            RemoveClubCommand = new RelayCommand(RemoveClub);

            stadium = new ObservableCollection<StadiumViewModel>();
            club = new ObservableCollection<ClubViewModel>();

            stadiumService = new StadiumService();
            clubService = new ClubService();
        }

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
