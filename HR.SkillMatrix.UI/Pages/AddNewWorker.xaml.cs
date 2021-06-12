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

namespace HR.SkillMatrix.UI.Pages
{
    /// <summary>
    /// Interaction logic for Worker.xaml
    /// </summary>
    public partial class AddNewWorker : Page
    {
        private readonly MainWindow _mainWindow;
        private string _sex;
        public Contacts Contacts;
        public Location Location;
        public AddNewWorker(MainWindow mainWindow)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
            ChooseDepartment.IsEnabled = false;
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            CreateNewPage createNewPage = new CreateNewPage(_mainWindow);
            _mainWindow.Content = createNewPage;
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            Worker worker = new Worker();
            
            MapperContacts mapperContacts = new MapperContacts();
            MapperLocation mapperLocation = new MapperLocation();

            worker.LastName = LastName.Text;
            worker.FirstName = FirstName.Text;
            worker.Patronymic = Patronymic.Text;
            worker.Hobby = Hobby.Text;
            worker.Sex = _sex;
            worker.StatusID = 1;
            worker.Education = Education.Text;
            worker.BirthDay = BirthDay.SelectedDate.Value.Date.ToString("MM.dd.yyyy");
            worker.ContactID = mapperContacts.AddNew(Contacts);
            worker.LocationID = mapperLocation.AddNewLocation(Location);
            worker.PositionID = 1;
            worker.DivisionID = 1;

            MapperWorker mapper = new MapperWorker();
            mapper.MapToWorkersDTO(worker);

            Saved saved = new Saved();
            saved.Show();
        }

        private void CreateLocation_Click(object sender, RoutedEventArgs e)
        {
            Location = new Location();
            NewWindow newWindow = new NewWindow();
            AddLocationMenu locationMenu = new AddLocationMenu(_mainWindow) { Location = this.Location };
            newWindow.Content = locationMenu;
            newWindow.ShowDialog();
        }
        private void CreateContact_Click(object sender, RoutedEventArgs e)
        {
            Contacts = new Contacts();
            NewWindow newWindow = new NewWindow();
            AddContactsMenu addContactsMenu = new AddContactsMenu(_mainWindow) { Contacts = this.Contacts };
            newWindow.Content = addContactsMenu;
            newWindow.ShowDialog();
            //_mainWindow.Content = addContactsMenu;
            //this.Contacts = addContactsMenu.Contacts;
        }

        //private void BoxContacts_OnMouseEnter(object sender, MouseEventArgs e)
        //{
        //    List<int> numbers = new List<int>() { 1, 2, 3, 45 };
        //    foreach (object ss in numbers)
        //    { 
        //        BoxContacts.Items.Add(ss + "ss");
        //    }

        //    //Button addlocations = new Button();
        //    //addlocations.Height = 100;
        //    //addlocations.Width = 100;
        //    //addlocations.Content = "sss";
        //    //addlocations.Click += AddLocation_OnClick;
        //}

        //private void AddLocation_OnClick(object sender, RoutedEventArgs e)
        //{
        //    AddLocationMenu locationMenu = new AddLocationMenu(_mainWindow);
        //    _mainWindow.Content = locationMenu;
        //}
        private void Men_OnChecked(object sender, RoutedEventArgs e)
        {
            _sex = "Мужской";
        }

        private void Women_OnChecked(object sender, RoutedEventArgs e)
        {
            _sex = "Женский";
        }

        private void ChoosePosition_Click(object sender, RoutedEventArgs e)
        {
            NewWindow newWindow = new NewWindow();
            ListOfPosition listOfPosition = new ListOfPosition(_mainWindow);
            newWindow.Content = listOfPosition;
            newWindow.Show();
        }

        private void PrewiousWork_Click(object sender, RoutedEventArgs e)
        {
            NewWindow newWindow = new NewWindow();
            AddPreviousJob addPreviousJob = new AddPreviousJob(_mainWindow);
            newWindow.Content = addPreviousJob;
            newWindow.Show();
        }

        private void ChooseCompany_OnClick(object sender, RoutedEventArgs e)
        {
            NewWindow newWindow = new NewWindow();
            ListOfCompanies listOfCompanies = new ListOfCompanies(_mainWindow);
            newWindow.Content = listOfCompanies;
            newWindow.Show();
        }

        private void ChooseProject_Click(object sender, RoutedEventArgs e)
        {
            NewWindow newWindow = new NewWindow();
            ListOfProject listOfзListOfProject = new ListOfProject(_mainWindow);
            newWindow.Content = listOfзListOfProject;
            newWindow.Show();
        }

        private void ChooseCompany_OnMouseEnter(object sender, MouseEventArgs e)
        {
            ChooseDepartment.IsEnabled = true;
        }
    }
}