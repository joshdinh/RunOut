using RunOut.Pages;
using static RunOut.Pages.Calendar;
using System.Globalization;
using static RunOut.Data.UserData;

namespace RunOut.Data
{
    public class Calendar_Data
    {
        public List<Day> runs = new List<Day>();

        public int runPointer = 3;

        public int currentDay = 1;
        public int currentMonth = 1;

        public List<CompletedRun> user1Runs = new List<CompletedRun>();
        public List<CompletedRun> user2Runs = new List<CompletedRun>();
        public List<CompletedRun> user3Runs = new List<CompletedRun>();

        public Interval nullInterval = new Interval(0, 0, 0, 0);

		public Calendar_Data()
        {


        }
        public void generateAccounts()
        {
            accounts.Add(new Account("user", "pass", "Chris"));
            accounts.Add(new Account("user1", "pass", "Jessica"));
            accounts.Add(new Account("user2", "pass", "Annie"));
            accounts.Add(new Account("blank", "blank", "blank"));
        }
        public void createRoutine(int accountNum)
        {
            if(accountNum == 0)
            {
                currentDay = 11;
                currentMonth = 12;
                runPointer = 3;

                user1Runs.Add(new CompletedRun("Dec", 8, "0", "0"));
                user1Runs.Add(new CompletedRun("Dec", 9, "1.5km", "5:42"));
                user1Runs.Add(new CompletedRun("Dec", 10, "0", "0"));

                //Week 1
                runs.Add(new Day("Dec", "Thu", 8, "Rest", nullInterval, 0, "0", 2));
                runs.Add(new Day("Dec", "Fri", 9, "Run", nullInterval, 1.5, "5:30", 2));
                runs.Add(new Day("Dec", "Sat", 10, "Rest", nullInterval, 0, "0", 2));
                runs.Add(new Day("Dec", "Sun", 11, "Interval", new Interval(2, 2.5, 3, 3.5), 2.0, "5:30", 1));
                runs.Add(new Day("Dec", "Sun", 11, "Interval", new Interval(2, 2.5, 3, 3.5), 2.0, "5:30", 0));
                runs.Add(new Day("Dec", "Sun", 11, "Interval", new Interval(2, 2.5, 3, 3.5), 2.0, "5:30", 0));
                runs.Add(new Day("Dec", "Sun", 11, "Interval", new Interval(2, 2.5, 3, 3.5), 2.0, "5:30", 0));

                //Week 2
                runs.Add(new Day("Dec", "Thu", 8, "Rest1", nullInterval, 0, "0", 0));
                runs.Add(new Day("Dec", "Fri", 9, "Run2", nullInterval, 1.5, "5:30", 0));
                runs.Add(new Day("Dec", "Sat", 10, "Rest3", nullInterval, 0, "0", 0));
                runs.Add(new Day("Dec", "Sun", 11, "Interval4", new Interval(2, 2.5, 3, 3.5), 2.0, "5:30", 0));
                runs.Add(new Day("Dec", "Sun", 11, "Interval5", new Interval(2, 2.5, 3, 3.5), 2.0, "5:30", 0));
                runs.Add(new Day("Dec", "Sun", 11, "Interval6", new Interval(2, 2.5, 3, 3.5), 2.0, "5:30", 0));
                runs.Add(new Day("Dec", "Sun", 11, "Interval7", new Interval(2, 2.5, 3, 3.5), 2.0, "5:30", 0));

            }
            else if(accountNum == 1)
            {
                currentDay = 10;
                currentMonth = 12;
                runPointer = 2;

                user1Runs.Add(new CompletedRun("Dec", 8, "0", "0"));
                user1Runs.Add(new CompletedRun("Dec", 9, "1.5km", "5:37"));
                //Week 1
                runs.Add(new Day("Dec", "Thu", 8, "Rest", nullInterval, 0, "0", 2));
                runs.Add(new Day("Dec", "Fri", 9, "Run", nullInterval, 1.5, "5:30", 2));
            }
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
            public int active;

            public Day(string month, string weekday, int day, string run, Interval interval, double distance, string pace, int active)
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

        public List<Account> accounts = new List<Account>();
        public string currentUser = "user";
        public string currentPassword = "pass";
        public string currentName = "Chris";
        public int accountNumber = 0;

        public struct Account
        {
            public string user;
            public string password;
            public string name;

            public string runName;
            public int raceDay;
            public int raceMonth;
            public int raceYear;

            public string raceDistance;
            public string targetPace;

            public Account(string user, string password, string name)
            {

                this.user = user;
                this.password = password;
                this.name = name;
                runName = "Dash of Doom";
                raceDay = 0;
                raceMonth = 0;
                raceYear = 2022;
                raceDistance = "10";
                targetPace = "6:40";

            }
			public Account(string user, string password, string name, string runName, int raceDay, int raceMonth, int raceYear, string raceDistance, string targetPace)
			{

				this.user = user;
				this.password = password;
				this.name = name;
				this.runName = runName;
				this.raceDay = raceDay;
				this.raceMonth = raceMonth;
				this.raceYear = raceYear;
				this.raceDistance = raceDistance;
				this.targetPace = targetPace;

			}
		}
        public List<Feed> feed = new List<Feed>();
        public struct Feed
        {
            public string name;
            public string comment;
            public string distance;
            public string pace;

            List<Feed> comments;
        }

   

        public struct CompletedRun
        {
            public string month;
            public int day;
            public string distance;
            public string pace;

            public CompletedRun(string month, int day, string distance, string pace)
            {
                this.month = month;
                this.day = day;
                this.distance = distance;
                this.pace = pace;
            }
        }
    }

}
