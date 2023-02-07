using HRSystem.Models;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace HRSystem {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {

        private HrContext db = new HrContext();
        private List<Employee> Employees => db.Employees.ToList();
        private List<Department> Departments {
            get {
                var lst = db.Departments.ToList();
                var dept = new Department();
                lst.Insert(0, dept);
                return lst;
            }
        }

        public MainWindow() {
            InitializeComponent();

            dgEmps.ItemsSource = Employees;
            cbDepts.ItemsSource = Departments;
        }

        private void cbDepts_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            var dept = cbDepts.SelectedItem as Department;

            if (dept == null || dept.DepartmentName == null) {
                dgEmps.ItemsSource = Employees;
            }
            else {
                dgEmps.ItemsSource = Employees.Where(e => e.DepartmentId == dept.DepartmentId).ToList();
            }
        }

        private void tbSearch_TextChanged(object sender, TextChangedEventArgs e) {

            var prefix = tbSearch.Text.ToLower();

            if (prefix == "") {
                dgEmps.ItemsSource = Employees;
            }
            else {
                dgEmps.ItemsSource = Employees.Where(e => e.FirstName.ToLower().StartsWith(prefix) 
                                                        || e.LastName.ToLower().StartsWith(prefix))
                                                .ToList();
            }

        }

        private void btAddDept_Click(object sender, RoutedEventArgs e) {

            var dialog = new AddDept();
            dialog.Owner = this;
            dialog.ShowDialog();
            cbDepts.ItemsSource = Departments;
        }

        private void btDelDept_Click(object sender, RoutedEventArgs e) {

            var dept = cbDepts.SelectedItem as Department;

            if (dept != null && dept.DepartmentName != null) {

                var choice = MessageBox.Show($"Delete department {dept.DepartmentName}"
                                            , "Delete Warrning", MessageBoxButton.YesNo);

                if (choice == MessageBoxResult.Yes) {
                    db.Departments.Remove(dept);
                    db.SaveChanges();
                    cbDepts.ItemsSource = Departments;
                }
            }

        }

        private void btExport_Click(object sender, RoutedEventArgs e) {

            var dialog = new SaveFileDialog();
            dialog.Filter = "CSV File |*.csv";
            var saved = dialog.ShowDialog();

            if (saved == true) {

                var sw = new StreamWriter(dialog.FileName);

                foreach (var col in dgEmps.Columns) {
                    sw.Write(col.Header.ToString() + ",");
                }
                sw.WriteLine();

                foreach (var item in dgEmps.Items) {
                    var emp = item as Employee;
                    if (emp != null) {
                        sw.WriteLine($"{emp.EmployeeId},{emp.FirstName},{emp.LastName},{emp.Email}");
                    }
                }


                sw.Close();

            }

        }
    }
}
