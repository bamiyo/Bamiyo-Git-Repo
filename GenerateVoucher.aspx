<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="GenerateVoucher.aspx.cs" Inherits="VoucherTemplates.GenerateVoucher" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
  


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
     <div class="panel panel-success" style="border-radius:0px 0px">
    <div class="panel-body">
    <div class="row">
  
        <div class="col-sm-1"></div>
        <div class="col-sm-10">
        <asp:Label ID="lblInfo" CssClass="text-danger" Font-Bold="True" runat="server" Font-Size="small" >Specify the required parameters then click the "Generate Button"</asp:Label>
        </div>
        <div class="col-sm-1"></div>

    </div>
     <div class="row">
  
        <div class="col-sm-1"></div>
               <div class="col-sm-3">  <asp:Label ID="lblBatch" CssClass="" Font-Bold="True" runat="server" Font-Size="small" >BatchNo:</asp:Label></div>
                <div class="col-sm-5">
                     <asp:Label ID="lblBatchNo" CssClass="" Font-Bold="True" runat="server" Font-Size="small" ></asp:Label>                  
                </div>
         <div class="col-sm-1"></div>

    </div>
     <div class="row">
  
        <div class="col-sm-1"></div>
               <div class="col-sm-3">  <asp:Label ID="Label1" CssClass="" Font-Bold="True" runat="server" Font-Size="small" >Voucher Type:</asp:Label></div>
                <div class="col-sm-5">
                    
                     <asp:DropDownList ID="ddlVoucherType" runat="server" CssClass="form-control" AutoPostBack="False">
                      
                      <asp:ListItem Text="Select Voucher Type" Value="Select Voucher Type" />
                       <asp:ListItem Text="Card Voucher" Value="Card Voucher" />  
                       <asp:ListItem Text="e-Voucher" Value="e-Voucher" />                     
                    </asp:DropDownList>
                </div>
         <div class="col-sm-1"></div>

    </div>
     <div class="row">
  
        <div class="col-sm-1"></div>
               <div class="col-sm-3">  <asp:Label ID="Label2" CssClass="" Font-Bold="True" runat="server" Font-Size="small" >No of Vouchers:</asp:Label></div>
                <div class="col-sm-5">
                    
                <input type="text" runat="server" class="form-control" id="txtVoucherNo" placeholder="Number of Vouchers" required="required" maxlength="50">      
                </div>
         <div class="col-sm-1"></div>

    </div>
     <div class="row">
  
        <div class="col-sm-1"></div>
               <div class="col-sm-3">  <asp:Label ID="Label3" CssClass="" Font-Bold="True" runat="server" Font-Size="small" >Voucher Value:</asp:Label></div>
                <div class="col-sm-5">
                  <asp:DropDownList ID="ddlVoucherValue" runat="server" CssClass="form-control" AutoPostBack="False">
                      
                      <asp:ListItem Text="Select Voucher Value" Value="Select Voucher Value" />
                       <asp:ListItem Text="500" Value="500" />  
                       <asp:ListItem Text="1000" Value="1000" />  
                       <asp:ListItem Text="2000" Value="2000" />  
                       <asp:ListItem Text="5000" Value="5000" /> 
                       <asp:ListItem Text="10000" Value="10000" />  
                       <asp:ListItem Text="15000" Value="15000" /> 
                       <asp:ListItem Text="20000" Value="20000" />                                      
                    </asp:DropDownList>   
                     
                </div>
         <div class="col-sm-1"></div>

    </div>
     <div class="row">
  
        <div class="col-sm-1"></div>
               <div class="col-sm-3">  <asp:Label ID="Label4" CssClass="" Font-Bold="True" runat="server" Font-Size="small" >Comment/Reason:</asp:Label></div>
                <div class="col-sm-5">
                    <asp:TextBox ID="txtComment" runat="server" style="width:224px;height:100px;" TextMode="MultiLine"></asp:TextBox>
                 <%--  <textarea name="Comment" id="Comment" cols="50" rows="10" style="width:240px;height:150px;"></textarea>--%>  
                </div>
         <div class="col-sm-1"></div>

    </div>
     <div class="row" style="margin-top:30px; margin-bottom:30px">
           <div class="col-sm-4"></div>
          <div class="col-sm-7"><asp:Button Text="Generate Voucher" ID="btnGenerate" CssClass="btn btn-danger" runat="server" OnClick="btnGenerate_Click" Width="240px" BackColor="#E4002B" /></div>          
         <div class="col-md-1"></div>

     </div>

        </div>
           </div>
      </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
