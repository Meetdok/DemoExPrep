using DemoExamen.Pages;
using DemoExamen.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace DemoExamen.ViewModels
{
    public class MainVM : BaseVM
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

        public CommandVM ToUsersPage { get; set; }
        public CommandVM ToOrdersPage { get; set; }
        public CommandVM ToShiftsPage { get; set; }

        public MainVM()
        {
            ToUsersPage = new CommandVM(() =>
            {
                CurrentPage = new UsersListPage();
            });

            ToOrdersPage = new CommandVM(() =>
            {
                CurrentPage = new OrdersListPage();
            });

            ToShiftsPage = new CommandVM(() =>
            {
                CurrentPage = new ShiftsListPage();
            });
        }
    }
}
