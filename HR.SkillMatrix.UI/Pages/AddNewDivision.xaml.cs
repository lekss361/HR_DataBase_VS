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
using HR_DataBase_VSBLL.Mappers.ModelsToDTO;
using HR_DataBase_VSBLL.Models;

namespace HR.SkillMatrix.UI.Pages
{
    /// <summary>
    /// Interaction logic for AddNewDivision.xaml
    /// </summary>
    public partial class AddNewDivision : Page
    {
        public Contacts Contacts;
        public Location Location;
        public Directions Directions;
        public int companyId;
        private readonly MainWindow _mainWindow;
        public AddNewDivision(MainWindow mainWindow)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
        }

        private void ButtonSave_Click(object sender, RoutedEventArgs e)
        {
            MapperContacts mapperContacts = new MapperContacts();
            MapperLocation mapperLocation = new MapperLocation();
            MapperDivisions mapper = new MapperDivisions();

            Divisions divisions = new Divisions();

            divisions.Name = textBoxName.Text;
            divisions.CompanyID = 1;
            divisions.ContactID = mapperContacts.AddNew(Contacts);
            divisions.LocationID = mapperLocation.AddNewLocation(Location);
            divisions.DirectionsID = 1;
            divisions.Information = textBoxDescription.Text;

            mapper.MapToDivisionsDTO(divisions);

            Saved saved = new Saved();
            saved.Show();
        }
        private void ButtonAddLocation_Click(object sender, RoutedEventArgs e)
        {
            Location = new Location();
            NewWindow newWindow = new NewWindow();
            AddLocationMenu locationMenu = new AddLocationMenu(newWindow) { Location = this.Location };
            newWindow.Content = locationMenu;
            newWindow.ShowDialog();
        }

        private void ButtonAddContact_Click(object sender, RoutedEventArgs e)
        {
            Contacts = new Contacts();
            NewWindow newWindow = new NewWindow();
            AddContactsMenu addContactsMenu = new AddContactsMenu(newWindow) { Contacts = this.Contacts };
            newWindow.Content = addContactsMenu;
            newWindow.ShowDialog();
        }

        private void ButtonAddDirection_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Back_OnClick(object sender, RoutedEventArgs e)
        {
            CreateNewPage createNewPage = new CreateNewPage(_mainWindow);
            _mainWindow.Content = createNewPage;
        }
    }
}
