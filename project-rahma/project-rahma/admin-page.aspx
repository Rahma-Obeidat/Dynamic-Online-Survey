<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="admin-page.aspx.cs" Inherits="project_rahma.admin_page" %>


<!DOCTYPE html>
<meta name="viewport" content="width=device-width, initial-scale=1">
 <link rel="stylesheet" href="bootstrap-5.2.2-dist/css/bootstrap.css">
    <script src="https://kit.fontawesome.com/a8b56cb52b.js" crossorigin="anonymous"></script>
 

<link rel="stylesheet" href="admin-page.css">



<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>

    <nav class="navbar bg-light">
  <div class="container-fluid">
      <img src="home-images\logo1.PNG"   style=" position:absolute; width:70px; left :10px ; top:5px" alt="no image" />
    <a class="navbar-brand " style="margin-left:7% ; color:#126266 ;"  >PEGASUS</a>
    <form class="d-flex" role="search" >
      <button class="btn btn-outline-success nav-bar" type="submit"><a href ="home-page.aspx"style="text-decoration:none;color: #126266;"  >Home</a></button>
        <button class="btn btn-outline-success nav-bar" type="submit"><a href ="home-page.aspx" style="text-decoration:none;color: #126266;" >Logout</a></button>
       <%-- <div class ="batool">batool walid</div>  --%>
    </form>
  </div>
</nav>
    <div style="background-color: #F4F4F4;">
    <div class="welcomeAdmin"><span style="color:black;">Welcome </span>Alex</div>

    <div style="display:inline-block; margin-left:10%" ><img  src="home-images\Admin-bro.png" width="100%" height="550px"/> </div>
    <div style="display:inline-block; margin-left:5%">
        <h4>What You Can do ?</h4>
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/survey-results.aspx" class="hyperlink">-See all employee's Survey. </asp:HyperLink>
        <br />
        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/addQuestions.aspx"  class="hyperlink">-Create Survey.</asp:HyperLink>
        
    </div>
</div>




    <form id="form1" runat="server">
        <div>
        </div>
    </form>


    
     <div class="footer">
           <div style="display:inline-block;"> <img src="home-images\logo1.PNG"  width="15%" height="" style=" position:relative; left :10px ; "/></div>
           <div style="float:right; font-size:30px; margin-left:5px; margin-right:33px;" ><i class="fa-brands fa-facebook fontawsome"></i>
               <i class="fa-brands fa-github fontawsome"></i><i class="fa-solid fa-envelope fontawsome" style="margin-left:10px;"></i>
           </div>
       </div>
</body>
</html>