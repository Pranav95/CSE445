using System;
using System.Collections.Generic;
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

        protected void Button1_Click(object sender, EventArgs e)
        {
            TextBox3.Text = "";
            ServiceReference1.Service1Client myprox = new ServiceReference1.Service1Client();

            string t = TextBox2.Text;

            TextBox3.Text = myprox.stemming(t);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox4.Text = "";

            ServiceReference1.Service1Client myprox = new ServiceReference1.Service1Client();
            string t = TextBox1.Text;

            TextBox4.Text = myprox.WordFilter(t);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Label1.Text = "";

            string t1 = TextBox5.Text;
            string t2 = TextBox6.Text;

            string[] documents = {t1,t2};

            

            ServiceReference2.Service2Client myprox = new ServiceReference2.Service2Client();

            Label1.Text = myprox.TFIDF_score(documents);

          
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Movies mov = new Movies();
            TextBox8.Text = "";
            string tags = TextBox7.Text;

            ServiceReference1.Service1Client myprox = new ServiceReference1.Service1Client();


            string movie = myprox.WordFilter(tags);  
            
            movie = mov.getMovie(movie.Split(' ').ToList());
            TextBox8.Text = movie;
        }
        protected void add_movie(object sender, EventArgs e)
        {
            Movies mov = new Movies();
            string movie = TextBox9.Text;
            string tags = TextBox10.Text;

            if(movie.Length!=0 && tags.Length!=0)
                mov.addMovie(movie, tags);
            TextBox10.Text = "";
            TextBox9.Text = "";
        }
    }
}