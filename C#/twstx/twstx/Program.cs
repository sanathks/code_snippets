using System;
using System.Collections.Generic;
using System.Text;
using Twitterizer;
using System.Runtime.InteropServices;

namespace twstx
{
    class Program
    {
        [DllImport("kernel32.dll")]
        static extern bool FreeConsole();

        static void Main(string[] args)
        {

            Console.Write("hELLO !");
            Console.Title = "WAIT.......";
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
            OptionalProperties op = new OptionalProperties();

            op.APIBaseAddress = "https://api.twitter.com/1.1/";
            op.UseSSL = true;

            //TwitterResponse<TwitterStatusCollection> timeline = TwitterTimeline.UserTimeline(tokens, userOptions);
            //MessageBox.Show(timeline.Content.ToString());
            var a = TwitterDirectMessage.Send(tokens, "@SerAlert", "PC-ON :" + DateTime.Now.ToShortDateString() + " : " + DateTime.Now.ToShortTimeString(), op);
        }
    }
}
