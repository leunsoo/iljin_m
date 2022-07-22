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
    public class InOut_Under_Service : IInOut_Under_Service
    {
        private HttpClient client;

        public InOut_Under_Service()
        {
            client = new HttpClient();
        }

        public async Task<List<InOut_Under>> SelectDataAsync(string itemCode)
        {
            List<InOut_Under> stockList = new List<InOut_Under>();

            try
            {
                string url = "http://iljin.ibuild.kr/Scripts/Mobile_InOut_Under_List.aspx";

                string param = $"?itemCode={itemCode}";

                Uri uri = new Uri(url);

                HttpResponseMessage response = await client.GetAsync(uri + param).ConfigureAwait(false);

                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    stockList = JsonConvert.DeserializeObject<List<InOut_Under>>(content);
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
