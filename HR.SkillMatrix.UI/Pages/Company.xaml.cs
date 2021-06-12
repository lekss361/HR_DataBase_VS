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
    public partial class Company : Page
    {
        private readonly MainWindow _mainWindow;
        public Company(MainWindow mainWindow)
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

       

        private void ButtonCancellation_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonSave_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonChange_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonBack_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
