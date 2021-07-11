using HR.SkillMatrix.UI.Pages;
using HR.SkillMatrix.UI.Windows;
using HR_DataBase_VSBLL.Models;

namespace HR.SkillMatrix.UI
{
    public class PageSwapper
    {
        private static PageSwapper _pageSwapper;
        private MainWindow _mainWindow;
        private AboutCompany _aboutCompany;
        private AboutDivision _aboutDivision;
        private AddComment _addComment;
        private AddContactsMenu _addContactsMenu;
        private AddLocationMenu _addLocationMenu;
        private AddNewCompany _addNewCompany;
        private AddNewDirections _addNewDirections;
        private AddNewDivision _addNewDivision;
        private AddNewProject _addNewProject;
        private AddNewStatus _addNewStatus;
        private AddNewWorker _addNewWorker;
        private AddNewPreviousJob _addNewPreviousJob;
        private AddSkillMenu _addSkillMenu;
        private CreateNewPage _createNewPage;
        private DepartmentDescription _departmentDescription;
        private AboutWorker _aboutWorker;
        private ListOfCompanies _listOfCompanies;
        private ListOfLocation _listOfLocation;
        private ListOfPosition _listOfPosition;
        private ListOfProject _listOfProject;
        private ListOfSkillsAndLevels _listOfSkillsAndLevels;
        private MainMenu _mainMenu;
        private SearchForEmployee _searchForEmployee;
        private SearchResult _searchResult;
        private NewWindow _newWindow;

        private PageSwapper()
        {

        }

        private PageSwapper(MainWindow mainWindow)
        {
            _mainWindow = mainWindow;
        }

        public static PageSwapper GetPageSwapper()
        {
            return _pageSwapper ??= new PageSwapper();
        }
        public static PageSwapper SetPageSwapper(MainWindow mainWindow)
        {
            return _pageSwapper = new PageSwapper(mainWindow);
        }

        public void NewWindow(AddLocationMenu addLocationMenu)
        {
            _newWindow = new NewWindow();
            _newWindow.Content = addLocationMenu;
            _newWindow.ShowDialog();
        }

        public void AddLocationMenu(Location location)
        {
            _addLocationMenu = new AddLocationMenu() { Location = location };
             NewWindow(_addLocationMenu);
        }
    }
}