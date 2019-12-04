<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="dashboard.aspx.cs" Inherits="VoucherTemplates.dashboard" %>

<asp:Content runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
    <div class="panel panel-success" style="border-radius:0px 0px">
        <div class="panel-header">
            <span></span>
        </div>
        <div class="panel-body">
            <span>
               
                <asp:Label ID="lblInfo" CssClass="text-danger" Font-Bold="True" runat="server" Font-Size="medium">Welcome <%= Session["User_Name"]%> you are logged on at <%= Session["Date"]%>.</asp:Label>
            </span>
        </div>
    </div>
</asp:Content>
