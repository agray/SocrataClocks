namespace MinuteDegreeCalculator {
    public class DegreeCalculator {
        private const int MinutesInHour = 60;
        private const int HoursInDay = 24;
        private const int DegreesPerMinute = 6;
        private const int OneRevolution = 360;

        public static int CalculateDegrees(SocrataClock firstClock, SocrataClock secondClock) {
            if(firstClock.AreEqual(secondClock)) {
                return 0;
            }
            
            int hourMargin = secondClock.HourDifference(firstClock.Hours);
            int minuteMargin = secondClock.MinuteDifference(firstClock.Minutes);

            if(!firstClock.IsBefore(secondClock)) {
                //Need to wraparound past midnight
                hourMargin += HoursInDay;
            }
            if (minuteMargin < 0) {
                hourMargin--;
                minuteMargin += MinutesInHour;
            }
            return (hourMargin * OneRevolution) + (minuteMargin * DegreesPerMinute);
        }
    }
}