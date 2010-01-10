<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PatientDashBoard.aspx.cs"
    Inherits="Kelvin.PatientDashBoard" MasterPageFile="~/MasterPages/LoggedIn.Master"
    Theme="Green" %>

<%@ Register Src="~/PatientRecord.ascx" TagName="patientRecord" TagPrefix="uc" %>
<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc:patientRecord ID="patientRecordControl" runat="server" />
    <br />
    <span>&nbsp;&nbsp;&nbsp;You are here : <b>Home > View Patients ></b> Patient</span>
    <br />
    <br />
    <div class="dashboard-container">
        <table width="70%" cellpadding="0" cellspacing="0" style="border-bottom: 1px solid #8DC63F;
            height: 350px; border-left: 1px solid #8DC63F; border-right: 1px solid #8DC63F;">
            <tr>
                <td colspan="4" width="100%" height="25px">
                    <table border="0" width="100%" cellpadding="0" cellspacing="0" height="25px">
                        <tr>
                            
                            <td class="dashboard-header-body" width="100%">
                                DashBoard
                            </td>
                            
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td style="text-align: center; background-color: #D3EDB0;" width="25%">
                    <asp:LinkButton ID="LinkButton2" runat="Server" CssClass="imageButton">
                        <asp:ImageButton ID="ImageButton2" runat="Server" ImageUrl="~/images/dashboards/viewpatientdetails.png">
                        </asp:ImageButton><br />
                        View Patient Details</asp:LinkButton>
                </td>
                <td style="text-align: center; background-color: #D3EDB0;" width="25%">
                    <asp:LinkButton ID="LinkButton3" runat="Server" CssClass="imageButton">
                        <asp:ImageButton ID="ImageButton3" runat="Server" ImageUrl="~/images/dashboards/viewconsultationhistory.png">
                        </asp:ImageButton><br />
                        Consultation History</asp:LinkButton>
                </td>
                <td style="text-align: center; background-color: #D3EDB0;" width="25%">
                    <asp:LinkButton ID="LinkButton4" runat="Server" CssClass="imageButton">
                        <asp:ImageButton ID="ImageButton4" runat="Server" ImageUrl="~/images/dashboards/viewaddprescriptions.png">
                        </asp:ImageButton><br />
                        View/Add Prescriptions</asp:LinkButton>
                </td>
                <td style="text-align: center; background-color: #D3EDB0;" width="25%">
                    <asp:LinkButton ID="lbtnDiagonistic" runat="Server" OnClick="lbtnDiagonistic_Click"
                        CssClass="imageButton">
                        <asp:ImageButton ID="ibtnDiagonistic" runat="Server" ImageUrl="~/images/dashboards/viewadddiagnostics.png"
                            OnClick="ibtnDiagonistic_Click"></asp:ImageButton><br />
                        View/Add Diagnostics</asp:LinkButton>
                </td>
            </tr>
            <tr>
                <td style="text-align: center; background-color: #D3EDB0;" width="25%">
                    <asp:LinkButton ID="LinkButton5" runat="Server" CssClass="imageButton">
                        <asp:ImageButton ID="ImageButton5" runat="Server" ImageUrl="~/images/dashboards/viewdrughistory.png">
                        </asp:ImageButton><br />
                        View Drug History</asp:LinkButton>
                </td>
                <td style="text-align: center; background-color: #D3EDB0;" width="25%">
                    <asp:LinkButton ID="LinkButton6" runat="Server" CssClass="imageButton">
                        <asp:ImageButton ID="ImageButton6" runat="Server" ImageUrl="~/images/dashboards/pasttreatmentdetails.png">
                        </asp:ImageButton><br />
                        Past Treatment Details</asp:LinkButton>
                </td>
                <td style="text-align: center; background-color: #D3EDB0;" width="25%">
                    <asp:LinkButton ID="LinkButton7" runat="Server" CssClass="imageButton">
                        <asp:ImageButton ID="ImageButton7" runat="Server" ImageUrl="~/images/dashboards/viewallergies.png">
                        </asp:ImageButton><br />
                        View Allergies</asp:LinkButton>
                </td>
                <td style="text-align: center; background-color: #D3EDB0;" width="25%">
                    <asp:LinkButton ID="LinkButton8" runat="Server" CssClass="imageButton">
                        <asp:ImageButton ID="ImageButton8" runat="Server" ImageUrl="~/images/dashboards/insurancedetails.png">
                        </asp:ImageButton><br />
                        Insurance Details</asp:LinkButton>
                </td>
            </tr>
        </table>
    </div>
    <%--Home > Facility Home > Patient Records
    <br />
    <br />
    Patient Dash Board<br />
    <asp:HyperLink ID="hlDiagnosticsHome" runat="server" Text="View/Add Diagnostics" NavigateUrl="~/Default.aspx"></asp:HyperLink>
--%>
</asp:Content>
