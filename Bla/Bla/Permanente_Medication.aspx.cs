using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using Bla.ctrl;
using System.Web.UI.WebControls;

namespace Bla
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BuildTable();
            BuildTable();
        }

        void BuildTable()
        {
            TableRow b = Manager.InitArray(5);
            b.Cells[0].Text = "Aspirin";
            b.Cells[1].Text = "50";
            b.Cells[2].Text = "1-0-1";
            b.Cells[3].Text = DateTime.Today.AddMonths(2).ToShortDateString();
            b.Cells[4].Text = DateTime.MaxValue.ToShortDateString();
            dataTable.Rows.Add(b);
        }


    }
}