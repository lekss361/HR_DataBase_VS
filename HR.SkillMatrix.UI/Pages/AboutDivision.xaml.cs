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
    /// Interaction logic for AboutDivision.xaml
    /// </summary>
    public partial class AboutDivision : Page
    {
        int divisionId;
        private Location location = new Location();
        private Contacts contact = new Contacts();
        private Divisions division = new Divisions();
        private readonly MainWindow _mainWindow;
        MapperDivisions mapperDivision = new MapperDivisions();
        public AboutDivision(MainWindow mainWindow, int id)
        {
            InitializeComponent();
            _mainWindow = mainWindow;

            divisionId = id;

            DivisionWithForeignKeyValue divisionWithForeignKeyValue = mapperDivision.GetDivisionByID(divisionId);

            TextBoxCity.Text = divisionWithForeignKeyValue.City;
            TextBoxStreet.Text = divisionWithForeignKeyValue.Street;
            TextBoxIndex.Text = divisionWithForeignKeyValue.LocationIndex.ToString();
            TextBoxApartmantN.Text = divisionWithForeignKeyValue.ApartmentNumber.ToString();
            TextBoxHouseN.Text = divisionWithForeignKeyValue.HouseNumber.ToString();
            TextBoxCountry.Text = divisionWithForeignKeyValue.Country;
            TextBoxContactInformation.Text = divisionWithForeignKeyValue.ContactInformation;
            TextBoxEmail.Text = divisionWithForeignKeyValue.Email;
            TextBoxPhone.Text = divisionWithForeignKeyValue.Phone;

            TextBoxDivision.Text = divisionWithForeignKeyValue.DirectionName;

            TextBoxCompany.Text = divisionWithForeignKeyValue.CompanyName;
            TextBoxName.Text = divisionWithForeignKeyValue.Name;
            TextBoxInformation.Text = divisionWithForeignKeyValue.Information;

            location.id = divisionWithForeignKeyValue.LocationID;
            contact.id = divisionWithForeignKeyValue.ContactID;

            division.CompanyID = divisionWithForeignKeyValue.CompanyID;
            division.ContactID = divisionWithForeignKeyValue.ContactID;
            division.DirectionsID = divisionWithForeignKeyValue.DirectionId;
            division.LocationID = divisionWithForeignKeyValue.LocationID;
        }

        private void ButtonBack_Click(object sender, RoutedEventArgs e)
        {
            AboutCompany aboutCompany = new AboutCompany(_mainWindow, division.CompanyID);
            _mainWindow.Content = aboutCompany;
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
            TextBoxDivision.IsEnabled = true;
            TextBoxCompany.IsEnabled = true;
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
            TextBoxDivision.IsEnabled = false;
            TextBoxCompany.IsEnabled = false;
            location.City = TextBoxCity.Text;
            location.LocationIndex = Int32.Parse(TextBoxIndex.Text);
            location.Country = TextBoxCountry.Text;
            location.ApartmentNumber = Int32.Parse(TextBoxApartmantN.Text);
            location.HouseNumber = Int32.Parse(TextBoxHouseN.Text);
            location.Street = "DefaultStreet";

            MapperLocation locationMapper = new MapperLocation();
            locationMapper.UpdateLocationByid(location, location.id);

            contact.Phone = TextBoxPhone.Text;
            contact.Information = TextBoxContactInformation.Text;
            contact.Email = TextBoxEmail.Text;

            MapperContacts contactMapper = new MapperContacts();
            contactMapper.UpdateContacts(contact, contact.id);

            division.Name = TextBoxName.Text;
            division.Information = TextBoxInformation.Text;

            mapperDivision.UpdateDivisionByid(division,divisionId);
        }
    }
}