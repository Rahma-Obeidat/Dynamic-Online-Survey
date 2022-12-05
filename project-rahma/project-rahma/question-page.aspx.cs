using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
namespace project_rahma
{
    public partial class question_page : System.Web.UI.Page
    {
        string s = File.ReadAllText(@"C:\Users\t\project-rahma\project-rahma\QuestionFile.txt");
        string[] lines = File.ReadAllLines(@"C:\Users\t\project-rahma\project-rahma\QuestionFile.txt");
        static string[] answer = new string[10] ;
      


        protected void Page_Load(object sender, EventArgs e)
        {
            string ID = Request.QueryString["ID"];

            Label1.Text = ID;

            DateTime now = DateTime.Today;
            Label2.Text = Convert.ToString(now.Date);


            //-----------------------------
            string s = File.ReadAllText(@"C:\Users\t\project-rahma\project-rahma\QuestionFile.txt");
            string[] lines = File.ReadAllLines(@"C:\Users\t\project-rahma\project-rahma\QuestionFile.txt");

            Label4.Text = lines[0];
            Label6.Text = lines[1];
            Label8.Text = lines[2];
            Label10.Text = lines[3];
            Label12.Text = lines[4];
            Label14.Text = lines[5];
            Label16.Text = lines[6];
            Label18.Text = lines[7];
            Label20.Text = lines[8];
            Label22.Text = lines[9];


            //File.AppendAllText(@"C:\Users\t\project-rahma\project-rahma\TextFile\" + ID, s);

        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //string s = "";
            //int i;
            //string ID = Request.QueryString["ID"];
            //for (i = 0; i < 35; i++)
            //{
            //    if (ID == Convert.ToString(i))
            //    { s = Convert.ToString(i); }
            //}
            //string answer1 = RadioButton1.Text;
            ////File.AppendAllText(@"C:\Users\t\project-rahma\project-rahma\TextFile\" + s, answer1 + "1,");
            //string now;
            //DateTime date = DateTime.Now;
            //now = date.ToString("dd.mm.yyyy");
            //string path2 = Server.MapPath($"TextFile/{ID + "-" + now}.txt");

            //File.AppendAllText(path2, answer1 + "1,");\
            answer[0] = RadioButton1.Text;
        }

        protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {

            answer[0] = RadioButton2.Text;

            //string s = "";
            //int i;
            //for (i = 0; i < 35; i++)
            //{
            //    string ID = Request.QueryString["ID"];
            //    if (ID == Convert.ToString(i))
            //    { s = Convert.ToString(i); }
            //}



            //string answer1 = RadioButton2.Text;
            //string now;
            //DateTime date = DateTime.Now;

            //now = date.ToString("MM.dd.yyyy");
            //string path2 = Server.MapPath($"TextFile/{ID + "-" + now}.txt");
            //string answer10 = RadioButton40.Text;

            //string answer1 = RadioButton2.Text;
            ////string text2 = "A class is the most powerful data type in C#. Like a structure,a class defines the data and behavior of the data type.";
            //File.AppendAllText(@"C:\Users\t\project-rahma\project-rahma\TextFile\" + s, answer1 + "1,");
        }

        protected void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            answer[0] = RadioButton3.Text;

            //string s = "";
            //int i;
            //string ID = Request.QueryString["ID"];

            //for (i = 0; i < 35; i++)
            //{
            //    if (ID == Convert.ToString(i))
            //    { s = Convert.ToString(i); }
            //}
            //string answer1 = RadioButton3.Text;
            ////string text2 = "A class is the most powerful data type in C#. Like a structure,a class defines the data and behavior of the data type.";
            //string now;
            //DateTime date = DateTime.Now;
            //now = date.ToString("dd.mm.yyyy");
            //string path2 = Server.MapPath($"TextFile/{ID + "-" +now}.txt");

            //File.AppendAllText(path2, answer1 + "1,");
        }

