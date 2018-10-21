using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Bla.ctrl;
using Bla.Logic;


namespace Bla
{
    public partial class Patientenseite : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TableBuilder();
        }


        void FillTable()
        {
            for(int i = 0; i < dataTable.Rows.Count; i++)
            {
                if (dataTable.Rows[i].TableSection.Equals(TableRowSection.TableBody))
                {
                    dataTable.Rows.RemoveAt(i);
                    i--;
                }
            }
          //  dataTable.Rows.AddRange(Manager.GetWeeklyDokumentation(1));
        }


        void TableBuilder()
        {
            List<VisualDocu> b = new List<VisualDocu>();
            b.Add(new VisualDocu("1", "1", "01-01-18", "1123113", "50", "10", "1", "Po", "Ja", "Nein"));
            b.Add(new VisualDocu("1", "1", "01-01-18", "1123113", "50", "10", "1", "Po", "Nein", "Ja"));
            TableRow[] rows = Manager.InitRows(b.Count, 10);
            for(int i = 0; i < rows.Length; i++)
            {
                rows[i].Cells[0].Text = b[i].id;
                rows[i].Cells[1].Text = b[i].therapy_week;
                rows[i].Cells[2].Text = b[i].create_date;
                rows[i].Cells[3].Text = b[i].batchnumber;
                rows[i].Cells[4].Text = b[i].quantity;
                rows[i].Cells[5].Text = b[i].amount;
                rows[i].Cells[6].Text = b[i].place;
                rows[i].Cells[7].Text = b[i].speed;
                if(b[i].complications=="Nein")
                    rows[i].Cells[8].Text = b[i].complications;
                else
                {
                    LinkButton link = new LinkButton();
                    link.ID = "Com";
                    link.Text = b[i].complications;
                    link.CommandArgument = b[i].id;
                    link.Command += new CommandEventHandler(comBtn_Command);
                    rows[i].Cells[8].Controls.Add(link);
                }
                if (b[i].infections == "Nein")
                    rows[i].Cells[9].Text = b[i].infections;
                else
                {
                    LinkButton link = new LinkButton();
                    link.ID = "Inf";
                    link.Text = b[i].infections;
                    link.CommandArgument = b[i].id;
                    link.Command += new CommandEventHandler(infBtn_Command);
                    rows[i].Cells[9].Controls.Add(link);
                }
            }
            dataTable.Rows.AddRange(rows);
         }

        protected void comBtn_Command(Object sender,CommandEventArgs e)
        {
            Manager.CurrentChosenDocuId = int.Parse((string)e.CommandArgument);
            Response.Redirect("https://www.youtube.com/watch?v=rVqKBhF4a3g");
        }
        protected void infBtn_Command(Object sender, CommandEventArgs e)
        {
            LinkButton help = (LinkButton)sender;
            if (help.Text == "Ja")
            {
                Manager.CurrentChosenDocuId = int.Parse((string)e.CommandArgument);
                Response.Redirect("https://www.youtube.com/watch?v=rVqKBhF4a3g");
            }

        }

    }
}