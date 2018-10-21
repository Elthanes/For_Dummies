using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Bla.Logic;
using Bla.ctrl;

namespace Bla
{

    public partial class Broadcast : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_sub_Click(object sender, EventArgs e)
        {
            NewsFeedEntry news = new NewsFeedEntry(0, lInhalt.InnerText, 666, DateTime.Now, "Satan", lBetreff.InnerText);
            Manager.NewNewsfeed(news);
            System.Diagnostics.Debug.WriteLine(news.newsfeedText);
            lInhalt.InnerText.Remove(0);
            lBetreff.InnerText.Remove(0);
        }
    }
}