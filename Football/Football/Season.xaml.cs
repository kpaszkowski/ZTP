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
    /// Interaction logic for Season.xaml
    /// </summary>
    public partial class Season : Window
    {
        public Season()
        {
            InitializeComponent();
        }

        private void Generate_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Ticket_Click(object sender, RoutedEventArgs e)
        {
            TicketManager window = new TicketManager();
            if (window.ShowDialog() == true)
            {
            }
        }
    }
}
