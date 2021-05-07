<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Demo_ASP_NET2021_WebForms1.index" EnableViewState="true"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Hello World!</h1>
        </div>
        
        <br />
        Please enter your name:&nbsp;&nbsp;&nbsp; 
        <asp:TextBox ID="nameTxt" runat="server" Width="289px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="sayhelloBtn" runat="server" Text="Say Hello" OnClick="sayhelloBtn_Click" />

        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

        <asp:Label ID="helloLbl" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Button ID="howareyouBtn" runat="server" Text="How are you today?" OnClick="howareyouBtn_Click" />
        
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        
        <asp:Label ID="fineLbl" runat="server"></asp:Label>
    </form>
</body>
</html>
