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
            string[] listL = txtleftContent.Value.Split(new char[] { '\n' });
            string[] listR = txtrightContent.Value.Split(new char[] { '\n' });


            if (txtleftCount >= txtrightCount)
            {
                compareText(txtleftCount, listL, listR);
                divleftResult.Visible = true;
                divrighttResult.Visible = true;

            }



        }

        protected void compareText(Int32 linecount, string[] listL, string[] listR)
        {
            for (int i = 0; i < linecount; i++)
            {
                if (listL[i].ToString() != listR[i].ToString())
                {
                    string listl = listL[i].ToString();
                    string listr = listR[i].ToString();

                    //if a particular line is empty in a textarea
                    //change to empty so that the text can be hidden and only background colour can be set in javascript
                    if (listl.Trim() == "")
                    {

                        listl = "Empty";

                    }
                   
                    if (listr.Trim() == "")
                    {

                        listr = "Empty";

                    }

                    //for left textarea
                    ScriptManager.RegisterStartupScript(this, GetType(), "color", "selcompare('" + listl + "');", true);
                    //for right textarea
                    ScriptManager.RegisterStartupScript(this, GetType(), "color1", "selcompareR('" + listr + "');", true);


                }
                else
                {
                    divleftResult.InnerHtml += "<span>" + listL[i] + "</span><br>";
                    divrighttResult.InnerHtml += "<span>" + listR[i] + "</span><br>";
                }

            }
        }




    }
}