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
    /// Interaction logic for ClubStaff.xaml
    /// </summary>
    public partial class ClubStaff : Window
    {
        public ClubStaff()
        {
            InitializeComponent();
        }

        private void AddPlayer_Click(object sender, RoutedEventArgs e)
        {
            AddPlayer window = new AddPlayer();
            if (window.ShowDialog() == true)
            {
            }
        }

        private void AddStaff_Click(object sender, RoutedEventArgs e)
        {
            AddStaff window = new AddStaff();
            if (window.ShowDialog() == true)
            {
            }
        }

        private void SearchPlayer_Click(object sender, RoutedEventArgs e)
        {
            SearchPlayer window = new SearchPlayer();
            if (window.ShowDialog() == true)
            {
            }

        }

        private void SearchStaff_Click(object sender, RoutedEventArgs e)
        {
            SearchStaff window = new SearchStaff();
            if (window.ShowDialog() == true)
            {
            }
        }
    }
}
