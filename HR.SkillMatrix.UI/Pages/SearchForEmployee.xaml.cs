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
using HR_DataBase_VSBLL.Mappers;
using HR_DataBase_VSBLL.Models;

namespace HR.SkillMatrix.UI.Pages
{
    /// <summary>
    /// Interaction logic for SearchForEmployee.xaml
    /// </summary>
    public partial class SearchForEmployee : Page
    {
        private readonly MainWindow _mainWindow;
        public SearchForEmployee(MainWindow mainWindow)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
        }
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MainMenu mainMenu = new MainMenu(_mainWindow);
            _mainWindow.Content = mainMenu;
        }

        private void Companies_OnInitialized(object? sender, EventArgs e)
        {
            MapperCompanies mapperCompanies = new MapperCompanies();
            List<HR_DataBase_VSBLL.Models.Company> sss = mapperCompanies.GetAllCompanies();
            foreach (var C in sss)
            {   
                Companies.Items.Add(C.Name);
            }

            Button addlocations = new Button();
            addlocations.Height = 100;
            addlocations.Width = 100;
            addlocations.Content = "sss";
            addlocations.Click += AddCompany_OnClick;
        }

        private void AddCompany_OnClick(object sender, RoutedEventArgs e)
        {
            AddNewCompany addNewCompany = new AddNewCompany(_mainWindow);
            _mainWindow.Content = addNewCompany;
        }
    }
}
