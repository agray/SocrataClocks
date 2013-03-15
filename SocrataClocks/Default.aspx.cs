using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using MinuteDegreeCalculator;

namespace SocrataClocks {
    public partial class Default : Page {
        private const string HourSpinner = "HourSpinner";
        private const string MinuteSpinner = "MinuteSpinner";
        private const string AMPMSpinner = "AMPMSpinner";
        private const string ValueHolder = "ValueHolder";

        protected void CalculateClick(object sender, EventArgs e) {
            SocrataClock firstClock = BuildSocrataClock(FirstClock);
            SocrataClock secondClock = BuildSocrataClock(SecondClock);

            int degrees = DegreeCalculator.CalculateDegrees(firstClock, secondClock);
            NumDegrees.Text = "The minute hand of an analog clock has to move " +  degrees + " degrees.";
        }

        private SocrataClock BuildSocrataClock(UserControl clock) {
            UserControl hourSpinner = GetUserControl(clock, HourSpinner);
            UserControl minuteSpinner = GetUserControl(clock, MinuteSpinner);
            UserControl ampmSpinner = GetUserControl(clock, AMPMSpinner);
            int hour = GetTextAsInt(hourSpinner);
            int minute = GetTextAsInt(minuteSpinner);
            string ampm = GetText(ampmSpinner);

            return new SocrataClock(hour, minute, ampm);
        }

        private UserControl GetUserControl(UserControl control, string controlToGet) {
            return (UserControl)control.FindControl(controlToGet);
        }

        private WebControl GetWebControl(UserControl control, string controlToGet) {
            return (WebControl)control.FindControl(controlToGet);
        }

        private string GetText(UserControl control) {
            return ((TextBox)(GetWebControl(control, ValueHolder))).Text;
        }

        private int GetTextAsInt(UserControl control) {
            return int.Parse(GetText(control));
        }
    }
}