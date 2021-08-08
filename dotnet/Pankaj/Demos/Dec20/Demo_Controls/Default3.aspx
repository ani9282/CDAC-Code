<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default3.aspx.cs" Inherits="Default3" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 100%;
            border: 1px solid #800000;
        }
        .style2
        {
            width: 416px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="style1" border=1>
            <tr>
                <td class="style2">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style2">
                    <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0">
                        <br />
                        <asp:View ID="View1" runat="server">
                            <asp:Login ID="Login1" runat="server" BackColor="#FFFBD6" BorderColor="#FFDFAD" 
                                BorderPadding="4" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" 
                                Font-Size="0.8em" ForeColor="#333333" style="font-size: x-large" 
                                TextLayout="TextOnTop">
                                <InstructionTextStyle Font-Italic="True" ForeColor="Black" />
                                <LoginButtonStyle BackColor="White" BorderColor="#CC9966" BorderStyle="Solid" 
                                    BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#990000" />
                                <TextBoxStyle Font-Size="0.8em" />
                                <TitleTextStyle BackColor="#990000" Font-Bold="True" Font-Size="0.9em" 
                                    ForeColor="White" />
                            </asp:Login>
                            <br />
                            <asp:LinkButton ID="LinkButton1" runat="server" onclick="LinkButton1_Click">New User Register Here</asp:LinkButton>
                        </asp:View>
                        <br />
                        <br />
                        <asp:View ID="View2" runat="server">
                            <asp:CreateUserWizard ID="CreateUserWizard1" runat="server" BackColor="#FFFBD6" 
                                BorderColor="#FFDFAD" BorderStyle="Solid" BorderWidth="1px" 
                                Font-Names="Verdana" Font-Size="0.8em" style="font-size: medium">
                                <ContinueButtonStyle BackColor="White" BorderColor="#CC9966" 
                                    BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" 
                                    ForeColor="#990000" />
                                <CreateUserButtonStyle BackColor="White" BorderColor="#CC9966" 
                                    BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" 
                                    ForeColor="#990000" />
                                <TitleTextStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                                <WizardSteps>
                                    <asp:CreateUserWizardStep runat="server" />
                                    <asp:CompleteWizardStep runat="server" />
                                </WizardSteps>
                                <HeaderStyle BackColor="#FFCC66" BorderColor="#FFFBD6" BorderStyle="Solid" 
                                    BorderWidth="2px" Font-Bold="True" Font-Size="0.9em" ForeColor="#333333" 
                                    HorizontalAlign="Center" />
                                <NavigationButtonStyle BackColor="White" BorderColor="#CC9966" 
                                    BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" 
                                    ForeColor="#990000" />
                                <SideBarButtonStyle ForeColor="White" />
                                <SideBarStyle BackColor="#990000" Font-Size="0.9em" VerticalAlign="Top" />
                            </asp:CreateUserWizard>
                        </asp:View>
                        <br />
                        <br />
                        <br />
                        <br />
                        <br />
                    </asp:MultiView>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
