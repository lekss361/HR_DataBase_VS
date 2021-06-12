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
using HR_DataBase_VSBLL.Mappers;

namespace HR.SkillMatrix.UI.Pages
{
    /// <summary>
    /// Interaction logic for AddContactsMenu.xaml
    /// </summary>
    public partial class AddContactsMenu : Page
    {
        public Contacts Contacts;
        private readonly MainWindow _mainWindow;
        public AddContactsMenu(MainWindow mainWindow)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
        }

        private void buttonSave_Click(object sender, RoutedEventArgs e)
        {
            //Contacts contacts = new Contacts();

            Contacts.Phone = textBoxPhone.Text;
            Contacts.Email = textBoxMail.Text;
            if (!string.IsNullOrEmpty(textBoxOther.Text))
            {
                Contacts.Information = textBoxOther.Text;
            }

            
            
            //MapperContacts mapper = new MapperContacts();
            //contacts.Id = mapper.AddNew(contacts);

            Saved saved = new Saved();
            saved.Show();
        }
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            AddNewWorker addNewWorker = new AddNewWorker(_mainWindow);
            addNewWorker.Contacts = this.Contacts;
            _mainWindow.Content = addNewWorker;
        }
    }
}
