namespace Questionnaires
{
    public class PageControl
    {
        private static MainPage mainpage;
        public static MainPage Mainpage
        {
            get
            {
                if (mainpage == null)
                    mainpage = new MainPage();
                return mainpage;
            }
        }

        private static TeacherRegistration teacherRegistration;
        public static TeacherRegistration teacherRegistrations
        {
            get
            {
                if (teacherRegistration == null)
                    teacherRegistration = new TeacherRegistration();
                return teacherRegistration;
            }
        }

        private static StudentRegistration studentRegistration;
        public static StudentRegistration studentRegistrations
        {
            get
            {
                if (studentRegistration == null)
                    studentRegistration = new StudentRegistration();
                return studentRegistration;
            }
        }

        private static TeacherAuthorization teacherAuthorization;
        public static TeacherAuthorization teacherAuthorizations
        {
            get
            {
                if (teacherAuthorization == null)
                    teacherAuthorization = new TeacherAuthorization();
                return teacherAuthorization;
            }
        }

        private static StudentAuthorization studentAuthorization;
        public static StudentAuthorization studentAuthorizations
        {
            get
            {
                if (studentAuthorization == null)
                    studentAuthorization = new StudentAuthorization();
                return studentAuthorization;
            }
        }
        private static CreatingEditingQuestionnaires creatingEditingQuestionnaires;
        public static CreatingEditingQuestionnaires creatingeditingQuestionnaires
        {
            get
            {
                if (creatingEditingQuestionnaires == null)
                    creatingEditingQuestionnaires = new CreatingEditingQuestionnaires();
                return creatingEditingQuestionnaires;
            }
        }
        private static QuestionnairesForStudents questionnairesForStudents;
        public static QuestionnairesForStudents questionnairesforStudents
        {
            get
            {
                if (questionnairesForStudents == null)
                    questionnairesForStudents = new QuestionnairesForStudents();
                return questionnairesForStudents;
            }
        }      
    }
}
