<%@ Page Language="C#" Culture="mr-IN" AutoEventWireup="true" CodeFile="LocalizeDemo.aspx.cs" Inherits="LocalizeDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>
        <br />
        <br />
        <strong>
        <asp:Label ID="Label1" runat="server"></asp:Label>
        </strong>
    
    </div>
    </form>
</body>
</html>
