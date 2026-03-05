<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Accounts.aspx.cs" Inherits="SQL_Practice.Accounts" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
         <asp:Label ID="lblAccountNumber1" runat="server" />
<asp:Label ID="lblName1" runat="server" />
<asp:Label ID="lblBalance1" runat="server" />
<br /><br />

<asp:Label ID="lblAccountNumber2" runat="server" />
<asp:Label ID="lblName2" runat="server" />
<asp:Label ID="lblBalance2" runat="server" />
<br /><br />

<asp:Button ID="btnTransfer" runat="server" 
    Text="Transfer 100 from A1 to A2" 
    OnClick="btnTransfer_Click" />

<br /><br />
<asp:Label ID="lblMessage" runat="server" ForeColor="Red" />



        </div>
    </form>
</body>
</html>
