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
using HR_DataBase_VSBLL.Models;

namespace HR.SkillMatrix.UI.Pages
{
    /// <summary>
    /// Interaction logic for SearchResult.xaml
    /// </summary>
    public partial class SearchResult : Page
    {
        private readonly MainWindow _mainWindow;
        private readonly NewWindow _newWindow;
        public SearchResult(MainWindow mainWindow)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
        }
        public SearchResult(NewWindow newWindow, List<Worker> workers)
        {
            InitializeComponent();
            int a=workers.Count;
            _newWindow = newWindow;
            DataGridSeacrhResults.ItemsSource = workers;
        }

        private void UIElement_OnMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            
        }
    }
}