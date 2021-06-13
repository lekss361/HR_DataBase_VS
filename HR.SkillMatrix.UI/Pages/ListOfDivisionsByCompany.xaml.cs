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
using HR_DataBase_VSBLL.Mappers;
using HR_DataBase_VSBLL.Models;

namespace HR.SkillMatrix.UI.Pages
{
    /// <summary>
    /// Interaction logic for ListOfDivisionsByCompany.xaml
    /// </summary>
    public partial class ListOfDivisionsByCompany : Page
    {
        private int _companyId;
        private int _divisionId;
        private readonly MainWindow _mainWindow;
        private readonly NewWindow _newWindow;
        public DivisionByCompany DivisionByCompany;
        public ListOfDivisionsByCompany(MainWindow mainWindow)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
        }
        public ListOfDivisionsByCompany(NewWindow newWindow, int companyCompanyId)
        {
            InitializeComponent();
            _newWindow = newWindow;
            _companyId = companyCompanyId;

            MapperDivisionByCompany mapperDivisionByCompany = new MapperDivisionByCompany();
            DataGridDivisions.ItemsSource = mapperDivisionByCompany.GetDivisionByCompanyID(_companyId);
        }

        private void DataGridDivisions_OnMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DataGrid dg = (DataGrid)sender;
            DivisionByCompany item = (DivisionByCompany)dg.CurrentItem;
            if (item != null)
            {
                DivisionByCompany.id = item.id;
            }
            _newWindow.Close();
            Saved saved = new Saved();
            saved.ShowDialog();
        }
    }
}
