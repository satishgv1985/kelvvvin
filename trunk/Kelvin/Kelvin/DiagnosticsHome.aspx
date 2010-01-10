<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DiagnosticsHome.aspx.cs"
    Inherits="Kelvin.DiagnosticsHome" MasterPageFile="~/MasterPages/LoggedIn.Master" %>

<%@ Register Src="~/PatientRecord.ascx" TagName="patientRecord" TagPrefix="uc" %>
<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc:patientRecord ID="patientRecordControl" runat="server" />
    <p class="info">
        <strong>Welcome to Diagnostics Centre!</strong><br />
        Select the diagnostics from the <strong>Tabs</strong> above, or <strong>search</strong>
        diagnostic test procedures based on <strong>diagnostics key words</strong> or <strong>
            ICD 9</strong> code<br />
        You can also browse diagnostics by <strong>alphabet</strong>.
        <br />
        please contact help desk on <strong>020 7216 6581</strong> for further assistance</p>
    <div class="Search-box">
        <table style="margin: 0 auto;">
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Key word" SkinID="Labels"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="ICD 9 Code" SkinID="Labels"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="Search" />
                </td>
            </tr>
        </table>
    </div>
    <div class="Search-box-bottom">
        <table style="margin: 0 auto;">
            <tr>
                <td style="width: 15%;">
                    <asp:Label ID="Label3" runat="server" Text="Browse by Alphabet: " Font-Bold="true"></asp:Label>
                </td>
                <td>
                    <ul class="alphabet">
                        <li>
                            <asp:LinkButton ID="LinkButton2" runat="server">A</asp:LinkButton></li>
                        <li>
                            <asp:LinkButton ID="LinkButton1" runat="server">B</asp:LinkButton></li>
                        <li>
                            <asp:LinkButton ID="LinkButton27" runat="server">C</asp:LinkButton></li>
                        <li>
                            <asp:LinkButton ID="LinkButton26" runat="server">D</asp:LinkButton></li>
                        <li>
                            <asp:LinkButton ID="LinkButton25" runat="server">E</asp:LinkButton></li>
                        <li>
                            <asp:LinkButton ID="LinkButton24" runat="server">F</asp:LinkButton></li>
                        <li>
                            <asp:LinkButton ID="LinkButton23" runat="server">G</asp:LinkButton></li>
                        <li>
                            <asp:LinkButton ID="LinkButton22" runat="server">H</asp:LinkButton></li>
                        <li>
                            <asp:LinkButton ID="LinkButton21" runat="server">I</asp:LinkButton></li>
                        <li>
                            <asp:LinkButton ID="LinkButton20" runat="server">J</asp:LinkButton></li>
                        <li>
                            <asp:LinkButton ID="LinkButton19" runat="server">K</asp:LinkButton></li>
                        <li>
                            <asp:LinkButton ID="LinkButton18" runat="server">L</asp:LinkButton></li>
                        <li>
                            <asp:LinkButton ID="LinkButton17" runat="server">M</asp:LinkButton></li>
                        <li>
                            <asp:LinkButton ID="LinkButton16" runat="server">N</asp:LinkButton></li>
                        <li>
                            <asp:LinkButton ID="LinkButton15" runat="server">O</asp:LinkButton></li>
                        <li>
                            <asp:LinkButton ID="LinkButton14" runat="server">P</asp:LinkButton></li>
                        <li>
                            <asp:LinkButton ID="LinkButton13" runat="server">Q</asp:LinkButton></li>
                        <li>
                            <asp:LinkButton ID="LinkButton12" runat="server">R</asp:LinkButton></li>
                        <li>
                            <asp:LinkButton ID="LinkButton11" runat="server">S</asp:LinkButton></li>
                        <li>
                            <asp:LinkButton ID="LinkButton10" runat="server">T</asp:LinkButton></li>
                        <li>
                            <asp:LinkButton ID="LinkButton9" runat="server">U</asp:LinkButton></li>
                        <li>
                            <asp:LinkButton ID="LinkButton8" runat="server">V</asp:LinkButton></li>
                        <li>
                            <asp:LinkButton ID="LinkButton7" runat="server">W</asp:LinkButton></li>
                        <li>
                            <asp:LinkButton ID="LinkButton6" runat="server">X</asp:LinkButton></li>
                        <li>
                            <asp:LinkButton ID="LinkButton5" runat="server">Y</asp:LinkButton></li>
                        <li class="last">
                            <asp:LinkButton ID="LinkButton4" runat="server">Z</asp:LinkButton></li>
                    </ul>
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
