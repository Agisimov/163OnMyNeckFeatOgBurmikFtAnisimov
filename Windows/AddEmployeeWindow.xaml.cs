using _163OnMyNeckFeatOgBurmikFtAnisimov.BD;
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
using static _163OnMyNeckFeatOgBurmikFtAnisimov.ClassHelper.EmployeeDataContextClass;



namespace _163OnMyNeckFeatOgBurmikFtAnisimov.Windows
{
    /// <summary>
    /// Логика взаимодействия для AddEmployeeWindow.xaml
    /// </summary>
    public partial class AddEmployeeWindow : Window
    {
        public AddEmployeeWindow()
        {
            InitializeComponent();
            CBPost.ItemsSource = context.Post.ToList();
            CBPost.SelectedIndex = 0;
            CBPost.DisplayMemberPath = "Title";
            CBGender.ItemsSource = context.Gender.ToList();
            CBGender.SelectedItem = 0;
            CBGender.DisplayMemberPath = "Title";
        }

        private void Vhod_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextFirstName.Text))
            {
                MessageBox.Show("Имя не может быть пустым");
                return;
            }
            else if (string.IsNullOrWhiteSpace(TextLastName.Text))
            {
                MessageBox.Show("Фамилия не может быть пустой");
                return;
            }
            else if (string.IsNullOrWhiteSpace(TbBirthday.Text))
            {
                MessageBox.Show("Дата не может быть пустой"); return;
            }
            else if (string.IsNullOrWhiteSpace(TextPhone.Text))
            {
                MessageBox.Show("Телефон не может быть пустой"); return;
            }
            else if (string.IsNullOrWhiteSpace(TextLogin.Text))
            {
                MessageBox.Show("Логин не может быть пустой"); return;
            }
            else if (string.IsNullOrWhiteSpace(PBPasswoed.Password))
            {
                MessageBox.Show("Пароль не может быть пустой"); return;
            }
            else
            {
                MessageBox.Show("Работник добавлен"); ;
            }

            BD.Account account = new BD.Account();
            account.FName = TextFirstName.Text;
            account.LName = TextLastName.Text;
            account.Birthday = TextBirthday.SelectedDate.Value;
            account.Phone = TextPhone.Text;
            account.Login = TextLogin.Text;
            account.Password = PBPasswoed.Password;
            context.Account.Add(account);
            context.SaveChanges();
            BD.Employee employee = new Employee();
            employee.IdPost = (CBPost.SelectedItem as Post).Id;
            employee.IdAccount = context.Account.ToList().Where(i => i.Login == TextLogin.Text).FirstOrDefault().Id;
            employee.IdGender = (CBGender.SelectedItem as Gender).Id;
            context.Employee.Add(employee);
            context.SaveChanges();
            EmployeeWindow employeeWindow = new EmployeeWindow();
            employeeWindow.Show();
            this.Close();






          



        }

       
    }
}