        protected void RadioButton4_CheckedChanged(object sender, EventArgs e)
        {

            answer[0] = RadioButton5.Text;

            //string s = "";
            //int i;
            //for (i = 0; i < 35; i++)
            //{
            //    string ID = Request.QueryString["ID"];
            //    if (ID == Convert.ToString(i))
            //    { s = Convert.ToString(i); }
            //}
            //string answer1 = RadioButton4.Text;
            ////string text2 = "A class is the most powerful data type in C#. Like a structure,a class defines the data and behavior of the data type.";
            //File.AppendAllText(@"C:\Users\t\project-rahma\project-rahma\TextFile\" + s, answer1 + "1,");

        }

        protected void RadioButton5_CheckedChanged(object sender, EventArgs e)
        {

            answer[1] = RadioButton5.Text;

            //string s = "";
            //int i;
            //for (i = 0; i < 35; i++)
            //{
            //    string ID = Request.QueryString["ID"];
            //    if (ID == Convert.ToString(i))
            //    { s = Convert.ToString(i); }
            //}
            //string answer2 = RadioButton5.Text;
            ////string text2 = "A class is the most powerful data type in C#. Like a structure,a class defines the data and behavior of the data type.";
            //File.AppendAllText(@"C:\Users\t\project-rahma\project-rahma\TextFile\" + s, answer2 + "2,");
        }

        protected void RadioButton6_CheckedChanged(object sender, EventArgs e)
        {

            answer[1] = RadioButton6.Text;

            //string s = "";
            //int i;
            //for (i = 0; i < 35; i++)
            //{
            //    string ID = Request.QueryString["ID"];
            //    if (ID == Convert.ToString(i))
            //    { s = Convert.ToString(i); }
            //}
            //string answer2 = RadioButton6.Text;
            ////string text2 = "A class is the most powerful data type in C#. Like a structure,a class defines the data and behavior of the data type.";
            //File.AppendAllText(@"C:\Users\t\project-rahma\project-rahma\TextFile\" + s, answer2 + "2,");
        }

        protected void RadioButton7_CheckedChanged(object sender, EventArgs e)
        {
            answer[1] = RadioButton7.Text;

            //string s = "";
            //int i;
            //for (i = 0; i < 35; i++)
            //{
            //    string ID = Request.QueryString["ID"];
            //    if (ID == Convert.ToString(i))
            //    { s = Convert.ToString(i); }
            //}
            //string answer2 = RadioButton7.Text;
            ////string text2 = "A class is the most powerful data type in C#. Like a structure,a class defines the data and behavior of the data type.";
            //File.AppendAllText(@"C:\Users\t\project-rahma\project-rahma\TextFile\" + s, answer2 + "2,");
        }

        protected void RadioButton8_CheckedChanged(object sender, EventArgs e)
        {
            answer[1] = RadioButton8.Text;

            //string s = "";
            //int i;
            //for (i = 0; i < 35; i++)
            //{
            //    string ID = Request.QueryString["ID"];
            //    if (ID == Convert.ToString(i))
            //    { s = Convert.ToString(i); }
            //}
            //string answer2 = RadioButton8.Text;
            ////string text2 = "A class is the most powerful data type in C#. Like a structure,a class defines the data and behavior of the data type.";
            //File.AppendAllText(@"C:\Users\t\project-rahma\project-rahma\TextFile\" + s, answer2 + "2,");
        }

        protected void RadioButton9_CheckedChanged(object sender, EventArgs e)
        {
            answer[2] = RadioButton9.Text;

            //string s = "";
            //int i;
            //for (i = 0; i < 35; i++)
            //{
            //    string ID = Request.QueryString["ID"];
            //    if (ID == Convert.ToString(i))
            //    { s = Convert.ToString(i); }
            //}
            //string answer3 = RadioButton9.Text;
            ////string text2 = "A class is the most powerful data type in C#. Like a structure,a class defines the data and behavior of the data type.";
            //File.AppendAllText(@"C:\Users\t\project-rahma\project-rahma\TextFile\" + s, answer3 + "3,");
        }

