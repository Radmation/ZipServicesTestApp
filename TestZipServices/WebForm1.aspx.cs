using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestZipServices
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            ServiceReference1.Zip2City1Client myClient = new ServiceReference1.Zip2City1Client();
            lblCityState.Text = myClient.GetCity(txtZip.Text);
        }
    }
}