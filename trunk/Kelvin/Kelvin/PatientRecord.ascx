<%@ Control Language="C#" AutoEventWireup="true" CodeFile="PatientRecord.ascx.cs"
    Inherits="Kelvin.PatientRecord" EnableTheming="true" %>
<table width="100%" cellpadding="0" cellspacing="0" border="0">
    <tr class="patient-banner-tr">
        <td colspan="2">
            <table width="100%">
                <tr>
                    <td>
                        <table>
                            <tr>
                                <td>
                                    <asp:Label ID="lblPatientNameText" runat="server" Text="Patient Name: " CssClass="patient-name-label"></asp:Label>
                                    <asp:Label ID="lblPatientName" runat="server" CssClass="patient-name"></asp:Label>
                                </td>
                                <td style="padding-left: 20px;">
                                    <asp:LinkButton ID="lbPatientInfo" runat="server" CssClass="patient-links">View Patient Info</asp:LinkButton>
                                </td>
                                <td>
                                    <asp:LinkButton ID="lbChangePatient" runat="server" CssClass="patient-links" Style="border: none;">Change Patient</asp:LinkButton>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                    <td>
                        <ul class="patient-info-ul">
                            <li>
                                <asp:Label ID="one" runat="server" Text="DOB : " CssClass="banner-label"></asp:Label>
                                <asp:Label ID="lbPatientDOB" runat="server" CssClass="banner-value"></asp:Label>
                            </li>
                            <li>
                                <asp:Label ID="Label7" runat="server" Text="Blood Group : " CssClass="banner-label"></asp:Label>
                                <asp:Label ID="lblPatientBloodGroup" runat="server" CssClass="banner-value"></asp:Label>
                            </li>
                            <li>
                                <asp:Label ID="lblPtSSn" runat="server" Text="SSN : " CssClass="banner-label"></asp:Label>
                                <asp:Label ID="lblPtSSnAns" runat="server" CssClass="banner-value"></asp:Label>
                            </li>
                            <li class="last">
                                <asp:Label ID="Label9" runat="server" Text="Medicare No : " CssClass="banner-label"></asp:Label>
                                <asp:Label ID="lblPatientMedicareNo" runat="server" CssClass="banner-value"></asp:Label>
                            </li>
                            <li class="last">
                                <asp:Label ID="Label11" runat="server" Text="Gender : " CssClass="banner-label">                                
                                </asp:Label>
                                <asp:Label ID="lblPatientConsultingDoctor" runat="server" CssClass="banner-value"></asp:Label>
                            </li>
                        </ul>
                    </td>
                </tr>
            </table>
        </td>
    </tr>
</table>