        protected void RadioButton10_CheckedChanged(object sender, EventArgs e)
        {
            answer[2] = RadioButton10.Text;

            //string s = "";
            //int i;
            //for (i = 0; i < 35; i++)
            //{
            //    string ID = Request.QueryString["ID"];
            //    if (ID == Convert.ToString(i))
            //    { s = Convert.ToString(i); }
            //}
            //string answer3 = RadioButton10.Text;
            ////string text2 = "A class is the most powerful data type in C#. Like a structure,a class defines the data and behavior of the data type.";
            //File.AppendAllText(@"C:\Users\t\project-rahma\project-rahma\TextFile\" + s, answer3 + "3,");


        }

        protected void RadioButton11_CheckedChanged(object sender, EventArgs e)
        {
            answer[2] = RadioButton11.Text;
            //string s = "";
            //int i;
            //for (i = 0; i < 35; i++)
            //{
            //    string ID = Request.QueryString["ID"];
            //    if (ID == Convert.ToString(i))
            //    { s = Convert.ToString(i); }
            //}
            //string answer3 = RadioButton11.Text;
            ////string text2 = "A class is the most powerful data type in C#. Like a structure,a class defines the data and behavior of the data type.";
            //File.AppendAllText(@"C:\Users\t\project-rahma\project-rahma\TextFile\" + s, answer3 + "3,");

        }

        protected void RadioButton12_CheckedChanged(object sender, EventArgs e)
        {
            answer[2] = RadioButton12.Text;
            //string s = "";
            //int i;
            //for (i = 0; i < 35; i++)
            //{
            //    string ID = Request.QueryString["ID"];
            //    if (ID == Convert.ToString(i))
            //    { s = Convert.ToString(i); }
            //}
            //string answer3 = RadioButton12.Text;
            ////string text2 = "A class is the most powerful data type in C#. Like a structure,a class defines the data and behavior of the data type.";
            //File.AppendAllText(@"C:\Users\t\project-rahma\project-rahma\TextFile\" + s, answer3 + "3,");
        }

        protected void RadioButton13_CheckedChanged(object sender, EventArgs e)
        {
            answer[3] = RadioButton13.Text;
            //string s = "";
            //int i;
            //for (i = 0; i < 35; i++)
            //{
            //    string ID = Request.QueryString["ID"];
            //    if (ID == Convert.ToString(i))
            //    { s = Convert.ToString(i); }
            //}
            //string answer4 = RadioButton13.Text;
            ////string text2 = "A class is the most powerful data type in C#. Like a structure,a class defines the data and behavior of the data type.";
            //File.AppendAllText(@"C:\Users\t\project-rahma\project-rahma\TextFile\" + s, answer4 + "4,");
        }

        protected void RadioButton14_CheckedChanged(object sender, EventArgs e)
        {
            answer[3] = RadioButton14.Text;
            //    string s = "";
            //    int i;
            //    for (i = 0; i < 35; i++)
            //    {
            //        string ID = Request.QueryString["ID"];
            //        if (ID == Convert.ToString(i))
            //        { s = Convert.ToString(i); }
            //    }
            //    string answer4 = RadioButton14.Text;
            //    //string text2 = "A class is the most powerful data type in C#. Like a structure,a class defines the data and behavior of the data type.";
            //    File.AppendAllText(@"C:\Users\t\project-rahma\project-rahma\TextFile\" + s, answer4 + "4,");
        }

        protected void RadioButton15_CheckedChanged(object sender, EventArgs e)
        {
            answer[3] = RadioButton15.Text;

            //string s = "";
            //int i;
            //for (i = 0; i < 35; i++)
            //{
            //    string ID = Request.QueryString["ID"];
            //    if (ID == Convert.ToString(i))
            //    { s = Convert.ToString(i); }
            //}
            //string answer4 = RadioButton15.Text;
            ////string text2 = "A class is the most powerful data type in C#. Like a structure,a class defines the data and behavior of the data type.";
            //File.AppendAllText(@"C:\Users\t\project-rahma\project-rahma\TextFile\" + s, answer4 + "4,");
        }

