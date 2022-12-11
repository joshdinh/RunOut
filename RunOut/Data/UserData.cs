namespace RunOut.Data
{
    public class UserData
    {
        public string firstName;
        public string lastName;
        public int marathonRaceDay;
        public int marathonRaceMonth;
        public int marathonRaceYear;
        public string marathonName;
        public int currentWorkoutWeek;
        public int currentWorkoutDay;
        public WorkoutSet WorkoutSet;

        public UserData(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.marathonRaceDay = marathonRaceDay;
            this.marathonRaceMonth = marathonRaceMonth;
            this.marathonRaceYear = marathonRaceYear;
            this.marathonName = marathonName;
            this.currentWorkoutWeek = currentWorkoutWeek;
            this.currentWorkoutDay = currentWorkoutDay;
            WorkoutSet = new WorkoutSet();
        }
        public UserData(int marathonRaceDay, int marathonRaceMonth, int marathonRaceYear, string marathonName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.marathonRaceDay = marathonRaceDay;
            this.marathonRaceMonth = marathonRaceMonth;
            this.marathonRaceYear = marathonRaceYear;
            this.marathonName = marathonName;
            this.currentWorkoutWeek = currentWorkoutWeek;
            this.currentWorkoutDay = currentWorkoutDay;
            WorkoutSet = new WorkoutSet();
        }
        public UserData(int currentWorkoutWeek, int currentWorkoutDay, WorkoutSet workoutSet)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.marathonRaceDay = marathonRaceDay;
            this.marathonRaceMonth = marathonRaceMonth;
            this.marathonRaceYear = marathonRaceYear;
            this.marathonName = marathonName;
            this.currentWorkoutWeek = currentWorkoutWeek;
            this.currentWorkoutDay = currentWorkoutDay;
            this.WorkoutSet = workoutSet;
        }

    }
}
