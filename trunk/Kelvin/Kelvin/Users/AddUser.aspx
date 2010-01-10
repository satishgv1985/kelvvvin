<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddUser.aspx.cs" Inherits="Kelvin.Users.AddUser"
    Culture="auto" UICulture="auto" MasterPageFile="~/MasterPages/LoggedIn.Master"
    Theme="Green" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <asp:UpdatePanel ID="upDefault" runat="server">
        <ContentTemplate>
            <div style="height: 500px; padding-top: 50px; padding-left: 175px;">
                <div class="popup-container" style="width: 600px;">
                    <div class="popup-header-bg">
                        <table width="98%">
                            <tr>
                                <td>
                                    Add User&nbsp;
                                </td>
                                <td align="right" valign="top">
                                    <asp:Button ID="Button1" runat="server" SkinID="popup-close-but" Visible="False" />
                                </td>
                            </tr>
                        </table>
                    </div>
                    <div class="popup-content">
                        <table cellpadding="4" cellspacing="0" border="0" width="100%">
                            <tr>
                                <td style="font: red;" colspan="2">
                                    <asp:Label ID="lblStatus" runat="server" ForeColor="Red"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td width="35%">
                                    <strong>
                                        <asp:Label ID="lblUserFName" runat="server" Text="FirstName: "></asp:Label>
                                    </strong>
                                </td>
                                <td width="65%">
                                    <asp:TextBox ID="txtUserFName" runat="server" Width="150px"></asp:TextBox><span style="color:Red">*</span>
                                    <asp:RequiredFieldValidator ID="rfvUserFName" runat="server" ControlToValidate="txtUserFName"></asp:RequiredFieldValidator>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <strong>
                                        <asp:Label ID="lblUserLName" runat="server" Text="LastName: "></asp:Label>
                                    </strong>
                                </td>
                                <td>
                                    <asp:TextBox ID="txtUserLName" runat="server" Width="150px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <strong>
                                        <asp:Label ID="lblUserName" runat="server" Text="UserName: "></asp:Label>
                                    </strong>
                                </td>
                                <td>
                                    <asp:TextBox ID="txtUserName" runat="server" Width="150px"></asp:TextBox><span style="color:Red">*</span>
                                    <asp:RequiredFieldValidator ID="rfvUserName" runat="server" ControlToValidate="txtUserName"></asp:RequiredFieldValidator>
                                    <cc1:AutoCompleteExtender ID="aceUserName" runat="server" ServicePath="~/UserNameSearch.asmx"
                                        ServiceMethod="UserCreationSearch" TargetControlID="txtUserName" CompletionListElementID="pnlUserName"
                                        MinimumPrefixLength="0" DelimiterCharacters="" Enabled="True">
                                    </cc1:AutoCompleteExtender>
                                    <asp:Panel ID="pnlUserName" runat="server" Style="z-index: 1000;" Width="150px">
                                    </asp:Panel>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <strong>
                                        <asp:Label ID="lblPassword" runat="server" Text="Password: "></asp:Label>
                                    </strong>
                                </td>
                                <td>
                                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" Width="150px" onpaste="return false"
                                        oncut="return false"></asp:TextBox><span style="color:Red">*</span>
                                    <asp:RequiredFieldValidator ID="rfvPassword" runat="server" ControlToValidate="txtPassword"
                                        onpaste="return false" oncut="return false"></asp:RequiredFieldValidator>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <strong>
                                        <asp:Label ID="lblReEnterPassword" runat="server" Text="Re-Enter Password: "></asp:Label>
                                    </strong>
                                </td>
                                <td>
                                    <asp:TextBox ID="txtReeneterPassword" runat="server" TextMode="Password" Width="150px"></asp:TextBox><span style="color:Red">*</span>
                                    <asp:RequiredFieldValidator ID="rfvReEnterPassword" runat="server" ControlToValidate="txtReeneterPassword">*</asp:RequiredFieldValidator>
                                    <asp:CompareValidator ID="cmpPassword" runat="server" ControlToValidate="txtReeneterPassword"
                                        ControlToCompare="txtPassword">*Enter Same Password</asp:CompareValidator>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <strong>
                                        <asp:Label ID="lblEmail" runat="server" Text="Email: "></asp:Label>
                                    </strong>
                                </td>
                                <td>
                                    <asp:TextBox ID="txtEmail" runat="server" Width="150px"></asp:TextBox><span style="color:Red">*</span>
                                    <asp:RequiredFieldValidator ID="rfvEmail" runat="server" ControlToValidate="txtEmail">
                                    </asp:RequiredFieldValidator>
                                    <asp:RegularExpressionValidator ID="revEmail" runat="server" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                                        ControlToValidate="txtEmail">*Enter Valid Email Address
                                    </asp:RegularExpressionValidator>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <strong>
                                        <asp:Label ID="lblGroup" runat="server" Text="Group: "></asp:Label>
                                    </strong>
                                </td>
                                <td>
                                    <asp:DropDownList ID="ddlGroups" runat="server" Width="150px" Style="border-color:#D3EDB0;">
                                    </asp:DropDownList><span style="color:Red">*</span>
                                </td>
                            </tr>
                            <tr>
                                <td colspan="2">
                                    <table border="0" cellpadding="5" cellspacing="0" width="100%">
                                        <tr>
                                            <td width="80%" align="right">
                                                <asp:Button ID="btnSubmit" Text="Save" runat="server" OnClick="btnSubmit_Click" />
                                            </td>
                                            <td width="20%">
                                                <asp:Button ID="btnCancel" Text="Reset" runat="server" OnClick="btnCancel_Click"
                                                    CausesValidation="False" />
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                            <tr>
                                <td colspan="2">
                                    <asp:Label ID="lblErrorMessage" runat="server" Text="* Indicates Mandatory Fields"
                                        Style="color: red"></asp:Label>
                                </td>
                            </tr>
                        </table>
                    </div>
                </div>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
