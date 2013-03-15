using System;
using System.Web.UI;

namespace SocrataClocks.Controls {
    public partial class AMPMSpinner : UserControl {
        protected void Page_Init(object sender, EventArgs e) {
            AMPMNUD.RefValues = "AM;PM";
        }
    }
}