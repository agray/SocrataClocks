<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AMPMSpinner.ascx.cs" Inherits="SocrataClocks.Controls.AMPMSpinner" %>

<asp:TextBox ID="ValueHolder" runat="server"/>
<ajaxToolkit:NumericUpDownExtender ID="AMPMNUD" runat="server"
                                   TargetControlID="ValueHolder" 
                                   Width="50" />