        protected void RadioButton16_CheckedChanged(object sender, EventArgs e)
        {
            answer[3] = RadioButton16.Text;
            //string s = "";
            //int i;
            //for (i = 0; i < 35; i++)
            //{
            //    string ID = Request.QueryString["ID"];
            //    if (ID == Convert.ToString(i))
            //    { s = Convert.ToString(i); }
            //}
            //string answer4 = RadioButton16.Text;
            ////string text2 = "A class is the most powerful data type in C#. Like a structure,a class defines the data and behavior of the data type.";
            //File.AppendAllText(@"C:\Users\t\project-rahma\project-rahma\TextFile\" + s, answer4 + "4,");

        }

        protected void RadioButton17_CheckedChanged(object sender, EventArgs e)
        {
            answer[4] = RadioButton17.Text;
            //    string s = "";
            //    int i;
            //    for (i = 0; i < 35; i++)
            //    {
            //        string ID = Request.QueryString["ID"];
            //        if (ID == Convert.ToString(i))
            //        { s = Convert.ToString(i); }
            //    }
            //    string answer5 = RadioButton17.Text;
            //    //string text2 = "A class is the most powerful data type in C#. Like a structure,a class defines the data and behavior of the data type.";
            //    File.AppendAllText(@"C:\Users\t\project-rahma\project-rahma\TextFile\" + s, answer5 + "5,");
        }

        protected void RadioButton18_CheckedChanged(object sender, EventArgs e)
        {

            answer[4] = RadioButton18.Text;
            //string s = "";
            //int i;
            //for (i = 0; i < 35; i++)
            //{
            //    string ID = Request.QueryString["ID"];
            //    if (ID == Convert.ToString(i))
            //    { s = Convert.ToString(i); }
            //}
            //string answer5 = RadioButton18.Text;
            ////string text2 = "A class is the most powerful data type in C#. Like a structure,a class defines the data and behavior of the data type.";
            //File.AppendAllText(@"C:\Users\t\project-rahma\project-rahma\TextFile\" + s, answer5 + "5,");
        }

        protected void RadioButton19_CheckedChanged(object sender, EventArgs e)
        {
            answer[4] = RadioButton19.Text;
            //string s = "";
            //int i;
            //for (i = 0; i < 35; i++)
            //{
            //    string ID = Request.QueryString["ID"];
            //    if (ID == Convert.ToString(i))
            //    { s = Convert.ToString(i); }
            //}
            //string answer5 = RadioButton19.Text;
            ////string text2 = "A class is the most powerful data type in C#. Like a structure,a class defines the data and behavior of the data type.";
            //File.AppendAllText(@"C:\Users\t\project-rahma\project-rahma\TextFile\" + s, answer5 + "5,");

        }

        protected void RadioButton20_CheckedChanged(object sender, EventArgs e)
        {

            answer[4] = RadioButton20.Text;
            //string s = "";
            //int i;
            //for (i = 0; i < 35; i++)
            //{
            //    string ID = Request.QueryString["ID"];
            //    if (ID == Convert.ToString(i))
            //    { s = Convert.ToString(i); }
            //}
            //string answer5 = RadioButton20.Text;
            ////string text2 = "A class is the most powerful data type in C#. Like a structure,a class defines the data and behavior of the data type.";
            //File.AppendAllText(@"C:\Users\t\project-rahma\project-rahma\TextFile\" + s, answer5 + "5,");
        }

        protected void RadioButton21_CheckedChanged(object sender, EventArgs e)
        {

            answer[5] = RadioButton21.Text;
            //string s = "";
            //int i;
            //for (i = 0; i < 35; i++)
            //{
            //    string ID = Request.QueryString["ID"];
            //    if (ID == Convert.ToString(i))
            //    { s = Convert.ToString(i); }
            //}
            //string answer6 = RadioButton21.Text;
            ////string text2 = "A class is the most powerful data type in C#. Like a structure,a class defines the data and behavior of the data type.";
            //File.AppendAllText(@"C:\Users\t\project-rahma\project-rahma\TextFile\" + s, answer6 + "6,");
        }

