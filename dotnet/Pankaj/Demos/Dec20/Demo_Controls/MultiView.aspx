<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MultiView.aspx.cs" Inherits="MultiView" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
    <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0">
        <asp:View ID="View1" runat="server">
            <asp:Login ID="Login1" runat="server" BackColor="#F7F7DE" BorderColor="#CCCC99" 
                BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="10pt" 
                style="font-size: xx-large">
                <TitleTextStyle BackColor="#6B696B" Font-Bold="True" ForeColor="#FFFFFF" />
            </asp:Login>
            <br />
            <asp:LinkButton ID="LinkButton1" runat="server" onclick="LinkButton1_Click">New User Register Here</asp:LinkButton>
        </asp:View>
        <asp:View ID="View2" runat="server">
            <asp:CreateUserWizard ID="CreateUserWizard1" runat="server" BackColor="#F7F7DE" 
                BorderColor="#CCCC99" BorderStyle="Solid" BorderWidth="1px" 
                Font-Names="Verdana" Font-Size="10pt">
                <ContinueButtonStyle BackColor="#FFFBFF" BorderColor="#CCCCCC" 
                    BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" 
                    ForeColor="#284775" />
                <CreateUserButtonStyle BackColor="#FFFBFF" BorderColor="#CCCCCC" 
                    BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" 
                    ForeColor="#284775" />
                <TitleTextStyle BackColor="#6B696B" Font-Bold="True" ForeColor="#FFFFFF" />
                <WizardSteps>
                    <asp:CreateUserWizardStep runat="server" />
                    <asp:CompleteWizardStep runat="server" />
                </WizardSteps>
                <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="#FFFFFF" 
                    HorizontalAlign="Center" />
                <NavigationButtonStyle BackColor="#FFFBFF" BorderColor="#CCCCCC" 
                    BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" 
                    ForeColor="#284775" />
                <SideBarButtonStyle BorderWidth="0px" Font-Names="Verdana" 
                    ForeColor="#FFFFFF" />
                <SideBarStyle BackColor="#7C6F57" BorderWidth="0px" Font-Size="0.9em" 
                    VerticalAlign="Top" />
                <StepStyle BorderWidth="0px" />
            </asp:CreateUserWizard>
            <br />
            <asp:LinkButton ID="LinkButton2" runat="server" onclick="LinkButton2_Click">Existing users Click to Log in</asp:LinkButton>
        </asp:View>
    </asp:MultiView>
    </form>
</body>
</html>
