using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http;
using System.Net.Http.Headers;

namespace WebMvc
{
    public static class GloVariable
    {
        public static HttpClient webclient = new HttpClient();
        static GloVariable()
        {
            webclient.BaseAddress = new Uri("https://localhost:44346/api/Products");
            webclient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

    }

    
}