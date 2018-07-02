using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

public partial class Protected2_Staff2Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string username = TextBox1.Text;
        string password = TextBox2.Text;

        
        string filepath = HttpRuntime.AppDomainAppPath + @"\Protected2\Staff2.xml";

        string redirect1 = HttpRuntime.AppDomainAppPath + @"\Protected2\Staff2.aspx";
        string redirect2 = HttpRuntime.AppDomainAppPath + @"\Protected2\Staff2_add.aspx";

        XmlDocument mydoc = new XmlDocument();
        mydoc.Load(filepath);

        XmlElement rootelement = mydoc.DocumentElement;
        foreach (XmlNode node in rootelement.ChildNodes)
        {
            if (node["name"].InnerText == username)
            {
                if (node["password"].InnerText == password)
                {
                    if (node["role"].InnerText == "admin")
                        Response.Redirect(redirect1);
                    else
                        Response.Redirect(redirect2);
                    return;
                }
                else
                {
                    Label1.Text = "PASSWORD OR USERNAME IS WRONG";
                }
            }
        }
    }
}