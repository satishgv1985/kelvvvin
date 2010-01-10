<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AdminDashBoard.aspx.cs" Inherits="Kelvin.AdminDashBoard"
    MasterPageFile="~/MasterPages/LoggedIn.Master" Theme="Green" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <span>&nbsp;&nbsp;&nbsp;You are here : <b>Home ></b> Admin</span>
    <br />
    <br />
    <div class="content-area">
        <table width="70%" cellpadding="0" cellspacing="0" style="border: 1px solid #8DC63F;
            height: 200px;">
            <tr>
                <td style="background-color: #8DC63F; border-bottom: 1px solid black; height: 25px;"
                    colspan="2">
                    <span style="font-weight: bold; font-size: 12px; color: #58595B">DashBoard</span>
                </td>
            </tr>
            <tr>
                <td style="text-align: right; background-color: #D3EDB0; padding-right:30px;">
                    <asp:LinkButton ID="lbtnAddUsers" ForeColor="#58595B" runat="Server" OnClick="lbtnAddUsers_Click"
                        CssClass="imageButton">
                        <asp:ImageButton ID="ibtnAddUsers" runat="Server" ImageUrl="~/images/dashboards/diagnostics.png"
                            OnClick="lbtnAddUsers_Click"></asp:ImageButton><br />
                        Add Users</asp:LinkButton>
                </td>
                <td style="text-align: left; background-color: #D3EDB0; padding-left:30px;">
                    <asp:LinkButton ID="lbtnAddGroups" ForeColor="#58595B" runat="Server" OnClick="lbtnAddGroups_Click"
                        CssClass="imageButton">
                        <asp:ImageButton ID="ibtnAddGroups" runat="Server" ImageUrl="~/images/dashboards/diagnostics.png"
                            OnClick="lbtnAddGroups_Click"></asp:ImageButton><br />
                        Add Groups</asp:LinkButton>
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
