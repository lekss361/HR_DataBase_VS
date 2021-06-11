using HR_DataBase_VSBLL.Mappers.ModelsToDTO;
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
    /// Interaction logic for ListOfPosition.xaml
    /// </summary>
    public partial class ListOfPosition : Page
    {
        private readonly MainWindow _mainWindow;

        public ListOfPosition(MainWindow mainWindow)
        {
            _mainWindow = mainWindow;
            InitializeComponent();
            MapperPositionsWithDirectionName mapperPositionsWithDirectionName = new MapperPositionsWithDirectionName();
            GridPositions.ItemsSource = mapperPositionsWithDirectionName.GetAllPositionsWithDirectionName();
        }

        private void ButtonBack_Click(object sender, RoutedEventArgs e)
        {
            //MainMenu mainMenu = new MainMenu(_mainWindow);
            //_mainWindow.Content = mainMenu;
            
        }
    }
}
