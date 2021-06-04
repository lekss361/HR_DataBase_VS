﻿using System;
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

namespace HR.SkillMatrix.UI.Pages
{
    /// <summary>
    /// Interaction logic for CreateNewPage.xaml
    /// </summary>
    public partial class CreateNewPage : Page
    {
        private readonly MainWindow _mainWindow;
        public CreateNewPage(MainWindow mainWindow)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
        }

        private void AddNewCompany_Click(object sender, RoutedEventArgs e)
        {
            AddNewCompany addNewCompany = new AddNewCompany(_mainWindow);
            _mainWindow.Content = addNewCompany;
        }

        //private void Back_Click(object sender, RoutedEventArgs e)
        //{
        //    MainWindow mainWindow = new MainWindow();
        //    _mainWindow.Content = mainWindow;
        //}
    }
}
