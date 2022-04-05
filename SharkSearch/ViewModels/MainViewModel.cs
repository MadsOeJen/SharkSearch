using Caliburn.Micro;
using Newtonsoft.Json;
using SharkSearch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;

namespace SharkSearch.ViewModels {
    public class MainViewModel : Screen {

        private string _resultData = "";

        public string ResultData {
            get { return _resultData; }
            set { 
                _resultData = value;
                NotifyOfPropertyChange(() => ResultData);
            }
        }

        public BindableCollection<StockModel> DisplayedStocks { get; set; }

        public MainViewModel() {
            APIHelper.InitializeClient();
            DisplayedStocks = new BindableCollection<StockModel>();
        }
        public async void Loaded() {
            await FetchStock("1810.HK");
            await FetchTrendingStocks();
        }

        public async Task FetchStock(string StockSymbol) {
            StockModel Stock = await StockFetcher.FetchStock(StockSymbol);
            if(Stock != null) {
                Console.WriteLine($"Region: {Stock.symbol}");
                Console.WriteLine($"Name: {Stock.longName}");
                Console.WriteLine($"Maket Cap: {Stock.marketCap} - {Stock.currency}");
                ResultData = $"Symbol: {Stock.region}";
                ResultData += $"\nName: {Stock.longName}";
                ResultData += $"\nMaket Cap: {Stock.marketCap} - {Stock.currency}";
            }
            else {
                ResultData = "Failed to fetch stock data";
            }
        }

        public async Task FetchTrendingStocks() {
            List<StockModel> Stocks = await StockFetcher.FetchTrendingStocks();
            foreach(StockModel Stock in Stocks) {
                DisplayedStocks.Add(Stock);
                ResultData += $"\n____________________________________________________________";
                ResultData += $"\nSymbol: {Stock.symbol}";
                ResultData += $"\nSymbol: {Stock.quoteType}";
                ResultData += $"\nName: {Stock.shortName}";
                ResultData += $"\nMaket Cap: {Stock.marketCap} - {Stock.currency}";
            }
        }

    }
}


