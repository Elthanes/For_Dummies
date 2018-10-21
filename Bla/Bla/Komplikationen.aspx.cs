using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Bla.ctrl;

namespace Bla
{
    public partial class Komplikationen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BuildTable();
        }

        void BuildTable()
        {
            TableRow b = Manager.InitArray(10);
            Random rand = new Random();
            for(int i = 0; i < b.Cells.Count-1; i++)
            {
                if(rand.NextDouble() > 0.5)
                {
                    b.Cells[i].Text = "ja";
                }
                else
                {
                    b.Cells[i].Text = "nein";
                }
            }
            b.Cells[b.Cells.Count-1].Text = "ASDA";
            dataTable.Rows.Add(b);
        }
    }
}