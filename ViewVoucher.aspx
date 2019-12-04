<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ViewVoucher.aspx.cs" Inherits="VoucherTemplates.ViewVoucher" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style>label {
  margin-left: -80px;
  font-size:small;
}</style>

   <%-- css for gridview--%>
 <style>
   
  .alt-row{background-color: #FF9999;}
  .empty-row{background-color: red; color:green;}
</style>
    
     <link href="Boostrapp/bootstrap.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <asp:UpdateProgress ID="UpdateProgress1" runat="server">
        <ProgressTemplate>
          
            <div style="position: fixed; text-align: center; height: 100%; width: 100%; top: 0; right: 0; left: 0; z-index: 9999999; background-color: #000000; opacity: 0.7;">
            <asp:Image ID="imgUpdateProgress" runat="server" ImageUrl="~/images/loading.gif" AlternateText="Loading ..." ToolTip="Loading ..." style="padding: 10px;position:fixed;top:45%;left:50%;" />
        </div>
        </ProgressTemplate>
    </asp:UpdateProgress>
  
    <asp:UpdatePanel ID="UpdatePanel1" runat="server"><ContentTemplate>
  <div class="row">
        <div class="col-sm-4">

   
    <div class="panel panel-success" style="border-radius:0px 0px">
    <div class="panel-header">
        <div class="row">
         <%--<div class="col-sm-2">
          <asp:Label ID="lblBatch" CssClass="text-danger" Font-Bold="True" runat="server" Font-Size="small" >Batch:</asp:Label>
          </div>--%>
        <div class="col-sm-10">
            <asp:DropDownList ID="ddlBatches" runat="server" CssClass="form-control" AutoPostBack="True"  OnSelectedIndexChanged="ddlBatches_SelectedIndexChanged">  
                    <%--  <asp:ListItem Text="Select Batch" Value="Select Voucher Type" />--%>
                                           
                     </asp:DropDownList>
        </div>
        <div class="col-sm-2">

              <%-- <asp:Button Text="Refresh" ID="btnRefresh" CssClass="btn btn-danger" runat="server" OnClick="btnRefresh_Click" Width="60px" Height="35px" BackColor="#E4002B" Font-Size="Small" />--%>
         </div>
            

      
       </div> 
     </div>
      </div>
       
  
    </div>
        <div class="col-sm-8">
   <div class="panel panel-success" style="border-radius:0px 0px">
    <div class="panel-header">
        <div class="row">
        <div class="col-sm-1">
        <asp:Label ID="lblCount" CssClass="" Font-Bold="True" runat="server" Font-Size="small" >No:</asp:Label>
        </div>
        <div class="col-sm-2">
        <asp:Label ID="lblCountNo" CssClass="text-danger" Font-Bold="True" runat="server" Font-Size="small" ></asp:Label>

        </div>
        <div class="col-sm-2">
        <asp:Label ID="lblGenerated" CssClass="" Font-Bold="True" runat="server" Font-Size="small" >Creator:</asp:Label>
           
        </div>
        <div class="col-sm-2">
        <asp:Label ID="lblGneratorName" CssClass="text-danger" Font-Bold="True" runat="server" Font-Size="small" ></asp:Label>
           
        </div>
        <div class="col-sm-2">
        <asp:Label ID="lblDate" CssClass="" Font-Bold="True" runat="server" Font-Size="small" >Date:</asp:Label>
           
        </div>
        <div class="col-sm-3">
        <asp:Label ID="lblDateGnerarted" CssClass="text-danger" Font-Bold="True" runat="server" Font-Size="small" ></asp:Label>
           
        </div>    

        </div>
     </div>
      </div>
   </div>
   
    </div>

    <div class="panel panel-success" style="border-radius:0px 0px">
    <div class="panel-header">
      <div class="row">
          <div class="col-sm-3">
                <input type="text" runat="server" class="form-control" id="txtVoucher" placeholder="Search Vouchers" maxlength="50"> 
          </div>
          <div class="col-sm-1">
          
           <asp:Button Text="Search" ID="btnSearch" CssClass="btn btn-danger" runat="server" OnClick="btnSearch_Click" Width="60px" Height="35px" BackColor="#E4002B" Font-Size="Small" />
          </div>
          <div class="col-sm-8">
          
             <%-- <input type="radio" name="beds" value="1" style="margin-left: 0; margin-right:0"/>1+
              <input type="radio" name="beds" value="2" style="margin-left: 0; margin-right:0"/>2+--%>

              <%--<input type="radio" name="search" value="serial" id="RBSerial" /><label for="RBSerial">Search by Serial</label>
              <input type="radio" name="search" value="pin" id="RBPin" /><label for="RBPin">Search by Pin</label>--%>
              <asp:RadioButtonList ID="RBSearchVoucher" runat="server" RepeatDirection="Horizontal" CellPadding="1" CellSpacing="1" RepeatLayout="Flow" >
                  <asp:ListItem>Pin</asp:ListItem>
                  <asp:ListItem>Serial</asp:ListItem>
              </asp:RadioButtonList>
          </div>
      </div>
    </div>
     
    </div>

     <div class="panel panel-success" style="border-radius:0px 0px;" >
    <div class="panel-header">
        <div class="row">
            <div class="col-sm-2"></div>
            <div class="col-sm-8"><asp:Label ID="lblInfo" CssClass="" Font-Bold="True" runat="server" Font-Size="Medium" ></asp:Label></div>
            <div class="col-sm-2"></div>
        </div>

   <div style="width: 640px; height: 400px; overflow: scroll">
        <asp:GridView ID="GridView" CssClass="ReportGrid" runat="server" AutoGenerateColumns="False" RowStyle-BackColor="#FFFFFF"
            AlternatingRowStyle-CssClass="alt-row" HeaderStyle-Font-Size="10px" HeaderStyle-BackColor="#E4002B" HeaderStyle-ForeColor="White" ShowFooter="True" HeaderStyle-Height="30px">
                    
                    <Columns>
                        <asp:BoundField DataField="Status" HeaderText="Availability" ItemStyle-Width="300px" ItemStyle-Height="20px">
                            <ItemStyle Width="300px"></ItemStyle>
                        </asp:BoundField>
                        <asp:BoundField DataField="CustomerID" HeaderText="Customer ID" ItemStyle-Width="300px" ItemStyle-Height="20px" ReadOnly="True">
                            <ItemStyle Width="300px"></ItemStyle>
                        </asp:BoundField>
                        <asp:BoundField DataField="Voucherstatus" HeaderText="Status" ItemStyle-Width="300px" ItemStyle-Height="20px">
                            <ItemStyle Width="300px"></ItemStyle>
                        </asp:BoundField>
                        <asp:BoundField DataField="SerialNo" HeaderText="Serial No" ItemStyle-Width="300px" ItemStyle-Height="20px" ReadOnly="True">
                            <ItemStyle Width="300px"></ItemStyle>
                        </asp:BoundField>
                        <asp:BoundField DataField="Voucher" HeaderText="Voucher" ItemStyle-Width="300px" ItemStyle-Height="20px">
                            <ItemStyle Width="300px"></ItemStyle>
                        </asp:BoundField>
                        <asp:BoundField DataField="Value" HeaderText="Value" ItemStyle-Width="300px" ItemStyle-Height="20px">
                            <ItemStyle Width="300px"></ItemStyle>
                        </asp:BoundField>
                        <asp:BoundField DataField="BatchName" HeaderText="Batch Name" ItemStyle-Width="300px" ItemStyle-Height="20px">
                            <ItemStyle Width="300px"></ItemStyle>
                        </asp:BoundField>
                        
                    </Columns>
                    <HeaderStyle BackColor="#E4002B" ForeColor="White"></HeaderStyle>

                    <RowStyle BackColor=""></RowStyle>
                </asp:GridView>
    </div>
        <asp:Button Text="Email Voucher to Printer" ID="BtnPrinter" CssClass="btn btn-danger" runat="server" OnClick="BtnPrinter_Click" Width="180px" Height="35px" BackColor="#E4002B" Font-Size="Small" />
    </div> 
    </div>

    
        </ContentTemplate>
    </asp:UpdatePanel>
    
</asp:Content>


 