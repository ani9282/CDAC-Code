<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LinqDataSourceDemo.aspx.cs" Inherits="LinqDataSourceDemo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1 {
            width: 100%;
        }
        .style2
        {
            width: 98px;
        }
        .style3
        {
            color: #800000;
        }
        .style4
        {
            background-color: #FFFF99;
        }
        .style5
        {
            width: 98px;
            background-color: #FFFF99;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
        AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="EmpId" 
        DataSourceID="LinqDataSource1" EnableModelValidation="True">
        <Columns>
            <asp:TemplateField HeaderText="My Column">
                <ItemTemplate>
                    <asp:CheckBox ID="CheckBox1" runat="server" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" 
                ShowSelectButton="True" />
            <asp:BoundField DataField="EmpId" HeaderText="EmpId" ReadOnly="True" 
                SortExpression="EmpId" />
            <asp:BoundField DataField="EmpName" HeaderText="EmpName" 
                SortExpression="EmpName" />
            <asp:BoundField DataField="Addr" HeaderText="Addr" SortExpression="Addr" />
        </Columns>
    </asp:GridView>
    <asp:LinqDataSource ID="LinqDataSource1" runat="server" 
        ContextTypeName="CDACDataClassesDataContext" EnableDelete="True" 
        EnableInsert="True" EnableUpdate="True" TableName="Employees">
    </asp:LinqDataSource>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <asp:FormView ID="FormView1" runat="server" AllowPaging="True" 
        DataKeyNames="EmpId" DataSourceID="LinqDataSource1" 
        EnableModelValidation="True">
        <EditItemTemplate>
            EmpId:
            <asp:Label ID="EmpIdLabel1" runat="server" Text='<%# Eval("EmpId") %>' />
            <br />
            EmpName:
            <asp:TextBox ID="EmpNameTextBox" runat="server" Text='<%# Bind("EmpName") %>' />
            <br />
            Addr:
            <asp:TextBox ID="AddrTextBox" runat="server" Text='<%# Bind("Addr") %>' />
            <br />
            <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" 
                CommandName="Update" Text="Update" />
            &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" 
                CausesValidation="False" CommandName="Cancel" Text="Cancel" />
        </EditItemTemplate>
        <InsertItemTemplate>
            EmpId:
            <asp:TextBox ID="EmpIdTextBox" runat="server" Text='<%# Bind("EmpId") %>' />
            <br />
            EmpName:
            <asp:TextBox ID="EmpNameTextBox" runat="server" Text='<%# Bind("EmpName") %>' />
            <br />
            Addr:
            <asp:TextBox ID="AddrTextBox" runat="server" Text='<%# Bind("Addr") %>' />
            <br />
            <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" 
                CommandName="Insert" Text="Insert" />
            &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" 
                CausesValidation="False" CommandName="Cancel" Text="Cancel" />
        </InsertItemTemplate>
        <ItemTemplate>
            <strong>Employee Details<br />
            <br />
            <table class="style1" border=1>
                <tr>
                    <td class="style2">
                        <strong>Employee Id</strong>:</td>
                    <td>
                        <asp:Label ID="EmpIdLabel" runat="server" CssClass="style3" 
                            Text='<%# Eval("EmpId") %>' />
                    </td>
                </tr>
                <tr>
                    <td class="style5">
                        <strong>Name:</strong></td>
                    <td class="style4">
                        <asp:Label ID="EmpNameLabel" runat="server" CssClass="style3" 
                            Text='<%# Bind("EmpName") %>' />
                    </td>
                </tr>
                <tr>
                    <td class="style2">
                        <strong>Address</strong>&nbsp;</td>
                    <td>
                        <asp:Label ID="AddrLabel" runat="server" CssClass="style3" 
                            Text='<%# Bind("Addr") %>' />
                    </td>
                </tr>
            </table>
            </strong>
            <br />
            <br />
            <asp:LinkButton ID="EditButton" runat="server" CausesValidation="False" 
                CommandName="Edit" Text="Edit" />
            &nbsp;<asp:LinkButton ID="DeleteButton" runat="server" CausesValidation="False" 
                CommandName="Delete" Text="Delete" />
            &nbsp;<asp:LinkButton ID="NewButton" runat="server" CausesValidation="False" 
                CommandName="New" Text="New" />
        </ItemTemplate>
    </asp:FormView>
    </form>
</body>
</html>
