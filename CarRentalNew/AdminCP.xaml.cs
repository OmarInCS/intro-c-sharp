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

namespace CarRentalNew {
    /// <summary>
    /// Interaction logic for AdminCP.xaml
    /// </summary>
    public partial class AdminCP : Window {
        public AdminCP() {
            InitializeComponent();
        }

        private void btLogout_Click(object sender, RoutedEventArgs e) {
            var win = new MainWindow();
            win.Show();
            this.Close();
        }

        private void btManageCars_Click(object sender, RoutedEventArgs e) {
            var win = new ManageCars();
            win.Show();
            //this.Close();
        }
    }
}
