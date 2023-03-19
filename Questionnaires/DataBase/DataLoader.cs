using System.Collections.ObjectModel;
using Npgsql;

namespace Questionnaires.DataBase
{
    public class DataLoader
    {
        public static ObservableCollection<Form> Forms { get; set; } = new ObservableCollection<Form>();

        public static void Fetch()
        {
            if (Forms == null)
            {
                Forms = new ObservableCollection<Form>();
            }
            //LoadForm();
        }
    }
}
