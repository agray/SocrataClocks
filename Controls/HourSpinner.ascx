<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="HourSpinner.ascx.cs" Inherits="SocrataClocks.Controls.HourSpinner" %>

<asp:TextBox ID="ValueHolder" runat="server"/>
<ajaxToolkit:NumericUpDownExtender ID="HourNUD" runat="server"
                                       TargetControlID="ValueHolder" 
                                       Width="50"
                                       Minimum="1"
                                       Maximum="12"
                                       Step="1" />

