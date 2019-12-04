<%@ Page Title="" Language="C#" MasterPageFile="~/LogOut.Master" AutoEventWireup="true" CodeBehind="oops.aspx.cs" Inherits="VoucherTemplates.oops" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="panel panel-success" style="border-radius:0px 0px">
    <div class="panel-header">
        <div class="row">
           <%-- <div class="col-sm-1">--%>
        <div class="col-sm-12">
        <asp:Label ID="lblCount" CssClass="" Font-Bold="True" runat="server" Font-Size="medium" >Oops!!!! Your session has Expired. Log in to continue!!!</asp:Label>
        </div>
       <%--  <div class="col-sm-1">--%>
      <%-- </div>
        </div>--%>
               </div>
              </div>
              </div>
</asp:Content>
