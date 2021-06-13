using HR.SkillMatrix.UI.Windows;
using HR_DataBase_VSBLL.Models;
using System.Windows;
using System.Windows.Controls;

namespace HR.SkillMatrix.UI.Pages
{
    /// <summary>
    /// Interaction logic for PreviousJob.xaml
    /// </summary>
    public partial class AddNewPreviousJob : Page
    {
        private readonly MainWindow _mainWindow;
        private readonly NewWindow _newWindow;
        public PreviousWork PreviousWork;
        public AddNewPreviousJob(MainWindow mainWindow)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
        }
        public AddNewPreviousJob(NewWindow newWindow)
        {
            InitializeComponent();
            _newWindow = newWindow;
        }
        /// <summary>
        /// кнопка "Сохранить"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSave_Click(object sender, RoutedEventArgs e)
        {
            PreviousWork.StartDate = DatePikerStartData.SelectedDate.Value.Date.ToString("MM.dd.yyyy");
            PreviousWork.EndDate = DatePikerEndData.SelectedDate.Value.Date.ToString("MM.dd.yyyy");
            PreviousWork.Information = textBoxDescription.Text;
            Saved saved = new Saved();
            saved.Show();
            _newWindow.Close();
        }
    }
}