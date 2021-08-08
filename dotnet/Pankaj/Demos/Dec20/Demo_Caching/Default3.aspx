<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default3.aspx.cs" Inherits="Default3" %>

<%@ Register src="WebUserControl.ascx" tagname="WebUserControl" tagprefix="uc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <strong>
        <asp:Label ID="Label1" runat="server"></asp:Label>
        </strong>
    
    </div>
        <p>
            &nbsp;</p>
        <p>
            <uc1:WebUserControl ID="WebUserControl1" runat="server" />
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" Text="Button" />
        </p>
    </form>
</body>
</html>
