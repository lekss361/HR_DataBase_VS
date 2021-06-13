using HR_DataBase_VSBLL.Mappers.ModelsToDTO;
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

namespace HR.SkillMatrix.UI.Pages
{
    /// <summary>
    /// Interaction logic for ListOfPosition.xaml
    /// </summary>
    public partial class ListOfPosition : Page
    {
        private readonly MainWindow _mainWindow;
        private readonly NewWindow _newWindow;
        public PositionsWithDirectionName PositionsWithDirectionName;
        public ListOfPosition(MainWindow mainWindow)
        {
            _mainWindow = mainWindow;
            InitializeComponent();
            FillDataGrid();
        }
        public ListOfPosition(NewWindow newWindow)
        {
            _newWindow = newWindow;
            InitializeComponent();
            FillDataGrid();
        }

        private void FillDataGrid()
        {
            MapperPositionsWithDirectionName mapperPositionsWithDirectionName = new MapperPositionsWithDirectionName();
            DataGridPositions.ItemsSource = mapperPositionsWithDirectionName.GetAllPositionsWithDirectionName();
        }

        private void ButtonBack_Click(object sender, RoutedEventArgs e)
        {
            //MainMenu mainMenu = new MainMenu(_mainWindow);
            //_mainWindow.Content = mainMenu;
        }

        private void DataGridPositions_OnMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DataGrid dg = (DataGrid)sender;
            PositionsWithDirectionName item = (PositionsWithDirectionName)dg.CurrentItem;
            if (item != null)
            {
                PositionsWithDirectionName.id = item.id;
            }
            Saved saved = new Saved();
            saved.ShowDialog();
            _newWindow.Close();
        }
    }
}
