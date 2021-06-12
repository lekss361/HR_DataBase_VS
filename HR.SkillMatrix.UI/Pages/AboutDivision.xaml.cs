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
        private readonly MainWindow _mainWindow;
        public AboutDivision(MainWindow mainWindow, int id)
        {
            InitializeComponent();
            _mainWindow = mainWindow;

            MapperDivisions mapperDivisionById = new MapperDivisions();
            DivisionWithForeignKeyValue divisionWithForeignKeyValue = mapperDivisionById.GetDivisionByID(id);
            TextBoxCity.Text = divisionWithForeignKeyValue.City;
            TextBoxIndex.Text = divisionWithForeignKeyValue.LocationIndex.ToString();
            TextBoxApartmantN.Text = divisionWithForeignKeyValue.ApartmentNumber.ToString();
            TextBoxHouseN.Text = divisionWithForeignKeyValue.HouseNumber.ToString();
            TextBoxCountry.Text = divisionWithForeignKeyValue.Country;
            TextBoxContactInformation.Text = divisionWithForeignKeyValue.ContactInformation;
            TextBoxEmail.Text = divisionWithForeignKeyValue.Email;
            TextBoxDivision.Text = divisionWithForeignKeyValue.DirectionName;
            TextBoxPhone.Text = divisionWithForeignKeyValue.Phone;
            TextBoxCompany.Text = divisionWithForeignKeyValue.CompanyName;
            TextBoxName.Text = divisionWithForeignKeyValue.Name;
            TextBoxInformation.Text = divisionWithForeignKeyValue.Information;
        }



        private void ButtonBack_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonChange_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonCancellation_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonSave_Click(object sender, RoutedEventArgs e)
        {

        }


    }
}