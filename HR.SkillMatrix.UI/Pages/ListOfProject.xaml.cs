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
    /// Interaction logic for ListOfProject.xaml
    /// </summary>
    public partial class ListOfProject : Page
    {
        private readonly MainWindow _mainWindow;
        public ListOfProject(MainWindow mainWindow)
        {
            _mainWindow = mainWindow;
            InitializeComponent();
            MapperProjectsWithDirectionName mapperProjectsWithDirectionName = new MapperProjectsWithDirectionName();
            Projects.ItemsSource = mapperProjectsWithDirectionName.GetAllProjectsWithDirectionName();
        }
    }
}