        protected void RadioButton22_CheckedChanged(object sender, EventArgs e)
        {
            answer[5] = RadioButton22.Text;
            //string s = "";
            //int i;
            //for (i = 0; i < 35; i++)
            //{
            //    string ID = Request.QueryString["ID"];
            //    if (ID == Convert.ToString(i))
            //    { s = Convert.ToString(i); }
            //}
            //string answer6 = RadioButton22.Text;
            ////string text2 = "A class is the most powerful data type in C#. Like a structure,a class defines the data and behavior of the data type.";
            //File.AppendAllText(@"C:\Users\t\project-rahma\project-rahma\TextFile\" + s, answer6 + "6,");
        }

        protected void RadioButton23_CheckedChanged(object sender, EventArgs e)
        {
            answer[5] = RadioButton23.Text;
            //string s = "";
            //int i;
            //for (i = 0; i < 35; i++)
            //{
            //    string ID = Request.QueryString["ID"];
            //    if (ID == Convert.ToString(i))
            //    { s = Convert.ToString(i); }
            //}
            //string answer6 = RadioButton23.Text;
            ////string text2 = "A class is the most powerful data type in C#. Like a structure,a class defines the data and behavior of the data type.";
            //File.AppendAllText(@"C:\Users\t\project-rahma\project-rahma\TextFile\" + s, answer6 + "6,");
        }

        protected void RadioButton24_CheckedChanged(object sender, EventArgs e)
        {
            answer[5] = RadioButton24.Text;
            //string s = "";
            //int i;
            //for (i = 0; i < 35; i++)
            //{
            //    string ID = Request.QueryString["ID"];
            //    if (ID == Convert.ToString(i))
            //    { s = Convert.ToString(i); }
            //}
            //string answer6 = RadioButton24.Text;
            ////string text2 = "A class is the most powerful data type in C#. Like a structure,a class defines the data and behavior of the data type.";
            //File.AppendAllText(@"C:\Users\t\project-rahma\project-rahma\TextFile\" + s, answer6 + "6,");
        }

        protected void RadioButton25_CheckedChanged(object sender, EventArgs e)
        {
            answer[6] = RadioButton25.Text;
            //string s = "";
            //int i;
            //for (i = 0; i < 35; i++)
            //{
            //    string ID = Request.QueryString["ID"];
            //    if (ID == Convert.ToString(i))
            //    { s = Convert.ToString(i); }
            //}
            //string answer7 = RadioButton25.Text;
            ////string text2 = "A class is the most powerful data type in C#. Like a structure,a class defines the data and behavior of the data type.";
            //File.AppendAllText(@"C:\Users\t\project-rahma\project-rahma\TextFile\" + s, answer7 + "7,");
        }

        protected void RadioButton26_CheckedChanged(object sender, EventArgs e)
        {
            answer[6] = RadioButton26.Text;
            //string s = "";
            //int i;
            //for (i = 0; i < 35; i++)
            //{
            //    string ID = Request.QueryString["ID"];
            //    if (ID == Convert.ToString(i))
            //    { s = Convert.ToString(i); }
            //}
            //string answer7 = RadioButton26.Text;
            ////string text2 = "A class is the most powerful data type in C#. Like a structure,a class defines the data and behavior of the data type.";
            //File.AppendAllText(@"C:\Users\t\project-rahma\project-rahma\TextFile\" + s, answer7 + "7,");
        }

        protected void RadioButton27_CheckedChanged(object sender, EventArgs e)
        {

            answer[6] = RadioButton27.Text;
            //string s = "";
            //int i;
            //for (i = 0; i < 35; i++)
            //{
            //    string ID = Request.QueryString["ID"];
            //    if (ID == Convert.ToString(i))
            //    { s = Convert.ToString(i); }
            //}
            //string answer7 = RadioButton27.Text;
            ////string text2 = "A class is the most powerful data type in C#. Like a structure,a class defines the data and behavior of the data type.";
            //File.AppendAllText(@"C:\Users\t\project-rahma\project-rahma\TextFile\" + s, answer7 + "7,");
        }

