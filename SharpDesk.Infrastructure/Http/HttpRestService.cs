using System;
using System.IO;
using System.Net;
using System.Text;

namespace SharpDesk.Infrastructure.Http
{
    public class HttpRestService : IHttpRestService
    {
        public string Get(Args args, string uri)
        {
            var req = WebRequest.Create(uri);
            req.Method = "GET";
            var authInfo = args["apikey"] + ":" + "X";
            authInfo = Convert.ToBase64String(Encoding.Default.GetBytes(authInfo));
            req.Headers["Authorization"] = "Basic " + authInfo;

            var resp = req.GetResponse() as HttpWebResponse;
            if (resp != null && resp.StatusCode == HttpStatusCode.OK)
            {
                using (var respStream = resp.GetResponseStream())
                {
                    if (respStream != null)
                    {
                        var reader = new StreamReader(respStream, Encoding.UTF8);
                        return reader.ReadToEnd();
                    }
                }
            }
            
            return String.Empty;
        }
    }
}
