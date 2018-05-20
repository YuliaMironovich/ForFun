using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Xml;

namespace TroposphericDelayApplication.Api
{
    public class Client
    {
        static HttpClient client;
        public string Url { get; set; }
        public Client()
        {
            client = new HttpClient();
            Url = "http://api.wunderground.com/auto/wui/geo/WXCurrentObXML/index.xml?query=";
        }

        public XmlDocument  GetMethod()
        {
            var httpRequest = (HttpWebRequest)WebRequest.Create(Url);

            //geting the response from the request url
            var response = (HttpWebResponse)httpRequest.GetResponse();

            //create a stream to hold the contents of the response
            var receiveStream = response.GetResponseStream();

            //creating XML document
            var mySourceDoc = new XmlDocument();

            //load the file from the stream
            mySourceDoc.Load(receiveStream);

            //close the stream
            receiveStream.Close();

            return mySourceDoc;
        }      
    }
}
