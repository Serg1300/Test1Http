using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TSLab.Script;
using TSLab.Script.Handlers;

namespace Test1
{
    public class TestProj : IExternalScript
    {
        private static HttpClient httpClient;        
        private static HttpClientHandler httpClientHandler;
        private static Cookie nameCookie;
        private static CookieContainer cookieContainer;
        private static Uri uri;
        private static XDocument xdoc = new XDocument();
        static TestProj()
        {
            nameCookie = new Cookie("_passport_session" ,"12345");
            uri = new Uri("https://iss.moex.com");
            cookieContainer = new CookieContainer();
            cookieContainer.Add(uri, nameCookie);
            httpClientHandler = new HttpClientHandler();
            httpClientHandler.CookieContainer = cookieContainer;
            httpClient = new HttpClient(httpClientHandler);
        }
        public void Execute(IContext ctx, ISecurity sec)
        {
            
        }
    }
}
