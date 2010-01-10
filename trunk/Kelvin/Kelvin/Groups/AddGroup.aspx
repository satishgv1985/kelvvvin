<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddGroup.aspx.cs" Inherits="Kelvin.Groups.AddGroup"
    MasterPageFile="~/MasterPages/LoggedIn.Master" Theme="Green" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <asp:UpdatePanel ID="upDefault" runat="server">
        <ContentTemplate>
            <div style="height: 200px; padding-top: 50px; padding-left: 325px;">
                <div class="popup-container">
                    <div class="popup-header-bg">
                        <table width="98%">
                            <tr>
                                <td>
                                    Add Group&nbsp;
                                </td>
                                <td align="right" valign="top">
                                    <asp:Button ID="Button1" runat="server" Text="" SkinID="popup-close-but" Visible="false" />
                                </td>
                            </tr>
                        </table>
                    </div>
                    <div class="popup-content">
                        <table cellpadding="4" cellspacing="0" border="0" width="100%">
                            <tr>
                                <td width="35%">
                                    <strong>
                                        <asp:Label ID="lblGroupName" runat="server" Text="Group Name: "></asp:Label>
                                    </strong>
                                </td>
                                <td width="65%">
                                    <asp:TextBox ID="txtGroupName" runat="server" Width="150px"></asp:TextBox><span style="color:Red">*</span>
                                    <asp:RequiredFieldValidator ID="rfvGroupName" runat="server" ControlToValidate="txtGroupName">
                                    </asp:RequiredFieldValidator>
                                    <cc1:AutoCompleteExtender ID="aceGroupName" runat="server" ServicePath="~/UserNameSearch.asmx"
                                        ServiceMethod="GroupCreationSearch" TargetControlID="txtGroupName" CompletionListElementID="pnlGroupName"
                                        MinimumPrefixLength="0" DelimiterCharacters="" Enabled="True">
                                    </cc1:AutoCompleteExtender>
                                    <asp:Panel ID="pnlGroupName" runat="server" Style="z-index: 1000;" Width="150px">
                                    </asp:Panel>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <strong>
                                        <asp:Label ID="lblGroupDescription" runat="server" Text="Group Description: "></asp:Label>
                                    </strong>
                                </td>
                                <td>
                                    <asp:TextBox ID="txtGroupDescription" runat="server" Width="150px"></asp:TextBox><span style="color:Red">*</span>
                                    <asp:RequiredFieldValidator ID="rfvGroupDescription" runat="server" ControlToValidate="txtGroupDescription">
                                    </asp:RequiredFieldValidator>
                                </td>
                            </tr>
                            <tr>
                            <td>
                            Permissions:
                            </td>
                            </tr>
                            <tr>
                                <td>
                                    <strong>
                                        <asp:Label ID="lblCanView" runat="server" Text="View: "></asp:Label>
                                    </strong>
                                </td>
                                <td>
                                    <asp:CheckBox ID="chkCanView" runat="server" Width="150px"></asp:CheckBox>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <strong>
                                        <asp:Label ID="lblCanAdd" runat="server" Text="Add: "></asp:Label>
                                    </strong>
                                </td>
                                <td>
                                    <asp:CheckBox ID="chkCanAdd" runat="server" Width="150px"></asp:CheckBox>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <strong>
                                        <asp:Label ID="lblCanUpdate" runat="server" Text="Update: "></asp:Label>
                                    </strong>
                                </td>
                                <td>
                                    <asp:CheckBox ID="chkUpDate" runat="server" Width="150px"></asp:CheckBox>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <strong>
                                        <asp:Label ID="lblCanDelete" runat="server" Text="Delete: "></asp:Label>
                                    </strong>
                                </td>
                                <td>
                                    <asp:CheckBox ID="chkCanDelete" runat="server" Width="150px"></asp:CheckBox>
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
                        </table>
                    </div>
                </div>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
