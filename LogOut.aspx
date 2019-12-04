<%@ Page Title="" Language="C#" MasterPageFile="~/LogOut.Master" AutoEventWireup="true" CodeBehind="LogOut.aspx.cs" Inherits="VoucherTemplates.LogOut" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="panel panel-success" style="border-radius:0px 0px">
        <div class="panel-header">
            <span> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Label ID="lblInfo" CssClass="text-danger" Font-Bold="True" runat="server" Font-Size="medium">Your Session has Ended. Click the Login in button to continue using the Application!!!</asp:Label></span>
        </div>
        <div class="panel-body">
            <span>
               
            </span>
        </div>
    </div>
</asp:Content>
