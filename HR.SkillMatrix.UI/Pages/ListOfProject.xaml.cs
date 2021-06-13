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
using HR_DataBase_VSDAL.Models;

namespace HR.SkillMatrix.UI.Pages
{
    /// <summary>
    /// Interaction logic for ListOfProject.xaml
    /// </summary>
    public partial class ListOfProject : Page
    {
        private readonly MainWindow _mainWindow;
        private readonly NewWindow _newWindow;
        public List<int> ProjectsId;
        public ListOfProject(MainWindow mainWindow)
        {
            _mainWindow = mainWindow;
            InitializeComponent();
            FillDataGrid();
        }

        public ListOfProject(NewWindow newWindow)
        {
            _newWindow = newWindow;
            InitializeComponent();
            FillDataGrid();
        }

        private void FillDataGrid()
        {
            MapperProjectsWithDirectionName mapperProjectsWithDirectionName = new MapperProjectsWithDirectionName();
            DataGridProjects.ItemsSource = mapperProjectsWithDirectionName.GetAllProjectsWithDirectionName();
        }

        private void DataGridProjects_OnMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DataGrid dg = (DataGrid)sender;
            ProjectsWithDirectionName item = (ProjectsWithDirectionName)dg.CurrentItem;
            if (item != null)
            {
                int count=0;
                foreach (var a  in ProjectsId)
                {
                    if (a == item.id)
                    {
                        count++;
                    }
                }

                if (count == 0)
                {
                    ProjectsId.Add(item.id);
                    MessageBox.Show($@"Выбрано {item.Name}");
                }
            }
            LabelCount.Content = ($@"Всего выбранно {ProjectsId.Count}");
        }

        private void ButtonCancel_OnClick(object sender, RoutedEventArgs e)
        {
            ProjectsId.Clear();
            MessageBox.Show($@"Не сохранено");
            _newWindow.Close();
        }

        private void ButtonSave_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($@"Сохранено");
            _newWindow.Close();
        }
    }
}