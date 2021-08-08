<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        <br />
    
    </div>
    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
        Text="Linq To Objects" />
    <p>
        <asp:Button ID="Button2" runat="server" onclick="Button2_Click" 
            Text="LINQ Insert" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button3" runat="server" onclick="Button3_Click" 
            Text="LINQ Update" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button4" runat="server" onclick="Button4_Click" 
            Text="LINQ Delete" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button5" runat="server" onclick="Button5_Click" 
            Text="LINQ SELECT" />
    </p>
    <p>
        <asp:Button ID="Button6" runat="server" onclick="Button6_Click" 
            Text="LINQ File" />
    </p>
    </form>
</body>
</html>
