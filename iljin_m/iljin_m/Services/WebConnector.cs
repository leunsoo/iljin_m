using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Http;
using Xamarin.Forms;

namespace iljin_m.ViewModels_DB
{
    public static class WebConnector
    {
        private static HttpClient client;

        private static void Init()
        {
            client = new HttpClient();
        }

        private static void SendHttpRequest(string url)
        {
        }
    }
}
