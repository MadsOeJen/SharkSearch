using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace SharkSearch {
    public static class APIHelper {

        public static HttpClient APIClient { get; set; }

        private static string APIKey = "uRwe4jmoqq7UFT8znJLFb1s6qLpiJIKa41HCLwG8";

        public static void InitializeClient() {
            APIClient = new HttpClient();
            APIClient.BaseAddress = new Uri("https://yfapi.net/v6/finance/");
            APIClient.DefaultRequestHeaders.Accept.Clear();
            APIClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            APIClient.DefaultRequestHeaders.Add("X-API-KEY", APIKey);
        }
    }
}
