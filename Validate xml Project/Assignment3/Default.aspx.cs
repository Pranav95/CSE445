using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment3
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Verification(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client verify = new ServiceReference1.Service1Client();
            TextBox5.Text = "";
            //validating urls as given on https://stackoverflow.com/questions/7578857/how-to-check-whether-a-string-is-a-valid-http-url

            Uri url;
            if (Uri.TryCreate(TextBox2.Text,UriKind.Absolute,out url) && Uri.TryCreate(TextBox3.Text, UriKind.Absolute, out url))
            {
                if(TextBox2.Text!=null && TextBox3.Text!=null)
                {
                    TextBox5.Text = verify.verify(TextBox2.Text, TextBox3.Text);
                }
                else
                {
                    TextBox5.Text = "Enter URLs first";
                }
                
            }
            else
            {
                TextBox5.Text = "The URLs are invalid";
            }
        }

        protected void Transform(object sender, EventArgs e)
        {
            ServiceReference2.Service1Client trans = new ServiceReference2.Service1Client();
            Label1.Text = "";
            Uri uri;
            
            if (Uri.TryCreate(TextBox1.Text, UriKind.Absolute, out uri) && Uri.TryCreate(TextBox4.Text, UriKind.Absolute, out uri))
            {
                if(TextBox1.Text!=null && TextBox4.Text!=null)
                {
                    string html = trans.transform(TextBox1.Text, TextBox4.Text);
                    Label1.Text = html; 
                }
                else
                {
                    Label1.Text = "The URLs are invalid";
                }
            }

        }
    }
}