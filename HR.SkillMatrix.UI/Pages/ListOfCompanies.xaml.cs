using HR_DataBase_VSBLL.Mappers;
using HR_DataBase_VSBLL.Models;
using HR_DataBase_VSDAL.Models;
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
using HR.SkillMatrix.UI.Windows;

namespace HR.SkillMatrix.UI.Pages
{
    /// <summary>
    /// Interaction logic for ListOfCompanies.xaml
    /// </summary>
    public partial class ListOfCompanies : Page
    {
        public Company Company;
        private int id;
        private readonly MainWindow _mainWindow;
        private readonly NewWindow _newWindow;
        public ListOfCompanies(MainWindow mainWindow)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
            MapperCompanies mapperCompanies = new MapperCompanies();
            DataGridCompanies.ItemsSource = mapperCompanies.GetAllCompaniesWithContactAndLocation();
        }
        public ListOfCompanies(NewWindow newWindow)
        {
            InitializeComponent();
            _newWindow = newWindow;
            MapperCompanies mapperCompanies = new MapperCompanies();
            DataGridCompanies.ItemsSource = mapperCompanies.GetAllCompaniesWithContactAndLocation();
        }
        private void DataGridCompanies_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DataGrid dg = (DataGrid)sender;
            CompaniesWithContactAndLocation item = (CompaniesWithContactAndLocation)dg.CurrentItem;
            if (item != null)
            {
                id = item.id;
            }
            Company.Id = id;
        }

        private void ButtonBack_Click(object sender, RoutedEventArgs e)
        {
            MainMenu mainMenu = new MainMenu(_mainWindow);
            _mainWindow.Content = mainMenu;
        }

        private void ButtonOpen_OnClick(object sender, RoutedEventArgs e)
        {
            AboutCompany aboutCompany = new AboutCompany(_mainWindow, id);
            _mainWindow.Content = aboutCompany;
        }

        private void ButtonChose_OnClick(object sender, RoutedEventArgs e)
        {
            _newWindow.Close();
        }
    }
}