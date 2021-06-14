using HR.SkillMatrix.UI.Windows;
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

namespace HR.SkillMatrix.UI.Pages
{
    /// <summary>
    /// Interaction logic for SearchResult.xaml
    /// </summary>
    public partial class SearchResult : Page
    {
        private readonly MainWindow _mainWindow;
        public NewWindow _newWindow;
        WorkerLogic mapperWorker = new WorkerLogic();
        private int id;
        public SearchResult(MainWindow mainWindow)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
        }
        public SearchResult(MainWindow mainWindow, List<int> listId)
        {
            InitializeComponent();
            List<WorkerWithForeignKeyValue> workerWithForeignKeyValue = new List<WorkerWithForeignKeyValue>();
            foreach (var tmp in listId)
            {
                workerWithForeignKeyValue.Add(mapperWorker.GetWorkerByID(tmp));
            }
            _mainWindow = mainWindow;
            DataGridSeacrhResults.ItemsSource = workerWithForeignKeyValue;
        }

        private void UIElement_OnMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DataGrid dg = (DataGrid)sender;
            WorkerWithForeignKeyValue item = (WorkerWithForeignKeyValue)dg.CurrentItem;
            if (item != null)
            {
                id = item.id;
            }
            //if (_mainWindow != null)
            //{
            //    AboutWorker aboutCompany = new AboutWorker(_mainWindow, id);
            //    _mainWindow.Content = aboutCompany;
            //}
            _newWindow = new NewWindow();
            AboutWorker aboutCompany = new AboutWorker(_newWindow, id);
            _newWindow.Content = aboutCompany;
            _newWindow.ShowDialog();
        }

        private void ButtonBack_OnClick(object sender, RoutedEventArgs e)
        {
            SearchForEmployee createNewPage = new SearchForEmployee(_mainWindow);
            _mainWindow.Content = createNewPage;
        }
    }
}