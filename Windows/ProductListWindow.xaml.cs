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
using _163OnMyNeckFeatOgBurmikFtAnisimov.BD;
using _163OnMyNeckFeatOgBurmikFtAnisimov.ClassHelper;
using static _163OnMyNeckFeatOgBurmikFtAnisimov.ClassHelper.EFClass;
using static _163OnMyNeckFeatOgBurmikFtAnisimov.ClassHelper.CartClass;



namespace _163OnMyNeckFeatOgBurmikFtAnisimov.Windows
{
    /// <summary>
    /// Логика взаимодействия для ProductListWindow.xaml
    /// </summary>
    public partial class ProductListWindow : Window
    {
        public ProductListWindow()
        {
            InitializeComponent();
            getAA();
            if (ClassHelper.EmployeeDataContextClass.employee.Post.Id !=1)
            {
                btnAddProd.Visibility = Visibility.Hidden;
            }
        }
        private void getAA()
        {
            List<Product> prodLists = new List<Product>();
            prodLists = context.Product.ToList();
            ProductList.ItemsSource = prodLists;
        }

        private void btnAddProd_Click(object sender, RoutedEventArgs e)
        {
            AddProdWindow1 addProdWindow1 = new AddProdWindow1();
            addProdWindow1.Show();
            this.Show();
        }

        private void BtnAddToCart_Click(object sender, RoutedEventArgs e)
        {
            bool seek = true;
            Button button = sender as Button;
            if (button == null)
            {
                return;
            }

            var selectedProduct = button.DataContext as BD.Product;


            if (selectedProduct != null)
            {
                for (int i = 0; i <  Products.Count; i++)
                {
                    if (Products[i] == selectedProduct)
                    {
                        Products[i].Quantity++;
                        seek = false;
                    }
                }
                if (seek)
                {
                    selectedProduct.Quantity = 1;
                    Products.Add(selectedProduct);
                }
            }



        }

        private void BtnGoToCart_Click(object sender, RoutedEventArgs e)
        {
            CartWindow cartWindow = new CartWindow();
            cartWindow.Show();
            

        }
    }
}