        protected void RadioButton28_CheckedChanged(object sender, EventArgs e)
        {
            answer[6] = RadioButton28.Text;
            //string s = "";
            //int i;
            //for (i = 0; i < 35; i++)
            //{
            //    string ID = Request.QueryString["ID"];
            //    if (ID == Convert.ToString(i))
            //    { s = Convert.ToString(i); }
            //}
            //string answer7 = RadioButton28.Text;
            ////string text2 = "A class is the most powerful data type in C#. Like a structure,a class defines the data and behavior of the data type.";
            //File.AppendAllText(@"C:\Users\t\project-rahma\project-rahma\TextFile\" + s, answer7 + "7,");

        }

        protected void RadioButton29_CheckedChanged(object sender, EventArgs e)
        {

            answer[7] = RadioButton29.Text;
            //    string s = "";
            //    int i;
            //    for (i = 0; i < 35; i++)
            //    {
            //        string ID = Request.QueryString["ID"];
            //        if (ID == Convert.ToString(i))
            //        { s = Convert.ToString(i); }
            //    }
            //    string answer8 = RadioButton29.Text;
            //    //string text2 = "A class is the most powerful data type in C#. Like a structure,a class defines the data and behavior of the data type.";
            //    File.AppendAllText(@"C:\Users\t\project-rahma\project-rahma\TextFile\" + s, answer8 + "8,");
        }

        protected void RadioButton30_CheckedChanged(object sender, EventArgs e)
        {
            answer[7] = RadioButton30.Text;
            //    string s = "";
            //    int i;
            //    for (i = 0; i < 35; i++)
            //    {
            //        string ID = Request.QueryString["ID"];
            //        if (ID == Convert.ToString(i))
            //        { s = Convert.ToString(i); }
            //    }
            //    string answer8 = RadioButton30.Text;
            //    //string text2 = "A class is the most powerful data type in C#. Like a structure,a class defines the data and behavior of the data type.";
            //    File.AppendAllText(@"C:\Users\t\project-rahma\project-rahma\TextFile\" + s, answer8 + "8,");
        }

        protected void RadioButton31_CheckedChanged(object sender, EventArgs e)
        {
            answer[7] = RadioButton31.Text;
            //string s = "";
            //int i;
            //for (i = 0; i < 35; i++)
            //{
            //    string ID = Request.QueryString["ID"];
            //    if (ID == Convert.ToString(i))
            //    { s = Convert.ToString(i); }
            //}
            //string answer8 = RadioButton31.Text;
            ////string text2 = "A class is the most powerful data type in C#. Like a structure,a class defines the data and behavior of the data type.";
            //File.AppendAllText(@"C:\Users\t\project-rahma\project-rahma\TextFile\" + s, answer8 + "8,");
        }

        protected void RadioButton32_CheckedChanged(object sender, EventArgs e)
        {

            answer[7] = RadioButton32.Text;
            //string s = "";
            //int i;
            //for (i = 0; i < 35; i++)
            //{
            //    string ID = Request.QueryString["ID"];
            //    if (ID == Convert.ToString(i))
            //    { s = Convert.ToString(i); }
            //}
            //string answer8 = RadioButton32.Text;
            ////string text2 = "A class is the most powerful data type in C#. Like a structure,a class defines the data and behavior of the data type.";
            //File.AppendAllText(@"C:\Users\t\project-rahma\project-rahma\TextFile\" + s, answer8 + "8,");
        }

        protected void RadioButton33_CheckedChanged(object sender, EventArgs e)
        {
            answer[8] = RadioButton33.Text;
            //string s = "";
            //int i;
            //for (i = 0; i < 35; i++)
            //{
            //    string ID = Request.QueryString["ID"];
            //    if (ID == Convert.ToString(i))
            //    { s = Convert.ToString(i); }
            //}
            //string answer9 = RadioButton33.Text;
            ////string text2 = "A class is the most powerful data type in C#. Like a structure,a class defines the data and behavior of the data type.";
            //File.AppendAllText(@"C:\Users\t\project-rahma\project-rahma\TextFile\" + s, answer9 + "9,");
        }

