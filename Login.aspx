<%@ Page Title="" Language="C#" MasterPageFile="~/LoginSite.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="VoucherTemplates.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

      <div class="row">
  
       <%-- <div class="col-sm-1"></div>--%>
               <div class="col-sm-4">  <asp:Label ID="lblUsername" CssClass="" Font-Bold="True" runat="server" Font-Size="small" >Username:</asp:Label></div>
                <div class="col-sm-5">
                     <input type="text" runat="server" class="form-control" id="txtUsename" placeholder="Username" required="required" maxlength="50">                        
                </div>
         <div class="col-sm-1"></div>

    </div>
      <div class="row">
  
        <%--<div class="col-sm-1"></div>--%>
               <div class="col-sm-4">  <asp:Label ID="Label1" CssClass="" Font-Bold="True" runat="server" Font-Size="small" >Password:</asp:Label></div>
                <div class="col-sm-5">
                     <input type="password" runat="server" class="form-control" id="txtPassword" placeholder="Password" required="required" maxlength="50">                       
                </div>
         <div class="col-sm-1"></div>

    </div>

     <div class="row" style="margin-top:30px; margin-bottom:30px">
           <div class="col-sm-4">
               <asp:HyperLink ID="HyperLink1" runat="server" Font-Size="Small" ForeColor="Red" NavigateUrl="~/forgotpassword.aspx">Forgot your Password?</asp:HyperLink>
           </div>
          <div class="col-sm-5"><asp:Button Text="Login" ID="btnLogin" CssClass="btn btn-danger" runat="server" OnClick="btnLogin_Click" Width="240px" BackColor="#E4002B" /></div>          
         <div class="col-md-1"></div>

     </div>
</asp:Content>
