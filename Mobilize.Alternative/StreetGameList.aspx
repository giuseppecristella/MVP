<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="StreetGameList.aspx.cs" Inherits="Mobilize.Alternative.StreetGameList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Repeater ID="rptStreetGames" runat="server">
         <ItemTemplate>
             <%#Eval("Name") %>
         </ItemTemplate>
    </asp:Repeater>
</asp:Content>
