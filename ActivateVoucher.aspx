<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ActivateVoucher.aspx.cs" Inherits="VoucherTemplates.ActivateVoucher" %>
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
        <div class="col-sm-7">

   
    <div class="panel panel-success" style="border-radius:0px 0px">
    <div class="panel-header">
        <div class="row">
         <%--<div class="col-sm-2">
          <asp:Label ID="lblBatch" CssClass="text-danger" Font-Bold="True" runat="server" Font-Size="small" >Batch:</asp:Label>
          </div>--%>
        <div class="col-sm-5">
            <asp:DropDownList ID="ddlBatches" runat="server" CssClass="form-control" AutoPostBack="True"  OnSelectedIndexChanged="ddlBatches_SelectedIndexChanged">  
   
                                           
                     </asp:DropDownList>
        </div>
        <div class="col-sm-3">

               <asp:Button Text="Activate" ID="btnActivate" CssClass="btn btn-danger" runat="server" OnClick="btnActivate_Click" Width="65px" Height="35px" BackColor="#E4002B" Font-Size="Small" />
         </div>
          <div class="col-sm-4">

               <asp:Button Text="DeActivate" ID="btnDeactivate" CssClass="btn btn-danger" runat="server" OnClick="btnDeactivate_Click" Width="80px" Height="35px" BackColor="#E4002B" Font-Size="Small" />
         </div>   

      
       </div> 
     </div>
      </div>
    </div>
        <div class="col-sm-5">
   <div class="panel panel-success" style="border-radius:0px 0px">
    <div class="panel-header">
        <div class="row">
        
            <div class="col-sm-12">
             <input type="text" runat="server" class="form-control" id="txtFrom" placeholder="Enter from range" required="required" maxlength="50" style="width:150px; height:25px;">  </br>                      
            
                 <input type="text" runat="server" class="form-control" id="txtTo" placeholder="Enter To range" required="required" maxlength="50" style="width:150px;height:25px;">                        
             </div>
            <%--<div class="col-sm-6"><asp:DropDownList ID="ddlSerial" runat="server" CssClass="form-control" AutoPostBack="True"></asp:DropDownList> </div>
                
                <asp:Label ID="lblText" CssClass="" Font-Bold="true" runat="server" Font-Size="small" >Select Range:</asp:Label>--%>
        </div>
     </div>
      </div>
   </div>
   
    </div>

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
        <asp:Label ID="lblGenerated" CssClass="" Font-Bold="True" runat="server" Font-Size="small" >Created By:</asp:Label>
           
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

     <div class="panel panel-success" style="border-radius:0px 0px;" >
    <div class="panel-header">
        <div class="row">
            <div class="col-sm-3"></div>
            <div class="col-sm-8"><asp:Label ID="lblInfo" CssClass="" Font-Bold="True" runat="server" Font-Size="small" ></asp:Label></div>
            <div class="col-sm-1"></div>
        </div>

   <div style="width: 640px; height: 400px; overflow: scroll">
        <asp:GridView ID="GridView" CssClass="ReportGrid" runat="server" AutoGenerateColumns="False" RowStyle-BackColor="#FFFFFF" OnRowDataBound="GridView_RowDataBound"
            AlternatingRowStyle-CssClass="alt-row" HeaderStyle-Font-Size="10px" HeaderStyle-BackColor="#E4002B" HeaderStyle-ForeColor="White" ShowFooter="True" HeaderStyle-Height="30px" >
                    
                    <AlternatingRowStyle CssClass="alt-row" />
                    
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
                       <%-- <asp:TemplateField HeaderText="No."><ItemTemplate><%#Container.DataItemIndex+1%></ItemTemplate>
                        <ItemStyle Width="8%" /></asp:TemplateField>   xmlns:asp="#unknown"--%>
                        <asp:TemplateField HeaderText="No"><ItemTemplate><asp:Label ID="lblSerial" runat="server"></asp:Label></ItemTemplate></asp:TemplateField>

                    </Columns>

                    <HeaderStyle BackColor="#E4002B" ForeColor="White"></HeaderStyle>

                    <RowStyle BackColor=""></RowStyle>
                </asp:GridView>
    </div>
     
    </div> 
    </div>

    
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
