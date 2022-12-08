namespace RunOut.Data
{
    public static class Database
    {
        //Create a dictionary to store usernames and passwords
        public static Dictionary<string, string> users = new Dictionary<string, string>();

        //Dictionary to connect the user to their data 
        public static Dictionary<string, UserData> userData = new Dictionary<string, UserData>();

        public static string currentUser;

        public static void SeedDictionaries()
        {
            //Database.users.Add("josh", "password");

            //Database.userData.Add("josh", new UserData("Josh", "Dinh", "Oct. 29", "Dash of Doom", 3, 2, new WorkoutSet()));
        }
    }

}
