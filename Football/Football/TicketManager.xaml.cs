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
    /// Interaction logic for TicketManager.xaml
    /// </summary>
    public partial class TicketManager : Window
    {
        public TicketManager()
        {
            InitializeComponent();
        }

        private void Button_Cancel(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
