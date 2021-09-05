<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AffectationDesVelo.aspx.cs" Inherits="WebApplication1.WebForm7" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

      <%--.-------------------------------------------   PAGE FOR BUTTON AJOUTER       ---------------------------------------------.--%>
   
    <p class="font-weight-bold" style="margin-top:7% ; margin-left:41%">Affictation des VELO</p>

      <%-- ---------------------------------- textbox: 1 ,2 ,3 -------------------------------------------------------------------.--%>
   <form class="needs-validation" novalidate>
  <div class="form-row" style="margin-top:3% ; width:70% ; margin-left:15%">
    <div class="col-md-4 mb-3">
      <label class="text-primary" >Immatriculation :</label>
      <input type="text" class="form-control"   runat="server" id="Immatriculation"   >
    </div>

    <div class="col-md-4 mb-3">
      <label class="text-primary" for="validationCustom02">Date mise en service :</label>
        <asp:TextBox class="form-control" ID="date"  runat="server"   type="date"  ></asp:TextBox>
    </div>

       <div class="col-md-4 mb-3">
      <label class="text-primary" for="validationCustom02">Marque :</label>
 
             <asp:DropDownList class="form-control"  runat="server" ID="Marque" ></asp:DropDownList>
    </div>
    </div>
  </div>

            <%-- ---------------------------------- textbox: 4 ,5 ,6 -------------------------------------------------------------------.--%>

         <div class="form-row" style=" width:70% ; margin-left:15% ; margin-top:1%">
    <div class="col-md-4 mb-3">
      <label class="text-primary" for="validationCustom01">Type :</label>
      
          <asp:DropDownList class="form-control"  runat="server" ID="type" ></asp:DropDownList>

    </div>
    <div class="col-md-4 mb-3">
      <label class="text-primary" for="validationCustom02">Numero de cadre :</label>
      <input type="text" class="form-control"  runat="server" id="Numero_de_cadre" >
   
    </div>
       <div class="col-md-4 mb-3">
      <label class="text-primary" for="validationCustom02">Genre :</label>
   
             <asp:DropDownList class="form-control"  runat="server" ID="Genre" ></asp:DropDownList>
     
    </div>
      
    </div>
  </div>


            <%-- ---------------------------------- textbox: 7 ,8 ,9 -------------------------------------------------------------------.--%>
        
         <div class="form-row" style=" width:70% ; margin-left:15%  ; margin-top:1%">
    <div class="col-md-4 mb-3">
      <label class="text-primary" for="validationCustom01">Puissance fiscale :</label>
   
                <asp:TextBox class="form-control" ID="puissance"  runat="server"   type="text"  ></asp:TextBox>


    </div>
    <div class="col-md-4 mb-3">
      <label class="text-primary" for="validationCustom02">Caburant :</label>
       <asp:DropDownList class="form-control"  runat="server" ID="Caburant" ></asp:DropDownList>
    </div>

       <div class="col-md-4 mb-3">
      <label class="text-primary" for="validationCustom02">TSVA :</label>
      <input type="text" class="form-control"  runat="server" id="TSVA" > 
    </div>
      
    </div>



            <%-- ---------------------------------- textbox: 10 ,11 ,12 -------------------------------------------------------------------.--%>
        
     <div class="form-row" style=" width:70% ; margin-left:15%  ; margin-top:1%">
    <div class="col-md-4 mb-3">
      <label class="text-primary" for="validationCustom01">Organisme :</label>
      <asp:DropDownList class="form-control"  runat="server" ID="Organisme" ></asp:DropDownList>
    </div>

    <div class="col-md-4 mb-3">
      <label class="text-primary" for="validationCustom02">Service :</label>
   
          <asp:DropDownList class="form-control"  runat="server" ID="Service" ></asp:DropDownList>
    </div>

       <div class="col-md-4 mb-3">
      <label class="text-primary" for="validationCustom02">Nom Compte :</label>
      <input type="text" class="form-control"  runat="server" id="Compte" >
    </div>
      
    </div>

            <%-- ---------------------------------- textbox: This for button ADD -------------------------------------------------------------------.--%>
       <asp:Button ID="Button1"  class="btn btn-outline-primary" runat="server" Text="Ajouter" style="margin-left:25% ; width:50%" OnClick="Button1_Click" />
    


</form>



</asp:Content>
