<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DataPage.aspx.cs" Inherits="DataPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: x-large;
            color: #800000;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style1">
    
        <strong>Just Sample Data Page</strong></div>
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="CustId" DataSourceID="SqlDataSource1" PageSize="4">
            <Columns>
                <asp:TemplateField HeaderText="New Column">
                    <ItemTemplate>
                        <asp:CheckBox ID="CheckBox1" runat="server" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowSelectButton="True" />
                <asp:BoundField DataField="CustId" HeaderText="CustId" InsertVisible="False" ReadOnly="True" SortExpression="CustId" />
                <asp:BoundField DataField="CustName" HeaderText="CustName" SortExpression="CustName" />
                <asp:BoundField DataField="Addr" HeaderText="Addr" SortExpression="Addr" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:PankajDbConnectionString %>" DeleteCommand="DELETE FROM [Customers] WHERE [CustId] = @original_CustId AND (([CustName] = @original_CustName) OR ([CustName] IS NULL AND @original_CustName IS NULL)) AND (([Addr] = @original_Addr) OR ([Addr] IS NULL AND @original_Addr IS NULL))" InsertCommand="INSERT INTO [Customers] ([CustName], [Addr]) VALUES (@CustName, @Addr)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT * FROM [Customers]" UpdateCommand="UPDATE [Customers] SET [CustName] = @CustName, [Addr] = @Addr WHERE [CustId] = @original_CustId AND (([CustName] = @original_CustName) OR ([CustName] IS NULL AND @original_CustName IS NULL)) AND (([Addr] = @original_Addr) OR ([Addr] IS NULL AND @original_Addr IS NULL))">
            <DeleteParameters>
                <asp:Parameter Name="original_CustId" Type="Int32" />
                <asp:Parameter Name="original_CustName" Type="String" />
                <asp:Parameter Name="original_Addr" Type="String" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="CustName" Type="String" />
                <asp:Parameter Name="Addr" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="CustName" Type="String" />
                <asp:Parameter Name="Addr" Type="String" />
                <asp:Parameter Name="original_CustId" Type="Int32" />
                <asp:Parameter Name="original_CustName" Type="String" />
                <asp:Parameter Name="original_Addr" Type="String" />
            </UpdateParameters>
        </asp:SqlDataSource>
        <br />
        <br />
        <asp:FormView ID="FormView1" runat="server" AllowPaging="True" DataKeyNames="CustId" DataSourceID="SqlDataSource1">
            <EditItemTemplate>
                CustId:
                <asp:Label ID="CustIdLabel1" runat="server" Text='<%# Eval("CustId") %>' />
                <br />
                CustName:
                <asp:TextBox ID="CustNameTextBox" runat="server" Text='<%# Bind("CustName") %>' />
                <br />
                Addr:
                <asp:TextBox ID="AddrTextBox" runat="server" Text='<%# Bind("Addr") %>' />
                <br />
                <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
                &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
            </EditItemTemplate>
            <InsertItemTemplate>
                CustName:
                <asp:TextBox ID="CustNameTextBox" runat="server" Text='<%# Bind("CustName") %>' />
                <br />
                Addr:
                <asp:TextBox ID="AddrTextBox" runat="server" Text='<%# Bind("Addr") %>' />
                <br />
                <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
                &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
            </InsertItemTemplate>
            <ItemTemplate>
                CustId:
                <asp:Label ID="CustIdLabel" runat="server" Text='<%# Eval("CustId") %>' />
                <br />
                CustName:
                <asp:Label ID="CustNameLabel" runat="server" Text='<%# Bind("CustName") %>' />
                <br />
                Addr:
                <asp:Label ID="AddrLabel" runat="server" Text='<%# Bind("Addr") %>' />
                <br />
                <asp:LinkButton ID="EditButton" runat="server" CausesValidation="False" CommandName="Edit" Text="Edit" />
                &nbsp;<asp:LinkButton ID="DeleteButton" runat="server" CausesValidation="False" CommandName="Delete" Text="Delete" />
                &nbsp;<asp:LinkButton ID="NewButton" runat="server" CausesValidation="False" CommandName="New" Text="New" />
            </ItemTemplate>
        </asp:FormView>
    </form>
</body>
</html>
