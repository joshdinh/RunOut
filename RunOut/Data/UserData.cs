namespace RunOut.Data
{
    public class UserData
    {
        public string UserName;
        public string Password;
        public string marathonRaceDate;
        public string marathonName;
        //public string marathonLocation;
        public int currentWorkoutWeek;
        public int currentWorkoutDay;
        public WorkoutSet WorkoutSet;

        public UserData(string marathonRaceDate, string marathonName, string marathonLocation, int currentWorkoutWeek, int currentWorkoutDay, WorkoutSet workoutSet)
        {
            this.marathonRaceDate = marathonRaceDate;
            this.marathonName = marathonName;
            //this.marathonLocation = marathonLocation;
            this.currentWorkoutWeek = currentWorkoutWeek;
            this.currentWorkoutDay = currentWorkoutDay;
            WorkoutSet = workoutSet;
        }

    }
}
