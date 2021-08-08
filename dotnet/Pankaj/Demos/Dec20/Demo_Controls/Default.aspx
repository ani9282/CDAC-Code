<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>

</head>
<body>
<script language ="javascript" type ="text/javascript" >
function MyFunction()
{
    alert("You have submitted information successfuly");
}



</script>
    <form id="form1" runat="server">
    <div>
        <table id="TABLE1" onclick="return TABLE1_onclick()">
            <tr>
                <td style="width: 100px">
                    <asp:Label ID="Label1" runat="server"  AccessKey="N" AssociatedControlID="TextBox1">User <u>N</u>ame</asp:Label></td>
                <td style="width: 100px">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
                <td style="width: 100px">
                </td>
            </tr>
            <tr>
                <td style="width: 100px">
                    <asp:Label ID="Label2" AccessKey ="P"  AssociatedControlID ="TextBox2"  runat="server"><u>P</u>assword</asp:Label></td>
                <td style="width: 100px">
                    <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox></td>
                <td style="width: 100px">
                </td>
            </tr>
            <tr>
                <td style="width: 100px">
                </td>
                <td style="width: 100px">
        <asp:Button ID="Button1" runat="server" Text="Submit" OnClientClick ="MSG()"   OnClick="Button1_Click" /></td>
                <td style="width: 100px">
                </td>
            </tr>
        </table>
    
    </div>
        &nbsp; &nbsp;&nbsp;&nbsp;
    </form>
</body>
</html>
