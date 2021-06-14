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
using HR_DataBase_VSBLL.Mappers.ModelsToDTO;
using HR_DataBase_VSBLL.Models;


namespace HR.SkillMatrix.UI.Pages
{
    /// <summary>
    /// Interaction logic for ListOfStatuses.xaml
    /// </summary>
    public partial class ListOfStatuses : Page
    {
        public Statuses Statuses;
        private readonly NewWindow _newWindow;
        public ListOfStatuses(NewWindow newWindow)
        {
            InitializeComponent();
            _newWindow = newWindow;
            StatusesLogic maperStatusesLogic = new StatusesLogic();
            DataGridStatuses.ItemsSource = maperStatusesLogic.GetAllStatuses();
        }

        private void DataGridStatuses_OnMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DataGrid dg = (DataGrid)sender;
            Statuses item = (Statuses)dg.CurrentItem;
            if (item != null)
            {
                Statuses.Id = item.Id;
            }
            Saved saved = new Saved();
            saved.ShowDialog();
            _newWindow.Close();
        }
    }
}