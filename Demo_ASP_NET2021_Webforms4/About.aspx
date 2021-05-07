<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="Demo_ASP_NET2021_Webforms4.About" %>
<%@ MasterType VirtualPath="Site.Master" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Your application description page.</h3>
    <p>Use this area to provide additional information.</p>
    <p>
        <asp:LinkButton ID="likeLnk" runat="server" CssClass="bi bi-hand-thumbs-up-fill text-decoration-none" style="font-size: 1.5rem;" OnClick="likeLnk_Click">
            Like
        </asp:LinkButton>
        
    
</asp:Content>
