using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.IO;

namespace WebServerResponse
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpWebRequest HttpWReq = (HttpWebRequest)WebRequest.Create("http://reg.hairuec.com/register.php/");
            //http://reg.sersoftlink.site50.net/products=its&user=hec&serial=102X-RT80-FH94-80JK

            ASCIIEncoding encoding = new ASCIIEncoding();
            string postData = "product=" + "1111";
            byte[] data = encoding.GetBytes(postData);

            HttpWReq.Method = "POST";
            HttpWReq.ContentType = "application/x-www-form-urlencoded";
            HttpWReq.ContentLength = data.Length;

            Stream newStream = HttpWReq.GetRequestStream();
            newStream.Write(data, 0, data.Length);
            newStream.Close();

            HttpWebResponse response = (HttpWebResponse)HttpWReq.GetResponse();

            Stream responseStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(responseStream, encoding);

            string rest = reader.ReadToEnd();

            Console.WriteLine(Int32.Parse(rest));

            Console.ReadLine();
        }

    }
}

