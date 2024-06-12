using DemoExamen.Database;
using DemoExamen.Models;
using DemoExamen.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoExamen.ViewModels
{
    public class OrdersListVM : BaseVM
    {
        public List<Order> Orders { get; set; }

        public OrdersListVM()
        {
            Orders = DemoExamenBDContext.GetInstance().Orders.ToList();
        }  
    }
}
