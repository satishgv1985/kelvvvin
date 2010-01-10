<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SelectPatient.aspx.cs" Inherits="Kelvin.Patients.SelectPatient"
    MasterPageFile="~/MasterPages/LoggedIn.Master" Theme="Green" StylesheetTheme="Green" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <br />
    <span>&nbsp;&nbsp;&nbsp;<b>Home > Facility Home ></b> Select Patient</span>
    <br />
    <br />
    <asp:UpdatePanel ID="upDefault" runat="server">
        <ContentTemplate>
            <div style="height: 600px; padding-top: 50px;" align="center">
                <div class="popup-container" style="width: 90%;">
                    <div class="popup-header-bg">
                        <table width="98%">
                            <tr>
                                <td align="left">
                                    Select Patient&nbsp;
                                </td>
                                <td align="right" valign="top">
                                    <asp:Button ID="Button1" runat="server" SkinID="popup-close-but" Visible="False" />
                                </td>
                            </tr>
                        </table>
                    </div>
                    <div class="popup-content">
                        <table cellpadding="0" cellspacing="0" border="0" style="" width="100%">
                            <tr>
                                <td align="left" width="15%">
                                    Search By Patient :
                                </td>
                                <td align="left" width="15%">
                                    <asp:TextBox runat="server" ID="tbSearchPatientText">
                                    </asp:TextBox>
                                    <cc1:AutoCompleteExtender ID="acePatientList" runat="server" ServicePath="~/UserNameSearch.asmx"
                                        ServiceMethod="PatientDetailsSearch" TargetControlID="tbSearchPatientText" CompletionListElementID="pnlPatientList"
                                        MinimumPrefixLength="1" DelimiterCharacters="" Enabled="True">
                                    </cc1:AutoCompleteExtender>
                                    <asp:Panel ID="pnlPatientList" runat="server" Style="z-index: 1000;" Width="150px">
                                    </asp:Panel>
                                </td>
                                <td align="left" width="10%">
                                    Or By SSN :
                                </td>
                                <td align="left" width="15%">
                                    <asp:TextBox runat="server" ID="txtSSn">
                                    </asp:TextBox>
                                </td>
                                <td align="right">
                                    <asp:Button runat="server" ID="btnSearchPatient" Text="Search" OnClick="btnSearchPatient_Click"
                                        Style="cursor: hand;" />
                                </td>
                                <td align="left">
                                    <asp:Button runat="server" ID="btnShowAll" Text="Show All" OnClick="btnShowAll_Click"
                                        Style="cursor: hand;" />
                                </td>
                            </tr>
                            <tr>
                                <td colspan="6">
                                    <br />
                                </td>
                            </tr>
                            <tr>
                                <td colspan="6">
                                    <asp:GridView ID="gvSearchPatientResults" runat="server" AutoGenerateColumns="false"
                                        Width="100%" GridLines="Both" PagerSettings-Mode="NumericFirstLast" AllowPaging="true"
                                        OnRowDataBound="gvSearchPatientResults_RowDataBound" PageSize="5" PagerSettings-FirstPageText="<< First"
                                        PagerSettings-LastPageText="Last >>" OnPageIndexChanging="gvSearchPatientResults_PageIndexChanging">
                                        <EmptyDataTemplate>
                                            No Patients Found
                                        </EmptyDataTemplate>
                                        <Columns>
                                            <asp:BoundField DataField="PatientId" />
                                            <asp:HyperLinkField DataTextField="PatientFullName" HeaderText="Patient Name" NavigateUrl="~/PatientDashBoard.aspx"
                                                DataNavigateUrlFormatString="~/PatientDashBoard.aspx?pid={0}" DataNavigateUrlFields="PatientId"
                                                HeaderStyle-HorizontalAlign="Left" ItemStyle-ForeColor="#8DC63F" />
                                            <asp:BoundField DataField="SSN" HeaderText="SSN" HeaderStyle-HorizontalAlign="Left" />
                                            <asp:BoundField DataField="BloodGroup" HeaderText="Blood Group" HeaderStyle-HorizontalAlign="Left" />
                                            <asp:BoundField DataField="DOB" HeaderText="DOB" DataFormatString="{0:d}" HeaderStyle-HorizontalAlign="Left" />
                                            <asp:BoundField DataField="MedicareNumber" HeaderText="Medicare Number" HeaderStyle-HorizontalAlign="Left" />
                                            <%-- <asp:LinkButton ID="lbPatientId" Text='<%# Convert.ToString(Eval("PatientId")) %>'  runat="server"></asp:LinkButton>--%>
                                            <asp:HyperLinkField HeaderText="Visit History" Text="Visit History" NavigateUrl="#"
                                                HeaderStyle-HorizontalAlign="Left" ItemStyle-ForeColor="#8DC63F" />
                                            <asp:HyperLinkField HeaderText="Diagnostics Tests To be Submitted" NavigateUrl="#"
                                                HeaderStyle-HorizontalAlign="Left" Text="View Diagnostics" ItemStyle-ForeColor="#8DC63F" />
                                        </Columns>
                                        <HeaderStyle BackColor="#8DC63F" />
                                        <PagerStyle ForeColor="#8DC63F" BorderWidth="0" />
                                    </asp:GridView>
                                </td>
                            </tr>
                        </table>
                    </div>
                </div>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
