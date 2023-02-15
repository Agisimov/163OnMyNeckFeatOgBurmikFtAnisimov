using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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

namespace _163OnMyNeckFeatOgBurmikFtAnisimov.Windows
{
    /// <summary>
    /// Логика взаимодействия для AthorizationWindow.xaml
    /// </summary>
    public partial class AthorizationWindow : Window
    {
        public AthorizationWindow()
        {
            InitializeComponent();
        }

        private void TBRegistr_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            RegistranionWindow registranionWindow = new RegistranionWindow();
            registranionWindow.Show();
            this.Close();
        }

        private void Vhod_Click(object sender, RoutedEventArgs e)
        {
            var authUser = context.Account.ToList()
            .Where(i => i.Login == TextLogin.Text && i.Password == PBPasswoed.Password)
            .FirstOrDefault();

            if (authUser != null)
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                
            }
            else
            {
                MessageBox.Show("нет такого пользователя");
            }
        }
    }
}
