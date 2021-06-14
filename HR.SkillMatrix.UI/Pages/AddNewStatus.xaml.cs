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
    /// Interaction logic for AddNewStatus.xaml
    /// </summary>
    public partial class AddNewStatus : Page
    {
        private readonly MainWindow _mainWindow;
        public AddNewStatus(MainWindow mainWindow)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
        }

        private void ButtonSave_Click(object sender, RoutedEventArgs e)
        {
            Statuses statuses = new Statuses();
            statuses.Name = textBoxName.Text;

            StatusesLogic mapper = new StatusesLogic();
            mapper.AddNewStatuses(statuses);

            Saved saved = new Saved();
            saved.Show();
        }

        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            CreateNewPage createNewPage = new CreateNewPage(_mainWindow);
            _mainWindow.Content = createNewPage;
        }
    }
}
