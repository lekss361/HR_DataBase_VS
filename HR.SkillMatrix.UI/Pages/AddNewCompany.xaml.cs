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
    /// Interaction logic for AddNew_Company.xaml
    /// </summary>
    public partial class AddNewCompany : Page
    {
        private readonly MainWindow _mainWindow;
        public AddNewCompany(MainWindow mainWindow)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
        }

        /// <summary>
        /// кнопка "Принять"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSave_Click(object sender, RoutedEventArgs e)
        {
            HR_DataBase_VSBLL.Models.Company companies = new HR_DataBase_VSBLL.Models.Company();

            companies.Name = textBoxName.Text;
            companies.ContactID = 1;
            companies.LocationID = 1;
            companies.Information = textBoxDescription.Text;

            MapperCompany mapper = new MapperCompany();
            mapper.MapToCompaniesDTO(companies);

            Saved saved = new Saved();
            saved.Show();
        }
        /// <summary>
        /// кнопка "Назад"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void ButtonBack_Click(object sender, RoutedEventArgs e)
        {
            CreateNewPage createNewPage = new CreateNewPage(_mainWindow);
            _mainWindow.Content = createNewPage;
        }


        private void ButtonAddLocation_Click(object sender, RoutedEventArgs e)
        {
            NewWindow newWindow = new NewWindow();
            AddLocationMenu locationMenu = new AddLocationMenu(_mainWindow);
            newWindow.Content = locationMenu;
            newWindow.Show();
        }

        private void ButtonAddContact_Click(object sender, RoutedEventArgs e)
        {
            NewWindow newWindow = new NewWindow();
            AddContactsMenu addContactsMenu = new AddContactsMenu(_mainWindow);
            newWindow.Content = addContactsMenu;
            newWindow.Show();
        }
    }
}
