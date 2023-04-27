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
using _163OnMyNeckFeatOgBurmikFtAnisimov.BD;
using _163OnMyNeckFeatOgBurmikFtAnisimov.ClassHelper;
using static _163OnMyNeckFeatOgBurmikFtAnisimov.ClassHelper.EFClass;
using static _163OnMyNeckFeatOgBurmikFtAnisimov.ClassHelper.CartClass;
using System.Windows.Shapes;
using System.Collections.ObjectModel;

namespace _163OnMyNeckFeatOgBurmikFtAnisimov.Windows
{
    
    /// <summary>
    /// Логика взаимодействия для CartWindow.xaml
    /// </summary>
    public partial class CartWindow : Window
    {
        public CartWindow()
        {
            InitializeComponent();
            GetListProduct();
        }


        private void GetListProduct()
        {
            ObservableCollection<BD.Product> products = new ObservableCollection<BD.Product>(ClassHelper.CartClass.Products);

            CartList.ItemsSource = products;
        }

        private void BtnRemoveToCart_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            if (button == null)
            {
                return;
            }

            var selectedProduct = button.DataContext as BD.Product;


            if (selectedProduct != null)
            {
                CartClass.Products.Remove(selectedProduct);
            }
            GetListProduct();
        }

        private void btnAddOnCart_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            if (button == null)
            {
                return;
            }

            BD.Product selectedProduct = button.DataContext as BD.Product;
            if (selectedProduct != null)
            {
                selectedProduct.Quantity++;
                int o = Products.IndexOf(selectedProduct);
                Products.Remove(selectedProduct);
                Products.Insert(o, selectedProduct);
            }
            GetListProduct();
        }

        private void Pay_Click(object sender, RoutedEventArgs e)
        {
            BD.Sale sale = new BD.Sale();
            sale.IdEmployee = ClassHelper.EmployeeDataContextClass.employee.Id;
            sale.IdClient = 1;
            sale.Date = DateTime.Now;
            if (sale != null)
            {
                context.Sale.Add(sale);
                context.SaveChanges();
            }


            foreach (var item in Products)
            {
                BD.ProductSale productSale = new BD.ProductSale();
                productSale.IdProduct = item.Id;
                productSale.Quantity = item.Quantity;
                productSale.IdSale = context.Sale.ToList().LastOrDefault().Id;
                context.ProductSale.Add(productSale);
                context.SaveChanges();
            }
            MessageBox.Show("Продукты успешно добавлены");
            ProductListWindow productListWindow = new ProductListWindow();
            productListWindow.Show();
            Close();
        }
    }
    
}