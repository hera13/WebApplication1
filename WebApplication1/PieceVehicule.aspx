<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="PieceVehicule.aspx.cs" Inherits="WebApplication1.WebForm5" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <p class="font-weight-bolder" style="font-size:x-large ; margin-left:45% ; margin-top:8%"><strong>Piece Vehicule</strong></p>

  <div class="form-group" style="margin-top:3% ; width:40% ; margin-left:30%">
    <label class="text-primary" for="exampleInputEmail1">Numero Piece : </label>
      <asp:DropDownList  class="form-control" ID="DropDownList1" runat="server"></asp:DropDownList>
  </div>
  <div class="form-group" style=" width:40% ; margin-left:30%">
    <label class="text-primary" for="exampleInputPassword1">Piece :</label>
    <input type="text" class="form-control" id="piece" runat="server" >
  </div>

    <asp:Button ID="Button1" class="btn btn-outline-primary" style="margin-left:40%" runat="server" Text="Ajouter" OnClick="Button1_Click" />

    <asp:Button ID="Button3" class="btn btn-outline-secondary" runat="server" Text="Suppremier" OnClick="Button3_Click" />



        <p class="font-weight-bolder" style="font-size:x-large ; margin-left:45% ; margin-top:8%"><strong> Fourmisseur</strong></p>

  <div class="form-group" style="margin-top:3% ; width:40% ; margin-left:30%">
    <label class="text-primary" for="exampleInputEmail1">Fourmisseur : </label>
      <asp:DropDownList  class="form-control" ID="DropDownList2" runat="server"></asp:DropDownList>
  </div>
  <div class="form-group" style=" width:40% ; margin-left:30%">
    <label class="text-primary" for="exampleInputPassword1">Ajouter Fourmisseur  :</label>
    <input type="text" class="form-control" id="Text2" runat="server" >
  </div>


    <asp:Button ID="Button5" runat="server" class="btn btn-outline-primary" style="margin-left:40%"   Text="Ajouter" onclick="Button5_Click" />
    <asp:Button ID="Button4" runat="server"   class="btn btn-outline-primary"  Text="Supprimer" OnClick="Button4_Click" />
   





   


   
</asp:Content>
