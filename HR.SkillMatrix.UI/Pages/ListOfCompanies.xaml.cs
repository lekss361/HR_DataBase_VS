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
            FillDataGrid();
        }
        public ListOfCompanies(NewWindow newWindow)
        {
            InitializeComponent();
            _newWindow = newWindow;
            ButtonBack.Visibility = Visibility.Hidden;
            FillDataGrid();
        }
        private void DataGridCompanies_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DataGrid dg = (DataGrid)sender;
            CompaniesWithContactAndLocation item = (CompaniesWithContactAndLocation)dg.CurrentItem;
            if (item != null)
            {
                id = item.id;
            }
            if (_mainWindow != null)
            {
                AboutCompany aboutCompany = new AboutCompany(_mainWindow, id);
                _mainWindow.Content = aboutCompany;
            }
            if (_newWindow != null)
            {
                Company.Id = id;
                Saved saved = new Saved();
                saved.ShowDialog();
                _newWindow.Close();
            }
        }

        private void ButtonBack_Click(object sender, RoutedEventArgs e)
        {
            MainMenu mainMenu = new MainMenu(_mainWindow);
            _mainWindow.Content = mainMenu;
        }

        private void FillDataGrid()
        {
            CompanyLogic mapperCompany = new CompanyLogic();
            DataGridCompanies.ItemsSource = mapperCompany.GetAllCompaniesWithContactAndLocation();
        }
    }
}