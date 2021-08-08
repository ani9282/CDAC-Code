<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sample Home Page</title>
    <style type="text/css">
        .auto-style1 {
            text-decoration: underline;
            color: #0000FF;
            font-size: xx-large;
        }
        .auto-style2 {
            width: 53%;
            border: 1px solid #800000;
            height: 49px;
        }
        .auto-style3 {
            width: 116px;
        }
        .auto-style4 {
            width: 5px;
        }
        .auto-style5 {
            text-decoration: underline;
            color: #0000FF;
        }
        .auto-style6 {
            width: 5px;
            font-size: medium;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Welcome to IET <span class="auto-style1"><strong><em>C-DAC<br />
        <br />
        </em>
        </span>
    
        <span class="auto-style5">
        <table class="auto-style2" border="1">
            <tr>
                <td class="auto-style6">RollNo</td>
                </span>
    
                <span class="auto-style1">
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style3">
                    <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" />
                </td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style3" rowspan="3" valign="Top">
                    <asp:GridView ID="GridView1" runat="server" Visible="False">
                    </asp:GridView>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
            </tr>
        </table>
        </span>
    
        </strong>
    
    </div>
    </form>
</body>
</html>
