<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Clock.ascx.cs" Inherits="SocrataClocks.Controls.Clock" %>

<%@ Register Src="HourSpinner.ascx" TagName="Hours" TagPrefix="Phoenix" %>
<%@ Register Src="MinuteSpinner.ascx" TagName="Minutes" TagPrefix="Phoenix" %>
<%@ Register Src="AMPMSpinner.ascx" TagName="AMPM" TagPrefix="Phoenix" %>

<div>
    <Phoenix:Hours ID="HourSpinner" runat="server" />
    <Phoenix:Minutes ID="MinuteSpinner" runat="server" />
    <Phoenix:AMPM ID="AMPMSpinner" runat="server" />
</div>