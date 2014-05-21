using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.IO;

namespace WSTest
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           	
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ////var wr = WebRequest.Create("http://localhost:8080/WSTest/ws_hello?wsdl");
           
            ////HttpWebResponse response = (HttpWebResponse)wr.GetResponse();

            ////Stream receiveStream = response.GetResponseStream();

            //// //Pipes the stream to a higher level stream reader with the required encoding format. 
            ////StreamReader readStream = new StreamReader(receiveStream);

            ////string data = readStream.ReadToEnd();
            ////Response.Write(data);


            string oRequest = "";
            oRequest = "<?xml version='1.0' encoding='UTF-8'?><S:Envelope xmlns:S='http://schemas.xmlsoap.org/soap/envelope/' xmlns:SOAP-ENV='http://schemas.xmlsoap.org/soap/envelope/'>";
            oRequest = oRequest + "<SOAP-ENV:Header/>";
            oRequest = oRequest + "<S:Body>";
            oRequest = oRequest + "<ns2:hello xmlns:ns2='http://test.ws/'>";
            oRequest = oRequest + "<name>SER Softlink</name>";
            oRequest = oRequest + "</ns2:hello>";
            oRequest = oRequest + "</S:Body>";
            oRequest = oRequest + "</S:Envelope>";

            //Builds the connection to the WebService.
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create("http://localhost:8080/WSTest/ws_hello?WSDL");
            req.Headers.Add("SOAPAction", "\"http://tempuri.org/Register\"");
            req.ContentType = "text/xml; charset=\"utf-8\"";
            req.Accept = "text/xml";
            req.Method = "POST";

            //Passes the SoapRequest String to the WebService
            using (Stream stm = req.GetRequestStream())
            {
                using (StreamWriter stmw = new StreamWriter(stm))
                {
                    stmw.Write(oRequest);
                }
            }
            //Gets the response
            WebResponse response = req.GetResponse();
            //Writes the Response
            Stream responseStream = response.GetResponseStream();

            StreamReader readStream = new StreamReader(responseStream);

            string data = readStream.ReadToEnd();
            Response.Write(data);
            //LblTransactionNum.Text = responseStream.ToString();
            
        }
    }
}
