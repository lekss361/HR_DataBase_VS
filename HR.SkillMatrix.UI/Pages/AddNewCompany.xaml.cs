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
using HR_DataBase_VSBLL.Models;

namespace HR.SkillMatrix.UI.Pages
{
    /// <summary>
    /// Interaction logic for AddNew_Company.xaml
    /// </summary>
    public partial class AddNewCompany : Page
    {
        private readonly MainWindow _mainWindow;
        public AddNewCompany(MainWindow mainWindow)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
        }

        /// <summary>
        /// кнопка "Принять"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Save_Click(object sender, RoutedEventArgs e)
        {
            HR_DataBase_VSBLL.Models.Company companies = new HR_DataBase_VSBLL.Models.Company();

            companies.Name = textBoxName.Text;
            companies.Phone = textBoxPhone.Text;
            companies.Location = textBoxLocation.Text;
            companies.Direction = textBoxDirection.Text;
            companies.Description = textBoxDescription.Text;
        }
        /// <summary>
        /// кнопка "Назад"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            CreateNewPage createNewPage = new CreateNewPage(_mainWindow);
            _mainWindow.Content = createNewPage;
        }
        private void CreateLocation_Click(object sender, RoutedEventArgs e)
        {
            AddLocationMenu locationMenu = new AddLocationMenu(_mainWindow);
            _mainWindow.Content = locationMenu;
        }
    }
}
