using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace trying
{
    public partial class index : System.Web.UI.Page
    {
        public static int counter = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            display.Text =  "Welcome :  "+content.Text.ToUpper();
        }

        protected void increment(object sender, EventArgs e)
        {
            counter+=2;
            no.Text = counter.ToString();
            
        }
    }
}