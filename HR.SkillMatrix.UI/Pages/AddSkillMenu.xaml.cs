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
using HR_DataBase_VSBLL.Mappers.ModelsToDTO;

namespace HR.SkillMatrix.UI.Pages
{
    /// <summary>
    /// Interaction logic for AddSkillMenu.xaml
    /// </summary>
    public partial class AddSkillMenu : Page
    {
        private readonly MainWindow _mainWindow;
        private int _skillType;
        public AddSkillMenu(MainWindow mainWindow)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
            _skillType = 1;
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            SkillNameWithType skillName = new SkillNameWithType();

            skillName.SkillName = textBoxNewSkill.Text;

            skillName.SkillTypeID = _skillType;

            SkillNameLogic mapper = new SkillNameLogic();
            mapper.MapToSkillNameDTO(skillName);
        }

        private void SoftSkill_Checked(object sender, RoutedEventArgs e)
        {
            _skillType = 2;
        }

        private void HardSkill_Checked(object sender, RoutedEventArgs e)
        {
            _skillType = 1;
        }
    }
}
