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
    /// Interaction logic for Company.xaml
    /// </summary>
    public partial class AboutCompany : Page
    {
        private readonly MainWindow _mainWindow;
        public AboutCompany(MainWindow mainWindow, int id)
        {
            InitializeComponent();
            _mainWindow = mainWindow;

            MapperDivisionByCompany mapperDivisionByCompany = new MapperDivisionByCompany();
            Divisions.ItemsSource = mapperDivisionByCompany.GetDivisionByCompanyID(id);
        }

        private void DataGridDivisions_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            AddLocationMenu aboutCompany = new AddLocationMenu(_mainWindow);
            _mainWindow.Content = aboutCompany;
            DataGrid dg = (DataGrid)sender;
            ////ClientBaseModel item = (ClientBaseModel)dg.CurrentItem;
            //Company item = (Company)dg.CurrentItem;
            //if (item != null)
            //{
            //    int id = item.Id;
            //    AboutCompany aboutCompany = new AboutCompany(_mainWindow, id);
            //    _mainWindow.Content = aboutCompany;

            //}



        }

        private void backToCompanyTable_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
