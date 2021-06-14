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
using HR_DataBase_VSBLL.Mappers;
using HR_DataBase_VSBLL.Models;
using HR_DataBase_VSDAL.Models;

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
        public AboutWorker(MainWindow mainWindow,int id)
        {
            InitializeComponent();
            _mainWindow = mainWindow;

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

            location.id =(Int32)workerWithForeignKeyValue.LocationID;
            contact.id = (Int32)workerWithForeignKeyValue.ContactID;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            location.City = TextBoxCity.Text;
            location.LocationIndex = Int32.Parse(TextBoxLocationIndex.Text);
            location.Country = TextBoxCountry.Text;
            location.ApartmentNumber = Int32.Parse(TextBoxApartmentN.Text);
            location.HouseNumber = Int32.Parse(TextBoxHousN.Text);
            location.Street = TextBoxStreet.Text;

            LocationLogic locationMapper = new LocationLogic();
            locationMapper.UpdateLocationByid(location, location.id);

            contact.Phone = TextBoxPhone.Text;
            contact.Information = TextBoxContactInformation.Text;
            contact.Email = TextBoxEmail.Text;

            ContactsLogic contactMapper = new ContactsLogic();
            contactMapper.UpdateContacts(contact, contact.id);
        }
    }
}