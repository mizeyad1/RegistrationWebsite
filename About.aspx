<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="TestingSQLite.About" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <hgroup class="title">
        <h1><%: Title %>.</h1>
        
    </hgroup>

    <article>
        <p>        
           This website manages users and their emails and passwords that are stored in SQLiteDatabase , the Web App uses C# Asp.net as its back end language and HTML,CSS for FrontEnd.
        </p>
    </article>

</asp:Content>