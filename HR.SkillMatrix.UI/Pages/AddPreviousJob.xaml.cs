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
    /// Interaction logic for PreviousJob.xaml
    /// </summary>
    public partial class AddPreviousJob : Page
    {
        private readonly MainWindow _mainWindow;

        public AddPreviousJob(MainWindow mainWindow)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
        }
        /// <summary>
        /// кнопка "Сохранить"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Save_Click(object sender, RoutedEventArgs e)
        {
            PreviousWork previousWork = new PreviousWork();

            previousWork.StartDate = DateTime.Parse(textBoxStarDate.Text);
            previousWork.EndDate = DateTime.Parse(textBoxDismassDate.Text);
            previousWork.Information = textBoxDescription.Text;

            MapperPreviousJob mapper = new MapperPreviousJob();
            mapper.MapToPreviousJobDTO(previousWork);

            Saved saved = new Saved();
            saved.Show();
        }




    }
}
