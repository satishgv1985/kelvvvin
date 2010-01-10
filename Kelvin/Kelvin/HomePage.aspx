<%@ Page Language="C#" MasterPageFile="~/MasterPages/Home.Master"AutoEventWireup="false" CodeFile="homepage.aspx.cs"
    Inherits="Kelvin.HomePage" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="column-left">
        <div class="banner-holder">
            <img src="Images/img-banner.png" alt="Banner" border="0" />
        </div>
        <div class="tab-bar-bg">
            <table width="100%" cellpadding="0" cellspacing="0">
                <tr>
                    <td style="width: 80%;">
                    </td>
                    <td valign="top">
                        <a href="#">1</a></td>
                    <td valign="top">
                        <a href="#">2</a></td>
                    <td valign="top">
                        <a href="#">3</a></td>
                    <td valign="top">
                        <a href="#">4</a></td>
                    <td valign="top">
                        <a href="#">5</a></td>
                    <td valign="top">
                        <a class="selected" href="#">6</a></td>
                    <td valign="top">
                        <a href="#">7</a></td>
                    <td valign="top">
                        <a href="#">8</a></td>
                    <td>
                        &nbsp;</td>
                </tr>
            </table>
        </div>
        <div class="content-tile-div">
            <h1>
                Health Tips</h1>
            <table width="100%" border="0" cellspacing="1" cellpadding="1">
                <tr>
                    <td style="width:33%;">
                        <table width="100%" border="0" cellspacing="2" cellpadding="2">
                            <tr>
                                <td align="center">
                                    <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/icon-sleepwell.png" /></td>
                                <td valign="top">
                                    <asp:Label ID="Label1" runat="server" Text="Sleep well" CssClass="block-header"></asp:Label><br />
                                    <asp:Label ID="Label2" runat="server" Text="Develop a ritual before going to bed so your body gets ready for sleep." CssClass="block-description"></asp:Label></td>
                            </tr>
                            <tr>
                                <td colspan="2" align="right">
                                    <asp:LinkButton CssClass="block-link" ID="LinkButton5" runat="server">...more</asp:LinkButton></td>
                            </tr>
                        </table>
                    </td>
                    <td style="width:33%;">
                        <table width="100%" border="0" cellspacing="2" cellpadding="2">
                            <tr>
                                <td align="center">
                                    <asp:Image ID="Image2" runat="server" ImageUrl="~/Images/icon-treatpain.png" /></td>
                                <td valign="top">
                                    <asp:Label ID="Label3" runat="server" Text="Treat pain " CssClass="block-header"></asp:Label><br />
                                    <asp:Label ID="Label4" runat="server" Text="Simple tips on how to treat pain without medications. " CssClass="block-description"></asp:Label></td>
                            </tr>
                            <tr>
                                <td colspan="2" align="right">
                                    <asp:LinkButton CssClass="block-link"  ID="LinkButton6" runat="server">...more</asp:LinkButton></td>
                            </tr>
                        </table></td>
                    <td style="width:33%;">
                        <table width="100%" border="0" cellspacing="2" cellpadding="2">
                            <tr>
                                <td align="center">
                                    <asp:Image ID="Image3" runat="server" ImageUrl="~/Images/icon-sleepwell.png" /></td>
                                <td valign="top">
                                    <asp:Label ID="Label5" runat="server" Text="Minerals and Vitamins" CssClass="block-header"></asp:Label><br />
                                    <asp:Label ID="Label6" runat="server" Text="Tips on how you can meet your entire mineral and vitamin" CssClass="block-description"></asp:Label></td>
                            </tr>
                            <tr>
                                <td colspan="2" align="right">
                                    <asp:LinkButton CssClass="block-link" ID="LinkButton7" runat="server">...more</asp:LinkButton></td>
                            </tr>
                        </table></td>
                </tr>
                <tr>
                    <td>
                        <table width="100%" border="0" cellspacing="2" cellpadding="2">
                            <tr>
                                <td align="center">
                                    <asp:Image ID="Image4" runat="server" ImageUrl="~/Images/icon-mdicines.png" /></td>
                                <td valign="top">
                                    <asp:Label ID="Label7" runat="server" Text="Medicines " CssClass="block-header"></asp:Label><br />
                                    <asp:Label ID="Label8" runat="server" Text="Medications that specifically target cancer cells and leave health cells alone" CssClass="block-description"></asp:Label></td>
                            </tr>
                            <tr>
                                <td colspan="2" align="right">
                                    <asp:LinkButton CssClass="block-link" ID="LinkButton8" runat="server">...more</asp:LinkButton></td>
                            </tr>
                        </table></td>
                    <td>
                        <table width="100%" border="0" cellspacing="2" cellpadding="2">
                            <tr>
                                <td align="center">
                                    <asp:Image ID="Image5" runat="server" ImageUrl="~/Images/icon-therapy.png" /></td>
                                <td valign="top">
                                    <asp:Label ID="Label9" runat="server" Text="Therapy " CssClass="block-header"></asp:Label><br />
                                    <asp:Label ID="Label10" runat="server" Text="Computer-guided radiation that is precisely sculpted to the shape..." CssClass="block-description"></asp:Label></td>
                            </tr>
                            <tr>
                                <td colspan="2" align="right">
                                    <asp:LinkButton CssClass="block-link" ID="LinkButton9" runat="server">...more</asp:LinkButton></td>
                            </tr>
                        </table></td>
                    <td>
                        <table width="100%" border="0" cellspacing="2" cellpadding="2">
                            <tr>
                                <td align="center">
                                    <asp:Image ID="Image6" runat="server" ImageUrl="~/Images/icon-heart-surgery.png" /></td>
                                <td valign="top">
                                    <asp:Label ID="Label11" runat="server" Text="Heart Surgery" CssClass="block-header"></asp:Label><br />
                                    <asp:Label ID="Label12" runat="server" Text="Minimally invasive heart valve replacement surgery                              " CssClass="block-description"></asp:Label></td>
                            </tr>
                            <tr>
                                <td colspan="2" align="right">
                                    <asp:LinkButton CssClass="block-link" ID="LinkButton10" runat="server">...more</asp:LinkButton></td>
                            </tr>
                        </table></td>
                </tr>
            </table>
        </div>
    </div>
    <div class="column-right">
        <div class="add-block-right-top">
            <table cellpadding="2" cellspacing="2" width="100%">
                <tr>
                    <td align="left">
                        <asp:LinkButton ID="LinkButton1" runat="server" CssClass="sponsord-link-add">Sponsored Links</asp:LinkButton>
                    </td>
                    <td align="right">
                        <asp:LinkButton ID="LinkButton2" runat="server" CssClass="hide-add">Hide</asp:LinkButton>
                    </td>
                </tr>
                <tr>
                    <td colspan="2" align="center">
                        <a href="">
                            <img src="Images/add-right-top.png" alt="Add Here" border="0" />
                        </a>
                    </td>
                </tr>
            </table>
        </div>
        <div class="add-block-right-top">
            <table cellpadding="2" cellspacing="2" width="100%">
                <tr>
                    <td align="left">
                        <asp:LinkButton ID="LinkButton3" runat="server" CssClass="sponsord-link-add">Sponsored Links</asp:LinkButton>
                    </td>
                    <td align="right">
                        <asp:LinkButton ID="LinkButton4" runat="server" CssClass="hide-add">Hide</asp:LinkButton>
                    </td>
                </tr>
                <tr>
                    <td colspan="2" align="center">
                        <a href="">
                            <img src="Images/add-right-bottom.png" alt="Add Here" border="0" />
                        </a>
                    </td>
                </tr>
            </table>
        </div>
    </div>
</asp:Content>
