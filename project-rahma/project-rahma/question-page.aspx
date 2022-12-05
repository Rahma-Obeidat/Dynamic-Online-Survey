<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="question-page.aspx.cs" Inherits="project_rahma.question_page" %>





<!DOCTYPE html>
<meta name="viewport" content="width=device-width, initial-scale=1">
 <link rel="stylesheet" href="bootstrap-5.2.2-dist/css/bootstrap.css">
    <script src="https://kit.fontawesome.com/a8b56cb52b.js" crossorigin="anonymous"></script>
 

<link rel="stylesheet" href="question-page.css">

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
      <button class="btn btn-outline-success nav-bar" type="submit"><a href ="home-page.aspx"style="text-decoration:none;color: #126266;"  >Home</a></button>
        <button class="btn btn-outline-success nav-bar" type="submit"><a href ="home-page.aspx" style="text-decoration:none;color: #126266;" >Logout</a></button>
      <%--   <div class ="batool">batool walid</div>  --%>
    </form>
  </div>
</nav>

    <br />
      <div  style=" background-color: #F4F4F4; height:3050px ; margin-top:0px;">
      <form id="form1" runat="server">
            
    <div class="employee-id-date" >
      
        <div class="id"><span>-Employee ID:</span></div>
            <asp:Label ID="Label1" runat="server" Text="ID-employee"></asp:Label>
            <br />
             <div class="date"><span>-Date:</span></div>
            <asp:Label ID="Label2" runat="server" Text="Date of Survey"></asp:Label>
           </div>
 


          
            <div class="question-box">
                <div class="question-text-style">
                <asp:Label ID="Label3" runat="server" Text="Label">Question1</asp:Label>
                    <br />
                    <br />
                     <asp:Label ID="Label4" runat="server" Text="Label">Question</asp:Label>
                    </div>
                  <div class="button-style">
                     <%-- <asp:Button ID="Button1" runat="server" Text="Poor" OnClick="Button1_Click" />
                      <asp:Button ID="Button2" runat="server" Text="Good" OnClick="Button2_Click1" />
                      <asp:Button ID="Button3" runat="server" Text="Very Good" OnClick="Button3_Click" />
                      <asp:Button ID="Button4" runat="server" Text="Excellent" OnClick="Button4_Click" />--%>
                        <asp:RadioButton ID="RadioButton1" runat="server" Text="Poor" GroupName="Q1" OnCheckedChanged="RadioButton1_CheckedChanged" />
                      <asp:RadioButton ID="RadioButton2" runat="server" Text="Good" GroupName="Q1" OnCheckedChanged="RadioButton2_CheckedChanged" />
                      <asp:RadioButton ID="RadioButton3" runat="server" Text="Very Good"  GroupName="Q1" OnCheckedChanged="RadioButton3_CheckedChanged" />
                      <asp:RadioButton ID="RadioButton4" runat="server" Text="Excellent"  GroupName="Q1" OnCheckedChanged="RadioButton4_CheckedChanged"/>
                     
                        <div style="height: 22px">  
            
        </div>  
                        
                </div>
                </div>

