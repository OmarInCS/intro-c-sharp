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

namespace CarRentalNew {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, RoutedEventArgs e) {
            var db = new CarrentEntities();

            var username = tbUsername.Text;
            var password = pbPassword.Password;

            var query = db
                .accounts
                .Where((row) => row.username == username && row.password == password)
                .Select(row => row);

            if (query.Count() != 0) {
                var window = new AdminCP();
                window.Show();
                this.Close();
            }
            else {
                MessageBox.Show("Login Failed");
            }

        }
    }
}
