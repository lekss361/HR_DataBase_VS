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
using HR_DataBase_VSBLL.Models;
using HR_DataBase_VSBLL.Mappers;

namespace HR.SkillMatrix.UI.Pages
{
    /// <summary>
    /// Interaction logic for AddNewDivision.xaml
    /// </summary>
    public partial class AddNewDivision : Page
    {
        private readonly MainWindow _mainWindow;
        public AddNewDivision(MainWindow mainWindow)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
        }

        private void ButtonSave_Click(object sender, RoutedEventArgs e)
        {
            Divisions divisions = new Divisions();

            divisions.Name = textBoxName.Text;
            divisions.CompanyID = 1;
            divisions.ContactID = 1;
            divisions.LocationID = 1;
            divisions.DirectionsID = 1;
            divisions.Information = textBoxDescription.Text;


            MapperDivisions mapper = new MapperDivisions();
            mapper.MapToDivisionsDTO(divisions);

            Saved saved = new Saved();
            saved.Show();
        }
       

       
       

        private void ButtonAddContact_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonAddLocation_Click(object sender, RoutedEventArgs e)
        {
            AddLocationMenu locationMenu = new AddLocationMenu(_mainWindow);
            _mainWindow.Content = locationMenu;
        }

        private void ButtonAddDirection_Click(object sender, RoutedEventArgs e)
        {

        }

    }
}
