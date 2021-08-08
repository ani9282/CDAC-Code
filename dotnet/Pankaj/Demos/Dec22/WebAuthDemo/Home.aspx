<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h1><em>ABCSOFT Pvt Ltd.</em></h1>
    
    </div>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/DataPage.aspx">Data Page</asp:HyperLink>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Clerk/ClerkDetails.aspx">Clerk Section</asp:HyperLink>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/Manager/ManagerDetails.aspx">Manager Section</asp:HyperLink>
    </form>
</body>
</html>
