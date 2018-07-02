using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;
using System;
using System.Web;
using System.Web.UI;
using Assignment_5_Final;
using System.Xml;
using Encrypt_Decrypt

public partial class Account_Login : Page
{
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void LogIn(object sender, EventArgs e)
        {
        string filepath = HttpRuntime.AppDomainAppPath + @"\Account\App_data\Passwords.xml";
        string user = UserName.Text;
        string password = Password.Text;

        password = Encrypt_Decrypt.Cryption.Encrypt(password);
        XmlDocument mydoc = new XmlDocument();
        mydoc.Load(filepath);

        XmlElement rootelement = mydoc.DocumentElement;
        foreach(XmlNode node in rootelement.ChildNodes)
        {
            if(node["name"].InnerText == user)
            {
                if(node["password"].InnerText==password)
                {
                    Response.Redirect(@"Image.aspx");
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