using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Twitterizer;

namespace TwitterAppTest
{
    public partial class Form1 : Form
    {
        //public static string consumerKey = "bd1SIg4gcxc4Qjv2ZNk4EA";
        //public static string consumerSecret = "C9Q4rYGdQKC7xelatvpEs97nlxGrsCWFgEBa3F0un8";
        //string callbackAddy = "oob";
        //public static OAuthTokens tokens;
        //OAuthTokenResponse tokenResponse2;
        //OAuthTokenResponse tokenResponse;

        //tokens.AccessToken = TwitterStuff.tokenResponse2.Token;
        //tokens.AccessTokenSecret = TwitterStuff.tokenResponse2.TokenSecret;
        //tokens.ConsumerKey = TwitterStuff.consumerKey;
        //tokens.ConsumerSecret = TwitterStuff.consumerSecret;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OAuthTokens tokens = new OAuthTokens();
            tokens.AccessToken = "1196314320-qrQk8YULpaqzqfti6xjPpkcu72r4eRVXQiLRWGG";
            tokens.AccessTokenSecret = "FTrOCs9eDcxJ55pachKH3M4lrMnowTuuUDquUpGUv8";
            tokens.ConsumerKey = "bWG35i1Say0iIGCWMYbZag";
            tokens.ConsumerSecret = "zRd2UVf9X0fUQp1GcmrgDfYJ2jjLzH5HIjpBpC9zSo";

            UserTimelineOptions userOptions = new UserTimelineOptions();
            userOptions.APIBaseAddress = "https://api.twitter.com/1.1/"; // <-- needed for API 1.1
            userOptions.Count = 20;
            userOptions.UseSSL = true; // <-- needed for API 1.1
            userOptions.ScreenName = "sersoftlink";//<-- replace with yours
            OptionalProperties op=new OptionalProperties();

            op.APIBaseAddress= "https://api.twitter.com/1.1/";
            op.UseSSL=true;
           
            //TwitterResponse<TwitterStatusCollection> timeline = TwitterTimeline.UserTimeline(tokens, userOptions);
            //MessageBox.Show(timeline.Content.ToString());
            var a = TwitterDirectMessage.Send(tokens, "@SerAlert", "PC-ON :" + DateTime.Now.ToShortDateString()+ " : " + DateTime.Now.ToShortTimeString(), op);
           //MessageBox.Show(a.Content.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //tokenResponse = new OAuthTokenResponse();
            //tokenResponse = Twitterizer.OAuthUtility.GetRequestToken(consumerKey, consumerSecret, callbackAddy);
            ////textBox1.Text = "Token is:  " + tokenResponse.Token.ToString();

            //string target = "http://twitter.com/oauth/authorize?oauth_token=" + tokenResponse.Token;
            //try
            //{
            //    System.Diagnostics.Process.Start(target);
            //}
            //catch (System.ComponentModel.Win32Exception noBrowser)
            //{
            //    if (noBrowser.ErrorCode == -2147467259)
            //        MessageBox.Show(noBrowser.Message);
            //}
            //catch (System.Exception other)
            //{
            //    MessageBox.Show(other.Message);
            //}
            ////tokenResponse2 = new OAuthTokenResponse();
            ////string pin = Properties.Settings.Default.pin;
            ////tokenResponse2 = OAuthUtility.GetAccessToken(consumerKey, consumerSecret, tokenResponse.Token, pin);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OAuthTokens tokens = new OAuthTokens();
            tokens.AccessToken = "1545351163-tIggq5jzkRW03fv0qDDmTTW9WOntJlKZVc0QPLr";
            tokens.AccessTokenSecret = "AM5BGHmLK3aJ4NC9ScQINebWXPeFTxf6oVgqutRi1qM";
            tokens.ConsumerKey = "bd1SIg4gcxc4Qjv2ZNk4EA";
            tokens.ConsumerSecret = "C9Q4rYGdQKC7xelatvpEs97nlxGrsCWFgEBa3F0un8";


            List<string> temp = new List<string>();
            var receivedMessages = TwitterDirectMessage.DirectMessages(tokens);
            foreach (var v in receivedMessages.ResponseObject)
            {
               // temp.Add(v.Recipient.ScreenName + " >> " + v.Text);

                MessageBox.Show(v.Recipient.ScreenName + " >> " + v.Text);
            }

            
        }
    }
}
