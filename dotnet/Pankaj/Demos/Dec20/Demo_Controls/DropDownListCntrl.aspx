<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DropDownListCntrl.aspx.cs" Inherits="DropDownListCntrl" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table>
            <tr>
                <td style="width: 100px">
                    <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" 
                        OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" 
                        style="font-size: x-large">
                    </asp:DropDownList></td>
                <td style="width: 100px">
                </td>
                <td style="width: 100px">
                    <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" 
                        Visible="False" style="font-size: x-large">
                    </asp:DropDownList></td>
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
                    <asp:CheckBoxList ID="CheckBoxList1" runat="server">
                    </asp:CheckBoxList>
                </td>
                <td style="width: 100px">
                </td>
                <td style="width: 100px">
                    <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                    </asp:RadioButtonList>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
