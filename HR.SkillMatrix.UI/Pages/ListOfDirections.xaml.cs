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
using HR_DataBase_VSBLL.Mappers.ModelsToDTO;
using HR_DataBase_VSBLL.Models;

namespace HR.SkillMatrix.UI.Pages
{
    /// <summary>
    /// Interaction logic for ListOfDirections.xaml
    /// </summary>
    public partial class ListOfDirections : Page
    {
        public Directions Directions;
        private readonly MainWindow _mainWindow;
        private readonly NewWindow _newWindow;
        public ListOfDirections(MainWindow mainWindow)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
            FillDataGrid();
        }
        public ListOfDirections(NewWindow newWindow)
        {
            InitializeComponent();
            _newWindow = newWindow;
            FillDataGrid();
        }

        private void FillDataGrid()
        {
            MapperDirections mapperDirections = new MapperDirections();
            DataGridDirections.ItemsSource = mapperDirections.GetAllDirections();
        }

        private void DataGridDirections_OnMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DataGrid dg = (DataGrid)sender;
            Directions item = (Directions)dg.CurrentItem;
            if (item != null)
            {
                Directions.id = item.id;
            }
            Saved saved = new Saved();
            saved.ShowDialog();
            _newWindow.Close();
        }
    }
}
