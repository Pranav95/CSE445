using Microsoft.AspNet.Identity;
using System;
using System.Linq;
using System.Web.UI;
using Assignment_5_Final;
using System.Web;
using System.Xml;
using Encrypt_Decrypt;
public partial class Account_Register : Page
{
    protected void CreateUser_Click(object sender, EventArgs e)
    {
        string filepath = HttpRuntime.AppDomainAppPath + @"\Account\App_data\Passwords.xml";
        string user = UserName.Text;
        string password = Password.Text;

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
        if(!ispresent)
        {
            XmlElement newMem = mydoc.CreateElement("user", rootelement.NamespaceURI);
            rootelement.AppendChild(newMem);

            XmlElement newuser = mydoc.CreateElement("name", rootelement.NamespaceURI);
            newMem.AppendChild(newuser);
            newuser.InnerText = user;

            XmlElement newpassword = mydoc.CreateElement("password", rootelement.NamespaceURI);
            newMem.AppendChild(newpassword);
            password = Encrypt_Decrypt.Cryption.Encrypt(password);
            newpassword.InnerText = password;
            

            mydoc.Save(filepath);
            Label1.Text = "USER CREATED.";
        }

        return;


    }
}