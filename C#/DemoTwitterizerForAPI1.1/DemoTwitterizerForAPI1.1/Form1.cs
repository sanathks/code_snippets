using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace DemoTwitterizerForAPI1._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OAuthTokens tokens = new OAuthTokens();
            tokens.AccessToken = "";
            tokens.AccessTokenSecret = "";
            tokens.ConsumerKey = "";
            tokens.ConsumerSecret = "";

            UserTimelineOptions userOptions = new UserTimelineOptions();
            userOptions.APIBaseAddress = "https://api.twitter.com/1.1/"; // <-- needed for API 1.1
            userOptions.Count = 20;
            userOptions.UseSSL = true; // <-- needed for API 1.1
            userOptions.ScreenName = "xxxx";//<-- replace with yours

            //TwitterResponse<TwitterStatusCollection> timeline = TwitterTimeline.UserTimeline(tokens, userOptions);
            //MessageBox.Show(timeline.Content.ToString());

            OptionalProperties op = new OptionalProperties();
            op.APIBaseAddress = "https://api.twitter.com/1.1/";
            op.UseSSL = true;
            TwitterDirectMessage.Send(tokens,textBox1.Text, textBox2.Text, op);
        }
    }
}
