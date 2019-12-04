<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ManageUsers.aspx.cs" Inherits="VoucherTemplates.ManageUsers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="panel panel-success" style="border-radius:0px 0px">
    <div class="panel-body">
     <div class="row">
  
        <div class="col-sm-3"></div>
        <div class="col-sm-8"><asp:Label ID="lblmsg" CssClass="" Font-Bold="True" runat="server" Font-Size="small" ></asp:Label></div>
        <div class="col-sm-1"></div>
                   
                

    </div>
     <div class="row" style="margin-top:20px;">
  
        <div class="col-sm-1"></div>
               <div class="col-sm-3"><asp:Label ID="lblUser" CssClass="" Font-Bold="True" runat="server" Font-Size="small" >Enter Usename:</asp:Label></div>
                <div class="col-sm-5">
                    <a href="ManageUsers.aspx"></a>
                <input type="text" runat="server" class="form-control" id="txtUsername" placeholder="Enter Password" required="required" maxlength="50">      
                </div>
         <div class="col-sm-3"><asp:Button Text="Change Role" ID="btnChange" CssClass="btn btn-danger" runat="server" OnClick="btnChange_Click" Width="140px" BackColor="#E4002B" /></div>

    </div>
     <div class="row">
  
        <div class="col-sm-1"></div>
               <div class="col-sm-3">  <asp:Label ID="Label2" CssClass="" Font-Bold="True" runat="server" Font-Size="small" >Enter Password:</asp:Label></div>
                <div class="col-sm-5">
                    
                <input type="password" runat="server" class="form-control" id="txtPassword" placeholder="Enter Password" required="required" maxlength="50">      
                </div>
         <div class="col-sm-3"><asp:Button Text="Create User" ID="btnCreate" CssClass="btn btn-danger" runat="server" OnClick="btnCreate_Click" Width="140px" BackColor="#E4002B" /></div>

    </div>
     <div class="row">
  
        <div class="col-sm-1"></div>
               <div class="col-sm-3">  <asp:Label ID="Label1" CssClass="" Font-Bold="True" runat="server" Font-Size="small" >User Role:</asp:Label></div>
                <div class="col-sm-5">
                    
                     <asp:DropDownList ID="ddlRole" runat="server" CssClass="form-control" AutoPostBack="False">
                      
                      <asp:ListItem Text="Administrator" Value="Admin" />
                       <asp:ListItem Text="Activator" Value="Activator" />  
                       <asp:ListItem Text="Generator" Value="Generator" />                     
                    </asp:DropDownList>
                </div>
         <div class="col-sm-3"><asp:Button Text="Disable User" ID="btnDisable" CssClass="btn btn-danger" runat="server" OnClick="btnDisable_Click" Width="140px" BackColor="#E4002B" /></div>

    </div>
    <%--<div class="row" style="margin-top:20px;">
     <div class="col-sm-4"><asp:Button Text="Change Role" ID="btnChange" CssClass="btn btn-danger" runat="server" OnClick="btnChange_Click" Width="140px" BackColor="#E4002B" /></div>
         <div class="col-sm-4"><asp:Button Text="Create User" ID="btnCreate" CssClass="btn btn-danger" runat="server" OnClick="btnCreate_Click" Width="140px" BackColor="#E4002B" /></div>          
         <div class="col-md-4"><asp:Button Text="Disable User" ID="btnDisable" CssClass="btn btn-danger" runat="server" OnClick="btnDisable_Click" Width="140px" BackColor="#E4002B" /></div>

    
   </div>--%> 
   </div>
  </div>
</asp:Content>
