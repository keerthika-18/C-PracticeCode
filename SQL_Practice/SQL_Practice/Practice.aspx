<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Practice.aspx.cs" Inherits="SQL_Practice.Practice" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="True" Height="380px"  Width="593px">
           <Columns>
                <asp:BoundField DataField="ProductID" HeaderText="ID" />
                <asp:BoundField DataField="Product_name" HeaderText="Product Name" />
                <asp:BoundField DataField="Price" HeaderText="Price" />
                <asp:BoundField DataField="Quantity" HeaderText="Quantity" SortExpression="Quantity" />
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>
