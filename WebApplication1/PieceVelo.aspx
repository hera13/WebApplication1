<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="PieceVelo.aspx.cs" Inherits="WebApplication1.WebForm10" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <p class="font-weight-bolder" style="font-size:x-large ; margin-left:45% ; margin-top:8%"><strong>Piece Velo</strong></p>

  <div class="form-group" style="margin-top:3% ; width:40% ; margin-left:30%">
    <label class="text-primary" for="exampleInputEmail1">Numero Piece : </label>
      <asp:DropDownList  class="form-control" ID="DropDownList1" runat="server"></asp:DropDownList>
  </div>
  <div class="form-group" style=" width:40% ; margin-left:30%">
    <label class="text-primary" for="exampleInputPassword1">Piece :</label>
    <input type="text" class="form-control" id="exampleInputPassword1" >
  </div>

    <asp:Button ID="Button1" class="btn btn-outline-primary" style="margin-left:40%" runat="server" Text="Ajouter" />
    <asp:Button ID="Button2" class="btn btn-outline-success" runat="server" Text="Modifier" />
    <asp:Button ID="Button3" class="btn btn-outline-secondary" runat="server" Text="Suppremier" />
   



</asp:Content>
