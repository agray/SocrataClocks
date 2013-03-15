namespace MinuteDegreeCalculator {
    public class SocrataClock {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public string AMPM { get; set; }

        private const string Morning = "AM";

        public SocrataClock(int hours, int minutes, string ampm) {
            Hours = hours;
            Minutes = minutes;
            AMPM = ampm;
        }

        public bool IsBefore(SocrataClock otherClock) {
            if(AreEqual(otherClock)) {
                return false;
            }
            if (IsAfternoon() && otherClock.IsMorning()) {
                return false;
            }
            if (IsMorning() && otherClock.IsAfternoon()) {
                return true;
            }
            if(Hours < otherClock.Hours) {
                return true;
            }
            if(Minutes < otherClock.Minutes) {
                return true;
            }
            return false;
        }

        public int HourDifference(int otherHours) {
            return Hours - otherHours;
        }

        public int MinuteDifference(int otherMinutes) {
            return Minutes - otherMinutes;
        }

        public bool AreEqual(SocrataClock otherClock) {
            return HasSameHours(otherClock.Hours) &&
                   HasSameMinutes(otherClock.Minutes) &&
                   HasSameAMPM(otherClock.AMPM);
        }

        private bool IsMorning() {
            return AMPM.Equals(Morning);
        }

        private bool IsAfternoon() {
            return !IsMorning();
        }

        private bool HasSameHours(int otherHours) {
            return Hours == otherHours;
        }

        private bool HasSameMinutes(int otherMinutes) {
            return Minutes == otherMinutes;
        }

        private bool HasSameAMPM(string otherAMPM) {
            return AMPM.Equals(otherAMPM);
        }
    }
}