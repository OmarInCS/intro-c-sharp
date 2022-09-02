using HRSystem.Models;
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

namespace HRSystem {
    /// <summary>
    /// Interaction logic for AddDept.xaml
    /// </summary>
    public partial class AddEmp : Window {

        private static hrContext db = new hrContext();
        public AddEmp() {
            InitializeComponent();

            cbJobs.ItemsSource = db.Jobs.ToList();
            cbDepts.ItemsSource = db.Departments.ToList();
        }

        private void btSave_Click(object sender, RoutedEventArgs e) {
            var emp = new Employee();
            emp.EmployeeId = long.Parse(tbEmpId.Text);
            emp.LastName = tbEmpName.Text;
            emp.Email = tbEmail.Text;
            emp.HireDate = dpHireDate.Text;
            emp.Job = cbJobs.SelectedItem as Job;
            emp.Salary = double.Parse(tbSalary.Text);
            emp.Department = cbDepts.SelectedItem as Department;
            db.Employees.Add(emp);
            db.SaveChanges();
            this.Close();
        }
    }
}
