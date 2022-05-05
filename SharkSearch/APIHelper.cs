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

        private static int keyIndex = 0;

        /************* Excel keys **********************/
        private static string APIKey0 = "uI94RpW8yQ7SLvVYM52UL8l5MDVsoWFjNvOxqu2a"; //Seward //
        private static string APIKey1 = "ZgyimbzcwJ8Dz60sZrcgg82zWqQm1s08aOlbRzXg"; //bepite //
        private static string APIKey2 = "wjCjsStviFaaJ8ZRi2VAS15QDbtKpefI4L7rbZxS"; //nadoner //
        private static string APIKey3 = "TJ2z7TRZzz7ra9eoJnF4f7b583VnmNh8OxXnyjfg"; //maxfield //
        private static string APIKey4 = "0WlPUPEuCH2dqXVot5V1N8YZeTsACauY4hDxHv9W"; //kreis //
        private static string APIKey5 = "G2ZRvaxcRt5bToLYxzBegaGvG4VknEG6dlQN5vUh"; //bimafa //


        private static List<string> ApiKeys = new List<string>() {
            "uI94RpW8yQ7SLvVYM52UL8l5MDVsoWFjNvOxqu2a",
            "ZgyimbzcwJ8Dz60sZrcgg82zWqQm1s08aOlbRzXg",
            "wjCjsStviFaaJ8ZRi2VAS15QDbtKpefI4L7rbZxS",
            "TJ2z7TRZzz7ra9eoJnF4f7b583VnmNh8OxXnyjfg",
            "0WlPUPEuCH2dqXVot5V1N8YZeTsACauY4hDxHv9W",
            "G2ZRvaxcRt5bToLYxzBegaGvG4VknEG6dlQN5vUh"
        };

        public static int GetNumberOfKeys() {
            return ApiKeys.Count;
        }

        public static void InitializeClient() {
            APIClient = new HttpClient();
            APIClient.BaseAddress = new Uri("https://yfapi.net/");
            APIClient.DefaultRequestHeaders.Accept.Clear();
            APIClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            APIClient.DefaultRequestHeaders.Add("X-API-KEY", GetNewKey());
        }

        public static void ChangeKey() {
            APIClient = new HttpClient();
            APIClient.BaseAddress = new Uri("https://yfapi.net/");
            APIClient.DefaultRequestHeaders.Accept.Clear();
            APIClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            APIClient.DefaultRequestHeaders.Add("X-API-KEY", GetNewKey());
        }

        private static string GetNewKey() {
            if(keyIndex < ApiKeys.Count) {
                keyIndex++;
                return ApiKeys[keyIndex - 1];
            }
            else {
                keyIndex = 0;
                return ApiKeys[keyIndex];
            }
        }
    }
}
