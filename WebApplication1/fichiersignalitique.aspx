<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="fichiersignalitique.aspx.cs" Inherits="WebApplication1.WebForm12" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <nav class="navbar navbar-expand-lg navbar-light bg-light  " style="margin-top:7%"  >
  
 
   
        <li class="nav-item" style="margin-left:5%">
          <a class="text-primary" href="#" tabindex="-1" aria-disabled="true" style="font-size:large "
            >Matricule</a
          >
        </li>
      
          <asp:DropDownList  class="form-control"  placeholder="Type query" aria-label="Search" ID="matricule" runat="server" style="width:20% ; margin-left:2%"  ></asp:DropDownList>
            <asp:RadioButton ID="rbj" runat="server" style="margin-left:1%" AutoPostBack="True" GroupName="type" OnCheckedChanged="RadioButton2_CheckedChanged" /> 
         <label  class="form-check-label" for="exampleRadios1">
        Tout
       </label>

           <a class="text-primary" href="#" tabindex="-1" aria-disabled="true" style="font-size:large ; margin-left:14% "
            >Velo</a >
         
                  <asp:DropDownList  class="form-control"  placeholder="Type query" aria-label="Search" ID="velo" runat="server" style="width:20% ; margin-left:2%" AutoPostBack="True"  ></asp:DropDownList>
               
        <asp:RadioButton ID="rdv" runat="server" style="margin-left:2%" AutoPostBack="True" GroupName="type" OnCheckedChanged="rdv_CheckedChanged" /> 
         <label  class="form-check-label" for="exampleRadios1">
        Tout
       </label>

   
        
 
</nav>
      <nav class="navbar navbar-expand-lg navbar-light bg-light  " style="margin-top:2%"  >
  
 
   
        <li class="nav-item" style="margin-left:5%">
          <a class="text-primary" href="#" tabindex="-1" aria-disabled="true" style="font-size:large "
            >Organisme</a
          >
        </li>
      
          <asp:DropDownList  class="form-control"  placeholder="Type query" aria-label="Search" ID="organisme" runat="server" style="width:20% ; margin-left:2%"  ></asp:DropDownList>
       

           <a class="text-primary" href="#" tabindex="-1" aria-disabled="true" style="font-size:large ; margin-left:1% "
            >Marque</a >
         
                  <asp:DropDownList  class="form-control"  placeholder="Type query" aria-label="Search" ID="Marque" runat="server" style="width:20% ; margin-left:2%"  ></asp:DropDownList>
               
      <a class="text-primary" href="#" tabindex="-1" aria-disabled="true" style="font-size:large ; margin-left:1% "
            >Puissance fiscale </a >
         
                  <asp:DropDownList  class="form-control"  placeholder="Type query" aria-label="Search" ID="puissance" runat="server" style="width:20% ; margin-left:2%"  ></asp:DropDownList>
     

   
       
 
</nav>

       <nav class="navbar navbar-expand-lg navbar-light bg-light  " style="margin-top:%"  >
  
 
   
        <li class="nav-item" style="margin-left:5%">
          <a class="text-primary" href="#" tabindex="-1" aria-disabled="true" style="font-size:large "
            >TSVA</a
          >
        </li>
      
          <asp:DropDownList  class="form-control"  placeholder="Type query" aria-label="Search" ID="TSVA" runat="server" style="width:20% ; margin-left:2%" AutoPostBack="True" OnSelectedIndexChanged="TSVA_SelectedIndexChanged"  ></asp:DropDownList>
       
            <asp:Button ID="Button2" class="btn btn-secondary" runat="server" style="margin-left:30%" Text="Imprimer" OnClick="Button2_Click" />
        

   
       
 
</nav>
    <asp:GridView class="table table-striped" ID="GridView1" style="font-size:small ; margin-top:5%" runat="server">

    </asp:GridView>

</asp:Content>