<%--        question2--%>
           <div class="question-box">
                <div class="question-text-style">
                <asp:Label ID="Label5" runat="server" Text="Label">Question2</asp:Label>
                    <br />
                    <br />
                     <asp:Label ID="Label6" runat="server" Text="Label">Question</asp:Label>
                    </div>
                  <div class="button-style">
                   <asp:RadioButton ID="RadioButton5" runat="server" Text="Poor" GroupName="Q2" OnCheckedChanged="RadioButton5_CheckedChanged" />
                      <asp:RadioButton ID="RadioButton6" runat="server" Text="Good" GroupName="Q2" OnCheckedChanged="RadioButton6_CheckedChanged" />
                      <asp:RadioButton ID="RadioButton7" runat="server" Text="Very Good"  GroupName="Q2" OnCheckedChanged="RadioButton7_CheckedChanged" />
                      <asp:RadioButton ID="RadioButton8" runat="server" Text="Excellent"  GroupName="Q2" OnCheckedChanged="RadioButton8_CheckedChanged"/>
             
                         
                </div>
                </div>
          


      <%--  question3--%>
           <div class="question-box">
                <div class="question-text-style">
                <asp:Label ID="Label7" runat="server" Text="Label">Question3</asp:Label>
                    <br />
                    <br />
                     <asp:Label ID="Label8" runat="server" Text="Label">Question</asp:Label>
                    </div>
                  <div class="button-style">
                    <asp:RadioButton ID="RadioButton9" runat="server" Text="Poor" GroupName="Q3" OnCheckedChanged="RadioButton9_CheckedChanged" />
                      <asp:RadioButton ID="RadioButton10" runat="server" Text="Good" GroupName="Q3" OnCheckedChanged="RadioButton10_CheckedChanged" />
                      <asp:RadioButton ID="RadioButton11" runat="server" Text="Very Good"  GroupName="Q3" OnCheckedChanged="RadioButton11_CheckedChanged" />
                      <asp:RadioButton ID="RadioButton12" runat="server" Text="Excellent"  GroupName="Q3" OnCheckedChanged="RadioButton12_CheckedChanged"/>
             
                         
                </div>
                </div>

         <%-- question4--%>
           <div class="question-box">
                <div class="question-text-style">
                <asp:Label ID="Label9" runat="server" Text="Label">Question4</asp:Label>
                    <br />
                    <br />
                     <asp:Label ID="Label10" runat="server" Text="Label">Question</asp:Label>
                    </div>
                  <div class="button-style">
                    <asp:RadioButton ID="RadioButton13" runat="server" Text="Poor" GroupName="Q4" OnCheckedChanged="RadioButton13_CheckedChanged" />
                      <asp:RadioButton ID="RadioButton14" runat="server" Text="Good" GroupName="Q4" OnCheckedChanged="RadioButton14_CheckedChanged" />
                      <asp:RadioButton ID="RadioButton15" runat="server" Text="Very Good"  GroupName="Q4" OnCheckedChanged="RadioButton15_CheckedChanged" />
                      <asp:RadioButton ID="RadioButton16" runat="server" Text="Excellent"  GroupName="Q4" OnCheckedChanged="RadioButton16_CheckedChanged"/>
             
                         
                </div>
                </div>

            <%-- question5--%>
           <div class="question-box">
                <div class="question-text-style">
                <asp:Label ID="Label11" runat="server" Text="Label">Question5</asp:Label>
                    <br />
                    <br />
                     <asp:Label ID="Label12" runat="server" Text="Label">Question</asp:Label>
                    </div>
                  <div class="button-style">
                   <asp:RadioButton ID="RadioButton17" runat="server" Text="Poor" GroupName="Q5" OnCheckedChanged="RadioButton17_CheckedChanged" />
                      <asp:RadioButton ID="RadioButton18" runat="server" Text="Good" GroupName="Q5" OnCheckedChanged="RadioButton18_CheckedChanged" />
                      <asp:RadioButton ID="RadioButton19" runat="server" Text="Very Good"  GroupName="Q5" OnCheckedChanged="RadioButton19_CheckedChanged" />
                      <asp:RadioButton ID="RadioButton20" runat="server" Text="Excellent"  GroupName="Q5" OnCheckedChanged="RadioButton20_CheckedChanged"/>
             
                         
                </div>
                </div>

            <%-- question6--%>
           <div class="question-box">
                <div class="question-text-style">
                <asp:Label ID="Label13" runat="server" Text="Label">Question6</asp:Label>
                    <br />
                    <br />
                     <asp:Label ID="Label14" runat="server" Text="Label">Question</asp:Label>
                    </div>
                  <div class="button-style">
                   <asp:RadioButton ID="RadioButton21" runat="server" Text="Poor" GroupName="Q6" OnCheckedChanged="RadioButton21_CheckedChanged" />
                      <asp:RadioButton ID="RadioButton22" runat="server" Text="Good" GroupName="Q6" OnCheckedChanged="RadioButton22_CheckedChanged" />
                      <asp:RadioButton ID="RadioButton23" runat="server" Text="Very Good"  GroupName="Q6" OnCheckedChanged="RadioButton23_CheckedChanged" />
                      <asp:RadioButton ID="RadioButton24" runat="server" Text="Excellent"  GroupName="Q6" OnCheckedChanged="RadioButton24_CheckedChanged"/>
             
                         
                </div>
                </div>

            <%-- question7--%>
           <div class="question-box">
                <div class="question-text-style">
                <asp:Label ID="Label15" runat="server" Text="Label">Question7</asp:Label>
                    <br />
                    <br />
                     <asp:Label ID="Label16" runat="server" Text="Label">Question</asp:Label>
                    </div>
                  <div class="button-style">
                   <asp:RadioButton ID="RadioButton25" runat="server" Text="Poor" GroupName="Q7" OnCheckedChanged="RadioButton25_CheckedChanged" />
                      <asp:RadioButton ID="RadioButton26" runat="server" Text="Good" GroupName="Q7" OnCheckedChanged="RadioButton26_CheckedChanged" />
                      <asp:RadioButton ID="RadioButton27" runat="server" Text="Very Good"  GroupName="Q7" OnCheckedChanged="RadioButton27_CheckedChanged" />
                      <asp:RadioButton ID="RadioButton28" runat="server" Text="Excellent"  GroupName="Q7" OnCheckedChanged="RadioButton28_CheckedChanged"/>
             
                         
                </div>
                </div>

            <%-- question8--%>
           <div class="question-box">
                <div class="question-text-style">
                <asp:Label ID="Label17" runat="server" Text="Label">Question8</asp:Label>
                    <br />
                    <br />
                     <asp:Label ID="Label18" runat="server" Text="Label">Question</asp:Label>
                    </div>
                  <div class="button-style">
                   <asp:RadioButton ID="RadioButton29" runat="server" Text="Poor" GroupName="Q8" OnCheckedChanged="RadioButton29_CheckedChanged" />
                      <asp:RadioButton ID="RadioButton30" runat="server" Text="Good" GroupName="Q8" OnCheckedChanged="RadioButton30_CheckedChanged" />
                      <asp:RadioButton ID="RadioButton31" runat="server" Text="Very Good"  GroupName="Q8" OnCheckedChanged="RadioButton31_CheckedChanged" />
                      <asp:RadioButton ID="RadioButton32" runat="server" Text="Excellent"  GroupName="Q8" OnCheckedChanged="RadioButton32_CheckedChanged"/>
             
                         
                </div>
                </div>

          <%--  <%-- question9--%>
           <div class="question-box">
                <div class="question-text-style">
                <asp:Label ID="Label19" runat="server" Text="Label">Question9</asp:Label>
                    <br />
                    <br />
                     <asp:Label ID="Label20" runat="server" Text="Label">Question</asp:Label>
                    </div>
                  <div class="button-style">
                    <asp:RadioButton ID="RadioButton33" runat="server" Text="Poor" GroupName="Q9" OnCheckedChanged="RadioButton33_CheckedChanged" />
                      <asp:RadioButton ID="RadioButton34" runat="server" Text="Good" GroupName="Q9" OnCheckedChanged="RadioButton34_CheckedChanged" />
                      <asp:RadioButton ID="RadioButton35" runat="server" Text="Very Good"  GroupName="Q9" OnCheckedChanged="RadioButton35_CheckedChanged" />
                      <asp:RadioButton ID="RadioButton36" runat="server" Text="Excellent"  GroupName="Q9" OnCheckedChanged="RadioButton36_CheckedChanged"/>
             
                         
                </div>
                </div>

          <%-- question 10--%>
           <div class="question-box">
                <div class="question-text-style">
                <asp:Label ID="Label21" runat="server" Text="Label">Question 10</asp:Label>
                    <br />
                    <br />
                     <asp:Label ID="Label22" runat="server" Text="Label">Question</asp:Label>
                    </div>
                  <div class="button-style">
                    <asp:RadioButton ID="RadioButton37" runat="server" Text="Poor" GroupName="Q10" OnCheckedChanged="RadioButton37_CheckedChanged" />
                      <asp:RadioButton ID="RadioButton38" runat="server" Text="Good" GroupName="Q10" OnCheckedChanged="RadioButton38_CheckedChanged" />
                      <asp:RadioButton ID="RadioButton39" runat="server" Text="Very Good"  GroupName="Q10" OnCheckedChanged="RadioButton39_CheckedChanged" />
                      <asp:RadioButton ID="RadioButton40" runat="server" Text="Excellent"  GroupName="Q10" OnCheckedChanged="RadioButton40_CheckedChanged"/>
             
                         
                </div>
                </div>
                 
            <asp:Button ID="Button41" runat="server" Text="Submit" class="submit-button" OnClick="Button41_Click" />
                
            </form>          
           </div> 
  

   


     
     <div class="footer">
           <div style="display:inline-block;"> <img src="home-images\logo1.PNG"  width="15%" height="" style=" position:relative; left :10px ; "/></div>
           <div style="float:right; font-size:30px; margin-left:5px; margin-right:33px;" ><i class="fa-brands fa-facebook fontawsome"></i>
               <i class="fa-brands fa-github fontawsome"></i><i class="fa-solid fa-envelope fontawsome" style="margin-left:10px;"></i>
           </div>
       </div>
</body>
</html>
