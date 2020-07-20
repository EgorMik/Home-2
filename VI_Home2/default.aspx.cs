using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VI_Home2
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SiteVisited.Text = "Подсчёт запросов =" + Application["SiteVisitedCounter"].ToString();

        }

        //protected void btnClearSesson_Click(object sender, EventArgs e)
        //{
        //    Request.Abort();
        //}
    }
}