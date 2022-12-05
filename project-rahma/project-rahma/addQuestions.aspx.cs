using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
namespace project_rahma
{
    public partial class addQuestions : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            string[] questions = String.Join(",", Form.Controls.OfType<TextBox>().Select(c => c.Text)).Split(',');//short hand to foreach
            File.WriteAllLines(@"C:\Users\t\project-rahma\project-rahma\QuestionFile.txt", questions);
        }
    }
}