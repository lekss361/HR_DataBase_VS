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
        private readonly MainWindow _mainWindow;
        public AboutCompany(MainWindow mainWindow, int id)
        {
            InitializeComponent();
            _mainWindow = mainWindow;

            MapperDivisionByCompany mapperDivisionByCompany = new MapperDivisionByCompany();
            Divisions.ItemsSource = mapperDivisionByCompany.GetDivisionByCompanyID(2);



           

            TextBoxInformation.Text = "информация";
            TextBoxName.Text = "название";
            TextBoxPhone.Text = "телефон";
            TextBoxEmail.Text = "почта";
            TextBoxContactInformation.Text = "дополнительно";
            TextBoxCountry.Text = "страна";
            TextBoxCity.Text = "город";
            TextBoxHouseN.Text = "номердома";
            TextBoxApartmantN.Text = "номерофиса";
            TextBoxIndex.Text = "индекс";
        }

        private void DataGridDivisions_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            AboutDivision aboutCompany = new AboutDivision(_mainWindow,7);
            _mainWindow.Content = aboutCompany;
            DataGrid dg = (DataGrid)sender;
            ////ClientBaseModel item = (ClientBaseModel)dg.CurrentItem;
            //Company item = (Company)dg.CurrentItem;
            //if (item != null)
            //{
            //    int id = item.Id;
            //    AboutCompany aboutCompany = new AboutCompany(_mainWindow, id);
            //    _mainWindow.Content = aboutCompany;

            //}



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
            TextBoxHouseN.IsEnabled = true;
            TextBoxApartmantN.IsEnabled = true;
            TextBoxIndex.IsEnabled = true;
        }

        private void ButtonBack_Click(object sender, RoutedEventArgs e)
        {

        }

        private void backToCompanyTable_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
