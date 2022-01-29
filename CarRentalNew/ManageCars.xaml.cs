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
    /// Interaction logic for ManageCars.xaml
    /// </summary>
    public partial class ManageCars : Window {

        private CarrentEntities db = new CarrentEntities();
        private List<car> CarsList {
            get {
                return db.cars.Select(row => row).ToList();
            }
        }


        public ManageCars() {
            InitializeComponent();

            dgCars.ItemsSource = CarsList;
        }

        private void btSave_Click(object sender, RoutedEventArgs e) {
            var car = db
                .cars
                .Where(row => row.reg_no == tbRegNo.Text)
                .Select(row => row)
                .FirstOrDefault();

            if (car is null) {
                car = new car();
                db.cars.Add(car);
            }

            car.reg_no = tbRegNo.Text;
            car.name = tbName.Text;
            car.mandate = Convert.ToInt32(tbMandate.Text);
            car.fees = Convert.ToDecimal(tbFees.Text);
            car.color = tbColor.Text;
            car.model = tbModel.Text;

            db.SaveChanges(); // commit the changes
            dgCars.ItemsSource = CarsList;  // refresh the table

        }

        private void dgCars_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            var car = dgCars.SelectedItem as car;

            if (car != null) {
                tbRegNo.Text = car.reg_no;
                tbName.Text = car.name;
                tbMandate.Text = car.mandate.ToString();
                tbFees.Text = car.fees.ToString();
                tbColor.Text = car.color;
                tbModel.Text = car.model;
            }
        }

        private void btNew_Click(object sender, RoutedEventArgs e) {
            tbRegNo.Text = "";
            tbName.Text = "";
            tbMandate.Text = "";
            tbFees.Text = "";
            tbColor.Text = "";
            tbModel.Text = "";

            dgCars.SelectedItem = null;
        }

        private void btDelete_Click(object sender, RoutedEventArgs e) {

            var car = dgCars.SelectedItem as car;

            if (car != null) {
                var choice = MessageBox.Show("Delete car: " + car.reg_no, "Warrning", MessageBoxButton.YesNo);

                if (choice == MessageBoxResult.Yes) {
                    db.cars.Remove(car);
                    db.SaveChanges(); // commit the changes
                    dgCars.ItemsSource = CarsList;  // refresh the table
                    btNew_Click(null, null);
                }
            }
        }
    }
}
