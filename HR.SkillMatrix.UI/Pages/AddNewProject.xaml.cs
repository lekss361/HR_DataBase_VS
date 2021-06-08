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
using HR_DataBase_VSBLL.Models;
using HR_DataBase_VSBLL.Mappers;
using HR.SkillMatrix.UI.Windows;

namespace HR.SkillMatrix.UI.Pages
{
    /// <summary>
    /// Interaction logic for AddNewProject.xaml
    /// </summary>
    public partial class AddNewProject : Page
    {
        
        private readonly MainWindow _mainWindow;
        public AddNewProject(MainWindow mainWindow)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
        }

        private void buttonSave(object sender, RoutedEventArgs e)
        {
            Project project  = new Project();

            project.Name = textBoxName.Text;
            project.DirectionsID = Int32.Parse(textBoxDirection.Text);
            if (!string.IsNullOrEmpty(textBoxInformation.Text))
            {
                project.Information = textBoxInformation.Text;
            }

            MapperProject mapper = new MapperProject();
            mapper.AddNew(project);

            Saved saved = new Saved();
            saved.Show();
        }

        private void buttonBack(object sender, RoutedEventArgs e)
        {
            CreateNewPage createNewPage = new CreateNewPage(_mainWindow);
            _mainWindow.Content = createNewPage;
        }
    }
}
