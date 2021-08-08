<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FormViewDemo.aspx.cs" Inherits="FormViewDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:FormView ID="FormView1" runat="server" AllowPaging="True" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" DataKeyNames="RollNo" DataSourceID="SqlDataSource1" GridLines="Horizontal">
            <EditItemTemplate>
                RollNo:
                <asp:Label ID="RollNoLabel1" runat="server" Text='<%# Eval("RollNo") %>' />
                <br />
                Name:
                <asp:TextBox ID="NameTextBox" runat="server" Text='<%# Bind("Name") %>' />
                <br />
                Addr:
                <asp:TextBox ID="AddrTextBox" runat="server" Text='<%# Bind("Addr") %>' />
                <br />
                <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
                &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
            </EditItemTemplate>
            <EditRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
            <FooterStyle BackColor="White" ForeColor="#333333" />
            <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
            <InsertItemTemplate>
                RollNo:
                <asp:TextBox ID="RollNoTextBox" runat="server" Text='<%# Bind("RollNo") %>' />
                <br />
                Name:
                <asp:TextBox ID="NameTextBox" runat="server" Text='<%# Bind("Name") %>' />
                <br />
                Addr:
                <asp:TextBox ID="AddrTextBox" runat="server" Text='<%# Bind("Addr") %>' />
                <br />
                <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
                &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
            </InsertItemTemplate>
            <ItemTemplate>
                RollNo:
                <asp:Label ID="RollNoLabel" runat="server" Text='<%# Eval("RollNo") %>' />
                <br />
                Name:
                <asp:Label ID="NameLabel" runat="server" Text='<%# Bind("Name") %>' />
                <br />
                Addr:
                <asp:Label ID="AddrLabel" runat="server" Text='<%# Bind("Addr") %>' />
                <br />
                <asp:LinkButton ID="EditButton" runat="server" CausesValidation="False" CommandName="Edit" Text="Edit" />
                &nbsp;<asp:LinkButton ID="DeleteButton" runat="server" CausesValidation="False" CommandName="Delete" Text="Delete" />
                &nbsp;<asp:LinkButton ID="NewButton" runat="server" CausesValidation="False" CommandName="New" Text="New" />
            </ItemTemplate>
            <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="White" ForeColor="#333333" />
        </asp:FormView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:PankajDbConnectionString %>" DeleteCommand="DELETE FROM [Students] WHERE [RollNo] = @original_RollNo AND (([Name] = @original_Name) OR ([Name] IS NULL AND @original_Name IS NULL)) AND (([Addr] = @original_Addr) OR ([Addr] IS NULL AND @original_Addr IS NULL))" InsertCommand="INSERT INTO [Students] ([RollNo], [Name], [Addr]) VALUES (@RollNo, @Name, @Addr)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT * FROM [Students]" UpdateCommand="UPDATE [Students] SET [Name] = @Name, [Addr] = @Addr WHERE [RollNo] = @original_RollNo AND (([Name] = @original_Name) OR ([Name] IS NULL AND @original_Name IS NULL)) AND (([Addr] = @original_Addr) OR ([Addr] IS NULL AND @original_Addr IS NULL))">
            <DeleteParameters>
                <asp:Parameter Name="original_RollNo" Type="Int32" />
                <asp:Parameter Name="original_Name" Type="String" />
                <asp:Parameter Name="original_Addr" Type="String" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="RollNo" Type="Int32" />
                <asp:Parameter Name="Name" Type="String" />
                <asp:Parameter Name="Addr" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="Name" Type="String" />
                <asp:Parameter Name="Addr" Type="String" />
                <asp:Parameter Name="original_RollNo" Type="Int32" />
                <asp:Parameter Name="original_Name" Type="String" />
                <asp:Parameter Name="original_Addr" Type="String" />
            </UpdateParameters>
        </asp:SqlDataSource>
    
    </div>
        <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" DataKeyNames="RollNo" DataSourceID="SqlDataSource1" Height="50px" Width="125px">
            <Fields>
                <asp:BoundField DataField="RollNo" HeaderText="RollNo" ReadOnly="True" SortExpression="RollNo" />
                <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                <asp:BoundField DataField="Addr" HeaderText="Addr" SortExpression="Addr" />
            </Fields>
        </asp:DetailsView>
    </form>
</body>
</html>
