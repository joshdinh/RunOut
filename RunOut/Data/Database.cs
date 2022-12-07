namespace RunOut.Data
{
    public static class Database
    {
        //Create a dictionary to store usernames and passwords
        public static Dictionary<string, string> users = new Dictionary<string, string>();

        //Dictionary to connect the user to their data 
        public static Dictionary<string, UserData> userData = new Dictionary<string, UserData>();


    }
}
