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

namespace _163OnMyNeckFeatOgBurmikFtAnisimov.Windows
{
    /// <summary>
    /// Логика взаимодействия для RegistranionWindow.xaml
    /// </summary>
    public partial class RegistranionWindow : Window
    {
        public RegistranionWindow()
        {
            InitializeComponent();
        }

        private void Vhod_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextLogin.Text))
            {
                MessageBox.Show("Логин не может быть пустым") ;
                return;
            }
            if (string.IsNullOrWhiteSpace(TextFirstName.Text))
            {
                MessageBox.Show("Имя не может быть пустым");
                return;
            }

            if (string.IsNullOrWhiteSpace(TextLastName.Text))
            {
                MessageBox.Show("Фамилия не может быть пустым");
                return;
            }
            if (string.IsNullOrWhiteSpace(TextBirthday.Text))
            {
                MessageBox.Show("Дата не может быть пустой");
                return;
            }
            if (string.IsNullOrWhiteSpace(TextPhone.Text))
            {
                MessageBox.Show("Телефон не может быть пустой");
                return;
            }
            if (string.IsNullOrWhiteSpace(PBPasswoed.Password))
            {
                MessageBox.Show("Пароль не может быть пустым");
                return;
            }



            //проверка уникальность

            var authUser = context.Account.ToList()
           .Where(i => i.Login == TextFirstName.Text).FirstOrDefault();

            if (authUser != null)
            {
                MessageBox.Show("Логин занят") ;
                return;

            }

            BD.Account account = new Account();
            account.FName = TextFirstName.Text;
            account.LName = TextLastName.Text;
            account.Birthday = TextBirthday.SelectedDate.Value;
            account.Phone = TextPhone.Text;
            account.Login = TextLogin.Text;
            account.Password = PBPasswoed.Password;

            context.Account.Add(account);
            context.SaveChanges();
            MessageBox.Show("Ok");
        }

        private void Grid_DpiChanged(object sender, DpiChangedEventArgs e)
        {

        }
    }
}
