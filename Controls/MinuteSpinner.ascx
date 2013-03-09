<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MinuteSpinner.ascx.cs" Inherits="SocrataClocks.Controls.MinuteSpinner" %>

<asp:TextBox ID="ValueHolder" runat="server"/>
<ajaxToolkit:NumericUpDownExtender ID="MinuteNUD" runat="server"
                                    TargetControlID="ValueHolder" 
                                    Width="50" />