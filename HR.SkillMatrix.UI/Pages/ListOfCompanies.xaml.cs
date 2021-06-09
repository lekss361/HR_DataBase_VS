using HR_DataBase_VSBLL.Mappers;
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
    /// Interaction logic for ListOfCompanies.xaml
    /// </summary>
    public partial class ListOfCompanies : Page
    {
        private readonly MainWindow _mainWindow;
        public ListOfCompanies(MainWindow mainWindow)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
            MapperCompanies mapperCompanies = new MapperCompanies();
            Companies.ItemsSource = mapperCompanies.GetAllCompanies();
        }

    }
}
