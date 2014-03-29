using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment_IAD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int curntloc = 0;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public static string FindLink(string htmlstr, ref int startloc)
        {
            int i;
            int start, end;
            string uri = null;


            i = htmlstr.IndexOf("href=\"http", startloc, StringComparison.OrdinalIgnoreCase);
            if (i != -1)
            {
                start = htmlstr.IndexOf('"', i) + 1;
                end = htmlstr.IndexOf('"', start);
                uri = htmlstr.Substring(start, end - start);
                startloc = end;

            }
            return uri;
        }




        private void GO_Click(object sender, EventArgs e)
        {

       


            int ch;
            string html = null;
            //Creating a webrequest to a uri
            //  HttpWebRequest req = (HttpWebRequest)WebRequest.Create("http:\\www.McGraw-Hill.com");
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(textBox1.Text);

            //IWebProxy proxy = new WebProxy("10.1.0.11", 8080);
            //proxy.Credentials = new NetworkCredential("test3", "karachi@3");
            //req.Proxy = proxy;



            //Next send that request and return response
            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();

            //From the response, btain an input stream
            Stream istrm = resp.GetResponseStream();

            // Now consume that data 
            for (int i = 1; ; i++)
            {
                ch = istrm.ReadByte();
                if (ch == -1) break;
                html += (char)ch;
                //   richTextBox1.Text = html;
            }

            richTextBox1.Text = html;

            // Close the Response. 
            resp.Close();




        }

        private void Find_Links_Click(object sender, EventArgs e)
        {
            string link;
            string htmltext = richTextBox1.Text;
            string pagesource = htmltext;
            do
            {
                link = FindLink(pagesource, ref curntloc);
                richTextBox2.Text += FindLink(pagesource, ref curntloc);
            } while (link != null);
                   
        }

        }
    }

