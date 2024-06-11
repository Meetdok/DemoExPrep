using DemoExamen.Database;
using DemoExamen.Models;
using DemoExamen.Pages;
using DemoExamen.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace DemoExamen.ViewModels
{
    public class AddUserVM : BaseVM
    {
        public Page currentPage;
        public Page CurrentPage
        {
            get => currentPage;
            set
            {
                currentPage = value;
                SignalChanged();
            }
        }

        public string Login { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
        public string UserLastName { get; set; }
        public string Patronomyc { get; set; }

        public List<Userrole> Roles { get; set; }
        public Userrole selectRole;
        public Userrole SelectedRole
        {
            get => selectRole;
            set
            {
                selectRole = value;
                SignalChanged();
            }
        }

        public CommandVM Back { get; set; }
        public CommandVM SaveUser { get; set; }

        public AddUserVM() 
        {
            Roles = DemoExamenBDContext.GetInstance().Userroles.ToList();

            SaveUser = new CommandVM(() =>
            {
                try
                {
                    if (Login == null || Password == null || UserName == null || UserLastName == null || Patronomyc == null || SelectedRole == null)
                    {
                        MessageBox.Show("Введены не все данные!");
                        return;
                    }
                    else
                    {
                        var user = new User()
                        {
                            Login = Login,
                            Password = Password,
                            Firstname = UserName,
                            Lastname = UserLastName,
                            Middlename = Patronomyc,
                            Status = null,
                            Userroleid = SelectedRole.Userroleid
                        };

                        DemoExamenBDContext.GetInstance().Users.Add(user);
                        DemoExamenBDContext.GetInstance().SaveChanges();
                        MessageBox.Show("Сотрудник добавлен!");
                    }                  
                }
                catch
                {
                    MessageBox.Show("Неизвестная ошибка");
                }
            });

            Back = new CommandVM(() =>
            {
                CurrentPage = new UsersListPage();
            });
        }
    }
}
