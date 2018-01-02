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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Football
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SaC_Click(object sender, RoutedEventArgs e)
        {
            ClubsAndStadions window = new ClubsAndStadions();
            if (window.ShowDialog() == true)
            {
            }
        }

        private void PaS_Click(object sender, RoutedEventArgs e)
        {
            ClubStaff window = new ClubStaff();
            if (window.ShowDialog() == true)
            {
            }
        }

        private void Re_Click(object sender, RoutedEventArgs e)
        {
            Referees window = new Referees();
            if (window.ShowDialog() == true)
            {
            }
        }

        private void Seas_Click(object sender, RoutedEventArgs e)
        {
            Season window = new Season();
            if (window.ShowDialog() == true)
            {
            }
        }
    }
}
