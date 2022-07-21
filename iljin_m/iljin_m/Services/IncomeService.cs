using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using iljin_m.Models;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using iljin_m.Interfaces;
using System.Collections.ObjectModel;

namespace iljin_m.Services
{
    public class IncomeService : IIncomeService
    {
        private HttpClient client;

        public IncomeService()
        {
            client = new HttpClient();
        }

        public async Task<List<Stock>> SelectDataAsync(string itemName, string itemDivCode1 , string itemDivCode2, string itemThickness,
                                                       string itemMinWidth, string itemMaxWidth, string itemMemo )
        {
            List<Stock> stockList = new List<Stock>();

            try
            {
                string url = "http://iljin.ibuild.kr/Scripts/Mobile_Income.aspx";

                string param = $"?itemName={itemName}" +
                               $"&itemDivCode1={itemDivCode1}" +
                               $"&itemDivCode2={itemDivCode2}" +
                               $"&itemThickness={itemThickness}" +
                               $"&itemMinWidth={itemMinWidth}" +
                               $"&itemMaxWidth={itemMaxWidth}" +
                               $"&itemMemo={itemMemo}";

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
