using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharkSearch.Models {
    public class StockModel {

        public string language { get; set; }
        //"language": "en-US",
        public string region { get; set; }
        //"region": "US",
        public string quoteType { get; set; }
        //"quoteType": "EQUITY",
        public string typeDisp { get; set; }
        //"typeDisp": "Equity",
        public string quoteSourceName { get; set; }
        //"quoteSourceName": "Delayed Quote",
        public string triggerable { get; set; }
        //"triggerable": true,
        public string customPriceAlertConfidence { get; set; }
        //"customPriceAlertConfidence": "HIGH",
        public string currency { get; set; }
        //"currency": "USD",
        public string exchange { get; set; }
        //"exchange": "NYQ",
        public string shortName { get; set; }
        //"shortName": "Ford Motor Company",
        public string longName { get; set; }
        //"longName": "Ford Motor Company",
        public string messageBoardId { get; set; }
        //"messageBoardId": "finmb_106335",
        public string exchangeTimezoneName { get; set; }
        //"exchangeTimezoneName": "America/New_York",
        public string exchangeTimezoneShortName { get; set; }
        //"exchangeTimezoneShortName": "EDT",
        public string gmtOffSetMilliseconds { get; set; }
        //"gmtOffSetMilliseconds": -14400000,
        public string market { get; set; }
        //"market": "us_market",
        public string esgPopulated { get; set; }
        //"esgPopulated": false,
        public string askSize { get; set; }
        //"askSize": 215,
        public string fullExchangeName { get; set; }
        //"fullExchangeName": "NYSE",
        public string financialCurrency { get; set; }
        //"financialCurrency": "USD",
        public string regularMarketOpen { get; set; }
        //"regularMarketOpen": 16.47,
        public string averageDailyVolume3Month { get; set; }
        //"averageDailyVolume3Month": 104343313,
        public string averageDailyVolume10Day { get; set; }
        //"averageDailyVolume10Day": 78068180,
        public string fiftyTwoWeekLowChange { get; set; }
        //"fiftyTwoWeekLowChange": 5.4399996,
        public string fiftyTwoWeekLowChangePercent { get; set; }
        //"fiftyTwoWeekLowChangePercent": 0.48833027,
        public string fiftyTwoWeekRange { get; set; }
        //"fiftyTwoWeekRange": "11.14 - 25.87",
        public string fiftyTwoWeekHighChange { get; set; }
        //"fiftyTwoWeekHighChange": -9.290001,
        public string fiftyTwoWeekHighChangePercent { get; set; }
        //"fiftyTwoWeekHighChangePercent": -0.35910323,
        public string fiftyTwoWeekLow { get; set; }
        //"fiftyTwoWeekLow": 11.14,
        public string fiftyTwoWeekHigh { get; set; }
        //"fiftyTwoWeekHigh": 25.87,
        public string dividendDate { get; set; }
        //"dividendDate": 1646092800,
        public string earningsTimestamp { get; set; }
        //"earningsTimestamp": 1643904300,
        public string earningsTimestampStart { get; set; }
        //"earningsTimestampStart": 1650989100,
        public string earningsTimestampEnd { get; set; }
        //"earningsTimestampEnd": 1651521900,
        public string trailingAnnualDividendRate { get; set; }
        //"trailingAnnualDividendRate": 0.1,
        public string trailingPE { get; set; }
        //"trailingPE": 3.725843,
        public string trailingAnnualDividendYield { get; set; }
        //"trailingAnnualDividendYield": 0.0062266504,
        public string epsTrailingTwelveMonths { get; set; }
        //"epsTrailingTwelveMonths": 4.45,
        public string epsForward { get; set; }
        //"epsForward": 2.3,
        public string epsCurrentYear { get; set; }
        //"epsCurrentYear": 2.04,
        public string priceEpsCurrentYear { get; set; }
        //"priceEpsCurrentYear": 8.127451,
        public string sharesOutstanding { get; set; }
        //"sharesOutstanding": 3933400064,
        public string bookValue { get; set; }
        //"bookValue": 12.117,
        public string fiftyDayAverage { get; set; }
        //"fiftyDayAverage": 19.4312,
        public string fiftyDayAverageChange { get; set; }
        //"fiftyDayAverageChange": -2.8512,
        public string fiftyDayAverageChangePercent { get; set; }
        //"fiftyDayAverageChangePercent": -0.14673309,
        public string twoHundredDayAverage { get; set; }
        //"twoHundredDayAverage": 16.8025,
        public string twoHundredDayAverageChange { get; set; }
        //"twoHundredDayAverageChange": -0.22249985,
        public string twoHundredDayAverageChangePercent { get; set; }
        //"twoHundredDayAverageChangePercent": -0.013242068,
        public string marketCap { get; set; }
        //"marketCap": 66307727360,
        public string forwardPE { get; set; }
        //"forwardPE": 7.208696,
        public string priceToBook { get; set; }
        //"priceToBook": 1.3683255,
        public string sourceInterval { get; set; }
        //"sourceInterval": 15,
        public string exchangeDataDelayedBy { get; set; }
        //"exchangeDataDelayedBy": 0,
        public string pageViewGrowthWeekly { get; set; }
        //"pageViewGrowthWeekly": 0.06660566,
        public string averageAnalystRating { get; set; }
        //"averageAnalystRating": "2.7 - Hold",
        public string tradeable { get; set; }
        //"tradeable": false,
        public string firstTradeDateMilliseconds { get; set; }
        //"firstTradeDateMilliseconds": 76253400000,
        public string priceHint { get; set; }
        //"priceHint": 2,
        public string postMarketChangePercent { get; set; }
        //"postMarketChangePercent": -0.18094504,
        public string postMarketTime { get; set; }
        //"postMarketTime": 1647475199,
        public string postMarketPrice { get; set; }
        //"postMarketPrice": 16.55,
        public string postMarketChange { get; set; }
        //"postMarketChange": -0.030000687,
        public string regularMarketChange { get; set; }
        //"regularMarketChange": 0.52000046,
        public string regularMarketChangePercent { get; set; }
        //"regularMarketChangePercent": 3.237861,
        public string regularMarketTime { get; set; }
        //"regularMarketTime": 1647460941,
        public string regularMarketPrice { get; set; }
        //"regularMarketPrice": 16.58,
        public string regularMarketDayHigh { get; set; }
        //"regularMarketDayHigh": 16.6298,
        public string regularMarketDayRange { get; set; }
        //"regularMarketDayRange": "16.06 - 16.6298",
        public string regularMarketDayLow { get; set; }
        //"regularMarketDayLow": 16.06,
        public string regularMarketVolume { get; set; }
        //"regularMarketVolume": 82400687,
        public string regularMarketPreviousClose { get; set; }
        //"regularMarketPreviousClose": 16.06,
        public string bid { get; set; }
        //"bid": 0.0,
        public string ask { get; set; }
        //"ask": 0.0,
        public string bidSize { get; set; }
        //"bidSize": 388,
        public string marketState { get; set; }
        //"marketState": "PREPRE",
        public string symbol { get; set; }
        //"symbol": "F"

        public string Recommendation {
            get { return RecommendAction().ToString(); }
        }

        public string IsMarketOpen {
            get { 
                if(tradeable == "False") {
                    return "Closed";
                }
                else if (tradeable == "True") {
                    return "Open";
                }
                else {
                    return "Failed";
                }
            }
        }

        private enum Actions {
            Buy,
            Sell,
            Hold
        }

        private Actions RecommendAction() {
            double PriceToBook;
            double EpsCurrentYear;
            double EpsForward;
            double FiftyTwoWeekLow;
            double FiftyTwoWeekHigh;
            double ForwardPE;
            double RegularMarketDayLow;
            double RegularMarketDayHigh;

            try {
                PriceToBook = double.Parse(priceToBook);
                EpsCurrentYear = double.Parse(epsCurrentYear);
                EpsForward = double.Parse(epsForward);
                FiftyTwoWeekLow = double.Parse(fiftyTwoWeekLow);
                FiftyTwoWeekHigh = double.Parse(fiftyTwoWeekHigh);
                ForwardPE = double.Parse(forwardPE);
                RegularMarketDayLow = double.Parse(regularMarketDayLow);
                RegularMarketDayHigh = double.Parse(regularMarketDayHigh);
            }
            catch {
                return Actions.Hold;
            }

            //ActionBook is set to Buy
            Actions ActionBook = Actions.Buy;

            //If PriceToBook is lower than one, then ActionBook is set to buy
            if (PriceToBook < 1) {

                ActionBook = Actions.Buy;

            }

            //If PriceToBook is lower than three, then ActionBook is set to Hold
            else if (PriceToBook < 3) {

                ActionBook = Actions.Hold;

            }

            //If PriceToBook is higher than three, then ActionBook is set to Sell
            else if (PriceToBook > 3) {

                ActionBook = Actions.Sell;

            }


            //ActionPEG is set to Buy
            Actions ActionPEG = Actions.Buy;

            //If Calculated PEG ratio is lower than one, then ActionPEG is set to Buy
            if (ForwardPE / ((1 - (EpsCurrentYear / EpsForward)) * 100) < 1) {

                ActionPEG = Actions.Buy;

            }

            //If Calculated PEG ratio is lower than two, then ActionPEG is set to Hold
            else if (ForwardPE / ((1 - (EpsCurrentYear / EpsForward)) * 100) < 2) {

                ActionPEG = Actions.Hold;

            }

            //If Calculated PEG ratio is higher than two, then ActionPEG is set to Sell
            else if (ForwardPE / ((1 - (EpsCurrentYear / EpsForward)) * 100) > 2) {

                ActionPEG = Actions.Sell;

            }


            //ActionRSI is set to Buy
            Actions ActionRSI = Actions.Buy;

            //If Calculated RSI is lower than fifty, then ActionRSI is set to Buy
            if ((100 - ((100) / (1 + (FiftyTwoWeekLow / FiftyTwoWeekHigh) + (RegularMarketDayLow / RegularMarketDayHigh)))) < 50) {

                ActionRSI = Actions.Buy;

            }

            //If Calculated RSI is lower than eighty, then ActionRSI is set to Hold
            else if ((100 - ((100) / (1 + (FiftyTwoWeekLow / FiftyTwoWeekHigh) + (RegularMarketDayLow / RegularMarketDayHigh)))) < 80) {

                ActionRSI = Actions.Hold;

            }

            //If Calculated RSI is higher than eighty, then ActionRSI is set to Sell
            else if ((100 - ((100) / (1 + (FiftyTwoWeekLow / FiftyTwoWeekHigh) + (RegularMarketDayLow / RegularMarketDayHigh)))) > 80) {

                ActionRSI = Actions.Sell;

            }


            // If any of the parameter are the same, it will return either ActionBook or ActionRSI
            if (ActionBook == ActionPEG || ActionPEG == ActionRSI || ActionRSI == ActionBook) {

                if (ActionBook == ActionPEG) {

                    return ActionBook;

                }

                else {

                    return ActionRSI;

                }

            }
            //If none of parameters are the same, it will return Hold
            else {

                return Actions.Hold;

            }
        }

        public string yahooURL { get {
                return @"https://finance.yahoo.com/quote/" + symbol;
            }
        }

        public void YahooSearch() {
            Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", yahooURL);
        }
    }
}
