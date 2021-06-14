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
    /// Interaction logic for Worker.xaml
    /// </summary>
    public partial class AddNewWorker : Page
    {
        public Contacts Contacts;
        public Location Location;
        public PreviousWork PreviousWork;
        public Company Company;
        public DivisionByCompany DivisionByCompany;
        public PositionsWithDirectionName PositionsWithDirectionName;
        public ProjectMaps ProjectMaps;
        public List<int> ProjectsId;
        private readonly MainWindow _mainWindow;
        private string _sex;
        public AddNewWorker(MainWindow mainWindow)
        {
            InitializeComponent();
            _mainWindow = mainWindow; 
            ButtonChooseDepartment.IsEnabled = false;
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            CreateNewPage createNewPage = new CreateNewPage(_mainWindow);
            _mainWindow.Content = createNewPage;
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            WorkerLogic mapper = new WorkerLogic();
            ContactsLogic mapperContacts = new ContactsLogic();
            LocationLogic mapperLocation = new LocationLogic();
            PreviousJobLogic mapperPreviousJob = new PreviousJobLogic();
            ProjectMapsLogic mapperProjectMaps = new ProjectMapsLogic();

            Worker worker = new Worker();
            worker.LastName = LastName.Text;
            worker.FirstName = FirstName.Text;
            worker.Patronymic = Patronymic.Text;
            worker.Hobby = Hobby.Text;
            worker.Sex = _sex;
            worker.StatusID = 1;
            worker.Education = Education.Text;
            worker.BirthDay = BirthDay.SelectedDate.Value.Date.ToString("MM.dd.yyyy");
            worker.ContactID = mapperContacts.AddContacts(Contacts);
            worker.LocationID = mapperLocation.AddNewLocation(Location);
            worker.PositionID = PositionsWithDirectionName.id;
            worker.DivisionID = DivisionByCompany.id;

            int workerId = mapper.AddNewWorker(worker);
            PreviousWork.WorkerID = workerId;
            mapperPreviousJob.AddPreviousWork(PreviousWork);

            ProjectMaps = new ProjectMaps();
            ProjectMaps.WorkerID = workerId;

            foreach (var a in ProjectsId)
            {
                ProjectMaps.ProjectID = a;
                mapperProjectMaps.AddNewProjectMaps(ProjectMaps);
            }

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
        private void ButtonPrewiousWork_Click(object sender, RoutedEventArgs e)
        {
            PreviousWork = new PreviousWork();
            NewWindow newWindow = new NewWindow();
            AddNewPreviousJob addNewPreviousJob = new AddNewPreviousJob(newWindow) { PreviousWork = this.PreviousWork };
            newWindow.Content = addNewPreviousJob;
            newWindow.ShowDialog();
        }

        private void Men_OnChecked(object sender, RoutedEventArgs e)
        {
            _sex = "Мужской";
        }

        private void Women_OnChecked(object sender, RoutedEventArgs e)
        {
            _sex = "Женский";
        }

        private void ButtonChoosePosition_Click(object sender, RoutedEventArgs e)
        {
            PositionsWithDirectionName = new PositionsWithDirectionName();
            NewWindow newWindow = new NewWindow();
            ListOfPosition listOfPosition = new ListOfPosition(newWindow){ PositionsWithDirectionName =this.PositionsWithDirectionName };
            newWindow.Content = listOfPosition;
            newWindow.Show();
        }

        private void ButtonChooseCompany_OnClick(object sender, RoutedEventArgs e)
        {
            Company = new Company();
            NewWindow newWindow = new NewWindow();
            ListOfCompanies listOfCompanies = new ListOfCompanies(newWindow) { Company = this.Company };
            newWindow.Content = listOfCompanies;
            newWindow.ShowDialog();
            if (Company.Id > 0)
            {
                ButtonChooseDepartment.IsEnabled = true;
            }
        }

        private void ButtonChooseProject_Click(object sender, RoutedEventArgs e)
        {
            ProjectsId = new List<int>();
            NewWindow newWindow = new NewWindow();
            ListOfProject listOfListOfProject = new ListOfProject(newWindow){ ProjectsId = this.ProjectsId };
            newWindow.Content = listOfListOfProject;
            newWindow.Show();
        }

        private void ChooseHardSkill_Click(object sender, RoutedEventArgs e)
        {
            CreateSkillDatagrid(1);
        }
        private void ChooseSoftSkill_OnClick(object sender, RoutedEventArgs e)
        {
            CreateSkillDatagrid(2);
        }

        private void CreateSkillDatagrid(int skilltypeId)
        {
            NewWindow newWindow = new NewWindow();
            ListOfSkillsAndLevels listOfPosition = new ListOfSkillsAndLevels(_mainWindow, skilltypeId);
            newWindow.Content = listOfPosition;
            newWindow.Show();
        }

        private void ButtonChooseDepartment_Click(object sender, RoutedEventArgs e)
        {
            DivisionByCompany = new DivisionByCompany();
            NewWindow newWindow = new NewWindow();
            ListOfDivisionsByCompany listOfDivisionsByCompany = new ListOfDivisionsByCompany(newWindow, Company.Id) { DivisionByCompany = this.DivisionByCompany };
            newWindow.Content = listOfDivisionsByCompany;
            newWindow.ShowDialog();
        }
    }
}   