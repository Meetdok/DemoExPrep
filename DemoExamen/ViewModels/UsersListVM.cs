using DemoExamen.Database;
using DemoExamen.Models;
using DemoExamen.Tools;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DemoExamen.ViewModels
{
    public class UsersListVM : BaseVM
    {
        public List<User> Users { get; set; }
        public User SelectedUser { get; set; }
        public CommandVM ChangeStatus { get; set; }

        public UsersListVM()
        {
            Users = DemoExamenBDContext.GetInstance().Users.Include(s => s.Userrole).Include(s => s.StatusNavigation).ToList();

            ChangeStatus = new CommandVM(() =>
            {

                    if (SelectedUser == null)
                    {
                        MessageBox.Show("Ошибка! Не выбран пользователь");
                        return;
                    }
                    try
                    {
                        SelectedUser.Status = 1;
                       
                        if(SelectedUser.Userid == 0)
                        {
                            DemoExamenBDContext.GetInstance().Users.Add(SelectedUser);                          
                        }
                        DemoExamenBDContext.GetInstance().SaveChanges();
                        MessageBox.Show("Статус обновлён");
                       
                    }
                    catch
                    {
                    MessageBox.Show("Ошибка!");
                    }
            });
        }       
    }
}
