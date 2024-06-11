using DemoExamen.Database;
using DemoExamen.Windows;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DemoExamen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SignIn(object sender, RoutedEventArgs e)
        {
           
                if (txt_login.Text == null || txt_password.Text == null)
                {
                    MessageBox.Show("Ошибка! Не введены данные");
                    return;
                }

                else
                {
                    var auth = DemoExamenBDContext.GetInstance().Users.FirstOrDefault(s => s.Login == txt_login.Text && s.Password == txt_password.Text);

                    if(auth == null)
                    {
                        MessageBox.Show("Пользователь не найден или введены не верные данные");
                        return;
                    }

                    if(auth.Userroleid == 1)
                    {
                        AdminWin ad = new AdminWin();
                        ad.Show();
                        this.Close();
                    }
                    else if(auth.Userroleid == 2)
                    {
                        EmpWin emp = new EmpWin();
                        emp.Show();
                        this.Close();
                    }
                    else if (auth.Userroleid == 3)
                    {
                        UserWin us = new UserWin();
                        us.Show();
                        this.Close();
                    }
                }              
        }
    }
}