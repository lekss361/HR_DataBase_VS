using System;
using System.Windows;
using System.Windows.Controls;
using HR_DataBase_VSBLL.Models;

using HR.SkillMatrix.UI.Windows;
using HR_DataBase_VSBLL.Mappers.ModelsToDTO;

namespace HR.SkillMatrix.UI.Pages
{
    /// <summary>
    /// Interaction logic for AddComment.xaml
    /// </summary>
    public partial class AddComment : Page
    {
        private readonly MainWindow _mainWindow;

        public AddComment(MainWindow mainWindow)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
        }


      
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Comments comments = new Comments();

            //worker.BirthDay = BirthDay.SelectedDate.Value.Date.ToString("MM.dd.yyyy");
            comments.WorkersID = 1; //textBoxNameWorker.Text;
            //comments.Date = Date.SelectedDate.Value.Date.ToString("MM.dd.yyyy");

            if (!string.IsNullOrEmpty(textBoxComment.Text))
            {
                comments.Comment = textBoxComment.Text;
            }

            MapperComments mapper = new MapperComments();
            mapper.AddNewComments(comments);

            Saved saved = new Saved();
            saved.Show();
        }
    }

    //private void ButtonBack(object sender, RoutedEventArgs e)
    //{

    //}
}
