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
    /// Interaction logic for SearchForEmployee.xaml
    /// </summary>
    public partial class SearchForEmployee : Page
    {
        public Contacts Contacts;
        public Location Location;
        public PreviousWork PreviousWork;
        public Company Company;
        public DivisionByCompany DivisionByCompany;
        public PositionsWithDirectionName PositionsWithDirectionName;
        public ProjectMaps ProjectMaps;
        public Statuses Statuses;
        public List<int> ProjectsId;
        Worker worker = new Worker();
        public List<Worker> workers = new List<Worker>();
        private readonly MainWindow _mainWindow;
        private readonly NewWindow _newWindow;
        public SearchForEmployee(MainWindow mainWindow)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
            ButtonChooseDepartment.IsEnabled = false;
        }
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MainMenu mainMenu = new MainMenu(_mainWindow);
            _mainWindow.Content = mainMenu;
        }
        private void TextBoxSurname_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(TextBoxSurname.Text))
            {
                worker.LastName = TextBoxSurname.Text;
            }
        }

        private void TextBoxName_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(TextBoxName.Text))
            {
                worker.FirstName = TextBoxName.Text;
            }
        }

        private void TextBoxPatronymic_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(TextBoxPatronymic.Text))
            {
                worker.Patronymic = TextBoxPatronymic.Text;
            }
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

        private void ButtonChooseDepartment_OnClick(object sender, RoutedEventArgs e)
        {
            DivisionByCompany = new DivisionByCompany();
            NewWindow newWindow = new NewWindow();
            ListOfDivisionsByCompany listOfDivisionsByCompany = new ListOfDivisionsByCompany(newWindow, Company.Id) { DivisionByCompany = this.DivisionByCompany };
            newWindow.Content = listOfDivisionsByCompany;
            newWindow.ShowDialog();
        }

        private void ButtonChoosePosition_OnClick(object sender, RoutedEventArgs e)
        {
            PositionsWithDirectionName = new PositionsWithDirectionName();
            NewWindow newWindow = new NewWindow();
            ListOfPosition listOfPosition = new ListOfPosition(newWindow) { PositionsWithDirectionName = this.PositionsWithDirectionName };
            newWindow.Content = listOfPosition;
            newWindow.ShowDialog();
            
        }

        private void Find_Click(object sender, RoutedEventArgs e)
        {
            {
                WorkerLogic mapper = new WorkerLogic();
                if (!string.IsNullOrEmpty(TextBoxName.Text))
                {
                    worker.FirstName = TextBoxName.Text;
                }
                if (!string.IsNullOrEmpty(TextBoxSurname.Text))
                {
                    worker.LastName = TextBoxSurname.Text;
                }
                if (!string.IsNullOrEmpty(TextBoxPatronymic.Text))
                {
                    worker.Patronymic = TextBoxPatronymic.Text;
                }
                if (Statuses!=null)
                {
                    worker.StatusID = Statuses.Id;
                }
                if (PositionsWithDirectionName != null)
                {
                    worker.PositionID = PositionsWithDirectionName.id;
                }
                if (DivisionByCompany != null)
                {
                    worker.DivisionID = DivisionByCompany.id;
                }

                workers = mapper.SearchWorkersBySameParams(worker);
                List<int> listId = new List<int>();
                foreach (var tmp in workers)
                {
                    listId.Add(tmp.Id);
                }

                NewWindow newWindow = new NewWindow();
                SearchResult searchResult = new SearchResult(_mainWindow, listId);
                _mainWindow.Content = searchResult;
                _mainWindow.Show();
            }
        }

        private void ButtonChooseProject_OnClick(object sender, RoutedEventArgs e)
        {
            ProjectsId = new List<int>();
            NewWindow newWindow = new NewWindow();
            ListOfProject listOfListOfProject = new ListOfProject(newWindow) { ProjectsId = this.ProjectsId };
            newWindow.Content = listOfListOfProject;
            newWindow.ShowDialog();
        }

        private void ButtonChooseStatus_OnClick(object sender, RoutedEventArgs e)
        {
            Statuses = new Statuses();
            NewWindow newWindow = new NewWindow();
            ListOfStatuses listOfStatuses = new ListOfStatuses(newWindow) { Statuses = this.Statuses };
            newWindow.Content = listOfStatuses;
            newWindow.ShowDialog();
        }

        private void Men_OnChecked(object sender, RoutedEventArgs e)
        {
            worker.Sex = "Мужской";
        }

        private void Women_OnChecked(object sender, RoutedEventArgs e)
        {
            worker.Sex = "Женский";
        }

        //private void BoxStatuses_OnInitialized(object? sender, EventArgs e)
        //{
        //    StatusesLogic StatusesLogic = new StatusesLogic();
        //    List<Statuses> statuses = StatusesLogic.GetAllStatuses();
        //    foreach (var tmp in statuses)
        //    {
        //        BoxStatuses.Items.Add(tmp.Id + " " + tmp.Name);
        //    }
        //}

        //private void BoxStatuses_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    var s = BoxStatuses.Items;
        //    //ComboBox dg = (ComboBox)sender;
        //    //Statuses item = (Statuses)dg.SelectedItem;
        //    //worker.StatusID = item.Id;
        //}
    }
}