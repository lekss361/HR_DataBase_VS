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
using HR_DataBase_VSBLL.Mappers.ModelsToDTO;

namespace HR.SkillMatrix.UI.Pages
{
    /// <summary>
    /// Interaction logic for AddNewDirections.xaml
    /// </summary>
    public partial class AddNewDirections : Page
    {
        private readonly MainWindow _mainWindow;
        public AddNewDirections(MainWindow mainWindow)
        {
            InitializeComponent();
            _mainWindow = mainWindow;

        }

        private void ButtonSave_Click(object sender, RoutedEventArgs e)
        {
            Directions directions = new Directions();
            directions.Name = textBoxName.Text;

            DirectionsLogic mapper = new DirectionsLogic();
            mapper.AddDirections(directions);

            Saved saved = new Saved();
            saved.Show();
        }

        private void ButtonBack_Click(object sender, RoutedEventArgs e)
        {
            CreateNewPage createNewPage = new CreateNewPage(_mainWindow);
            _mainWindow.Content = createNewPage;
        }
    }
}
