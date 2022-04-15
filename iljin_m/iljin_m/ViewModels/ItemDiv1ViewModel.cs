using System;
using System.Collections.Generic;
using System.Text;
using iljin_m.Models;
using iljin_m.Services;
using System.Windows.Input;
using Xamarin.Forms;
using System.Threading.Tasks;
using System.Linq;

namespace iljin_m.ViewModels
{
    public class ItemDiv1ViewModel : Notify
    {
        //제품구분1 
        private Dictionary<string, string> itemDiv1 = new Dictionary<string, string>() { { "PET","I0002" }, { "PP","I0003" }, { "알미늄","I0004" } };

        //ItemSource
        public List<KeyValuePair<string,string>> ItemDiv1List
        {
            get => itemDiv1.ToList();
        }

        public KeyValuePair<string,string> SelectedItem { get; set; }
    }
}
