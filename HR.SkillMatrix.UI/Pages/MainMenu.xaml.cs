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

namespace HR.SkillMatrix.UI.Pages
{
    /// <summary>
    /// Interaction logic for MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Page
    {
        private readonly MainWindow _mainWindow;

        public MainMenu(MainWindow mainWindow)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
        }

        private void Create_Click(object sender, RoutedEventArgs e)
        {
            CreateNewPage createNewPage = new CreateNewPage(_mainWindow);
            _mainWindow.Content = createNewPage;
        }

        private void Companies_Click(object sender, RoutedEventArgs e)
        {
            //ListOfLocation listOfLocation = new ListOfLocation(_mainWindow);
            //_mainWindow.Content = listOfLocation;
            ListOfCompanies listOfCompanies = new ListOfCompanies(_mainWindow);
            _mainWindow.Content = listOfCompanies;
        }

        private void SearchEmploy_Click(object sender, RoutedEventArgs e)
        {
            SearchForEmployee searchForEmployee = new SearchForEmployee(_mainWindow);
            _mainWindow.Content = searchForEmployee;
        }

        private void Projects_OnClick(object sender, RoutedEventArgs e)
        {
            ListOfProject listOfProject = new ListOfProject(_mainWindow);
            _mainWindow.Content = listOfProject;
        }
    }
}
