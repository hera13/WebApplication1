﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="WebApplication1.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
<script src="//netdna.bootstrapcdn.com/bootstrap/3.0.0/js/bootstrap.min.js"></script>
<script src="//code.jquery.com/jquery-1.11.1.min.js"></script>
    <style>
        /*
 * Globals
 */
/* Links */
a,
a:focus,
a:hover {
  color: #fff;
}

/* Custom default button */
.btn-default {
  color: #fff;
  text-shadow: none;
  /* Prevent inheritence from `body` */
  background-color: transparent;
  border: 2px solid #fff;
  border-radius: 20px;
  padding: 0.5rem 2rem;
}

.btn-default:hover,
.btn-default:focus {
  background-color: rgba(255, 255, 255, 0.3);
}

/*
 * Base structure
 */
html,
body {
  height: 100%;
}

body {

  background: url( 'pic/bss2.jpeg') no-repeat center center fixed;
  background-size: cover;
  color: #fff;
  text-align: center;
  font-family: 'Quicksand', sans-serif;
  font-size:18px !important;
}

.cover-copy{
    color:#fff !important ;
}

.btn-notify{
    border:2px solid #fff !important;
}



/* Extra markup and styles for table-esque vertical and horizontal centering */
.site-wrapper {
  display: table;
  width: 100%;
  height: 100%;
  /* For at least Firefox */
  min-height: 100%;
  background: rgba(48, 53, 70, 0.5);
  box-shadow: inset 0 0 100px rgba(0, 0, 0, 0.5);
}

.site-wrapper-inner {
  display: table-cell;
  vertical-align: top;
}

.cover-container {
  margin-right: auto;
  margin-left: auto;
}

/* Padding for spacing */
.inner {
  padding: 30px;
}

/*
 * Header
 */
.masthead-brand {
  margin-top: 10px;
  margin-bottom: 10px;
  color:#fff !important;
}

.nav-masthead {
  text-align: center;
  display: block;
  color:#fff !important;
}

.nav-masthead .nav-link {
  display: inline-block;
  color:#fff !important;

}

@media (min-width: 768px) {
  .masthead-brand {
    float: left;
  }
  .nav-masthead {
    float: right;
  }
}

/*
 * Cover
 */
.cover {
  padding: 0 20px;
}

.cover .btn-notify {
  padding: 10px 60px;
  font-weight: 500;
  text-transform: uppercase;
  border-radius: 40px;
}

.cover-heading {
  font-weight: 500;
  text-transform: uppercase;
  letter-spacing: 10px;
  font-size: 2rem;
  margin-bottom: 15px !important;
}

.sub-header{
    font-size: 23px;
    letter-spacing:6px;
    color:#fff !important;
}

   .cover-heading
   {
        color:#fff !important;
   }

@media (min-width: 768px) {
  .cover-heading {
    font-size: 3.4rem;
    letter-spacing: 15px;
  }
}

.cover-copy {
  max-width: 500px;
  margin: 0 auto 3rem;
}

/*
 * Footer
 */
.mastfoot {
  color: #999;
  /* IE8 proofing */
  color: rgba(255, 255, 255, 0.5);
}

/*
 * Subscribe modal box
 */
#subscribeModal .modal-content {
  background-color: #303546;
  color: #fff;
  text-align: left;
}

#subscribeModal .modal-header, #subscribeModal .modal-footer {
  border: 0;
}

#subscribeModal .close {
  color: #fff;
}

#subscribeModal .form-control {
  margin-top: 1rem;
  background: rgba(0, 0, 0, 0.4);
  color: #fff;
}

#subscribeModal .form-control:focus {
  border-color: #49506a;
}

/*
 * Affix and center
 */
@media (min-width: 768px) {
  /* Pull out the header and footer */
  .masthead {
    position: fixed;
    top: 0;
  }
  .mastfoot {
    position: fixed;
    bottom: 0;
  }
  /* Start the vertical centering */
  .site-wrapper-inner {
    vertical-align: middle;
  }
  /* Handle the widths */
  .masthead,
  .mastfoot,
  .cover-container {
    width: 100%;
    /* Must be percentage or pixels for horizontal alignment */
  }
}

@media (min-width: 992px) {
  .masthead,
  .mastfoot,
  .cover-container {
    width: 1060px;
  }
}

    </style>
</head>
<body>
        <link href="//netdna.bootstrapcdn.com/bootstrap/3.0.0/css/bootstrap.min.css" rel="stylesheet" id="bootstrap-css">


    
     <head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title> Digital Vibrant | Coming Soon </title>

    <!-- Google fonts --->
    <link href="https://fonts.googleapis.com/css?family=Quicksand:300,400,500,700" rel="stylesheet">

    <!-- Bootstrap & font awesome Css ---->
    <link href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-alpha.6/css/bootstrap.min.css" rel="stylesheet">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">

    <!-- Custom Css ---->
    <link href="styles/main.css" rel="stylesheet">

    <!-- Fevicon Add ---->
    <link rel="icon" href="img/fevicon.ico" type="image/ico" sizes="16x16">

  </head>
  <body id="top"><div class="site-wrapper">
  <div class="site-wrapper-inner">
<%--    <div class="cover-container">
      <div class="masthead clearfix">
        <div class="inner">
          <h3 class="masthead-brand"> Your Logo </h3>
          <nav class="nav nav-masthead">
            <a class="nav-link nav-social" href="#"><i class="fa fa-facebook" aria-hidden="true"></i></a>
            <a class="nav-link nav-social" href="#"><i class="fa fa-twitter" aria-hidden="true"></i></a>
            <a class="nav-link nav-social" href="#"><i class="fa fa-google-plus" aria-hidden="true"></i></a>
            <a class="nav-link nav-social" href="#"><i class="fa fa-linkedin" aria-hidden="true"></i></a>
          </nav>
        </div>

      </div>--%>
     <%--    <img src="pic/bss2.jpeg" />--%>
      <br>
      <div class="inner cover">
        <h1 class="cover-heading">ROYAUME DU MAROC</h1>
        <h5 class="sub-header"> MINISTÈRE DE L'INTÉRIEUR </h5>
        <br>
        <p class="lead cover-copy">
           Service du parc-Auto et engins.</p>
            <p class="lead">
               <a href="Login.aspx"><button type="button" class="btn btn-lg btn-default btn-notify" data-toggle="modal" runat="server" id="btn" data-target="#subscribeModal">SE CONNECTER </button></p></a> 
      </div>
<%--<img src="images/bss2.jpg" />--%>
     <%-- <div class="mastfoot">
        <div class="inner">
            <p>© Angi for informatique .</p>
        </div>
      </div>--%>
  </div>
</div>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-alpha.6/js/bootstrap.min.js"></script>
  </body>


    <form id="form1" runat="server">
        <div>
        </div>
    </form>
</body>
</html>
