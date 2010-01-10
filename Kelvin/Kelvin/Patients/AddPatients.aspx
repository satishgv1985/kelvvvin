<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddPatients.aspx.cs" Inherits="Kelvin.Patients.AddPatients"
    MasterPageFile="~/MasterPages/LoggedIn.Master" Theme="Green" StylesheetTheme="Green" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <asp:UpdatePanel ID="upDefault" runat="server">
        <ContentTemplate>
            <div style="height: 500px; padding-top: 50px; padding-left: 175px;">
                <div class="popup-container" style="width: 700px;">
                    <div class="popup-header-bg">
                        <table width="98%">
                            <tr>
                                <td>
                                    Add Patient&nbsp;
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
                                        <asp:Label ID="lblPatientName" runat="server" Text="First Name: "></asp:Label>
                                    </strong>
                                </td>
                                <td width="65%">
                                    <asp:TextBox ID="txtPatientName" runat="server" Width="150px"></asp:TextBox><span
                                        style="color: Red">*</span>
                                   <%-- <asp:RequiredFieldValidator ID="rfvPatientName" runat="server" ControlToValidate="txtPatientName"></asp:RequiredFieldValidator>--%>
                                </td>
                            </tr>
                            <tr>
                                <td width="35%">
                                    <strong>
                                        <asp:Label ID="lblPatientLastName" runat="server" Text="Last Name: "></asp:Label>
                                    </strong>
                                </td>
                                <td width="65%">
                                    <asp:TextBox ID="txtPatientLastName" runat="server" Width="150px"></asp:TextBox><span
                                        style="color: Red">*</span>
                                    <%--<asp:RequiredFieldValidator ID="rfvPatientLastName" runat="server" ControlToValidate="txtPatientName"></asp:RequiredFieldValidator>--%>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <strong>
                                        <asp:Label ID="lblDob" runat="server" Text="DOB: "></asp:Label>
                                    </strong>
                                </td>
                                <td>
                                    <asp:TextBox ID="txtDOB" runat="server" Width="150px"></asp:TextBox>
                                    <cc1:MaskedEditExtender ID="meeDOB" runat="server" MaskType="Date" InputDirection="LeftToRight"
                                        TargetControlID="txtDOB" UserDateFormat="MonthDayYear" Mask="99/99/9999" PromptCharacter="_">
                                    </cc1:MaskedEditExtender>
                                    <asp:ImageButton ID="imgbtnDOB" runat="server" CausesValidation="false" ImageUrl="~/images/Calendar.png" />
                                    <cc1:CalendarExtender ID="ceDOB" runat="server" TargetControlID="txtDOB" PopupButtonID="imgbtnDOB">
                                    </cc1:CalendarExtender>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <strong>
                                        <asp:Label ID="lblSSN" runat="server" Text="SSN: "></asp:Label>
                                    </strong>
                                </td>
                                <td>
                                    <asp:TextBox ID="txtSSN" runat="server" Width="150px"></asp:TextBox><span style="color: Red">*</span>
                                    <%--<asp:RequiredFieldValidator ID="rfvSSN" runat="server" ControlToValidate="txtSSN">
                                    </asp:RequiredFieldValidator>--%>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <strong>
                                        <asp:Label ID="lblGender" runat="server" Text="Gender: "></asp:Label>
                                    </strong>
                                </td>
                                <td>
                                    <asp:RadioButtonList ID="rblGender" runat="server" Width="150px" RepeatDirection="Horizontal" Style="border-color:#D3EDB0;">
                                        <asp:ListItem Text="Male"></asp:ListItem>
                                        <asp:ListItem Text="Female"></asp:ListItem>
                                    </asp:RadioButtonList>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <strong>
                                        <asp:Label ID="lblContactNo" runat="server" Text="Contact No.: "></asp:Label>
                                    </strong>
                                </td>
                                <td>
                                    <asp:TextBox ID="txtContactNo" runat="server" Width="150px"></asp:TextBox>
                                    <%--<asp:RegularExpressionValidator ID="revContactNo" runat="server" ControlToValidate="txtContactNo"
                                        ValidationExpression="\(\d{3}\) \d{3}\-\d{4}" Display="Dynamic">*You must enter in the form of (999) 999-9999</asp:RegularExpressionValidator>
                                --%></td>
                            </tr>
                            <tr>
                                <td>
                                    <strong>
                                        <asp:Label ID="lblEmailId" runat="server" Text="Email Id: "></asp:Label>
                                    </strong>
                                </td>
                                <td>
                                    <asp:TextBox ID="txtEmailId" runat="server" Width="150px"></asp:TextBox><span style="color: Red">*</span>
                                    <%--<asp:RequiredFieldValidator ID="rfvEmail" runat="server" ControlToValidate="txtEmailId">
                                    </asp:RequiredFieldValidator>
                                    <asp:RegularExpressionValidator ID="revEmail" runat="server" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                                        ControlToValidate="txtEmailId">*Enter Valid Email Address
                                    </asp:RegularExpressionValidator>--%>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <strong>
                                        <asp:Label ID="lblAddress" runat="server" Text="Address: "></asp:Label>
                                    </strong>
                                </td>
                                <td>
                                    <asp:TextBox ID="txtAddress" runat="server" TextMode="MultiLine" Width="150px" Height="40px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <strong>
                                        <asp:Label ID="lblBloodGroup" runat="server" Text="Blood Group: "></asp:Label>
                                    </strong>
                                </td>
                                <td>
                                    <asp:DropDownList ID="ddlBloodGroup" runat="server" Width="150px" Style="border-color:#D3EDB0;">
                                        <asp:ListItem Text="A Positive" Selected="True"></asp:ListItem>
                                        <asp:ListItem Text="A Negative"></asp:ListItem>
                                        <asp:ListItem Text="A Unknown"></asp:ListItem>
                                        <asp:ListItem Text="B Positive"></asp:ListItem>
                                        <asp:ListItem Text="B Negative"></asp:ListItem>
                                        <asp:ListItem Text="B Unknown"></asp:ListItem>
                                        <asp:ListItem Text="AB Positive"></asp:ListItem>
                                        <asp:ListItem Text="AB Negative"></asp:ListItem>
                                        <asp:ListItem Text="AB Unknown"></asp:ListItem>
                                        <asp:ListItem Text="O Positive"></asp:ListItem>
                                        <asp:ListItem Text="O Negative"></asp:ListItem>
                                        <asp:ListItem Text="O Unknown"></asp:ListItem>
                                        <asp:ListItem Text="Unknown"></asp:ListItem>
                                    </asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <strong>
                                        <asp:Label ID="lblFacilityName" runat="server" Text="Facility: "></asp:Label>
                                    </strong>
                                </td>
                                <td>
                                    <asp:TextBox ID="txtFacilityName" runat="server" Width="150px"></asp:TextBox>
                                    <%--<asp:RequiredFieldValidator ID="rfvFacilityName" runat="server" ControlToValidate="txtFacilityName">*</asp:RequiredFieldValidator>--%>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <strong>
                                        <asp:Label ID="lblMedicareNumber" runat="server" Text="Medicare Number: "></asp:Label>
                                    </strong>
                                </td>
                                <td>
                                    <asp:TextBox ID="txtMedicareNumber" runat="server" Width="150px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr style="display:none;">
                                <td>
                                    <strong>
                                        <asp:Label ID="lblConsultingDoctor" runat="server" Text="Consulting Doctor: " Visible="false"></asp:Label>
                                    </strong>
                                </td>
                                <td>
                                    <asp:TextBox ID="txtConsultingDoctor" runat="server" Width="150px" Visible="false"
                                        Text="Albert"></asp:TextBox>
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
