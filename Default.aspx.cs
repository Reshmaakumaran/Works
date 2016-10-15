using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace FileComparer
{
    public partial class _Default : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void btnfileCompare_Click(object sender, EventArgs e)
        {
            divleftResult.InnerText = "";
            divrighttResult.InnerText = "";
            var txtleftCount = txtleftContent.Value.Split(new char[] { '\n' }).Length;
            var txtrightCount = txtrightContent.Value.Split(new char[] { '\n' }).Length;
            Int32 count = txtleftCount >= txtrightCount ? txtleftCount : txtrightCount;
            divleftResult.Visible = true;
            divrighttResult.Visible = true;
            ScriptManager.RegisterStartupScript(this, GetType(), "highlight", "selcompare('" + count + "');", true);

        }

    }
}