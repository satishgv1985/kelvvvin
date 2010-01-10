<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FacilityHome.aspx.cs" Inherits="Kelvin.FacilityHome"
    MasterPageFile="~/MasterPages/LoggedIn.Master" %>

<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <span>&nbsp;&nbsp;&nbsp;You are here : <b>Home > </b>Facility Home</span>
    <br />
    <br />
    <div class="dashboard-container">
        <table width="70%" cellpadding="0" cellspacing="0" style="border-bottom: 1px solid #8DC63F;
            height: 200px; border-left: 1px solid #8DC63F; border-right: 1px solid #8DC63F;">
            <tr>
                <td colspan="4" width="100%" height="25px">
                    <table border="0" width="100%" cellpadding="0" cellspacing="0" height="25px">
                        <tr>
                            <%--<td class="dashboard-header-left" width="2%">
                                &nbsp;
                            </td>--%>
                            <td class="dashboard-header-body" width="100%">
                                DashBoard
                            </td>
                            <%--<td class="dashboard-header-right" width="2%">
                                &nbsp;
                            </td>--%>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td style="text-align: center; background-color: #D3EDB0;" width="25%">
                    <asp:LinkButton ID="lbtnAddnePatients" ForeColor="#58595B" runat="Server" CssClass="imageButton"
                        OnClick="lbtnAddnePatients_Click">
                        <asp:ImageButton ID="ibtnAddnePatients" runat="Server" ImageUrl="~/images/dashboards/addnewpatient.png"
                            OnClick="lbtnAddnePatients_Click"></asp:ImageButton><br />
                        Add New Patients</asp:LinkButton>
                </td>
                <td style="text-align: center; background-color: #D3EDB0;" width="25%">
                    <asp:LinkButton ID="lbtnBrowsePAtientRecords" ForeColor="#58595B" runat="Server"
                        OnClick="BrowsePatientRecords_Click" CssClass="imageButton">
                        <asp:ImageButton ID="ibtnBrowsePAtientRecords" runat="Server" ImageUrl="~/images/dashboards/browse-patients.png"
                            OnClick="BrowsePatientRecords_Click"></asp:ImageButton><br />
                        View Patients</asp:LinkButton>
                </td>
                <td style="text-align: center; background-color: #D3EDB0;" width="25%">
                    <asp:LinkButton ID="lbtnDiagonistics" ForeColor="#58595B" runat="Server" CssClass="imageButton">
                        <asp:ImageButton ID="ibtnDiagonistics" runat="Server" ImageUrl="~/images/dashboards/diagnostics.png">
                        </asp:ImageButton><br />
                        Diagonostics</asp:LinkButton>
                </td>
                <td style="text-align: center; background-color: #D3EDB0;" width="25%">
                    <asp:LinkButton ID="lbtnAdmin" ForeColor="#58595B" runat="Server" CssClass="imageButton"
                        OnClick="lbtnAdmin_Click">
                        <asp:ImageButton ID="ibtnAdmin" runat="Server" ImageUrl="~/images/dashboards/admin.png"
                            OnClick="ibtnAdmin_Click"></asp:ImageButton><br />
                        Admin</asp:LinkButton>
                </td>
            </tr>
        </table>
        <%-- <div class="popup-container">
        <div class="popup-header-bg">
            <table width="98%">
                <tr>
                    <td>
                        Faculty Home&nbsp;
                    </td>
                    <td align="right" valign="top">
                    </td>
                </tr>
            </table>
        </div>
        <div class="popup-content">
            <table>
                <tr>
                    <td style="text-align: center">
                        <asp:LinkButton ID="lbBrowsePatientRecords" ForeColor="#58595B" runat="Server" OnClick="BrowsePatientRecords_Click"
                            CssClass="imageButton">
                            <asp:ImageButton ID="lbBrowsePatientRecordsButton" runat="Server" ImageUrl="~/images/dashboards/browse-patients.png"
                                OnClick="BrowsePatientRecords_Click"></asp:ImageButton><br />
                            Browse Patient Records</asp:LinkButton>
                    </td>
                </tr>
            </table>
        </div>
    </div>--%>
        <%--<asp:HyperLink ID="hlFacilityHome" runat="server" Text="Browse Patient Records" NavigateUrl="~/PatientDashBoard.aspx"></asp:HyperLink>--%>
    </div>
</asp:Content>
