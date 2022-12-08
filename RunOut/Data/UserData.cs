namespace RunOut.Data
{
    public class UserData
    {
        public string firstName;
        public string lastName;
        public string marathonRaceDate;
        public string marathonName;
        public int currentWorkoutWeek;
        public int currentWorkoutDay;
        public WorkoutSet WorkoutSet;

        public UserData(string firstName, string lastName, string marathonRaceDate, string marathonName, int currentWorkoutWeek, int currentWorkoutDay, WorkoutSet workoutSet)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.marathonRaceDate = marathonRaceDate;
            this.marathonName = marathonName;
            this.currentWorkoutWeek = currentWorkoutWeek;
            this.currentWorkoutDay = currentWorkoutDay;
            WorkoutSet = workoutSet;
        }

    }
}
