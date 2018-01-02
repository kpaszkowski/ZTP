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
    /// Interaction logic for Referee.xaml
    /// </summary>
    public partial class Referees : Window
    {
        public Referees()
        {
            InitializeComponent();
        }

        private void AddReferee_Click(object sender, RoutedEventArgs e)
        {
            NewReferee window = new NewReferee();
            if (window.ShowDialog() == true)
            {
            }
        }
    }
}
