<%@ Page Title="Services" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Services.aspx.cs" Inherits="Demo_ASP_NET2021_WebForms3.Services" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">
        <div>
            <h2>List of services</h2>
            <div>
                Here is what we can offer you:
            <ul>
                <li>Web development
                </li>
                <li>Mobile development</li>
                <li>Cloud hosting</li>
            </ul>
            </div>
        </div>
        <div runat="server" id="contactForm">
            <h2>Please get in-touch for more details:</h2>
            <div class="m-3">
                Your Name&nbsp;&nbsp;&nbsp;&nbsp;
             <asp:TextBox ID="nameTxt" runat="server" Width="241px"></asp:TextBox>
            </div>
            <div class="m-3">
                Your email &nbsp;&nbsp;&nbsp;&nbsp;
             <asp:TextBox ID="emailTxt" runat="server" Width="241px" AutoCompleteType="Email"></asp:TextBox>
            </div>

            <div class="m-3">
                <asp:Button ID="submit" runat="server" Text="Submit" OnClick="submit_Click" />
            </div>
        </div>
        <div runat="server" id="successMsg" visible="False">
            <div class="m-3">
                <h3>
                    Thank you for contacting us. Will get back to you soon.
                </h3>
            </div>
        </div>

    </div>
</asp:Content>
