<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>
<%@ OutputCache Duration="60" VaryByParam="none" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            color: #3333FF;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <strong>
        <asp:Label ID="Label1" runat="server"></asp:Label>
        </strong>
    
    </div>
        <p class="auto-style1">
            <strong>This is a sample page created for Caching Demo on 12/04/2019</strong></p>
        <p class="auto-style1">
            &nbsp;</p>
        <p class="auto-style1">
            <asp:Button ID="Button1" runat="server" Text="Button" />
        </p>
    </form>
</body>
</html>
