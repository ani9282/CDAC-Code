<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 100%;
            border: 2px solid #800000;
        }
        .style2
        {
            width: 111px;
            font-size: large;
        }
        .style3
        {
            width: 190px;
        }
    </style>
    <script language="javascript" type="text/javascript">
        function CheckAge(sender, args) 
        {
            if (args.Value>18) 
            {
                args.IsValid = true;
            }
            else
             {
                args.IsValid = false;
            }
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="style1" border="2">
            <tr>
                <td class="style2">
                    Name</td>
                <td class="style3">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ControlToValidate="TextBox1" ErrorMessage="Please Provide Your name" 
                        Display="None"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    Age</td>
                <td class="style3">
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:CustomValidator ID="CustomValidator1" runat="server" 
                        ClientValidationFunction="CheckAge" ControlToValidate="TextBox2" 
                        ErrorMessage="Age req.  is Greater then 18" Display="None"></asp:CustomValidator>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    Address</td>
                <td class="style3">
                    <asp:TextBox ID="TextBox3" runat="server" Height="70px" TextMode="MultiLine" 
                        Width="267px"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style2">
                    Email</td>
                <td class="style3">
                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                        ControlToValidate="TextBox4" ErrorMessage="RegularExpressionValidator" 
                        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    Password</td>
                <td class="style3">
                    <asp:TextBox ID="TextBox5" runat="server" TextMode="Password"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style2">
                    Retype Password</td>
                <td class="style3">
                    <asp:TextBox ID="TextBox6" runat="server" TextMode="Password"></asp:TextBox>
                </td>
                <td>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" 
                        ControlToCompare="TextBox5" ControlToValidate="TextBox6" Display="None" 
                        ErrorMessage="CompareValidator"></asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    &nbsp;</td>
                <td class="style3">
                    <asp:Button ID="Button1" runat="server" Text="Submit" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style2">
                    &nbsp;</td>
                <td class="style3">
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
