<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPages/LoggedIn.Master"
    CodeFile="Default.aspx.cs" Inherits="Kelvin._Default" EnableEventValidation="true"
    Culture="auto" meta:resourcekey="PageResource1" UICulture="auto" Theme="Green"
    StylesheetTheme="Green" EnableTheming="true" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<%@ Register Src="~/PatientRecord.ascx" TagName="patientRecord" TagPrefix="uc" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <uc:patientRecord ID="patientRecordControl" runat="server" />
    <asp:UpdatePanel ID="upDefault" runat="server">
        <ContentTemplate>
            <div>
                <table cellpadding="0" cellspacing="0" width="100%" border="1">
                    <tr class="third-level-navigation-tr">
                        <td colspan="2">
                            <ul class="third-navigation-ul">
                                <li id="liOccupationalTherapy" runat="server">
                                    <asp:LinkButton ID="lbOccupationTherapy" CommandArgument="1" CssClass="tabsStyle"
                                        runat="server" Text="Occupational Therapy" OnCommand="lbTestMaster_Click"></asp:LinkButton></li>
                                <li id="liPhysicalTherapy" runat="server">
                                    <asp:LinkButton ID="lbPhysicalTherapy" CommandArgument="2" runat="server" Text="Physical Therapy"
                                        CssClass="tabsStyle" OnCommand="lbTestMaster_Click"></asp:LinkButton></li>
                                <li id="liMedicalImaging" runat="server">
                                    <asp:LinkButton ID="lbMedicalImaging" CommandArgument="3" runat="server" Text="Medical Imaging"
                                        CssClass="tabsStyle" OnCommand="lbTestMaster_Click"></asp:LinkButton></li>
                                <li id="liLabs" runat="server">
                                    <asp:LinkButton CommandArgument="4" ID="lbLabs" runat="server" Text="Labs" CssClass="tabsStyle"
                                        OnCommand="lbTestMaster_Click"></asp:LinkButton></li>
                            </ul>
                        </td>
                    </tr>
                    <tr>
                        <td width="15%" valign="top">
                            <table cellpadding="5" cellspacing="0" border="0">
                                <tr>
                                    <td class="left-menu-td" valign="top">
                                        <div class="menu-container-div">
                                            <div class="menu-container-white-div" >
                                                <asp:Repeater ID="innerRepeater" runat="server" OnItemCommand="innerRepeater_command">
                                                    <ItemTemplate>
                                                        <%--<asp:Button runat="server" ID="innerTabsContent" CommandName='<%# Eval("TestId") %>' Text='<%# Eval("TestName") %>' />--%>
                                                        <asp:Button ID="innerTabsContent" runat="server" CommandName='<%# Eval("TestId") %>'
                                                            Width="100%" Text='<%# Eval("TestName") %>' Style="cursor: hand; margin-top: 10px;
                                                            background: repeat-x #ffffff; color: #A4D165; border: 0px #ffffff"></asp:Button>
                                                    </ItemTemplate>
                                                    
                                                </asp:Repeater>
                                            </div>
                                        </div>
                                    </td>
                                    <%--<td class="main-content-td" valign="top">
                                        <div class="main-content-div">
                                            <div class="main-content-white-div">
                                            </div>
                                        </div>
                                    </td>--%>
                                </tr>
                            </table>
                        </td>
                        <td width="84%" valign="top">
                            <table width="100%" border="0" cellspacing="2" cellpadding="2">
                                <tr>
                                    <td style="width: 8%;">
                                        <asp:Label ID="lblIcdCode" runat="server" Text="ICD9 Code" meta:resourcekey="lblIcdCodeResource1"></asp:Label>
                                    </td>
                                    <td style="width: 24%;">
                                        <asp:TextBox ID="txtIcdCode" runat="server" meta:resourcekey="txtIcdCodeResource1"></asp:TextBox>
                                    </td>
                                    <td style="width: 8%;">
                                        <asp:Label ID="lblKeyWord" runat="server" Text="Test Procedure Name" meta:resourcekey="lblKeyWordResource1"></asp:Label>
                                    </td>
                                    <td style="width: 18%;">
                                        <asp:TextBox ID="txtKeyWord" runat="server" meta:resourcekey="txtKeyWordResource1"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click"
                                            Style="cursor: hand;" meta:resourcekey="btnSearchResource1" />
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="5">
                                        Sort By Alphabet:
                                        <br />
                                        <asp:LinkButton ID="lbtnA" Font-Bold="true" runat="server" Text="A" OnClick="lbtnA_Click"
                                            meta:resourcekey="lbtnAResource1" Style="color: #8DC63F;"></asp:LinkButton>
                                        &nbsp;
                                        <asp:LinkButton ID="lbtnB" Font-Bold="true" runat="server" Text="B" OnClick="lbtnA_Click"
                                            meta:resourcekey="lbtnBResource1" Style="color: #8DC63F;"></asp:LinkButton>
                                        &nbsp;
                                        <asp:LinkButton ID="lbtnC" Font-Bold="true" runat="server" Text="C" OnClick="lbtnA_Click"
                                            meta:resourcekey="lbtnCResource1" Style="color: #8DC63F;"></asp:LinkButton>
                                        &nbsp;
                                        <asp:LinkButton ID="lbtnD" Font-Bold="true" runat="server" Text="D" OnClick="lbtnA_Click"
                                            meta:resourcekey="lbtnDResource1" Style="color: #8DC63F;"></asp:LinkButton>
                                        &nbsp;
                                        <asp:LinkButton ID="lbtnE" Font-Bold="true" runat="server" Text="E" OnClick="lbtnA_Click"
                                            meta:resourcekey="lbtnEResource1" Style="color: #8DC63F;"></asp:LinkButton>
                                        &nbsp;
                                        <asp:LinkButton ID="lbtnF" Font-Bold="true" runat="server" Text="F" OnClick="lbtnA_Click"
                                            meta:resourcekey="lbtnFResource1" Style="color: #8DC63F;"></asp:LinkButton>
                                        &nbsp;
                                        <asp:LinkButton ID="lbtG" Font-Bold="true" runat="server" Text="G" OnClick="lbtnA_Click"
                                            meta:resourcekey="lbtGResource1" Style="color: #8DC63F;"></asp:LinkButton>
                                        &nbsp;
                                        <asp:LinkButton ID="lbtnH" Font-Bold="true" runat="server" Text="H" OnClick="lbtnA_Click"
                                            meta:resourcekey="lbtnHResource1" Style="color: #8DC63F;"></asp:LinkButton>
                                        &nbsp;
                                        <asp:LinkButton ID="lbtnI" Font-Bold="true" runat="server" Text="I" OnClick="lbtnA_Click"
                                            meta:resourcekey="lbtnIResource1" Style="color: #8DC63F;"></asp:LinkButton>
                                        &nbsp;
                                        <asp:LinkButton ID="lbtnJ" Font-Bold="true" runat="server" Text="J" OnClick="lbtnA_Click"
                                            meta:resourcekey="lbtnJResource1" Style="color: #8DC63F;"></asp:LinkButton>
                                        &nbsp;
                                        <asp:LinkButton ID="lbtnK" Font-Bold="true" runat="server" Text="K" OnClick="lbtnA_Click"
                                            meta:resourcekey="lbtnKResource1" Style="color: #8DC63F;"></asp:LinkButton>
                                        &nbsp;
                                        <asp:LinkButton ID="lbtnL" Font-Bold="true" runat="server" Text="L" OnClick="lbtnA_Click"
                                            meta:resourcekey="lbtnLResource1" Style="color: #8DC63F;"></asp:LinkButton>
                                        &nbsp;
                                        <asp:LinkButton ID="lbtnM" Font-Bold="true" runat="server" Text="M" OnClick="lbtnA_Click"
                                            meta:resourcekey="lbtnMResource1" Style="color: #8DC63F;"></asp:LinkButton>
                                        &nbsp;
                                        <asp:LinkButton ID="lbtnN" Font-Bold="true" runat="server" Text="N" OnClick="lbtnA_Click"
                                            meta:resourcekey="lbtnNResource1" Style="color: #8DC63F;"></asp:LinkButton>
                                        &nbsp;
                                        <asp:LinkButton ID="lbtnO" Font-Bold="true" runat="server" Text="O" OnClick="lbtnA_Click"
                                            meta:resourcekey="lbtnOResource1" Style="color: #8DC63F;"></asp:LinkButton>
                                        &nbsp;
                                        <asp:LinkButton ID="lbtnP" runat="server" Text="P" OnClick="lbtnA_Click" meta:resourcekey="lbtnPResource1"
                                            Style="color: #8DC63F;"></asp:LinkButton>
                                        &nbsp;
                                        <asp:LinkButton ID="lbtnQ" runat="server" Text="Q" OnClick="lbtnA_Click" meta:resourcekey="lbtnQResource1"
                                            Style="color: #8DC63F;"></asp:LinkButton>
                                        &nbsp;
                                        <asp:LinkButton ID="lbtnR" Font-Bold="true" runat="server" Text="R" OnClick="lbtnA_Click"
                                            meta:resourcekey="lbtnRResource1" Style="color: #8DC63F;"></asp:LinkButton>
                                        &nbsp;
                                        <asp:LinkButton ID="lbtnS" Font-Bold="true" runat="server" Text="S" OnClick="lbtnA_Click"
                                            meta:resourcekey="lbtnSResource1" Style="color: #8DC63F;"></asp:LinkButton>
                                        &nbsp;
                                        <asp:LinkButton ID="lbtnT" Font-Bold="true" runat="server" Text="T" OnClick="lbtnA_Click"
                                            meta:resourcekey="lbtnTResource1" Style="color: #8DC63F;"></asp:LinkButton>
                                        &nbsp;
                                        <asp:LinkButton ID="lbtnU" Font-Bold="true" runat="server" Text="U" OnClick="lbtnA_Click"
                                            meta:resourcekey="lbtnUResource1" Style="color: #8DC63F;"></asp:LinkButton>
                                        &nbsp;
                                        <asp:LinkButton ID="lbtnV" Font-Bold="true" runat="server" Text="V" OnClick="lbtnA_Click"
                                            meta:resourcekey="lbtnVResource1" Style="color: #8DC63F;"></asp:LinkButton>
                                        &nbsp;
                                        <asp:LinkButton ID="lbtnW" Font-Bold="true" runat="server" Text="W" OnClick="lbtnA_Click"
                                            meta:resourcekey="lbtnWResource1" Style="color: #8DC63F;"></asp:LinkButton>
                                        &nbsp;
                                        <asp:LinkButton ID="lbtnX" Font-Bold="true" runat="server" Text="X" OnClick="lbtnA_Click"
                                            meta:resourcekey="lbtnXResource1" Style="color: #8DC63F;"></asp:LinkButton>
                                        &nbsp;
                                        <asp:LinkButton ID="lbtnY" Font-Bold="true" runat="server" Text="Y" OnClick="lbtnA_Click"
                                            meta:resourcekey="lbtnYResource1" Style="color: #8DC63F;"></asp:LinkButton>
                                        &nbsp;
                                        <asp:LinkButton ID="lbtnZ" Font-Bold="true" runat="server" Text="Z" OnClick="lbtnA_Click"
                                            meta:resourcekey="lbtnZResource1" Style="color: #8DC63F;"></asp:LinkButton>
                                        &nbsp; &nbsp;
                                        <asp:LinkButton ID="lbtnShowAll" Font-Bold="true" runat="server" Text="Show All"
                                            OnClick="lbtnA_Click" meta:resourcekey="lbtnShowAllResource1" Style="color: #8DC63F;"></asp:LinkButton>
                                    </td>
                                </tr>
                                <tr>
                                    <%--<asp:UpdateProgress ID="upImage" runat="server" AssociatedUpdatePanelID="upDefault">
                                        <ProgressTemplate>
                                            <div>
                                                <img src="App_Themes/Green/Images/spinner.gif" />
                                                Please Wait...
                                            </div>
                                        </ProgressTemplate>
                                    </asp:UpdateProgress>--%>
                                    <td colspan="5">
                                        <asp:GridView ID="gvMedicationProcedures" runat="server" AutoGenerateColumns="False"
                                            Width="100%" AllowPaging="True" OnRowDataBound="gvMedicationProcedures_RowDataBound"
                                            OnPageIndexChanging="gvMedicationProcedures_PageIndexChanging" meta:resourcekey="gvMedicationProceduresResource1"
                                            GridLines="Both" PagerSettings-Mode="NumericFirstLast">
                                            <Columns>
                                                <asp:TemplateField meta:resourcekey="TemplateFieldResource1">
                                                    <HeaderTemplate>
                                                        <asp:CheckBox ID="chkSelectAll" runat="server" OnCheckedChanged="chkSelectAll_CheckedChanged"
                                                            AutoPostBack="True" meta:resourcekey="chkSelectAllResource1" />
                                                    </HeaderTemplate>
                                                    <ItemTemplate>
                                                        <asp:CheckBox ID="chkSelect" runat="server" OnCheckedChanged="chkSelect_CheckedChanged"
                                                            AutoPostBack="True" meta:resourcekey="chkSelectResource1" />
                                                    </ItemTemplate>
                                                    <ItemStyle Width="4%" />
                                                </asp:TemplateField>
                                                <asp:BoundField DataField="TestProcedureId" meta:resourcekey="BoundFieldResource1">
                                                    <ItemStyle Width="5%" />
                                                </asp:BoundField>
                                                <asp:BoundField DataField="TestProcedureDescription" HeaderText="Test Procedure"
                                                    meta:resourcekey="BoundFieldResource2" ItemStyle-ForeColor="#8DC63F" ItemStyle-Font-Bold="true">
                                                    <ItemStyle Width="60%" />
                                                    <HeaderStyle HorizontalAlign="Left" Font-Size="Larger" />
                                                </asp:BoundField>
                                                <asp:BoundField DataField="ICD9Code" HeaderText="ICD9 Code" meta:resourcekey="BoundFieldResource3"
                                                    ItemStyle-ForeColor="#8DC63F" ItemStyle-Font-Bold="true">
                                                    <ItemStyle Width="30%" />
                                                    <HeaderStyle HorizontalAlign="Left" Font-Size="Larger" />
                                                </asp:BoundField>
                                            </Columns>
                                            <HeaderStyle BackColor="#8DC63F" />
                                            <PagerStyle ForeColor="#8DC63F" />
                                        </asp:GridView>
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="5" align="right">
                                        <asp:Button ID="btnSave" runat="server" Text=" Save and Add more " Style="cursor: hand;"
                                            meta:resourcekey="btnSaveResource1" Enabled="false" />
                                        <asp:Button ID="btnCancel" runat="server" Text=" Save and exit " OnClick="btnCancel_Click"
                                            Style="cursor: hand;" meta:resourcekey="btnCancelResource1" Enabled="false" />
                                        <asp:Button ID="btnSubmit" runat="server" Text=" Submit " Style="cursor: hand;" meta:resourcekey="btnSubmitResource1"
                                            Enabled="false" />
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>
            </div>
            <div class="popup-container" style="width: 500px; display: none; background-color: #D3EDB0;"
                id="divSelect" runat="server">
                <div class="popup-header-bg">
                    <table width="98%">
                        <tr>
                            <td>
                                Select Different Options
                            </td>
                            <td align="right" valign="top">
                                <asp:Button ID="btnClose" runat="server" OnClick="btnClose_Click" Style="background-image: url(images/popup-close-but.png);
                                    width: 14px; height: 14px; border: none;" />
                            </td>
                        </tr>
                    </table>
                </div>
                <div class="popup-content" style="background-color: #FFFFFF;">
                    <table cellpadding="4" border="0" width="100%">
                        <tr>
                            <td style="width: 40%;">
                                <asp:Label ID="lblSendMail" runat="server" Text="Send Mail:"></asp:Label>
                            </td>
                            <td style="width: 60%;" align="left">
                                <asp:CheckBox ID="chkSendMail" runat="server" />
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 40%;">
                                <asp:Label ID="lblSendFax" runat="server" Text="Upload File to FTP:"></asp:Label>
                            </td>
                            <td style="width: 60%;" align="left">
                                <asp:CheckBox ID="chkFtp" runat="server" />
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 40%;">
                                <asp:Label ID="lblFax" runat="server" Text="Send FAX:"></asp:Label>
                            </td>
                            <td style="width: 60%;" align="left">
                                <asp:CheckBox ID="chkFax" runat="server" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2" align="right">
                                <asp:Button ID="btnOk" runat="server" Style="cursor: hand;" OnClick="btnOk_Click"
                                    Text=" Ok " />
                                <asp:Button ID="btnSubmitCancel" runat="server" Style="cursor: hand;" OnClick="btnSubmitCancel_Click"
                                    Text=" Cancel " />
                            </td>
                        </tr>
                    </table>
                </div>
            </div>
            <cc1:ModalPopupExtender ID="mpeSubmit" runat="server" TargetControlID="btnSubmit"
                BackgroundCssClass="modalBackground" PopupControlID="divSelect" Enabled="True">
            </cc1:ModalPopupExtender>
            <div class="popup-container" style="width: 500px; display: none;" id="divSaveandAddMore"
                runat="server">
                <div class="popup-header-bg">
                    <table width="98%">
                        <tr>
                            <td>
                                Selected Tests
                            </td>
                            <td align="right" valign="top">
                                <asp:Button ID="Button1" runat="server" OnClick="btnClose_Click" Style="background-image: url(images/popup-close-but.png);
                                    width: 14px; height: 14px; border: none;" />
                            </td>
                        </tr>
                    </table>
                </div>
                <div class="popup-content" style="background-color: #FFFFFF">
                    <table width="100%" cellpadding="0" cellspacing="0" border="0">
                        <tr>
                            <td>
                                <asp:GridView ID="gvSaveandAddMore" runat="server" AutoGenerateColumns="False" Width="100%"
                                    AllowPaging="True" GridLines="Both" PageSize="10" OnPageIndexChanging="gvSaveandAddMore_PageIndexChanging"
                                    PagerSettings-Mode="NumericFirstLast" OnRowDataBound="gvSaveandAddMore_RowDataBound">
                                    <Columns>
                                        <asp:TemplateField>
                                            <HeaderTemplate>
                                                <asp:CheckBox ID="chkSaveandAddmoreSelectAll" runat="server" Checked="true" />
                                            </HeaderTemplate>
                                            <ItemTemplate>
                                                <asp:CheckBox ID="chkSaveandAddmore" runat="server" Checked="true" AutoPostBack="true" />
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:BoundField DataField="TestProcedureId">
                                            <ItemStyle Width="5%" />
                                        </asp:BoundField>
                                        <asp:BoundField DataField="TestProcedureDescription" HeaderText="Test Procedure"
                                            ItemStyle-ForeColor="#8DC63F" ItemStyle-Font-Bold="true">
                                            <ItemStyle Width="60%" />
                                            <HeaderStyle HorizontalAlign="Left" Font-Size="Larger" />
                                        </asp:BoundField>
                                        <asp:BoundField DataField="ICD9Code" HeaderText="ICD9 Code" ItemStyle-ForeColor="#8DC63F"
                                            ItemStyle-Font-Bold="true">
                                            <ItemStyle Width="30%" />
                                            <HeaderStyle HorizontalAlign="Left" Font-Size="Larger" />
                                        </asp:BoundField>
                                    </Columns>
                                    <HeaderStyle BackColor="#8DC63F" />
                                    <AlternatingRowStyle BackColor="#D3EDB0" />
                                    <RowStyle BackColor="#D3EDB0" />
                                    <PagerStyle ForeColor="#8DC63F" />
                                </asp:GridView>
                            </td>
                        </tr>
                        <tr>
                            <td align="right">
                                <asp:Button ID="btnAddMore" runat="server" Text=" Add more " Style="cursor: hand;"
                                    meta:resourcekey="btnSaveResource1" OnClick="btnAddMore_Click" />
                                <asp:Button ID="btnSaveExit" runat="server" Text=" Save and exit " Style="cursor: hand;"
                                    meta:resourcekey="btnCancelResource1" OnClick="btnSaveExit_Click" />
                                <asp:Button ID="btnPreviewandSubmit" runat="server" Text=" Preview and Submit " Style="cursor: hand;"
                                    meta:resourcekey="btnSubmitResource1" />
                            </td>
                        </tr>
                    </table>
                </div>
            </div>
            <cc1:ModalPopupExtender ID="mpeSaveAndAddMore" runat="server" TargetControlID="btnSave"
                BackgroundCssClass="modalBackground" PopupControlID="divSaveandAddMore" Enabled="True">
            </cc1:ModalPopupExtender>
            <div id="divPdfPreview" runat="server" style="width: 100%; height: 600px; padding-top: 5px;
                padding-left: 0px; display: none;">
                <div class="pdf_popup_container">
                    <div class="ClosePDF">
                        <asp:LinkButton ID="lbtnClose" OnClick="lbtnClose_Click" runat="server">Close</asp:LinkButton></div>
                    <div class="pdf_warning">
                        <strong>IMPORTANT!</strong><br />
                        Review the information before submitting, click <span>Submit</span> button to send
                        the Diagnostics information to the Insurance provider, else click on <span>Save</span>
                        to save the information for submission at a later point of time.
                    </div>
                    <div class="pdf_body">
                        <div class="pdf_body_1">
                            <div class="pdf_body_2">
                                <div class="pdf_body_3">
                                    <div class="pdf_inner_header">
                                        <table width="100%" border="0" cellspacing="0" cellpadding="0">
                                            <tr>
                                                <td>
                                                    <table border="0" cellspacing="2" cellpadding="2">
                                                        <tr>
                                                            <td>
                                                                <asp:Label ID="Label1" runat="server" Text="Patient consent form signed:"></asp:Label>
                                                            </td>
                                                            <td>
                                                                <asp:Label ID="Label2" Font-Bold="true" runat="server" Text="Yes" CssClass="yes"></asp:Label>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <table border="0" cellspacing="2" cellpadding="2">
                                                        <tr>
                                                            <td>
                                                                <asp:Label ID="Label3" runat="server" Text="Medical Condition:"></asp:Label>
                                                            </td>
                                                            <td>
                                                                <asp:Label ID="Label4" Font-Bold="true" runat="server" Text=" Venous angiomas"></asp:Label>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <table border="0" cellspacing="2" cellpadding="2">
                                                        <tr>
                                                            <td>
                                                                <asp:Label ID="Label5" runat="server" Text="Submittedby : "></asp:Label>
                                                            </td>
                                                            <td>
                                                                <asp:Label ID="Label6" Font-Bold="true" runat="server" Text="Dr. Morgan Juelsky, "></asp:Label>
                                                            </td>
                                                            <td>
                                                                <asp:Label ID="Label7" Font-Bold="true" runat="server" Text="on behalf of "></asp:Label>
                                                            </td>
                                                            <td>
                                                                <asp:Label ID="Label8" Font-Bold="true" runat="server" Text="Maryland Medicare Centre "></asp:Label>
                                                            </td>
                                                            <td>
                                                                <asp:Label ID="Label9" Font-Bold="true" runat="server" Text="on "></asp:Label>
                                                            </td>
                                                            <td>
                                                                <asp:Label ID="Label10" Font-Bold="true" runat="server" Text="25-Jul-2009 "></asp:Label>
                                                            </td>
                                                            <td>
                                                                <asp:Label ID="Label11" Font-Bold="true" runat="server" Text="at "></asp:Label>
                                                            </td>
                                                            <td>
                                                                <asp:Label ID="Label12" Font-Bold="true" runat="server" Text="10:32 AM"></asp:Label>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </td>
                                            </tr>
                                        </table>
                                    </div>
                                    <div class="pdf_inner_header2">
                                        <uc:patientRecord ID="patientRecord1" runat="server" />
                                        <br />
                                    </div>
                                    <div class="pdf_content_white">
                                        <asp:GridView ID="gvPdfPreview" runat="server" AutoGenerateColumns="False" Width="100%"
                                            AllowPaging="True" GridLines="Both" PageSize="10" OnPageIndexChanging="gvPdfPreview_PageIndexChanging"
                                            PagerSettings-Mode="NumericFirstLast">
                                            <Columns>
                                                <asp:BoundField DataField="TestProcedureId"></asp:BoundField>
                                                <asp:BoundField DataField="TestProcedureDescription" HeaderText="Test Procedure"
                                                    ItemStyle-ForeColor="#8DC63F" ItemStyle-Font-Bold="true">
                                                    <HeaderStyle HorizontalAlign="Left" Font-Size="Larger" />
                                                </asp:BoundField>
                                                <asp:BoundField DataField="ICD9Code" HeaderText="ICD9 Code" ItemStyle-ForeColor="#8DC63F"
                                                    ItemStyle-Font-Bold="true">
                                                    <HeaderStyle HorizontalAlign="Left" Font-Size="Larger" />
                                                </asp:BoundField>
                                            </Columns>
                                            <HeaderStyle BackColor="#8DC63F" />
                                            <AlternatingRowStyle BackColor="#D3EDB0" />
                                            <RowStyle BackColor="#D3EDB0" />
                                            <PagerStyle ForeColor="#8DC63F" />
                                        </asp:GridView>
                                    </div>
                                    <div class="pdf_warning" style="background: none; padding: 8px 0 8px 0">
                                        <table width="100%" border="0" cellspacing="2" cellpadding="2">
                                            <tr>
                                                <td>
                                                    &nbsp;
                                                </td>
                                                <td align="right" style="width: 10%;">
                                                    <asp:Button ID="btnPdfCancel" runat="server" Text="Cancel" OnClick="btnPdfCancel_Click" />
                                                </td>
                                                <td align="right" style="width: 10%;">
                                                    <asp:Button ID="btnPdfSaveandExit" runat="server" Text="Save & Exit" OnClick="btnPdfSaveandExit_Click" />
                                                </td>
                                                <td align="right" style="width: 10%;">
                                                    <asp:Button ID="btnPdfSubmit" runat="server" Text="Submit" OnClick="btnPdfSubmit_Click" />
                                                </td>
                                            </tr>
                                        </table>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <cc1:ModalPopupExtender ID="mpePdfPreview" runat="server" TargetControlID="btnPreviewandSubmit"
                BackgroundCssClass="modalBackground" PopupControlID="divPdfPreview" Enabled="True">
            </cc1:ModalPopupExtender>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
