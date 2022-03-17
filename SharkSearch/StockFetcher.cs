using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SharkSearch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SharkSearch {
    public class StockFetcher {


        public static async Task<StockModel> FetchStock(string StockSymbol) {

            using (HttpResponseMessage response = await APIHelper.APIClient.GetAsync($"quote?region=US&lang=en&symbols={StockSymbol}")) {
                if (response.IsSuccessStatusCode) {
                    string StockResult = await response.Content.ReadAsStringAsync();
                    StockModel Stock = await DeserializeData(StockResult);
                    return Stock;
                }
                else {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        private static async Task<StockModel> DeserializeData(string stockData) {

            JObject StockDataObject = JObject.Parse(stockData);

            // get JSON result objects into a list
            IList<JToken> StockDataList = StockDataObject["quoteResponse"]["result"].Children().ToList();

            // serialize JSON results into .NET objects
            IList<StockModel> StockObjects = new List<StockModel>();
            foreach (JToken StockData in StockDataList) {
                // JToken.ToObject is a helper method that uses JsonSerializer internally
                StockModel StockObject = StockData.ToObject<StockModel>();
                StockObjects.Add(StockObject);
            }

            return StockObjects[0];
        }




    }
}
