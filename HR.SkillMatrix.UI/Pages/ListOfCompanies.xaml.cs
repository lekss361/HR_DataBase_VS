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

namespace HR.SkillMatrix.UI.Pages
{
    /// <summary>
    /// Interaction logic for ListOfCompanies.xaml
    /// </summary>
    public partial class ListOfCompanies : Page
    {
        private readonly MainWindow _mainWindow;
        public ListOfCompanies(MainWindow mainWindow)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
            MapperCompanies mapperCompanies = new MapperCompanies();
            DataGridCompanies.ItemsSource = mapperCompanies.GetAllCompanies();
        }
        private void DataGridCompanies_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DataGrid dg = (DataGrid)sender;
            Company item = (Company)dg.CurrentItem;
            if (item != null)
            {
                int id = item.Id;
                AboutCompany aboutCompany = new AboutCompany(_mainWindow, id);
                _mainWindow.Content = aboutCompany;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainMenu mainMenu = new MainMenu(_mainWindow);
            _mainWindow.Content = mainMenu;
        }
    }
}
