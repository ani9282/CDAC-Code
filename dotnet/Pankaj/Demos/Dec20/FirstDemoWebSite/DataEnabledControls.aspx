<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DataEnabledControls.aspx.cs" Inherits="DataEnabledControls" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 59%;
        }
        .auto-style2 {
            width: 184px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1" border="1">
            <tr>
                <td class="auto-style2"><strong>ListBox</strong></td>
                <td>
                    <asp:ListBox ID="ListBox1" runat="server" Height="73px" Width="126px"></asp:ListBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2"><strong>ComboBox</strong></td>
                <td>
                    <asp:DropDownList ID="DropDownList1" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style2"><strong>RadioButtonList</strong></td>
                <td>
                    <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td class="auto-style2"><strong>CheckBoxList</strong></td>
                <td>
                    <asp:CheckBoxList ID="CheckBoxList1" runat="server">
                    </asp:CheckBoxList>
                </td>
            </tr>
            <tr>
                <td class="auto-style2"><strong>Bulleted List</strong></td>
                <td>
                    <asp:BulletedList ID="BulletedList1" runat="server">
                    </asp:BulletedList>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
