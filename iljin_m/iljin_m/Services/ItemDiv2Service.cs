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
using System.Linq;

namespace iljin_m.Services
{
    public class ItemDiv2Service
    {
        private HttpClient client;

        public ItemDiv2Service()
        {
            client = new HttpClient();
        }

        public async Task<List<KeyValuePair<string, string>>> SelectDataAsync()
        {
            List<KeyValuePair<string, string>> itemDivList = new List<KeyValuePair<string, string>>();

            try
            {
                string url = "http://iljin.ibuild.kr/Scripts/Mobile_Get_ItemDiv.aspx";

                Uri uri = new Uri(url);

                HttpResponseMessage response = await client.GetAsync(uri).ConfigureAwait(false);

                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    itemDivList = JsonConvert.DeserializeObject<List<KeyValuePair<string, string>>>(content);
                }
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

            return itemDivList;
        }
    }
}
