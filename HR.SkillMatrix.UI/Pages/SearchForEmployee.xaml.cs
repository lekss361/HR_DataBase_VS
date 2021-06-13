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
using HR_DataBase_VSBLL.Mappers.ModelsToDTO;
using HR_DataBase_VSBLL.Models;

namespace HR.SkillMatrix.UI.Pages
{
    /// <summary>
    /// Interaction logic for SearchForEmployee.xaml
    /// </summary>
    public partial class SearchForEmployee : Page
    {
        Worker worker = new Worker();
        List<Worker> workers = new List<Worker>();
        private readonly MainWindow _mainWindow;
        public SearchForEmployee(MainWindow mainWindow)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
        }
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MainMenu mainMenu = new MainMenu(_mainWindow);
            _mainWindow.Content = mainMenu;
        }

        private void BoxCompanies_OnInitialized(object? sender, EventArgs e)
        {
            MapperCompanies mapperCompanies = new MapperCompanies();
            List<HR_DataBase_VSBLL.Models.Company> company = mapperCompanies.GetAllCompanies();
            foreach (var tmp in company)
            {
                BoxCompanies.Items.Add(tmp.Name);
            }

            //Button addlocations = new Button();
            //addlocations.Height = 100;
            //addlocations.Width = 100;
            //addlocations.Content = "sss";
            //addlocations.Click += AddCompany_OnClick;
        }

        //private void AddCompany_OnClick(object sender, RoutedEventArgs e)
        //{
        //    AddNewCompany addNewCompany = new AddNewCompany(_mainWindow);
        //    _mainWindow.Content = addNewCompany;
        //}

        private void BoxDivisions_OnInitialized(object? sender, EventArgs e)
        {
            //MapperDivisions mapperDivisions = new MapperDivisions();
            //List<HR_DataBase_VSBLL.Models.Divisions> divisions = mapperDivisions();
            //foreach (var tmp in divisions)
            //{
            //    BoxCompanies.Items.Add(tmp.Name);
            //}
        }

        private void BoxPositions_OnInitialized(object? sender, EventArgs e)
        {

        }
        private void BoxProjects_OnInitialized(object? sender, EventArgs e)
        {

        }

        private void BoxStatuses_OnInitialized(object? sender, EventArgs e)
        {

        }

        private void BoxSkill1_OnInitialized(object? sender, EventArgs e)
        {

        }

        private void BoxLevel1_OnInitialized(object? sender, EventArgs e)
        {

        }

        private void BoxSkill2_OnInitialized(object? sender, EventArgs e)
        {

        }

        private void BoxLevel2_OnInitialized(object? sender, EventArgs e)
        {

        }

        private void BoxSkill3_OnInitialized(object? sender, EventArgs e)
        {

        }

        private void BoxLevel3_OnInitialized(object? sender, EventArgs e)
        {

        }

        private void BoxSkill4_OnInitialized(object? sender, EventArgs e)
        {

        }

        private void BoxLevel4_OnInitialized(object? sender, EventArgs e)
        {

        }

        private void BoxSkill5_OnInitialized(object? sender, EventArgs e)
        {

        }

        private void BoxLevel5_OnInitialized(object? sender, EventArgs e)
        {

        }

        private void BoxSkill6_OnInitialized(object? sender, EventArgs e)
        {

        }

        private void BoxLevel6_OnInitialized(object? sender, EventArgs e)
        {

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

        private void BoxCompanies_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //if (BoxCompanies.SelectedItem != null)
            //{
            //    worker = TextBoxPatronymic.Text;
            //}
        }

        private void Find_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(TextBoxSurname.Text) ||
                !string.IsNullOrEmpty(TextBoxName.Text) ||
                !string.IsNullOrEmpty(TextBoxPatronymic.Text))
            {
                MapperWorker mapper = new MapperWorker();
                workers = mapper.SearchWorkersBySameParams(worker);
            }
        }
    }
}
