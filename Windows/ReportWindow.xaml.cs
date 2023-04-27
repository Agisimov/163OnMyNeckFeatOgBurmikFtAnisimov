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
using static _163OnMyNeckFeatOgBurmikFtAnisimov.ClassHelper.EFClass;

namespace _163OnMyNeckFeatOgBurmikFtAnisimov.Windows
{
    /// <summary>
    /// Логика взаимодействия для ReportWindow.xaml
    /// </summary>
    public partial class ReportWindow : Window
    {
        public ReportWindow()
        {
            InitializeComponent();
            RepGrid.ItemsSource = context.ProductSale.ToList();
        }

        private void Ot_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            RepGrid.ItemsSource = context.ProductSale.ToList().Where(i => i.Sale.Date > Ot.SelectedDate.Value);
        }

        private void Second_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            RepGrid.ItemsSource = context.ProductSale.ToList().Where(i => i.Sale.Date < Second.SelectedDate.Value);
        }
    }
}
