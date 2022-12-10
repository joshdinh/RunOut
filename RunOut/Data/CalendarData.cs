using RunOut.Pages;
using static RunOut.Pages.Calendar;
using System.Globalization;

namespace RunOut.Data
{
    public class Calendar_Data
    {
        public List<Day> runs = new List<Day>();
        public int runPointer = 3;

        public int currentDay = 1;
        public int currentMonth = 1;

        public int raceDay = -1;
        public int raceMonth = -1;

        public Interval nullInterval = new Interval(0, 0, 0, 0);

		public Calendar_Data()
        {
            runs.Add(new Day("Dec", "Thu", 8, "Rest", nullInterval, 0, "0", true));
            runs.Add(new Day("Dec", "Fri", 9, "Run", nullInterval, 1.5, "5:30", false));
            runs.Add(new Day("Dec", "Sat", 10, "Rest", nullInterval, 0, "0", false));
            runs.Add(new Day("Dec", "Sun", 11, "Interval", new Interval(2,2.5,3,3.5), 2.0, "5:30", false));
        }

        void generateRoutine(int month, int day)
        {
            this.raceDay = day;
            this.raceMonth = month; 
        }

        public struct Interval
        {
            public double interval1;
            public double interval2;
            public double interval3;
            public double interval4;

            public Interval(double first, double second, double third, double fourth)
            {
                interval1 = first;
                interval2 = second;
                interval3 = third;
                interval4 = fourth;
            }
        }

        public struct Day
        {
            public string month;
            public string weekday;
            public int day;
            public string runType;
            public Interval interval;
            public double distance;
            public string pace;
            public bool active;

            public Day(string month, string weekday, int day, string run, Interval interval, double distance, string pace, bool active)
            {
                this.month = month;
                this.weekday = weekday;
                this.day = day;
                this.pace = pace;
                this.runType = run;
                this.interval = interval;
                this.distance = distance;
                this.active = active;
            }
        }


    }
}
