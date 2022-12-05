<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Good-Luck.aspx.cs" Inherits="project_rahma.Good_Luck" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="Good-Luck.css" />
</head>
<body>

    
    <form id="form1" runat="server">
        <div class="thanks">
            <div class="text">
                <h1>
                    Thank you for apply our Survey
                </h1>
                <h1><span style="color:#126266">GOOD</span>  LUCK</h1>

            </div>
            <div class="img">
        <img src="home-images\Appreciation-bro.PNG" width="100%" height="40%" />
            </div>
            <div >
                <asp:Button ID="Button1" runat="server" Text="Logout" class="btn" OnClick="Button1_Click"/>

            </div>
        </div>
    </form>
</body>
</html>
