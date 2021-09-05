<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Etatdesvehicules.aspx.cs" Inherits="WebApplication1.WebForm6" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
               <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.6.0/jquery.min.js"></script> 
    <script src="https://cdnjs.cloudflare.com/ajax/libs/chosen/1.8.7/chosen.jquery.min.js"></script>
    <link href="https://cdnjs.cloudflare.com/ajax/libs/chosen/1.8.7/chosen.css" rel="stylesheet" />


 
  <div class="form-row" style="margin-top:5% ; width:70% ; margin-left:5%">
    <div class="col-md-4 mb-3">
      <label class="text-primary" style="font-size:small" for="validationCustom01" >Matricule :</label>
        <asp:DropDownList class="form-control form-control-sm" ID="DropDownList1" runat="server" style="width:65% ; height:30%" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged"></asp:DropDownList>
        <asp:Button class="btn btn-outline-warning" ID="Button1" runat="server" Text="AfficherTout" OnClick="Button1_Click"/>
        <asp:Button class="btn btn-outline-dark" ID="Button2" runat="server" Text="Imprimer"  style="margin-top:2%" OnClick="Button2_Click"/>

    </div>
      
      </div>
 
    <%--.-------------------------          gridview                       ---------------------------------------------.--%>

    
    <asp:GridView class="table table-striped" ID="GridView1" style="font-size:small" runat="server"   >


    </asp:GridView>
  
      <script>
          $('#<%=DropDownList1.ClientID%>').chosen();
      </script>

</asp:Content>
