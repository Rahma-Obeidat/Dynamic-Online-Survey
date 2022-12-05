<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addQuestions.aspx.cs" Inherits="project_rahma.addQuestions" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="addQuestionsstylesheet.css"/>
    
</head>
<body>

 
    <form id="form1" runat="server">
        <div class="container">
           
            <div class="table">

                <div class="adminhead">
                    <h2 > Admin page </h2>
            <p>welcome MOATH, <br /> Here you can add the survey questions  </p>
                </div> 

            <table style="width: 100%;">
                <tr>
                    <td>Question1</td>
                    <td><asp:TextBox ID="TextBox1" CssClass="TextBox" runat="server"></asp:TextBox></td>
                   
                </tr>
                <tr></tr> <tr></tr> <tr></tr>
                <tr>
            <td> Question2</td>
                    <td><asp:TextBox ID="TextBox2" CssClass="TextBox" runat="server"></asp:TextBox></td>
                   
                </tr>

                  <tr></tr> <tr></tr> <tr></tr> <tr></tr>

                <tr >
                    <td> <asp:Label ID="Label2" runat="server" Text="Question3"></asp:Label></td>
                    <td><asp:TextBox ID="TextBox3" CssClass="TextBox" runat="server" ></asp:TextBox></td>
                    
                </tr>

                 <tr></tr> <tr></tr> <tr></tr> <tr></tr>

                <tr >
                   
                    <td> <asp:Label ID="Label1" runat="server" Text="Question4" style="" ></asp:Label></td>
                    <td><asp:TextBox ID="TextBox4" CssClass="TextBox" runat="server" ></asp:TextBox></td>
                    
                </tr>
                

                 <tr></tr> <tr></tr> <tr></tr> <tr></tr>
                
                   
                   <tr>
                    <td>Question5</td>
                    <td><asp:TextBox ID="TextBox5" CssClass="TextBox" runat="server"></asp:TextBox></td>
                    
                </tr>
                 <tr></tr> <tr></tr> <tr></tr> <tr></tr>
                <tr>
                    <td>Question6</td>
                    <td><asp:TextBox ID="TextBox6" CssClass="TextBox" runat="server"></asp:TextBox></td>
                    
                </tr>
                 <tr></tr> <tr></tr> <tr></tr> <tr></tr>
                <tr>
                    <td>Question7</td>
                    <td><asp:TextBox ID="TextBox7" CssClass="TextBox" runat="server"></asp:TextBox></td>
                    
                </tr>
                 <tr></tr> <tr></tr> <tr></tr> <tr></tr>
                <tr>
                    <td>Question8</td>
                    <td><asp:TextBox ID="TextBox8" CssClass="TextBox" runat="server"></asp:TextBox></td>
                    
                </tr>
                 <tr></tr> <tr></tr> <tr></tr> <tr></tr>
                <tr>
                    <td>Question9</td>
                    <td><asp:TextBox ID="TextBox9" CssClass="TextBox" runat="server"></asp:TextBox></td>
                    
                </tr>
                 <tr></tr> <tr></tr> <tr></tr> <tr></tr>
                <tr>
                    <td>Question10</td>
                    <td><asp:TextBox ID="TextBox10" CssClass="TextBox" runat="server"></asp:TextBox></td>
                    
                </tr>
               <tr></tr> <tr></tr> <tr></tr> <tr></tr> <tr></tr> <tr></tr> <tr></tr> <tr></tr>
            </table>
                 <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click1" />
               <%-- <asp:Button ID="Button2" runat="server" Text="Add" OnClick="Button2_Click" />--%>
                </div>
        </div>

    </form>

    
</body>
</html>
