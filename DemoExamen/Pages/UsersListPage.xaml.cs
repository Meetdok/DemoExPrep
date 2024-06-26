﻿using DemoExamen.ViewModels;
using DemoExamen.Windows;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DemoExamen.Pages
{
    /// <summary>
    /// Логика взаимодействия для UsersListPage.xaml
    /// </summary>
    public partial class UsersListPage : Page
    {
        public UsersListPage()
        {
            InitializeComponent();
            DataContext = new UsersListVM();
        }

        private void AddEmp(object sender, RoutedEventArgs e)
        {
            AddEmpWin ad = new AddEmpWin();
            ad.Show();
        }
    }
}
