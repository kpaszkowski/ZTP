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
        public ObservableCollection<StadiumViewModel> stadium { get; set; }
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
        public RelayCommand AddStadiumCommand { get; set; }
        public RelayCommand RemoveStadiumCommand { get; set; }

        public MainViewModel()
        {
            InitializeCommands();
            UpdateGrid();
        }

        private void InitializeCommands()
        {
            AddStadiumCommand = new RelayCommand(AddStadium);
            RemoveStadiumCommand = new RelayCommand(RemoveStadium);

            stadium = new ObservableCollection<StadiumViewModel>();
        }

        void AddStadium(object parameter)
        {
            if (parameter == null) return;
            var values = (object[])parameter;
            StadiumService stadiumService = new StadiumService();
            Stadium s = new Stadium
            {
                name = values[0].ToString(),
                city = values[1].ToString(),
                country =values[2].ToString()
            };
            stadiumService.AddStadium(s);
            UpdateGrid();
        }

        void RemoveStadium(object parameter)//usuwanie po wyszukiwaniu
        {
            if (parameter == null) return;
            var values = (StadiumViewModel)parameter;
            StadiumService stadiumService = new StadiumService();
            stadiumService.RemoveStadium(values.Name,values.City,values.Country);
            UpdateGrid();

        }

        void UpdateGrid()//Bieda update , czysci grida i od nowa laduje
        {
            StadiumService stadiumService = new StadiumService();
            var s = stadiumService.GetAllStadium();
            stadium.Clear();
            foreach (Stadium item in s)
            {
                stadium.Add(new StadiumViewModel { Name = item.name, City = item.city, Country = item.country });
            }
        }
    }
}
