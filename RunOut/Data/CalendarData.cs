using RunOut.Pages;
using static RunOut.Pages.Calendar;
using System.Globalization;
using static RunOut.Data.UserData;

namespace RunOut.Data
{
    public class Calendar_Data
    {
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
            feed = new List<Feed>();
            feed.Add(new Feed("Jessica", "This is the best interval run", "10K", "6:40"));
            feed.Add(new Feed("Annie", "What's up new PR", "10K", "5:30"));
        }
        public void generateAccounts()
        {
            accounts.Add(new Account("user", "pass", "Chris",1));
            accounts.Add(new Account("user1", "pass", "Jessica",1));
            accounts.Add(new Account("user2", "pass", "Annie", 1));
            accounts.Add(new Account("blank", "blank", "Chris",0));
        }


        public void createRoutine(int accountNum)
        {
            if (accountNum == 0)
            {
                currentDay = 1;
                currentMonth = 1;
                runPointer = 3;

                user1Runs.Add(new CompletedRun("Jan", 1, "0", "0"));
                user1Runs.Add(new CompletedRun("Jan", 2, "1.5km", "5:30"));
                user1Runs.Add(new CompletedRun("Jan", 3, "0", "0"));

                //Week 1
                runs.Add(new Day("Jan", "Sun", 1, "Rest", nullInterval, 0, "0", 2));
                runs.Add(new Day("Jan", "Mon", 2, "Run", nullInterval, 1.5, "5:30", 2));
                runs.Add(new Day("Jan", "Tue", 3, "Rest", nullInterval, 0, "0", 2));
                runs.Add(new Day("Jan", "Wed", 4, "Interval", new Interval(2, 2.5, 3, 3.5), 2.0, "5:30", 1));
                runs.Add(new Day("Jan", "Thu", 5, "Interval", new Interval(2, 2.5, 3, 3.5), 2.0, "5:30", 0));
                runs.Add(new Day("Jan", "Fri", 6, "Interval", new Interval(2, 2.5, 3, 3.5), 2.0, "5:30", 0));
                runs.Add(new Day("Jan", "Sat", 7, "Interval", new Interval(2, 2.5, 3, 3.5), 2.0, "5:30", 0));

                //Week 2
                runs.Add(new Day("Jan", "Sun", 8, "Rest", nullInterval, 0, "0", 0));
                runs.Add(new Day("Jan", "Mon", 9, "Run", nullInterval, 1.5, "5:30", 0));
                runs.Add(new Day("Jan", "Tue", 10, "Rest", nullInterval, 0, "0", 0));
                runs.Add(new Day("Jan", "Wed", 11, "Interval", new Interval(2, 2.5, 3, 3.5), 2.0, "5:30", 0));
                runs.Add(new Day("Jan", "Thu", 12, "Rest", new Interval(2, 2.5, 3, 3.5), 2.0, "5:30", 0));
                runs.Add(new Day("Jan", "Fri", 13, "Interval", new Interval(2, 2.5, 3, 3.5), 2.0, "5:30", 0));
                runs.Add(new Day("Jan", "Sat", 14, "Race Day", new Interval(2, 2.5, 3, 3.5), 2.0, "5:30", 0));

            }
            else if (accountNum == 1)
            {
                currentDay = 1;
                currentMonth = 1;
                runPointer = 0;

                user1Runs.Add(new CompletedRun("Jan", 1, "0", "0"));
                user1Runs.Add(new CompletedRun("Jan", 2, "1.5km", "5:37"));
                //Week 1
                runs.Add(new Day("Jan", "Sun", 1, "Rest", nullInterval, 0, "0", 1));
                runs.Add(new Day("Jan", "Mon", 2, "Run", nullInterval, 1.5, "5:30", 0));
            }
            else
            {
                currentDay = 1;
                currentMonth = 1;
                runPointer = 3;

                user1Runs.Add(new CompletedRun("Jan", 1, "0", "0"));
                user1Runs.Add(new CompletedRun("Jan", 2, "1.5km", "5:30"));
                user1Runs.Add(new CompletedRun("Jan", 3, "0", "0"));
                //Week 1
                runs.Add(new Day("Jan", "Sun", 1, "Rest", nullInterval, 0, "0", 2));
                runs.Add(new Day("Jan", "Mon", 2, "Run", nullInterval, 1.5, "5:30", 2));
                runs.Add(new Day("Jan", "Tue", 3, "Rest", nullInterval, 0, "0", 2));
                runs.Add(new Day("Jan", "Wed", 4, "LongRun", new Interval(2, 2.5, 3, 3.5), 2.0, "5:30", 1));
                runs.Add(new Day("Jan", "Thu", 5, "Interval", new Interval(2, 2.5, 3, 3.5), 2.0, "5:30", 0));
                runs.Add(new Day("Jan", "Fri", 6, "LongRun", new Interval(2, 2.5, 3, 3.5), 2.0, "5:30", 0));
                runs.Add(new Day("Jan", "Sat", 7, "Interval", new Interval(2, 2.5, 3, 3.5), 2.0, "5:30", 0));

                //Week 2
                runs.Add(new Day("Jan", "Sun", 8, "Rest", nullInterval, 0, "0", 0));
                runs.Add(new Day("Jan", "Mon", 9, "LongRun", nullInterval, 1.5, "5:30", 0));
                runs.Add(new Day("Jan", "Tue", 10, "Rest", nullInterval, 0, "0", 0));
                runs.Add(new Day("Jan", "Wed", 11, "Interval", new Interval(2, 2.5, 3, 3.5), 2.0, "5:30", 0));
                runs.Add(new Day("Jan", "Thu", 12, "Rest", new Interval(2, 2.5, 3, 3.5), 2.0, "5:30", 0));
                runs.Add(new Day("Jan", "Fri", 13, "Interval", new Interval(2, 2.5, 3, 3.5), 2.0, "5:30", 0));
                runs.Add(new Day("Jan", "Sat", 14, "Race Day", new Interval(2, 2.5, 3, 3.5), 2.0, "5:30", 0));
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

            public Account(string user, string password, string name, int raceDay)
            {

                this.user = user;
                this.password = password;
                this.name = name;
                runName = "Dash of Doom";
                this.raceDay = raceDay;
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

            public List<Feed> comments;

            public Feed(string name, string comment, string distance, string pace)
            {
                this.name = name;
                this.comment = comment;
                this.distance = distance;
                this.pace = pace;
                comments = new List<Feed>();
                comments.Add(new Feed("Jessica", "Nice Run"));
            }

            public Feed(string name, string comment)
            {
                this.name = name;
                this.comment = comment;
                this.distance = "";
                this.pace = "";
                comments = new List<Feed>();
            }


        }
    }

}
