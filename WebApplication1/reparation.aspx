<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="reparation.aspx.cs" Inherits="WebApplication1.WebForm4" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
                 <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.6.0/jquery.min.js"></script> 
    <script src="https://cdnjs.cloudflare.com/ajax/libs/chosen/1.8.7/chosen.jquery.min.js"></script>
    <link href="https://cdnjs.cloudflare.com/ajax/libs/chosen/1.8.7/chosen.css" rel="stylesheet" />
      <%-- --------------------------- Ajouter une Vehicule en pannes ---------------------------------------------.--%>

     <p class="font-italic" style="margin-top:5% ; margin-left:5%">Ajouter une Vehicule en pannes :</p>



  <div class="form-row" style=" width:30% ; margin-left:3% ; " >
    <div class="col-md-4 mb-3">
      <label class="text-primary" for="validationCustom01" style="font-size:small" >Matricule:</label>
      <asp:DropDownList class="form-control" ID="DropDownList3" runat="server" style="height:50%" OnSelectedIndexChanged="DropDownList3_SelectedIndexChanged"></asp:DropDownList>  
     
    </div>
        <div class="col-md-4 mb-3">
        <asp:TextBox class="form-control" ID="TextBox2" style="margin-top:25px" runat="server"  rows="7"></asp:TextBox>
    </div>    
     
    </div>

      <%----------------------------------------------------------------------------------------------------------------..--%>
    
               
    
  <div class="form-row" style=" width:60% ; margin-left:3% ; height:25% ; margin-top:-1% " >
    <div class="col-md-4 mb-3">
      <asp:ListBox ID="ListBox1" runat="server"></asp:ListBox>
    </div>     
    
      
            <div class="col-md-4 mb-3" style="margin-right:250px ; margin-top:4%">
                <asp:Button class="btn btn-secondary" ID="Button8" runat="server" Text="Ajouter" OnClick="Button8_Click" />
    </div>   
         <div class="col-md-4 mb-3" style="margin-right:">
      <label class="text-primary" for="validationCustom02" style="font-size:small">Probleme:</label>
        <asp:DropDownList class="form-control" ID="DropDownList1" runat="server" style="height:53% ;width:250px ; margin-left: "></asp:DropDownList>   
    </div>
    </div>

    <%----------------------------------------------------------------------------------------------------------------..--%>
  <div class="form-row" style=" width:30% ; margin-left:3% ; margin-top:-1.5% " >
    <div class="col-md-4 mb-3">
      <label class="text-primary" for="validationCustom01" style="font-size:small" >Kilomitrage:</label>
      
        <asp:TextBox ID="Kilomitrage" runat="server" class="form-control" style="height:45%"></asp:TextBox>
       
    </div>

       <div class="col-md-4 mb-3" >
      <label class="text-primary" for="validationCustom01" style="font-size:small" >Date d'entrer:</label>
       <asp:TextBox class="form-control" ID="date_entree"  runat="server"  placeholder="Last name" style="width:200px" TextMode="Date"  ></asp:TextBox>
    </div>
      </div>
  
     <%----------------------------------------------------------------------------------------------------------------..--%>
    <div class="form-row" style=" width:60% ; margin-left:3% ; margin-top:-1.5% " >
    <div class="col-md-4 mb-3">
      <label class="text-primary" for="validationCustom01" style="font-size:small" >Fournisseur:</label>
        <asp:DropDownList class="form-control" ID="DropDownList4" runat="server" style="height:53%"></asp:DropDownList>
    </div>
        <div class="col-md-4 mb-3" style="margin-left:400px ; margin-top:1%">
      <label class="text-primary" for="validationCustom01" style="font-size:small ; margin-left:20%" >Total des Article:</label>
            <asp:Label ID="Label1" runat="server" Text="0" class="text-primary" for="validationCustom01" style="font-size:small ; margin-left:20%"></asp:Label>
    </div>
        </div>
 

    <%-- ---------------------------       this for button ADD , MODIFER , Supprimer , vider ---------------------------------------------.--%>

    <div style="margin-left:3% ">
        <%-- --------------------------- Ajouter ---------------------------------------------.--%>
        <asp:Button  class="btn btn-outline-primary" ID="Button1" runat="server" Text="Ajouter" OnClick="Button1_Click" />
        <%-- --------------------------- Mofifier ---------------------------------------------.--%>
        <asp:Button class="btn btn-outline-success" ID="Button2" runat="server" Text="Mofifier" OnClick="Button2_Click" />
        <%-- --------------------------- Supprimer ---------------------------------------------.--%>
        <asp:Button class="btn btn-outline-danger" ID="Button3" runat="server" Text="Supprimer"  OnClick="Button3_Click" />
        <%-- --------------------------- recherche---------------------------------------------.--%>
        <asp:Button class="btn btn-outline-dark" ID="Button4" runat="server" Text="Rechaerch" OnClick="Button4_Click" />
         <%-- --------------------------- Vider---------------------------------------------.--%>
        <asp:Button class="btn btn-outline-dark" ID="Button6" runat="server" Text="Vider" OnClick="Button6_Click1"  />
    </div>



      <%----------------------------------------------------------       Reparation     ------------------------------------------------------..--%>

    


    
     <%--  -------------------------------------------------- textbox 1 , date--------------------------------------------------  ..--%>
  
  <div class="form-row" style=" width:30% ; margin-left:45% ; margin-top:-30% " >
       <label class="font-italic" for="validationCustom01" style="font-size:large ; margin-top:4% ; margin-right:7%"   >Reparation:</label>

    <div class="col-md-4 mb-3">
         <label class="text-primary" for="validationCustom01" style="font-size:small "  >Matricule:</label>
      <asp:DropDownList class="form-control" ID="DropDownList2" runat="server" style="height:50% ; margin-left:2%"></asp:DropDownList>  
    </div>

    <div class="col-md-4 mb-3" style="margin-left:2%" >
      <label class="text-primary" for="validationCustom01" style="font-size:small" >Date d'sortee:</label>
               <asp:TextBox class="form-control" ID="date_S"  runat="server"  placeholder="Last name" style="width:200px" TextMode="Date"  ></asp:TextBox>
           <asp:Button ID="Button9"  runat="server" Text="Repair" class="btn btn-dark" style="margin-left=10px; margin-bottom=20px ; margin-top:3%" OnClick="Button9_Click" />

    </div>
  
    </div>

  

 <%--  -------------------------------------------------- textbox 1--------------------------------------------------  ..--%>
   

    <div class="form-row" style=" width:50% ; margin-left:50% ; margin-top:" >
    <div class="col-md-4 mb-3">
      <label class="text-primary" for="validationCustom01" style="font-size:small" >Service :</label>
        <asp:DropDownList class="form-control" ID="DropDownList5" runat="server"  style="height:53% ;width:400px"></asp:DropDownList>
     
    </div>
        </div>
    <asp:Button ID="Button7" runat="server" Text="Impremer" OnClick="Button7_Click1" class="btn btn-primary"   style="margin-left:60% ; margin-top:-1% ; width:7%" />
   
     <%--  -------------------------------------------------- textbox 1--------------------------------------------------  ..--%>

     
    

 



   <%-- .     -------------------------------------------------  grdview ----------------------------------------------..--%>
    <br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br />
    <p class="font-weight-bold" style="margin-left:2%">Vehicule en Pammes</p>
    <asp:GridView class="table table-striped" ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" OnSelectedIndexChanging="GridView1_SelectedIndexChanging"   >
        <Columns>
            <asp:CommandField ShowSelectButton="True" />
        </Columns>


    </asp:GridView>

        <script>
            $('#<%=DropDownList3.ClientID%>').chosen();
            $('#<%=DropDownList1.ClientID%>').chosen();
            $('#<%=DropDownList2.ClientID%>').chosen();
            $('#<%=DropDownList4.ClientID%>').chosen();
            $('#<%=DropDownList5.ClientID%>').chosen();
        </script>

</asp:Content>
