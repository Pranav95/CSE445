using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

public partial class Protected2_Staff2_add : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string filepath = HttpRuntime.AppDomainAppPath + @"\Protected2\Staff2.xml";
        string user = TextBox1.Text;

        XmlDocument mydoc = new XmlDocument();
        mydoc.Load(filepath);

        XmlElement rootelement = mydoc.DocumentElement;
        foreach (XmlNode node in rootelement.ChildNodes)
        {

            if (node["name"].InnerText == user)
            {
                node["role"].InnerText = "admin";
                return;
            }
            return;
        }
        Label1.Text = "User not found, first add user";
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        string filepath = HttpRuntime.AppDomainAppPath + @"\Protected2\Staff2.xml";
        string user = TextBox2.Text;
        string password = TextBox3.Text;

        XmlDocument mydoc = new XmlDocument();
        mydoc.Load(filepath);

        bool ispresent = false;

        XmlElement rootelement = mydoc.DocumentElement;
        foreach (XmlNode node in rootelement.ChildNodes)
        {

            if (node["name"].InnerText == user)
            {
                Label1.Text = "User already registered";
                ispresent = true;
             
            }
        }
        if (!ispresent)
        {
            XmlElement newMem = mydoc.CreateElement("user", rootelement.NamespaceURI);
            rootelement.AppendChild(newMem);

            XmlElement newuser = mydoc.CreateElement("name", rootelement.NamespaceURI);
            newMem.AppendChild(newuser);
            newuser.InnerText = user;

            XmlElement newpassword = mydoc.CreateElement("password", rootelement.NamespaceURI);
            newMem.AppendChild(newpassword);
            newpassword.InnerText = password;

            XmlElement newrole = mydoc.CreateElement("role", rootelement.NamespaceURI);
            newMem.AppendChild(newrole);
            newrole.InnerText = "";
        
            mydoc.Save(filepath);
            Label2.Text = "USER CREATED.";
        }




    }
}