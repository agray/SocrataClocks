<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="SocrataClocks.Default" %>

<%@ Register Src="Controls/Clock.ascx" TagName="Clock" TagPrefix="Phoenix" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <asp:ScriptManager runat="server"/>
    <h2>Socrata Clocks</h2>

    <p>Set both clocks to desired time.</p>
    
    <h3>First Clock</h3>
    <Phoenix:Clock ID="FirstClock" runat="server" />
    <h3>Second Clock</h3>
    <Phoenix:Clock ID="SecondClock" runat="server" />
    <br/><br/>
    <asp:Button ID="Calculate" runat="server" Text="Calculate Minute Hand Degrees" onclick="CalculateClick" />
    <br/><br/>
    <asp:Label ID="NumDegrees" runat="server"/>
</asp:Content>
