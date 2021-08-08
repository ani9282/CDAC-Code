<%@ Page Language="C#" AutoEventWireup="true"   CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table border="2">
            <tr>
                <td style="width: 100px">
                    <asp:Label ID="Label1" runat="server" Text="Enter Text" 
                        style="font-weight: 700"></asp:Label></td>
                <td style="width: 100px">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
                <td style="width: 100px">
                </td>
            </tr>
            <tr>
                <td style="width: 100px">
                </td>
                <td style="width: 100px">
                </td>
                <td style="width: 100px">
                </td>
            </tr>
            <tr>
                <td style="width: 100px">
                </td>
                <td style="width: 100px">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Click Me" 
                        style="font-weight: 700" />
                    <asp:Button ID="Button2" runat="server" Text="Button" style="font-weight: 700" 
                        Width="77px" onclick="Button2_Click" /></td>
                <td style="width: 100px">
                    <asp:Label ID="Label2" runat="server" Text="Label" style="font-weight: 700"></asp:Label></td>
            </tr>
        </table>
    
    </div>
        &nbsp;
    </form>
</body>
</html>
