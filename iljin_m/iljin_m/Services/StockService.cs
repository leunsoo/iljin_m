using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using iljin_m.Models;
using System.Net;
using System.Net.Http;
using Xamarin.Forms;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace iljin_m.Services
{
    public class StockService : IStockService
    {
        private HttpClient client;

        public StockService()
        {
            client = new HttpClient();
        }

        public async Task<List<Stock>> SelectDataAsync()
        {
            List<Stock> stockList = new List<Stock>();

            try
            {
                string url = "http://iljin.ibuild.kr/Scripts/Mobile_Stock.aspx";
                string param = "";

                Uri uri = new Uri(url);

                HttpResponseMessage response = await client.GetAsync(uri + param).ConfigureAwait(false);

                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    stockList = JsonConvert.DeserializeObject<List<Stock>>(content);
                }
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

            return stockList;
        }
    }
}
