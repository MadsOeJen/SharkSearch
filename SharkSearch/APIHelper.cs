using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SharkSearch {
    public class APIHelper {

        public static HttpClient APIClient { get; set; }

        public static void InitializeClient() {
            APIClient = new HttpClient();
            APIClient.DefaultRequestHeaders.Accept.Clear();

        }
    }
}
