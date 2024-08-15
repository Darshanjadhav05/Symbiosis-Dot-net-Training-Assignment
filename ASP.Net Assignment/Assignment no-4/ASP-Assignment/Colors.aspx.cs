using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP_Assignment
{
    public partial class Colors : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Rainbow rainbow = new Rainbow();
                IEnumerator<string> enumerator = rainbow.GetEnumerator();

                while (enumerator.MoveNext())
                {
                    string currentColor = enumerator.Current;
                    lstColorsUppercase.Items.Add(currentColor.ToUpper());
                    lstColorsLowercase.Items.Add(currentColor.ToLower());
                }
            }
        }
    }
}