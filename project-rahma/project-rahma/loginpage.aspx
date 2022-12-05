<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="loginpage.aspx.cs" Inherits="project_rahma.loginpage" %>




<!DOCTYPE html>
<meta name="viewport" content="width=device-width, initial-scale=1">
 <link rel="stylesheet" href="bootstrap-5.2.2-dist/css/bootstrap.css">
    <script src="https://kit.fontawesome.com/a8b56cb52b.js" crossorigin="anonymous"></script>
 

<link rel="stylesheet" href="loginpage.css">
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
     <%-- <button class="btn btn-outline-success nav-bar" type="submit">--%>
          <a href ="home-page.aspx"style="text-decoration:none;color: #126266; background-color:aliceblue;margin-right:42px; font-size:large;font-weight:bold; " class="hover"  >Home</a>
       <%-- <button class="btn btn-outline-success nav-bar" type="submit">Sign in</button>--%>
       <%-- <div class ="batool">batool walid</div>  --%>
    </form>
  </div>
</nav>
     <%-- <h4 style=" margin-top:2%;margin-left:22% ; font-weight:bold; color:#126266;">Login</h4>--%>
    <div class="contain"> 
        
        <div class="container-login">
         
             <form id="form1" runat="server">
      <%-- <div class="username" > --%>
                <%-- </div>--%>
       
               <h4 style=" position:absolute;top:12%;left:37% ; font-weight:bold; color:#126266;font-size:xx-large">Login</h4>
<asp:Label ID="Label1" runat="server" Text="ID" style="position:absolute; top:23%; left:12% ; font-weight:bold; color:#126266;font-size:x-large;" ></asp:Label>
                 <asp:TextBox ID="TextBox1" runat="server" class="username" placeholder="enter your id"></asp:TextBox>

                 <asp:Label ID="Label2" runat="server" Text="Password" style="position:absolute; top:50%; left:12% ;font-size:x-large; font-weight:bold; color:#126266;" ></asp:Label>
                 <asp:TextBox ID="TextBox2" runat="server" class="username1" placeholder="enter your password" type="password"></asp:TextBox>
  
               
             
                 <asp:Label ID="Label3" runat="server" Text="Label"  style="position:absolute ; left:30% ; bottom:20%; color:red; font-size:small; " Visible="False"></asp:Label>
                   <asp:Button ID="Button1" runat="server" Text="Login"  style="position:absolute;background-color:#126266; color:white; left:40% ; top :80%;padding:13px;font-size:large ;border-radius:12px; border: solid #126266 2px; " OnClick="Button1_Click"/>
             </form>
            
        </div>
          <div class="login-image" > <img src="login-images\loginimage.PNG" style="color: #FF0000"   /></div>
       
    </div>
   
   


  
     <div class="footer">
           <div style="display:inline-block;"> <img src="home-images\logo1.PNG"  width="15%" height="" style=" position:relative; left :10px ; "/></div>
           <div style="float:right; font-size:30px; margin-left:5px; margin-right:33px;" ><i class="fa-brands fa-facebook fontawsome"></i>
               <i class="fa-brands fa-github fontawsome"></i><i class="fa-solid fa-envelope fontawsome" style="margin-left:10px;"></i>
           </div>
       </div>
     
</body>
</html>