        protected void RadioButton34_CheckedChanged(object sender, EventArgs e)
        {
            answer[8] = RadioButton34.Text;
            //string s = "";
            //int i;
            //for (i = 0; i < 35; i++)
            //{
            //    string ID = Request.QueryString["ID"];
            //    if (ID == Convert.ToString(i))
            //    { s = Convert.ToString(i); }
            //}
            //string answer9 = RadioButton34.Text;
            ////string text2 = "A class is the most powerful data type in C#. Like a structure,a class defines the data and behavior of the data type.";
            //File.AppendAllText(@"C:\Users\t\project-rahma\project-rahma\TextFile\" + s, answer9 + "9,");
        }

        protected void RadioButton35_CheckedChanged(object sender, EventArgs e)
        {
            answer[8] = RadioButton35.Text;
            //string s = "";
            //int i;
            //for (i = 0; i < 35; i++)
            //{
            //    string ID = Request.QueryString["ID"];
            //    if (ID == Convert.ToString(i))
            //    { s = Convert.ToString(i); }
            //}
            //string answer9 = RadioButton35.Text;
            ////string text2 = "A class is the most powerful data type in C#. Like a structure,a class defines the data and behavior of the data type.";
            //File.AppendAllText(@"C:\Users\t\project-rahma\project-rahma\TextFile\" + s, answer9 + "9,");
        }

        protected void RadioButton36_CheckedChanged(object sender, EventArgs e)
        {
            answer[8] = RadioButton36.Text;
            //string s = "";
            //int i;
            //for (i = 0; i < 35; i++)
            //{
            //    string ID = Request.QueryString["ID"];
            //    if (ID == Convert.ToString(i))
            //    { s = Convert.ToString(i); }
            //}
            //string answer9 = RadioButton36.Text;
            ////string text2 = "A class is the most powerful data type in C#. Like a structure,a class defines the data and behavior of the data type.";
            //File.AppendAllText(@"C:\Users\t\project-rahma\project-rahma\TextFile\" + s, answer9 + "9,");
        }

        protected void RadioButton37_CheckedChanged(object sender, EventArgs e)
        {
            answer[9] = RadioButton37.Text;
            //string s = "";
            //int i;
            //for (i = 0; i < 35; i++)
            //{
            //    string ID = Request.QueryString["ID"];
            //    if (ID == Convert.ToString(i))
            //    { s = Convert.ToString(i); }
            //}
            //string answer10 = RadioButton37.Text;
            ////string text2 = "A class is the most powerful data type in C#. Like a structure,a class defines the data and behavior of the data type.";
            //File.AppendAllText(@"C:\Users\t\project-rahma\project-rahma\TextFile\" + s, answer10 + "10,");

        }

        protected void RadioButton38_CheckedChanged(object sender, EventArgs e)
        {

            answer[9] = RadioButton38.Text;
            //string s = "";
            //int i;
            //for (i = 0; i < 35; i++)
            //{
            //    string ID = Request.QueryString["ID"];
            //    if (ID == Convert.ToString(i))
            //    { s = Convert.ToString(i); }
            //}
            //string answer10 = RadioButton38.Text;
            ////string text2 = "A class is the most powerful data type in C#. Like a structure,a class defines the data and behavior of the data type.";
            //File.AppendAllText(@"C:\Users\t\project-rahma\project-rahma\TextFile\" + s, answer10 + "10,");
        }

