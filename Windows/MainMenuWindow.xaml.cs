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

namespace _163OnMyNeckFeatOgBurmikFtAnisimov.Windows
{
    /// <summary>
    /// Логика взаимодействия для MainMenuWindow.xaml
    /// </summary>
    public partial class MainMenuWindow : Window
    {
        public MainMenuWindow()
        {
            InitializeComponent();


        }

        private void BtnProd_Click(object sender, RoutedEventArgs e)
        {
            ProductListWindow productListWindow = new ProductListWindow();
            productListWindow.Show();
            this.Close();


        }

        private void BtnEmp_Click(object sender, RoutedEventArgs e)
        {
            EmployeeWindow employeeWindow = new EmployeeWindow();
            employeeWindow.Show();
            this.Close();
        }

        private void btnReport_Click(object sender, RoutedEventArgs e)
        {
            ReportMainWindow reportMainWindow = new ReportMainWindow();
            reportMainWindow.Show();
            this.Close();
        }
    }
}
