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
    public class ItemDiv1Service
    {
        //제품구분1 
        private Dictionary<string, string> itemDiv1 = new Dictionary<string, string>() { { "I0002", "PET" }, { "I0003", "PP" }, { "I0004", "알미늄" } };

        //ItemSource
        public List<KeyValuePair<string, string>> ItemDiv1List
        {
            get => itemDiv1.ToList();
        }
    }
}
