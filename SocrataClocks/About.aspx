<%@ Page Title="About Us" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="About.aspx.cs" Inherits="SocrataClocks.About" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>About</h2>
    <div align="center">
        Solution developed by:<br/><br/>
        Andrew Gray.<br/>
        Phoenix Consulting. <br/> 
        Copyright 2013.
    </div>
    <br />
    <div align="center">
        <asp:Image ImageUrl="phoenix.gif" runat="server"/>
    </div>
</asp:Content>
