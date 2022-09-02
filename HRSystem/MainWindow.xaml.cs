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

        private hrContext db = new hrContext();
        private List<Employee> Employees {
            get {
                return db.Employees.ToList();
            }
        }
        private List<Department> Departments {
            get {
                var lst = db.Departments.ToList();
                var dept = new Department();
                dept.DepartmentName = "";
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
            if (dept == null || dept.DepartmentName == "") {
                dgEmps.ItemsSource = Employees;
            }
            else {
                dgEmps.ItemsSource = dept.Employees;
            }
        }

        private void tbSearch_TextChanged(object sender, TextChangedEventArgs e) {
            var prefix = tbSearch.Text.ToLower();
            if (prefix.Equals("")) {
                dgEmps.ItemsSource = Employees;
            }
            else {
                var data = Employees.Where(e => e.FirstName.ToLower().StartsWith(prefix)
                                                || e.LastName.ToLower().StartsWith(prefix));
                dgEmps.ItemsSource = data;
            }
        }

        private void btAddDept_Click(object sender, RoutedEventArgs e) {
            var dialog = new AddDept();
            dialog.ShowDialog();
            cbDepts.ItemsSource = Departments;
        }

        private void btDelDept_Click(object sender, RoutedEventArgs e) {
            var dept = cbDepts.SelectedItem as Department;
            if (dept != null || !dept.DepartmentName.Equals("")) {
                var choice = MessageBox.Show($"Delete department {dept.DepartmentName}",
                                            "Delete Warrning", MessageBoxButton.YesNo);
                if (choice == MessageBoxResult.Yes) {
                    db.Departments.Remove(dept);
                    db.SaveChanges();
                    cbDepts.ItemsSource = Departments;
                }

            }
        }

        private void btAddEmp_Click(object sender, RoutedEventArgs e) {
            var dialog = new AddEmp();
            dialog.ShowDialog();
            dgEmps.ItemsSource = Employees;
        }

        private void btDelEmp_Click(object sender, RoutedEventArgs e) {
            var emp = dgEmps.SelectedItem as Employee;
            if (emp != null) {
                var choice = MessageBox.Show($"Delete Employee {emp.LastName}",
                                            "Delete Warrning", MessageBoxButton.YesNo);
                if (choice == MessageBoxResult.Yes) {
                    db.Employees.Remove(emp);
                    db.SaveChanges();
                    dgEmps.ItemsSource = Employees;
                }

            }
        }

        private void btExport_Click(object sender, RoutedEventArgs e) {
            var dialog = new SaveFileDialog();
            dialog.Filter = "CSV File |*.csv";
            var saved = dialog.ShowDialog();
            if (saved == true) {
                using (var sw = new StreamWriter(dialog.FileName)) {
                    foreach (var col in dgEmps.Columns) {
                        sw.Write(col.Header.ToString() + ",");
                    }
                    sw.WriteLine();
                    foreach (var row in dgEmps.Items) {
                        switch (row) {
                            case Employee emp:
                                sw.WriteLine($"{emp.EmployeeId}, {emp.FirstName},{emp.LastName},{emp.Email},{emp.PhoneNumber},{emp.HireDate},{emp.JobId},{emp.Salary},{emp.ManagerId},{emp.DepartmentId}");
                                break;
                        }
                    }
                }
            }
        }

        private void btExit_Click(object sender, RoutedEventArgs e) {
            this.Close();
        }

        private void FilterByDateRange(object sender, SelectionChangedEventArgs e) {
            var startDate = dpStart.SelectedDate;
            var endDate = dpEnd.SelectedDate;
            if (startDate == null || endDate == null) {
                return;
            }

            if (startDate < endDate) {
                dgEmps.ItemsSource = Employees.Where(e => DateTime.Parse(e.HireDate) >= startDate
                                                        && DateTime.Parse(e.HireDate) <= endDate);
            }
        }
    }
}
