using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Football
{
    /// <summary>
    /// Interaction logic for ClubsAndStadions.xaml
    /// </summary>
    public partial class ClubsAndStadions : Window
    {
        public ClubsAndStadions()
        {
            InitializeComponent();
        }

        private void AddClub_Click(object sender, RoutedEventArgs e)
        {
            Clubs window = new Clubs();
            if (window.ShowDialog() == true)
            {
            }
        }

        private void AddStadium_Click(object sender, RoutedEventArgs e)
        {
            Stadiums window = new Stadiums();
            if (window.ShowDialog() == true)
            {
            }
        }
    }
}
