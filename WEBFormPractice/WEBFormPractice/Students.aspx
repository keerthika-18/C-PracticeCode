<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Students.aspx.cs" Inherits="WEBFormPractice.Students" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:GridView ID="GridView1" runat="server" Height="404px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Width="597px"
           AutoGenerateColumns="False" BackColor="White" BorderColor="White" BorderStyle="Ridge" BorderWidth="2px" CellPadding="3" CellSpacing="1" GridLines="None" >
            <Columns>
                <asp:BoundField DataField="StID" HeaderText="Student ID" />
                <asp:BoundField DataField="Name" HeaderText ="Name"/>
            
            </Columns>

            <FooterStyle BackColor="#C6C3C6" ForeColor="Black" />
            <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#E7E7FF" />
            <PagerStyle BackColor="#C6C3C6" ForeColor="Black" HorizontalAlign="Right" />
            <RowStyle BackColor="#DEDFDE" ForeColor="Black" />
            <SelectedRowStyle BackColor="#9471DE" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#594B9C" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#33276A" />

        </asp:GridView>
       <asp:TextBox ID="Text1" runat="server"></asp:TextBox><asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="GET MARKS" Height="36px" Width="181px" />
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        <br />
        <asp:TextBox ID="Text2" runat="server"></asp:TextBox><asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="GET GRADE" />
            
            <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
            <p>
            &nbsp;</p>
        
    </form>
</body>
</html>
