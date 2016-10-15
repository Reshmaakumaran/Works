using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

namespace TextComparer
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// click event of the button compare
        /// method to process two texts
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnfileCompare_Click(object sender, EventArgs e)
        {

            divleftResult.InnerText = "";
            divrighttResult.InnerText = "";
            var listL = txtleftContent.Value.Split(new char[] { '\n' });
            var listR = txtrightContent.Value.Split(new char[] { '\n' });
            Int32 count = listL.Count() <= listR.Count() ? listL.Count() : listR.Count();
            compareText(count, listL, listR);
            divleftResult.Visible = true;
            divrighttResult.Visible = true;

        }
        /// <summary>
        /// method to highlight the differences by matching the line count of both the files
        /// </summary>
        /// <param name="lineCount"></param>
        /// <param name="listL"></param>
        /// <param name="listR"></param>
        protected void compareText(Int32 lineCount, string[] listL, string[] listR)
        {
            StringBuilder sbL = new StringBuilder();
            StringBuilder sbR = new StringBuilder();
            for (int i = 0; i < lineCount; i++)
            {
                if (listL[i] == null || listL[i].Trim() == "")
                {
                    listL[i] = "Empty";
                }

                if (listR[i] == null || listR[i].Trim() == "")
                {
                    listR[i] = "Empty";
                }
                if (listL[i].ToString() != listR[i].ToString())
                {
                    //for left textarea
                    if (listL[i] == "Empty")
                    {
                        //to highlight empty line
                        sbL.Append("<span style='color:transparent;background-color:grey;border-color:white;border-style: solid;border-width: 1px'>" + listL[i].Trim() + "</span><br/>");

                    }
                    else
                    {
                        sbL.Append("<span style='background-color:Lime;border-color:white;border-style: solid;border-width: 1px'>" + listL[i].Trim() + "</span><br/>");


                    }
                    //for right textarea
                    if (listR[i] == "Empty")
                    {

                        //to highlight empty line
                        sbR.Append("<span style='color:transparent;background-color:grey;border-color:white;border-style: solid;border-width: 1px'>" + listR[i].Trim() + "</span><br/>");

                    }
                    else
                    {
                        sbR.Append("<span style='background-color:gold;border-color:white;border-style: solid;border-width: 1px'>" + listR[i].Trim() + "</span><br/>");

                    }
                }
                else
                {
                    //text that are same in both the textareas
                    if (listL[i] == "Empty" && listR[i] == "Empty")
                    {
                        sbL.Append("<span> </span><br/>");
                        sbR.Append("<span> </span><br/>");


                    }
                    else
                    {

                        sbL.Append("<span>" + listL[i].Trim() + "</span><br/>");
                        sbR.Append("<span>" + listR[i].Trim() + "</span><br/>");

                    }
                }

            }

            selectRemaining(lineCount, listL, listR, sbL, sbR);

            ScriptManager.RegisterStartupScript(this, GetType(), "highlight", "selcompare(\"" + sbL + "\",\"" + sbR + "\");", true);

        }


        /// <summary>
        /// Method to highlight the line differences in the largest text of the two
        /// </summary>
        /// <param name="count"></param>
        /// <param name="listL"></param>
        /// <param name="listr"></param>
        /// <param name="sbl"></param>
        /// <param name="sbr"></param>
        protected void selectRemaining(int count, string[] listL, string[] listr, StringBuilder sbl, StringBuilder sbr)
        {

            if (listL.Count() == count)
            {
                for (int i = count; i < listr.Count(); i++)
                {
                    if (listr[i] == null)
                    {


                        sbr.Append("<span style='color:transparent;background-color:grey;border-color:white;border-style: solid;border-width: 1px'>Empty</span><br>");
                    }
                    else
                    {
                        sbr.Append("<span style='background-color:gold;border-color:white;border-style: solid;border-width: 1px'>" + listr[i].Trim() + "</span><br>");

                    }
                    sbl.Append("<span style='color:transparent;background-color:grey;border-color:white;border-style: solid;border-width: 1px'>Empty</span><br>");
                }
            }
            else
            {

                for (int i = count; i < listL.Count(); i++)
                {
                    if (listL[i] == null)
                    {
                        sbl.Append("<span style='color:transparent;background-color:grey;border-color:white;border-style: solid;border-width: 1px'>Empty</span><br>");
                    }
                    else
                    {

                        sbl.Append("<span style='background-color:Lime;border-color:white;border-style: solid;border-width: 1px'>" + listL[i].Trim() + "</span><br>");

                    }
                    sbr.Append("<span style='color:transparent;background-color:grey;border-color:white;border-style: solid;border-width: 1px'>Empty</span><br>");
                }

            }

        }



    }
}
