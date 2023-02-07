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
    public partial class AddDept : Window {

        private HrContext db = new HrContext();

        public AddDept() {
            InitializeComponent();

            cbLocs.ItemsSource = db.Locations.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            this.Close();
        }

        private void btSave_Click(object sender, RoutedEventArgs e) {

            var dept = new Department();
            dept.DepartmentId = long.Parse(tbDeptId.Text);
            dept.DepartmentName = tbDeptName.Text;
            dept.Location = cbLocs.SelectedItem as Location;

            db.Departments.Add(dept);
            db.SaveChanges();
            this.Close();
        }
    }
}