        protected void RadioButton39_CheckedChanged(object sender, EventArgs e)
        {
            answer[9] = RadioButton39.Text;
            //string s = "";
            //int i;
            //for (i = 0; i < 35; i++)
            //{
            //    string ID = Request.QueryString["ID"];
            //    if (ID == Convert.ToString(i))
            //    { s = Convert.ToString(i); }
            //}
            //string answer10 = RadioButton39.Text;
            ////string text2 = "A class is the most powerful data type in C#. Like a structure,a class defines the data and behavior of the data type.";
            //File.AppendAllText(@"C:\Users\t\project-rahma\project-rahma\TextFile\" + s, answer10 + "10,");
        }

        protected void RadioButton40_CheckedChanged(object sender, EventArgs e)
        {


            answer[9] = RadioButton40.Text;
            //string s = "";
            //int i;
            //for (i = 0; i < 35; i++)
            //{
            //    string ID = Request.QueryString["ID"];
            //    if (ID == Convert.ToString(i))
            //    { s = Convert.ToString(i); }
            //}


            //string now;
            //DateTime date = DateTime.Now;

            //now = date.ToString("MM.dd.yyyy");
            //string path2 = Server.MapPath($"TextFile/{ID + "-" + now}.txt");
            //string answer10 = RadioButton40.Text;

            //File.AppendAllText(path2, answer10 + "10,");





            //string text2 = "A class is the most powerful data type in C#. Like a structure,a class defines the data and behavior of the data type.";
            //File.AppendAllText(@"C:\Users\t\project-rahma\project-rahma\TextFile\" + s, answer10 + "10,");
        }

        protected void Button41_Click(object sender, EventArgs e)
        {

            string s = "";
            int i;
            string ID = Request.QueryString["ID"];
            for (i = 0; i < 35; i++)
            {

                if (ID == Convert.ToString(i))
                { s = Convert.ToString(i); }
            }


            string now;
            DateTime date = DateTime.Now;

            now = date.ToString("MM.dd.yyyy");
            string path2 = Server.MapPath($"TextFile/{ID + "-" + now}.txt");
            //**
            //string question = lines[0];           

            //File.AppendAllText(path2,question+ "   "+ answer1+"1");
            for(int ii=0;ii<10;ii++)
            {
                File.AppendAllText(path2, s+"  "+ lines[ii] + "   " + answer[ii] +"     ");

            }


            //-----------------------------
            if (File.ReadAllText("C:\\Users\\t\\project-rahma\\project-rahma\\TextFile\\ID.txt") == "")
            {
                File.AppendAllText(@"C:\Users\t\project-rahma\project-rahma\TextFile\ID.txt", "," + s);
            }
            else { File.AppendAllText(@"C:\Users\t\project-rahma\project-rahma\TextFile\ID.txt", s); }

            //string answer2;
            //answer2 = Button41.Text;
            //string text2 = "A class is the most powerful data type in C#. Like a structure,a class defines the data and behavior of the data type.";
            //File.AppendAllText(@"C:\Users\t\project-rahma\project-rahma\TextFile\" + s, answer2 + "1,");
            string[] Answers = String.Join(",", values: Form.Controls.OfType<RadioButton>().Where(x => x.Checked == true).Select(c => c.Text)).Split(',');//short hand to foreach
            File.AppendAllLines(@"C:\Users\t\project-rahma\project-rahma" + s + ".txt", Answers);
            File.AppendAllLines(@"C:\Users\t\project-rahma\project-rahma\allAnswers.txt", Answers);
            string[] counter = File.ReadAllLines(@"C:\Users\t\project-rahma\project-rahma\allAnswers.txt");

            int exc = 0;
            int very = 0;
            int good = 0;
            int poor = 0;

            for (int x = 0; x < counter.Length; x++)
            {
                if (counter[x] == "Excellent")
                {
                    exc++;
                }
                else if (counter[x] == "Very Good")
                {
                    very++;
                }
                else if (counter[x] == "Good")
                {
                    good++;
                }
                else if (counter[x] == "Poor")
                {
                    poor++;
                }
                else
                {
                    Response.Write("there was an error");
                }
            }
            double percent = (exc * 100 + very * 75 + good * 50 + poor * 25) / (poor + good + very + exc);
            Response.Redirect("Good-Luck.aspx");
           
        }

    }
}