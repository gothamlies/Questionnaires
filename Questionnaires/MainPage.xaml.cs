using System.Windows;
using System.Windows.Navigation;

namespace Questionnaires
{
    public partial class MainPage : Window
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void FirstPage(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(PageControl.Mainpage);
        }

        private void CreatingEditingQuestionnaires(object sender, RoutedEventArgs e) //После входа, как препод
        {
            NavigationService.Navigate(PageControl.creatingeditingQuestionnaires);
        }

        private void QuestionnairesForStudents(object sender, RoutedEventArgs e) //После входа, как студент
        {
            NavigationService.Navigate(PageControl.questionnairesforStudents);
        }

        private void TeacherAuthorization(object sender, RoutedEventArgs e) //авторизация как препод
        {
            NavigationService.Navigate(PageControl.teacherAuthorizations);
        }

        private void StudentAuthorization(object sender, RoutedEventArgs e) //авторизация как студент
        {
            NavigationService.Navigate(PageControl.studentAuthorizations);
        }

        private void TeacherRegestration(object sender, RoutedEventArgs e) //регитсрация препода
        {
            NavigationService.Navigate(PageControl.teacherRegistrations);
        }

        private void StudentRegestration(object sender, RoutedEventArgs e) // регистрация студента
        {
            NavigationService.Navigate(PageControl.studentRegistrations);
        }

    }
}
