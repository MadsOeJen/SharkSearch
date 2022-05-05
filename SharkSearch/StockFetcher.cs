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


        /******************   Fetch one specific stock   ********************/
        public static async Task<StockModel?> FetchStock(string StockSymbol) {
            int UsedKeys = 0;
            bool successful = false;
            while (!successful && UsedKeys <= APIHelper.GetNumberOfKeys()) {
                using (HttpResponseMessage response = await APIHelper.APIClient.GetAsync($"v6/finance/quote?region=US&lang=en&symbols={StockSymbol}")) {
                    if (response.IsSuccessStatusCode) {
                        string StockResult = await response.Content.ReadAsStringAsync();
                        StockModel Stock = DeserializeStockData(StockResult);
                        successful = true;
                        return Stock;
                    }
                    else {
                        APIHelper.ChangeKey();
                        UsedKeys++;
                    }
                }
            }
            return null;
        }


        /******************   Fetch all trending stocks   ********************/
        public static async Task<List<StockModel>?> FetchTrendingStocks() {
            string trendingStocks = await GetTrendingStockSymbols();
            int UsedKeys = 0;
            bool successful = false;
            while (!successful && UsedKeys <= APIHelper.GetNumberOfKeys()) {
                using (HttpResponseMessage response = await APIHelper.APIClient.GetAsync($"v6/finance/quote?region=US&lang=en&symbols={trendingStocks}")) {
                    if (response.IsSuccessStatusCode) {
                        string StockResult = await response.Content.ReadAsStringAsync();
                        List<StockModel> Stocks = DeserializeStocks(StockResult);
                        successful = true;
                        return Stocks;
                    }
                    else {
                        APIHelper.ChangeKey();
                        UsedKeys++;
                    }
                }
            }
            return null;
        }


        /******************   Get symbols of top 20 trending stocks   ********************/
        public static async Task<string?> GetTrendingStockSymbols() {
            int UsedKeys = 0;
            bool successful = false;
            while (!successful && UsedKeys <= APIHelper.GetNumberOfKeys()) {
                using (HttpResponseMessage response = await APIHelper.APIClient.GetAsync($"v1/finance/trending/US")) {
                    if (response.IsSuccessStatusCode) {
                        string CallResult = await response.Content.ReadAsStringAsync();
                        string Symbols = DeserializeTrendingStockData(CallResult);
                        successful = true;
                        return Symbols;
                    }
                    else {
                        APIHelper.ChangeKey();
                        UsedKeys++;
                    }
                }
            }
            return null;
        }



        /******************   Deserialize data for one stock   ********************/
        private static StockModel DeserializeStockData(string stockData) {

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


        /******************   Deserialize data for multiple stocks   ********************/
        private static List<StockModel> DeserializeStocks(string stockData) {

            JObject StockDataObject = JObject.Parse(stockData);

            // get JSON result objects into a list
            IList<JToken> StockDataList = StockDataObject["quoteResponse"]["result"].Children().ToList();

            // serialize JSON results into .NET objects
            List<StockModel> StockObjects = new List<StockModel>();
            foreach (JToken StockData in StockDataList) {
                // JToken.ToObject is a helper method that uses JsonSerializer internally
                StockModel StockObject = StockData.ToObject<StockModel>();
                StockObjects.Add(StockObject);
            }
            return StockObjects;
        }


        /******************   Deserialize data for trending stocks   ********************/
        private static string DeserializeTrendingStockData(string CallResult) {

            string CommaSeperatedSymbols = "";

            JObject TrendingStockJSON = JObject.Parse(CallResult);

            // Turn JSON result objects into a list
            IList<JToken> TrendingStocksList = TrendingStockJSON["finance"]["result"].Children().ToList();
            IList<JToken> TrendingStocks = TrendingStocksList[0]["quotes"].Children().ToList();

            foreach(JToken StockSymbol in TrendingStocks) {
                SymbolModel SymbolOBJ = StockSymbol.ToObject<SymbolModel>();
                CommaSeperatedSymbols += $"{SymbolOBJ.symbol},";
            }

            return CommaSeperatedSymbols;
        }


    }
}
