using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            // Check to see if the button can go back to the
            // previous page
            if(webBrowser1.CanGoBack)
            {
                // If the condition is met, call the GoBack()
                webBrowser1.GoBack();
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            // Like the Back button, check if going forward is
            // allowed.
            if(webBrowser1.CanGoForward)
            {
                // Call the .GoForward if condition is met
                webBrowser1.GoForward();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // Calls the GoHome(), which calls the url for Home
            // page
            webBrowser1.GoHome();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            // Calls the Refresh to allow reloading of the page
            webBrowser1.Refresh();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            // Stops the web browser while loading the page.
            webBrowser1.Stop();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            // Set string variable to the contents(the url) that
            // removes extra spaces from both the beginning and
            // end (if there are any)
            string WebPage = textBox1.Text.Trim();
            webBrowser1.Navigate(WebPage);
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
