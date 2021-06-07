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
    /// Interaction logic for Worker.xaml
    /// </summary>
    public partial class AddNewWorker : Page
    {
        private readonly MainWindow _mainWindow;
        public AddNewWorker(MainWindow mainWindow)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            CreateNewPage createNewPage = new CreateNewPage(_mainWindow);
            _mainWindow.Content = createNewPage;
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            Worker worker = new Worker();

            worker.Country = textBoxCountry.Text;
            worker.City = textBoxCity.Text;
            worker.Street = textBoxStreet.Text;
            worker.HouseNumber = Int32.Parse(textBoxHouseNumber.Text);
            worker.ApartmentNumber = Int32.Parse(textBoxApartmentNumber.Text);
            location.LocationIndex = Int32.Parse(textBoxLocationIndex.Text);

            MapperLocation mapper = new MapperLocation();
            mapper.MapToWorkersDTO(worker);

            Saved saved = new Saved();
            saved.Show();
        }

        private void CreateLocation_Click(object sender, RoutedEventArgs e)
        {
            NewWindow newWindow = new NewWindow();
            AddLocationMenu locationMenu = new AddLocationMenu(_mainWindow);
            newWindow.Content = locationMenu;
            newWindow.Show();
        }
        //private void BoxContacts_OnMouseEnter(object sender, MouseEventArgs e)
        //{
        //    List<int> numbers = new List<int>() { 1, 2, 3, 45 };
        //    foreach (object ss in numbers)
        //    { 
        //        BoxContacts.Items.Add(ss + "ss");
        //    }

        //    //Button addlocations = new Button();
        //    //addlocations.Height = 100;
        //    //addlocations.Width = 100;
        //    //addlocations.Content = "sss";
        //    //addlocations.Click += AddLocation_OnClick;
        //}

        //private void AddLocation_OnClick(object sender, RoutedEventArgs e)
        //{
        //    AddLocationMenu locationMenu = new AddLocationMenu(_mainWindow);
        //    _mainWindow.Content = locationMenu;
        //}
    }
}
