using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Image : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label2.Visible = false;
        Label3.Text = "";
    }

    protected void btn_newIMG_Click(object sender, EventArgs e)
    {
        ServiceReference1.ServiceClient client = new ServiceReference1.ServiceClient();
        var verifier = client.GetVerifierString(5.ToString());
        Image1.ImageUrl = "http://neptune.fulton.ad.asu.edu/WSRepository/Services/ImageVerifier/Service.svc/GetImage/" + verifier;
    }

    protected void btn_verify_Click(object sender, EventArgs e)
    {
        var key = Image1.ImageUrl.Substring(Image1.ImageUrl.Length - 5);

        if (txtVerify.Text.Equals(key))
        {
            Server.Transfer("MainPage.aspx");
        }
        else
        {
            Label3.Text = "Wrong input!";
        }
    }
}