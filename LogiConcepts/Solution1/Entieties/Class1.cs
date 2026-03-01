using System;

namespace Taller01.Entities
{
    public class Time
    {
        // FIELDS
        private int _hour;
        private int _minute;
        private int _second;
        private int _millisecond;

        // PROPERTIES
        public int Hour { get => _hour; set => _hour = value; }
        public int Minute { get => _minute; set => _minute = value; }
        public int Second { get => _second; set => _second = value; }
        public int Millisecond { get => _millisecond; set => _millisecond = value; }

        // CONSTRUCTORS
        public Time() : this(0, 0, 0, 0) { }
        public Time(int h) : this(h, 0, 0, 0) { }
        public Time(int h, int m) : this(h, m, 0, 0) { }
        public Time(int h, int m, int s) : this(h, m, s, 0) { }
        public Time(int h, int m, int s, int ms)
        {
            if (!ValidHour(h)) throw new ArgumentException($"The hour: {h}, is not valid.");
            if (!ValidMinute(m)) throw new ArgumentException($"The minute: {m}, is not valid.");
            if (!ValidSecond(s)) throw new ArgumentException($"The second: {s}, is not valid.");
            if (!ValidMillisecond(ms)) throw new ArgumentException($"The millisecond: {ms}, is not valid.");

            _hour = h; _minute = m; _second = s; _millisecond = ms;
        }

        // PRIVATE VALIDATION METHODS
        private bool ValidHour(int h) => h >= 0 && h <= 23;
        private bool ValidMinute(int m) => m >= 0 && m <= 59;
        private bool ValidSecond(int s) => s >= 0 && s <= 59;
        private bool ValidMillisecond(int ms) => ms >= 0 && ms <= 999;

        // METHODS
        public long ToMilliseconds() =>
            _hour * 3600000L + _minute * 60000L + _second * 1000L + _millisecond;

        public long ToSeconds() => ToMilliseconds() / 1000;
        public long ToMinutes() => ToMilliseconds() / 60000;

        public Time Add(Time other)
        {
            long total = (this.ToMilliseconds() + other.ToMilliseconds()) % 86400000L;
            return new Time(
                (int)(total / 3600000),
                (int)((total % 3600000) / 60000),
                (int)((total % 60000) / 1000),
                (int)(total % 1000)
            );
        }

        public bool IsOtherDay(Time other) =>
            (this.ToMilliseconds() + other.ToMilliseconds()) >= 86400000;

        public override string ToString()
        {
            int hour12;
            string period;

            if (Hour == 0)
            {
                hour12 = 0;   
                period = "AM";
            }
            else if (Hour < 12)
            {
                hour12 = Hour;
                period = "AM";
            }
            else if (Hour == 12)
            {
                hour12 = 0;   
                period = "PM";
            }
            else
            {
                hour12 = Hour - 12; 
                period = "PM";
            }

            return $"{hour12:00}:{Minute:00}:{Second:00}.{Millisecond:000} {period}";
        }
    }
}
