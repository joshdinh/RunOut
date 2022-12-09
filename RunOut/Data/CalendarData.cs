using RunOut.Pages;
using static RunOut.Pages.Calendar;
using System.Globalization;

namespace RunOut.Data
{
    public class Calendar_Data
    {
        public List<Day> runs = new List<Day>();
        public int runPointer = 0;

        public int currentDay = 1;
        public int currentMonth = 1;

        public int raceDay = -1;
        public int raceMonth = -1;

		public Calendar_Data()
        {
            runs.Add(new Day("Dec", "Thu", 8, "Rest", 0, 0, true));
            runs.Add(new Day("Dec", "Fri", 9, "Run", 1.5, 5.30, false));
            runs.Add(new Day("Dec", "Sat", 10, "Rest", 0, 0, false));
        }

        void generateRoutine(int month, int day)
        {
            this.raceDay = day;
            this.raceMonth = month; 
        }


        public struct Day
        {
            public string month;
            public string weekday;
            public int day;
            public string runType;
            public double distance;
            public double pace;
            public bool active;

            public Day(string month, string weekday, int day, string run, double distance, double pace, bool active)
            {
                this.month = month;
                this.weekday = weekday;
                this.day = day;
                this.pace = pace;
                this.runType = run;
                this.distance = distance;
                this.active = active;
            }
        }

    }
}
