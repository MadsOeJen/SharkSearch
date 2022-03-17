using Caliburn.Micro;
using Newtonsoft.Json;
using SharkSearch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public MainViewModel() {
            APIHelper.InitializeClient();
        }
        public async void Loaded() {
            await FetchStock("F");
        }

        public async Task FetchStock(string StockSymbol) {
            StockModel Stock = await StockFetcher.FetchStock(StockSymbol);
            Console.WriteLine($"Symbol: {Stock.symbol}");
            Console.WriteLine($"Name: {Stock.longName}");
            Console.WriteLine($"Maket Cap: {Stock.marketCap} - {Stock.currency}");
            ResultData = $"Symbol: {Stock.symbol}";
            ResultData += $"\nName: {Stock.longName}";
            ResultData += $"\nMaket Cap: {Stock.marketCap} - {Stock.currency}";
        }

        public async Task FetchTrendingStocks() {

        }


    }
}
