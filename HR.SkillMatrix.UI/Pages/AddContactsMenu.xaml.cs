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
        private readonly MainWindow _mainWindow;
        public AddContactsMenu(MainWindow mainWindow)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
        }

        private void buttonSave_Click(object sender, RoutedEventArgs e)
        {
            Contacts contacts = new Contacts();

            contacts.Phone = textBoxPhone.Text;
            contacts.Email = textBoxMail.Text;
            if (!string.IsNullOrEmpty(textBoxOther.Text))
            {
                contacts.Information = textBoxOther.Text;
            }

            MapperContacts mapper = new MapperContacts();
            mapper.AddNew(contacts);

            Saved saved = new Saved();
            saved.Show();
        }
    }
}
