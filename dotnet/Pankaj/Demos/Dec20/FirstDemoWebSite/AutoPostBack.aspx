<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AutoPostBack.aspx.cs" Inherits="AutoPostBack" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form2" runat="server">
        <p>
            Name
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </p>
        <p>
            City
            <asp:DropDownList ID="DropDownList2" runat="server" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged" AutoPostBack="True">
            </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;
        </p>
    </form>
    
</body>
</html>
