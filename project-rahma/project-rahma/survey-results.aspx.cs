using System;
using System.Linq;
using System.Web.UI.WebControls;
using System.IO;

namespace project_rahma
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            for (int r = 1; r < 35; r++)
            {
                TableRow row = new TableRow();
                //File.re
                bool flag = false;
                string filepath = Server.MapPath("TextFile/ID.txt");
                string done = File.ReadAllText(filepath);
                string[] lines = done.Split(',');
                
                string check="";
                foreach (string number in lines)
                {
                    int num = Convert.ToInt32(number);
                    if (r ==num ) 
                    
                    {
                        flag = true;
                        check = number;
                        break;
                    }
                }


                for (int j = 1; j < 2; j++)
                {
                    TableCell cell = new TableCell();
                    cell.Text = String.Format(Convert.ToString(r));
                    row.Cells.Add(cell);
                    cell.CssClass = "Rside";


                }
                for (int c = 1; c < 2; c++)
                {
                    TableCell cell2 = new TableCell();

                    //---------------------
                    string s = File.ReadAllText("C:\\Users\\t\\project-rahma\\project-rahma\\TextFile\\ID.txt");
                    //string[] ss=File.ReadAllLines(s);
                    //Label2.Text = s;

                    string[] id = s.Split(' ');
                    for (int i = 0; i < id.Length; i++)
                    {
                        if (id[i] == Convert.ToString(r))
                        {
                            //Server.MapPath(@"C:\\Users\\t\\project-rahma\\project-rahma\\TextFile\\");
                           //  < asp:HyperLink ID = "HyperLink1" runat = "server" NavigateUrl = "~/" class="hyperlink">-See all employee's Survey. </asp:HyperLink>

                            //cell2.Text =
                        }
                    }
                    //string[] ss = File.ReadAllLines("C:\\Users\\t\\source\\repos\\1-12-practice\\1-12-practice\\orange.txt");



                    string filelink="";
                    if (flag)

                    {
                        string folderPath = Server.MapPath("TextFile");
                        var filenames = Directory.EnumerateFiles(folderPath).Select(Path.GetFileName);
                        foreach (string filePath in filenames) 
                        {
                            string[] doublecheck = filePath.Split('-');
                            if (doublecheck[0] == check) 
                            {
                                filelink = filePath;
                                break;
                            }
                        }
                        HyperLink link= new HyperLink();
                        link.Text ="Submitted";
                        link.NavigateUrl= $"TextFile\\{filelink}";
                        cell2.Controls.Add(link);
                        
                    }
                    else { cell2.Text = "Not Submitted"; }
                    row.Cells.Add(cell2);
                    //-------------------------

                }

                Table1.Rows.Add(row);
            }

        }
    }
}