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
        
        private int _currentCompanyId;
        private Location location = new Location();
        private Contacts contact = new Contacts();
        public CompanyWithForeignKeyValue Company;
        private Company company = new Company();
        private readonly MainWindow _mainWindow;
        MapperCompany mapperCompany = new MapperCompany();
        MapperCompanies mapperCompanies = new MapperCompanies();
        public AboutCompany(MainWindow mainWindow, int id)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
            _currentCompanyId = id;

            MapperDivisionByCompany mapperDivisionByCompany = new MapperDivisionByCompany();
            DataGridDivisions.ItemsSource = mapperDivisionByCompany.GetDivisionByCompanyID(id);
            

            CompanyWithForeignKeyValue companyWithForeignKeyValue = mapperCompany.GetCompanyByID(_currentCompanyId);

            TextBoxInformation.Text = companyWithForeignKeyValue.Information;
            TextBoxName.Text = companyWithForeignKeyValue.Name;
            TextBoxPhone.Text = companyWithForeignKeyValue.Phone;
            TextBoxEmail.Text = companyWithForeignKeyValue.Email;
            TextBoxContactInformation.Text = companyWithForeignKeyValue.ContactInformation;
            TextBoxCountry.Text = companyWithForeignKeyValue.Country;
            TextBoxCity.Text = companyWithForeignKeyValue.City;
            TextBoxStreet.Text = companyWithForeignKeyValue.Street;
            TextBoxHouseN.Text = companyWithForeignKeyValue.HouseNumber;
            TextBoxApartmantN.Text = companyWithForeignKeyValue.ApartmentNumber;
            TextBoxIndex.Text = companyWithForeignKeyValue.LocationIndex;

            location.id = companyWithForeignKeyValue.LocationID;
            contact.id = companyWithForeignKeyValue.ContactID;

            company.ContactID = companyWithForeignKeyValue.ContactID;
            company.LocationID = companyWithForeignKeyValue.LocationID;
        }

        private void DataGridDivisions_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DataGrid dg = (DataGrid)sender;
            DivisionByCompany item = (DivisionByCompany)dg.CurrentItem;
            if (item != null)
            {
                Company = new CompanyWithForeignKeyValue();
                Company.id = _currentCompanyId;
                int id = item.id;
                AboutDivision aboutDivision = new AboutDivision(_mainWindow, id);
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

            location.City = TextBoxCity.Text;
            location.LocationIndex = Int32.Parse(TextBoxIndex.Text);
            location.Country = TextBoxCountry.Text;
            location.ApartmentNumber = Int32.Parse(TextBoxApartmantN.Text);
            location.HouseNumber = Int32.Parse(TextBoxHouseN.Text);
            location.Street = TextBoxStreet.Text;

            MapperLocation locationMapper = new MapperLocation();
            locationMapper.UpdateLocationByid(location, location.id);

            contact.Phone = TextBoxPhone.Text;
            contact.Information = TextBoxContactInformation.Text;
            contact.Email = TextBoxEmail.Text;

            MapperContacts contactMapper = new MapperContacts();
            contactMapper.UpdateContacts(contact, contact.id);

            company.Name = TextBoxName.Text;
            company.Information = TextBoxInformation.Text;

            mapperCompanies.UpdateCompanyByid(company, _currentCompanyId);
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
