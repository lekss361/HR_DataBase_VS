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

namespace HR.SkillMatrix.UI.Pages
{
    /// <summary>
    /// Interaction logic for ListOfSkillsAndLevels.xaml
    /// </summary>
    public partial class ListOfSkillsAndLevels : Page
    {
        private readonly MainWindow _mainWindow;
        public ListOfSkillsAndLevels(MainWindow mainWindow,int id)
        {
            _mainWindow = mainWindow;
            InitializeComponent();
            SkillNameLogic mapperSkillName = new SkillNameLogic();
            DataGridSkillsAndLevels.ItemsSource = mapperSkillName.GetSkillNameByTypeId(id);
        }
        public ListOfSkillsAndLevels(MainWindow mainWindow)
        {
            _mainWindow = mainWindow;
            InitializeComponent();
            SkillNameLogic mapperSkillName = new SkillNameLogic();
            DataGridSkillsAndLevels.ItemsSource = mapperSkillName.GetSkillNameByAllType();
        }

        private void ButtonSaveSkill_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonAddSkill_Click(object sender, RoutedEventArgs e)
        {
            AddSkillMenu addSkillMenu = new AddSkillMenu(_mainWindow);
            _mainWindow.Content = addSkillMenu;
        }
    }
}
