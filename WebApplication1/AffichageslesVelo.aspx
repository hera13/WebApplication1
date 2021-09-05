<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AffichageslesVelo.aspx.cs" Inherits="WebApplication1.WebForm8" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


          <%--..----------------------      Rechercher par    --------------------------------------------------------------%>
              <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.6.0/jquery.min.js"></script> 
    <script src="https://cdnjs.cloudflare.com/ajax/libs/chosen/1.8.7/chosen.jquery.min.js"></script>
    <link href="https://cdnjs.cloudflare.com/ajax/libs/chosen/1.8.7/chosen.css" rel="stylesheet" />
           <%--..----------------------      Rechercher par    --------------------------------------------------------------%>
 <p class="font-italic" style="margin-top:5% ; margin-left:15%">Recherch par :</p>

    <%--.---------------------------------------       this for textBox 1 ,2 , 3    -----------------------------------------------%>

  <div class="form-row" style=" width:30% ; margin-left:2% ; " >
    <div class="col-md-4 mb-3">
      <label class="text-primary" for="validationCustom01" style="font-size:small" >Matricule:</label>
       <asp:DropDownList class="form-control" ID="Matricule" runat="server" style="height:50%" AutoPostBack="True" OnSelectedIndexChanged="Matricule_SelectedIndexChanged"></asp:DropDownList>  
     
    </div>
    <div class="col-md-4 mb-3">
      <label class="text-primary" for="validationCustom02" style="font-size:small">Organisme</label>
        <asp:DropDownList class="form-control" ID="Organisme" runat="server" style="height:50% ; width:390px" AutoPostBack="True" OnSelectedIndexChanged="Organisme_SelectedIndexChanged"></asp:DropDownList>   
    </div>


    </div>

     <%--.---------------------------------------       this for textBox 4 ,5 , CHECKBOX    -----------------------------------------------%>

    <div class="form-row" style=" width:30% ; margin-left:2% ; margin-top:"">
        
       <div class="col-md-4 mb-3">
      <label class="text-primary" for="validationCustom02" style="font-size:small ; margin-top:-1.5%">Marque :</label>
      
                   <asp:DropDownList class="form-control" ID="Marque" runat="server" style="height:45% ;  margin-top:-1.5%" AutoPostBack="True" OnSelectedIndexChanged="Marque_SelectedIndexChanged" ></asp:DropDownList>   

    </div>
   

            <div class="col-md-4 mb-3">
                
    </div>
    <div class="col-md-4 mb-3">
       <asp:Button ID="Button6" class="btn btn-dark" runat="server" Text="Affecher Tout" style="margin-left:1%; margin-top:30px " OnClick="Button6_Click" />


    </div>
        </div>
    






    <%--..----------------------             this for part les informations       --------------------------------------------------------------%>


    <p class="font-italic" style="margin-top:-3% ; margin-left:55%">Les Information :</p>

        <%--..----------------------     this for texbox 1,2,3--------------------------------------------------------------%>

      <div class="form-row" style=" width:30% ; margin-left:65% ; margin-top:-14% " >
    <div class="col-md-4 mb-3">
      <label class="text-primary" for="validationCustom01" style="font-size:small" >Immatriculation:</label>
     
        <asp:TextBox ID="immat" class="form-control" runat="server" style="height:45%" ReadOnly="True" OnTextChanged="immat_TextChanged" ></asp:TextBox>
     
    </div>
    <div class="col-md-4 mb-3">
      <label class="text-primary" for="validationCustom02" style="font-size:small">date mise en service</label>
        
        <asp:TextBox ID="date" runat="server" TextMode="Date" class="form-control" style="height:45%" OnTextChanged="date_TextChanged"></asp:TextBox>
    </div>

       <div class="col-md-4 mb-3">
      <label class="text-primary" for="validationCustom02" style="font-size:small">Marque </label>
      
           <asp:TextBox class="form-control" ID="marque_M" runat="server" style="height:45%" OnTextChanged="marque_M_TextChanged"></asp:TextBox>
    </div>
    </div>

    <%--..----------------------     this for texbox 4,5,6--------------------------------------------------------------%>

    <div class="form-row" style=" width:30% ; margin-left:65% ; margin-top:-1.5% ">
    <div class="col-md-4 mb-3">
      <label class="text-primary" for="validationCustom01" style="font-size:small" >Type</label>
      
        <asp:TextBox class="form-control" ID="type_M" runat="server" style="height:45%" OnTextChanged="type_M_TextChanged"></asp:TextBox>
     
    </div>
    <div class="col-md-4 mb-3">
      <label class="text-primary" for="validationCustom02" style="font-size:small">Numero de cagre</label>
      <asp:TextBox class="form-control" ID="NDG_M" runat="server" style="height:45%" OnTextChanged="NDG_M_TextChanged"></asp:TextBox>
    </div>

   <div class="col-md-4 mb-3">
      <label class="text-primary" for="validationCustom02" style="font-size:small">Genre</label>
     
            <asp:DropDownList class="form-control" ID="genre_M" runat="server" style="height:45%" ></asp:DropDownList>  

    </div>
    </div>


    <%--..----------------------     this for texbox 7,8,9--------------------------------------------------------------%>
    
    <div class="form-row" style=" width:30% ; margin-left:65% ; margin-top:-1.5%">
    <div class="col-md-4 mb-3">
      <label class="text-primary" for="validationCustom01" style="font-size:small" >Puissance fiscal</label>
  <asp:TextBox class="form-control" ID="PF_M" runat="server" style="height:45%" OnTextChanged="PF_M_TextChanged"></asp:TextBox>
     
    </div>
    <div class="col-md-4 mb-3">
      <label class="text-primary" for="validationCustom02" style="font-size:small">Carbulant</label>
     <asp:DropDownList class="form-control" ID="Carbulant_M" runat="server" style="height:50%" OnSelectedIndexChanged="Carbulant_M_SelectedIndexChanged"></asp:DropDownList>  
    </div>

   <div class="col-md-4 mb-3">
      <label class="text-primary" for="validationCustom02" style="font-size:small">Tsva</label>
      <asp:TextBox class="form-control" ID="tsva_M" runat="server" style="height:45%"></asp:TextBox> 
    </div>
    </div>




    <%--..----------------------     this for texbox 10 , 11 , 12--------------------------------------------------------------%>
    
    <div class="form-row" style=" width:30% ; margin-left:65% ; margin-top:-1.5%">
    <div class="col-md-4 mb-3">
          <label class="text-primary" for="validationCustom02" style="font-size:small">Organisme</label>
       <asp:DropDownList class="form-control" ID="Organisme_M" runat="server" style="height:50%" OnSelectedIndexChanged="Organisme_M_SelectedIndexChanged"></asp:DropDownList>  
  
     
    </div>
    <div class="col-md-4 mb-3">
      <label class="text-primary" for="validationCustom02" style="font-size:small">Service</label>
      <asp:DropDownList class="form-control" ID="serv_M" runat="server" style="height:50%" OnSelectedIndexChanged="serv_M_SelectedIndexChanged"></asp:DropDownList>  
    </div>

 
    </div>

    <%--..----------------------     this for texbox Button  UPDATE , DELETE , EMPTY     --------------------------------------------------------------%>
  
      <div class="form-row" style=" width:30% ; margin-left:67% ; margin-top:-1%">
         <%-- --------------------------- MODIFER ---------------------------------------------.--%>
    <div class="col-md-4 mb-3">
        <asp:Button class="btn btn-outline-success" ID="Button1" runat="server"  Text="Modifier" OnClick="Button1_Click"   />
    </div>
            <%-- --------------------------- SUPPREMIER ---------------------------------------------.--%>
    <div class="col-md-4 mb-3" >
        <asp:Button class="btn btn-outline-danger" ID="Button2" runat="server" Text="Supprimer" OnClick="Button2_Click"  />
    </div>
            <%-- --------------------------- VIDER ---------------------------------------------.--%>
   <div class="col-md-4 mb-3">
       <asp:Button class="btn btn-outline-dark" ID="Button3" runat="server" Text="Vidier" OnClick="Button3_Click" />
    </div>
    </div>





    <%--.------------------------------------------- GRIDVIEW ------------------------------------------------------------------------.--%>


  <p class="font-weight-bold">Vehicule en Pammes</p>
    <asp:GridView class="table table-striped" ID="GridView1" runat="server" OnSelectedIndexChanging="GridView1_SelectedIndexChanging" >
   
        <Columns>
            <asp:CommandField ShowSelectButton="True" />
        </Columns>


    </asp:GridView>


         <script>
             $('#<%=Matricule.ClientID%>').chosen();
             $('#<%=Organisme.ClientID%>').chosen();
         </script>



    </asp:GridView>



</asp:Content>
