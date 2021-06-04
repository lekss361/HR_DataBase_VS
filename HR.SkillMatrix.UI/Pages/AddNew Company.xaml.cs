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

namespace HR_DataBase_UI.Pages
{
    /// <summary>
    /// Interaction logic for AddNew_Company.xaml
    /// </summary>
    public partial class AddNew_Company : Page
    {
        public AddNew_Company()
        {
            InitializeComponent();
        }
        /// <summary>
        /// кнопка "Принять"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Companies companies = new Companies();

            companies.Name = textBoxName.Text;
            companies.Phone = textBoxPhone.Text;
            companies.Location = textBoxLocation.Text;
            companies.Direction = textBoxDirection.Text;
            companies.Description = textBoxDescription.Text;
        }
    }
}
