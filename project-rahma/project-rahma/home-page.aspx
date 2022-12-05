<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home-page.aspx.cs" Inherits="project_rahma.home_page" %>

<!DOCTYPE html>
<meta name="viewport" content="width=device-width, initial-scale=1">
 <link rel="stylesheet" href="bootstrap-5.2.2-dist/css/bootstrap.css">
    <script src="https://kit.fontawesome.com/a8b56cb52b.js" crossorigin="anonymous"></script>
 

<link rel="stylesheet" href="homepag1.css">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <nav class="navbar bg-light">
  <div class="container-fluid">
      <img src="home-images\logo1.PNG"  width="70px" height="" style=" position:absolute; left :10px ; top:5px" alt="no image" />
    <a class="navbar-brand " style="margin-left:7% ; color:#126266 ;"  >PEGASUS</a>
    <form class="d-flex" role="search" >
          <a href ="home-page.aspx"style="text-decoration:none;color: #126266; background-color:aliceblue;margin-right:42px; font-size:large;font-weight:bold; " class="hover"  >Home</a>
                 <a href ="loginpage.aspx"style="text-decoration:none;color: #126266; background-color:aliceblue;margin-right:42px; font-size:large;font-weight:bold; " class="hover"  >Sign in</a>

       <%-- <div class ="batool">batool walid</div>  --%>
    </form>
  </div>
</nav>
    <form id="form1" runat="server">
        <div>
        </div>
    </form>
    <div class="home-box">
        <div class="project-name"> <span>Gateway <span style="color: #126266">Information</span> </span> </div>
        <img  src="home-images\Forms-bro.png" width="60%" height="270px"/>
        <div class="about-us">
            <div class="breif-statement"> Brief about survey<br /></div>
            <div class="breif-paragraph"> <span>Here at Pegasus We always hold our employees to a higher standard.
and as such to improve your experience in the Pegasus workplace, we request that you complete this short survey.

Your Opinion Matters!.
                                          </span></div>   
            
            
        </div>
    </div>

   <br />
       <div class="footer">
           <div style="display:inline-block;"> <img src="home-images\logo1.PNG"  width="15%" height="" style=" position:relative; left :10px ; "/></div>
           <div style="float:right; font-size:30px; margin-left:5px; margin-right:33px;" ><i class="fa-brands fa-facebook fontawsome"></i>
               <i class="fa-brands fa-github fontawsome"></i><i class="fa-solid fa-envelope fontawsome" style="margin-left:10px;"></i>
           </div>
       </div>
  
</body>
</html>
