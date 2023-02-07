namespace Times
{
    public struct Time
    {
        private int secondsSinceMidnight = 0;

        public Time(string time)
        {
            string[] times = time.Split(":");
            Second = int.Parse(times[2]);
            Minute = int.Parse(times[1]);
            Hour = int.Parse(times[0]);
        }

        public Time(int seconds, int minutes, int hours)
        {
            Second = seconds;
            Minute = minutes;
            Hour = hours;
        }

        public int Hour
        {
            set
            {
                int hour = value;
                int temp = secondsSinceMidnight % 3600;
                secondsSinceMidnight = (temp + hour * 3600) % 86400;
            }
            get
            {
                return secondsSinceMidnight / 3600;
            }
        }

        public int Minute
        {
            set
            {
                int minute = value;
                int temp = secondsSinceMidnight % 60;
                secondsSinceMidnight = (temp + minute * 60) % 3600;
            }
            get
            {
                return secondsSinceMidnight / 60 % 60;
            }
        }
        public int Second
        {
            set
            {
                int second = value;
                secondsSinceMidnight += second;
            }
            get
            {
                return secondsSinceMidnight % 60;
            }
        }

        

        public override string ToString()
        {
            return Hour + ":" + Minute + ":" + Second;
        }
    }
}