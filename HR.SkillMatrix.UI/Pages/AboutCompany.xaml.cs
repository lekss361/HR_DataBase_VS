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
using HR_DataBase_VSDAL.Models;

namespace HR.SkillMatrix.UI.Pages
{
    /// <summary>
    /// Interaction logic for Company.xaml
    /// </summary>
    public partial class AboutCompany : Page
    {
        public CompanyWithForeignKeyValue Company;
        private int _id;
        private readonly MainWindow _mainWindow;
        public AboutCompany(MainWindow mainWindow, int id)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
            _id = id;

            MapperDivisionByCompany mapperDivisionByCompany = new MapperDivisionByCompany();
            DataGridDivisions.ItemsSource = mapperDivisionByCompany.GetDivisionByCompanyID(id);
            MapperCompany mapperCompany = new MapperCompany();

            CompanyWithForeignKeyValue company = mapperCompany.GetCompanyByID(_id);

            TextBoxInformation.Text = company.Information;
            TextBoxName.Text = company.Name;
            TextBoxPhone.Text = company.Phone;
            TextBoxEmail.Text = company.Email;
            TextBoxContactInformation.Text = company.ContactInformation;
            TextBoxCountry.Text = company.Country;
            TextBoxCity.Text = company.City;
            TextBoxStreet.Text = company.Street;
            TextBoxHouseN.Text = company.HouseNumber;
            TextBoxApartmantN.Text = company.ApartmentNumber;
            TextBoxIndex.Text = company.LocationIndex;
        }

        private void DataGridDivisions_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DataGrid dg = (DataGrid)sender;
            DivisionByCompany item = (DivisionByCompany)dg.CurrentItem;
            if (item != null)
            {
                Company = new CompanyWithForeignKeyValue();
                Company.id = _id;
                int id = item.id;
                AboutDivision aboutDivision = new AboutDivision(_mainWindow, id){ Company = this.Company };
                _mainWindow.Content = aboutDivision;
            }
        }

        private void ButtonCancellation_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonSave_Click(object sender, RoutedEventArgs e)
        {
            TextBoxInformation.IsEnabled = false;
            TextBoxName.IsEnabled = false;
            TextBoxPhone.IsEnabled = false;
            TextBoxEmail.IsEnabled = false;
            TextBoxContactInformation.IsEnabled = false;
            TextBoxCountry.IsEnabled = false;
            TextBoxCity.IsEnabled = false;
            TextBoxStreet.IsEnabled = false;
            TextBoxHouseN.IsEnabled = false;
            TextBoxApartmantN.IsEnabled = false;
            TextBoxIndex.IsEnabled = false;
        }

        private void ButtonChange_Click(object sender, RoutedEventArgs e)
        {
            TextBoxInformation.IsEnabled = true;
            TextBoxName.IsEnabled = true;
            TextBoxPhone.IsEnabled = true;
            TextBoxEmail.IsEnabled = true;
            TextBoxContactInformation.IsEnabled = true;
            TextBoxCountry.IsEnabled = true;
            TextBoxCity.IsEnabled = true;
            TextBoxStreet.IsEnabled = true;
            TextBoxHouseN.IsEnabled = true;
            TextBoxApartmantN.IsEnabled = true;
            TextBoxIndex.IsEnabled = true;
        }

        private void ButtonBack_Click(object sender, RoutedEventArgs e)
        {

            ListOfCompanies listOfCompanies = new ListOfCompanies(_mainWindow);
            _mainWindow.Content = listOfCompanies;


        }

        private void backToCompanyTable_Click(object sender, RoutedEventArgs e)
        {
        }
    }
}
