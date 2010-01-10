<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Kelvin.Login"
    Culture="auto" meta:resourcekey="PageResource1" UICulture="auto" Theme="Green" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <link href="App_Themes/Green/Green.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div style="width: 800px; height: 200px; padding-top: 50px; padding-left: 325px;">
        <%--login starts--%>
        <div class="popup-container">
            <div class="popup-header-bg">
                <table width="98%">
                    <tr>
                        <td>
                            Login&nbsp;
                        </td>
                        <td align="right" valign="top">
                            <asp:Button ID="Button1" runat="server" Text="" SkinID="popup-close-but" Visible="false" />
                        </td>
                    </tr>
                </table>
            </div>
            <div class="popup-content">
                <table style="margin: 0 auto;">
                    <tr>
                        <td align="right">
                            <asp:Label ID="Label1" runat="server" Text="User Name" SkinID="Labels"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="tbLoginName" runat="server" Width="150px"></asp:TextBox>
                            <asp:RequiredFieldValidator ControlToValidate="tbLoginName" SetFocusOnError="True"
                                ID="rfvLoginName" Text="* Required" runat="server" meta:resourcekey="rfvLoginNameResource1"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td align="right">
                            <asp:Label ID="Label2" runat="server" Text="Password" SkinID="Labels"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="tbPassword" runat="server" TextMode="Password" Width="150px" onpaste="return false"
                                oncut="return false"></asp:TextBox>
                            <asp:RequiredFieldValidator ControlToValidate="tbPassword" SetFocusOnError="True"
                                ID="rfvPassword" Text="* Required" runat="server" meta:resourcekey="rfvPasswordResource1"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>
                        </td>
                        <td align="left">
                            <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                        </td>
                        <td>
                            <asp:LinkButton ID="LinkButton2" runat="server" CssClass="fontgotpassword">Forgot Password?</asp:LinkButton>
                        </td>
                    </tr>
                </table>
                <table style="margin: 0 auto;">
                    <tr>
                        <td colspan="2">
                            <%--                            <asp:Label ID="lblUserLogout" runat="server" SkinId="Labels" CssClass="Labels" ForeColor="Red" meta:resourcekey="lblUserLogoutResource1"></asp:Label>--%>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <asp:Label ID="lblInvalidError" runat="server" SkinID="Labels" CssClass="Labels"
                                ForeColor="Red" meta:resourcekey="lblInvalidErrorResource1"></asp:Label>
                        </td>
                    </tr>
                </table>
            </div>
        </div>
        <%--End login--%>
    </div>
    <!-- ------------------------- --->
    </form>
</body>
</html>
