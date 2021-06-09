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
using HR_DataBase_VSBLL.Mappers;


namespace HR.SkillMatrix.UI.Pages
{
    /// <summary>
    /// Interaction logic for AddLocationMenu.xaml
    /// </summary>
    public partial class AddLocationMenu : Page
    {
        private readonly MainWindow _mainWindow;

        public AddLocationMenu(MainWindow mainWindow)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
        }
        /// <summary>
        /// кнопка "Сохранить"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Save(object sender, RoutedEventArgs e)
        {
            Location location = new Location();

            location.Country = textBoxCountry.Text;
            location.City = textBoxCity.Text;
            location.Street = textBoxStreet.Text;
            location.HouseNumber = Int32.Parse(textBoxHouseNumber.Text);
            location.ApartmentNumber = Int32.Parse(textBoxApartmentNumber.Text);
            if (!string.IsNullOrEmpty(textBoxLocationIndex.Text))
            {
                location.LocationIndex = Int32.Parse(textBoxLocationIndex.Text);
            }

            MapperLocation mapper = new MapperLocation();
            mapper.AddNewLocation(location);

            Saved saved = new Saved();
            saved.Show();
        }
    }
}
