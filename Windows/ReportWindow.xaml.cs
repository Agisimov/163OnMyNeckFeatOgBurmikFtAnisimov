using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
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
            for (int i = 0; i < 14; i++)
            {
                PoMes.Items.Add(DateTime.Now.Year - i );
            }
        }

        private void Ot_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            RepGrid.ItemsSource = context.ProductSale.ToList().Where(i => i.Sale.Date > Ot.SelectedDate.Value);
        }

        private void Second_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            RepGrid.ItemsSource = context.ProductSale.ToList().Where(i => i.Sale.Date < Second.SelectedDate.Value);
        }

        private void PoGodam_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DateTime dateTime = new DateTime(DateTime.Now.Year, 1,1 );
            DateTime dateTime2 = new DateTime(DateTime.Now.Year, 1,31 );


            switch(PoGodam.SelectedIndex)
            {
                case 0:
                    RepGrid.ItemsSource = context.ProductSale.ToList().Where(i => i.Sale.Date > dateTime && i.Sale.Date < dateTime2);

                    break;

                case 1:
                     dateTime = new DateTime(DateTime.Now.Year, 2, 1);
                     dateTime2 = new DateTime(DateTime.Now.Year, 2, 28);
                    RepGrid.ItemsSource = context.ProductSale.ToList().Where(i => i.Sale.Date > dateTime && i.Sale.Date < dateTime2);
                    break;

                case 2:
                    dateTime = new DateTime(DateTime.Now.Year, 3, 1);
                    dateTime2 = new DateTime(DateTime.Now.Year, 3, 31);
                    RepGrid.ItemsSource = context.ProductSale.ToList().Where(i => i.Sale.Date > dateTime && i.Sale.Date < dateTime2);
                    break;

                case 3:
                    dateTime = new DateTime(DateTime.Now.Year, 4, 1);
                    dateTime2 = new DateTime(DateTime.Now.Year, 4, 30);
                    RepGrid.ItemsSource = context.ProductSale.ToList().Where(i => i.Sale.Date > dateTime && i.Sale.Date < dateTime2);
                    break;

                case 4:
                    dateTime = new DateTime(DateTime.Now.Year, 5, 1);
                    dateTime2 = new DateTime(DateTime.Now.Year, 5, 31);
                    RepGrid.ItemsSource = context.ProductSale.ToList().Where(i => i.Sale.Date > dateTime && i.Sale.Date < dateTime2);
                    break;

                case 5:
                    dateTime = new DateTime(DateTime.Now.Year, 6, 1);
                    dateTime2 = new DateTime(DateTime.Now.Year, 6, 30);
                    RepGrid.ItemsSource = context.ProductSale.ToList().Where(i => i.Sale.Date > dateTime && i.Sale.Date < dateTime2);
                    break;

                case 6:
                    dateTime = new DateTime(DateTime.Now.Year, 7, 1);
                    dateTime2 = new DateTime(DateTime.Now.Year, 7, 31);
                    RepGrid.ItemsSource = context.ProductSale.ToList().Where(i => i.Sale.Date > dateTime && i.Sale.Date < dateTime2);
                    break;

                case 7:
                    dateTime = new DateTime(DateTime.Now.Year, 8, 1);
                    dateTime2 = new DateTime(DateTime.Now.Year, 8, 31);
                    RepGrid.ItemsSource = context.ProductSale.ToList().Where(i => i.Sale.Date > dateTime && i.Sale.Date < dateTime2);
                    break;

                case 8:
                    dateTime = new DateTime(DateTime.Now.Year, 9, 1);
                    dateTime2 = new DateTime(DateTime.Now.Year, 9, 30);
                    RepGrid.ItemsSource = context.ProductSale.ToList().Where(i => i.Sale.Date > dateTime && i.Sale.Date < dateTime2);
                    break;

                case 9:
                    dateTime = new DateTime(DateTime.Now.Year, 10, 1);
                    dateTime2 = new DateTime(DateTime.Now.Year, 10, 31);
                    RepGrid.ItemsSource = context.ProductSale.ToList().Where(i => i.Sale.Date > dateTime && i.Sale.Date < dateTime2);
                    break;

                case 10:
                    dateTime = new DateTime(DateTime.Now.Year, 11, 1);
                    dateTime2 = new DateTime(DateTime.Now.Year, 11, 30);
                    RepGrid.ItemsSource = context.ProductSale.ToList().Where(i => i.Sale.Date > dateTime && i.Sale.Date < dateTime2);
                    break;

                case 11:
                    dateTime = new DateTime(DateTime.Now.Year, 12, 1);
                    dateTime2 = new DateTime(DateTime.Now.Year, 12, 31);
                    RepGrid.ItemsSource = context.ProductSale.ToList().Where(i => i.Sale.Date > dateTime && i.Sale.Date < dateTime2);
                    break;
            }
            
                
        }

        private void PoMes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            DateTime dateTime = new DateTime(DateTime.Now.Year, 1, 1);
            DateTime dateTime2 = new DateTime(DateTime.Now.Year, 12, 31);
            switch(PoMes.SelectedIndex)
            {
                case 0:
                    RepGrid.ItemsSource = context.ProductSale.ToList().Where(i => i.Sale.Date > dateTime && i.Sale.Date < dateTime2);

                    break;

                case 1:
                    dateTime = new DateTime(DateTime.Now.Year-1, 1, 1);
                    dateTime2 = new DateTime(DateTime.Now.Year-1, 12, 28);
                    RepGrid.ItemsSource = context.ProductSale.ToList().Where(i => i.Sale.Date > dateTime && i.Sale.Date < dateTime2);
                    break;

                case 2:
                    dateTime = new DateTime(DateTime.Now.Year-2, 3, 1);
                    dateTime2 = new DateTime(DateTime.Now.Year-2, 3, 31);
                    RepGrid.ItemsSource = context.ProductSale.ToList().Where(i => i.Sale.Date > dateTime && i.Sale.Date < dateTime2);
                    break;

                case 3:
                    dateTime = new DateTime(DateTime.Now.Year-3, 4, 1);
                    dateTime2 = new DateTime(DateTime.Now.Year-3, 4, 30);
                    RepGrid.ItemsSource = context.ProductSale.ToList().Where(i => i.Sale.Date > dateTime && i.Sale.Date < dateTime2);
                    break;

                case 4:
                    dateTime = new DateTime(DateTime.Now.Year-4, 5, 1);
                    dateTime2 = new DateTime(DateTime.Now.Year-4, 5, 31);
                    RepGrid.ItemsSource = context.ProductSale.ToList().Where(i => i.Sale.Date > dateTime && i.Sale.Date < dateTime2);
                    break;

                case 5:
                    dateTime = new DateTime(DateTime.Now.Year-5, 6, 1);
                    dateTime2 = new DateTime(DateTime.Now.Year-5, 6, 30);
                    RepGrid.ItemsSource = context.ProductSale.ToList().Where(i => i.Sale.Date > dateTime && i.Sale.Date < dateTime2);
                    break;

                case 6:
                    dateTime = new DateTime(DateTime.Now.Year-6, 7, 1);
                    dateTime2 = new DateTime(DateTime.Now.Year-6, 7, 31);
                    RepGrid.ItemsSource = context.ProductSale.ToList().Where(i => i.Sale.Date > dateTime && i.Sale.Date < dateTime2);
                    break;

                case 7:
                    dateTime = new DateTime(DateTime.Now.Year-7, 8, 1);
                    dateTime2 = new DateTime(DateTime.Now.Year-7, 8, 31);
                    RepGrid.ItemsSource = context.ProductSale.ToList().Where(i => i.Sale.Date > dateTime && i.Sale.Date < dateTime2);
                    break;

                case 8:
                    dateTime = new DateTime(DateTime.Now.Year-8, 9, 1);
                    dateTime2 = new DateTime(DateTime.Now.Year-8, 9, 30);
                    RepGrid.ItemsSource = context.ProductSale.ToList().Where(i => i.Sale.Date > dateTime && i.Sale.Date < dateTime2);
                    break;

                case 9:
                    dateTime = new DateTime(DateTime.Now.Year-9, 10, 1);
                    dateTime2 = new DateTime(DateTime.Now.Year-9, 10, 31);
                    RepGrid.ItemsSource = context.ProductSale.ToList().Where(i => i.Sale.Date > dateTime && i.Sale.Date < dateTime2);
                    break;

                case 10:
                    dateTime = new DateTime(DateTime.Now.Year-10, 11, 1);
                    dateTime2 = new DateTime(DateTime.Now.Year-10, 11, 30);
                    RepGrid.ItemsSource = context.ProductSale.ToList().Where(i => i.Sale.Date > dateTime && i.Sale.Date < dateTime2);
                    break;

                case 11:
                    dateTime = new DateTime(DateTime.Now.Year-11, 12, 1);
                    dateTime2 = new DateTime(DateTime.Now.Year-11, 12, 31);
                    RepGrid.ItemsSource = context.ProductSale.ToList().Where(i => i.Sale.Date > dateTime && i.Sale.Date < dateTime2);
                    break;
                case 12:
                    dateTime = new DateTime(DateTime.Now.Year - 12, 12, 1);
                    dateTime2 = new DateTime(DateTime.Now.Year - 12, 12, 31);
                    RepGrid.ItemsSource = context.ProductSale.ToList().Where(i => i.Sale.Date > dateTime && i.Sale.Date < dateTime2);
                    break;
                case 13:
                    dateTime = new DateTime(DateTime.Now.Year - 13, 12, 1);
                    dateTime2 = new DateTime(DateTime.Now.Year - 13, 12, 31);
                    RepGrid.ItemsSource = context.ProductSale.ToList().Where(i => i.Sale.Date > dateTime && i.Sale.Date < dateTime2);
                    break;

            }
            
        }
    }
}
