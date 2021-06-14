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
using HR_DataBase_VSBLL.Mappers;
using HR_DataBase_VSBLL.Models;
using HR_DataBase_VSDAL.Models;
using HR_DataBase_VSBLL.Mappers.ModelsToDTO;

namespace HR.SkillMatrix.UI.Pages
{
    /// <summary>
    /// Interaction logic for AboutWorker.xaml
    /// </summary>
    /// 
    
    public partial class AboutWorker : Page
    {
        int _currentWorkerId;
        WorkerLogic mapperWorker = new WorkerLogic();
        private Location location = new Location();
        private Contacts contact = new Contacts();
        private readonly MainWindow _mainWindow;
        private readonly NewWindow _newWindow;
        public AboutWorker(NewWindow newWindow, int id)
        {
            InitializeComponent();
            _newWindow = newWindow;

            WorkerWithForeignKeyValue workerWithForeignKeyValue = mapperWorker.GetWorkerByID(id);
            TextBoxName.Text = workerWithForeignKeyValue.FirstName;
            TextBoxSurname.Text = workerWithForeignKeyValue.LastName;
            TextBoxPatronymic.Text = workerWithForeignKeyValue.Patronymic;
            TextBoxCompany.Text = workerWithForeignKeyValue.CompanyName;
            TextBoxDivision.Text = workerWithForeignKeyValue.DivisionName;
            // TextBoxProject.Text = workerWithForeignKeyValue.pro
            TextBoxSex.Text = workerWithForeignKeyValue.Sex;
            TextBoxDateOfBirth.Text = workerWithForeignKeyValue.BirthDay;
            TextBoxPhone.Text = workerWithForeignKeyValue.Phone;
            TextBoxEmail.Text = workerWithForeignKeyValue.Email;
            TextBoxContactInformation.Text = workerWithForeignKeyValue.ContactInformation;
            TextBoxCountry.Text = workerWithForeignKeyValue.Country;
            TextBoxCity.Text = workerWithForeignKeyValue.City;
            TextBoxStreet.Text = workerWithForeignKeyValue.Street;
            TextBoxHousN.Text = workerWithForeignKeyValue.HouseNumber.ToString();
            TextBoxApartmentN.Text = workerWithForeignKeyValue.ApartmentNumber.ToString();
            TextBoxLocationIndex.Text = workerWithForeignKeyValue.LocationIndex.ToString();
            TextBoxEducation.Text = workerWithForeignKeyValue.Education;
            TextBoxHobby.Text = workerWithForeignKeyValue.Hobby;
           

        }

   

        private void ButtonAddNewSkill_Click(object sender, RoutedEventArgs e)
        {
            AddSkillMenu addSkillMenu = new AddSkillMenu(_mainWindow);
            _mainWindow.Content = addSkillMenu;
        }

        private void ButtonChange_Click(object sender, RoutedEventArgs e)
        {

            TextBoxName.IsEnabled = true;
            TextBoxSurname.IsEnabled = true;
            TextBoxPatronymic.IsEnabled = true;
            TextBoxCompany.IsEnabled = true;
            TextBoxDivision.IsEnabled = true;
            
            TextBoxSex.IsEnabled = true;
            TextBoxDateOfBirth.IsEnabled = true;
            TextBoxPhone.IsEnabled = true;
            TextBoxEmail.IsEnabled = true;
            TextBoxContactInformation.IsEnabled = true;
            TextBoxCountry.IsEnabled = true;
            TextBoxCity.IsEnabled = true;
            TextBoxStreet.IsEnabled = true;
            TextBoxHousN.IsEnabled = true;
            TextBoxApartmentN.IsEnabled = true;
            TextBoxLocationIndex.IsEnabled = true;
            TextBoxEducation.IsEnabled = true;
            TextBoxHobby.IsEnabled = true;
         
        }

        private void ButtonSave_Click(object sender, RoutedEventArgs e)
        {
            TextBoxName.IsEnabled = false;
            TextBoxSurname.IsEnabled = false;
            TextBoxPatronymic.IsEnabled = false;
            TextBoxCompany.IsEnabled = false;
            TextBoxDivision.IsEnabled = false;
            
            TextBoxSex.IsEnabled = false;
            TextBoxDateOfBirth.IsEnabled = false;
            TextBoxPhone.IsEnabled = false;
            TextBoxEmail.IsEnabled = false;
            TextBoxContactInformation.IsEnabled = false;
            TextBoxCountry.IsEnabled = false;
            TextBoxCity.IsEnabled = false;
            TextBoxStreet.IsEnabled = false;
            TextBoxHousN.IsEnabled = false;
            TextBoxApartmentN.IsEnabled = false;
            TextBoxLocationIndex.IsEnabled = false;
            TextBoxEducation.IsEnabled = false;
            TextBoxHobby.IsEnabled = false;


        }
    }
}