<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="EtatdesVekos.aspx.cs" Inherits="etat_president" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     
  <div class="form-row" style="margin-top:5% ; width:70% ; margin-left:5%">
    <div class="col-md-4 mb-3">
      <label class="text-primary" style="font-size:small" for="validationCustom01" >Matricule :</label>
        <asp:DropDownList class="form-control form-control-sm" ID="DropDownList1" runat="server" style="width:65% ; height:30%"></asp:DropDownList>
        <asp:Button class="btn btn-outline-warning" ID="Button1" runat="server" Text="Recherche"  style="margin-top:2%"/>
        <asp:Button class="btn btn-outline-dark" ID="Button2" runat="server" Text="Imprimer"  style="margin-top:2%"/>

    </div>
      
      </div>
 
    <%--.-------------------------          gridview                       ---------------------------------------------.--%>

    
    <asp:GridView class="table table-striped" ID="GridView1" style="font-size:small" runat="server"   >


    </asp:GridView>


</asp:Content>
