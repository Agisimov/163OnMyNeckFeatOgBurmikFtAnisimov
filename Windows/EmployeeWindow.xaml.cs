using _163OnMyNeckFeatOgBurmikFtAnisimov.BD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
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
using static _163OnMyNeckFeatOgBurmikFtAnisimov.ClassHelper.EFClass;

namespace _163OnMyNeckFeatOgBurmikFtAnisimov.Windows
{
    /// <summary>
    /// Логика взаимодействия для EmployeeWindow.xaml
    /// </summary>
    public partial class EmployeeWindow : Window
    {
        public EmployeeWindow()
        {
            InitializeComponent();
            if (ClassHelper.EmployeeDataContextClass.employee.IdPost != 1 )
            {
                btnAddProd.Visibility = Visibility.Hidden;
            }

            EmpGrid.ItemsSource = context.Employee.ToList();
        }

        private void btnAddProd_Click(object sender, RoutedEventArgs e)
        {
            AddEmployeeWindow addEmployeeWindow = new AddEmployeeWindow();
            addEmployeeWindow.Show();
            this.Close();
        }

        private void edit_Click(object sender, RoutedEventArgs e)
        {
            context.SaveChanges();
            MessageBox.Show("Изменено");
        }
    }
}
