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

        /************* Excel keys **********************/
        private static string APIKey0 = "uI94RpW8yQ7SLvVYM52UL8l5MDVsoWFjNvOxqu2a"; //Seward
        private static string APIKey1 = "CSS8f5uRAn3nfXet1RjWvIZzzxurkGq2gRnYdbXg"; //bepite
        private static string APIKey2 = "zVAsGhOMJA7IDhGoShHNR9pUDWzd1pZI53Xq7XE5";
        private static string APIKey3 = "li3pi3d5AT7LkbsQm8TCNaFcjUx9sMak22dWmp7f";
        private static string APIKey4 = "bFwo3UbXA88mocccmTIvrads7yrcP9CE8aWCpse6";
        private static string APIKey5 = "4DYHOpGxFE7A1UYYUGzQJG0EapDMfXQ69VC5Jb4c";

        /************* Private keys **********************/
        private static string APIKey6 = "ohNOimyQoLoWc2kAb7908Pxiwo1iVXm55skxxqM2"; //mads@wtcon


        public static void InitializeClient() {
            APIClient = new HttpClient();
            APIClient.BaseAddress = new Uri("https://yfapi.net/");
            APIClient.DefaultRequestHeaders.Accept.Clear();
            APIClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            APIClient.DefaultRequestHeaders.Add("X-API-KEY", APIKey6);
        }
    }
}
