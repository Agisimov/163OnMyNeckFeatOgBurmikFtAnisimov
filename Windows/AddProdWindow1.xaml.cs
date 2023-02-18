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
using System.IO;
using Microsoft.Win32;
using _163OnMyNeckFeatOgBurmikFtAnisimov.ClassHelper;
using static _163OnMyNeckFeatOgBurmikFtAnisimov.ClassHelper.EFClass;

namespace _163OnMyNeckFeatOgBurmikFtAnisimov.Windows
{
    /// <summary>
    /// Логика взаимодействия для AddProdWindow1.xaml
    /// </summary>
    public partial class AddProdWindow1 : Window
    {
        private string pathPhoto = null;
        public AddProdWindow1()
        {
            InitializeComponent();

        
            cmbCatigory.SelectedIndex = 0;
            cmbCatigory.DisplayMemberPath = "Title";
            cmbCatigory.ItemsSource = context.Category.ToList();
        }

    

        private void Image_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                ImgProduct.Source = new BitmapImage(new Uri(openFileDialog.FileName));
                pathPhoto = openFileDialog.FileName;
            }
        }
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            Product product = new Product();
            product.Title = NameProduct.Text;
            product.Price = Convert.ToDecimal(PricePr.Text);
            product.IdСategory = (cmbCatigory.SelectedItem as Category).Id;
            if (pathPhoto != null)
            {
                product.Image = File.ReadAllBytes(pathPhoto);
            }

            context.Product.Add(product);

            context.SaveChanges();
            MessageBox.Show("OK");

        }
    }
}
