using System;
using System.Collections.Generic;
using System.Text;
using iljin_m.Models;
using iljin_m.Services;
using System.Windows.Input;
using Xamarin.Forms;
using System.Threading.Tasks;
using iljin_m.ViewModels;
using System.Linq;

[assembly:Dependency(typeof(ItemDiv1ViewModel))]
namespace iljin_m.ViewModels
{
    public class ItemDiv1ViewModel : Notify
    {
        //제품구분1 
        private Dictionary<string, string> itemDiv1 = new Dictionary<string, string>() { { "I0002", "PET" }, { "I0003", "PP" }, { "I0004", "알미늄" } };

        //ItemSource
        public List<KeyValuePair<string,string>> ItemDiv1List
        {
            get => itemDiv1.ToList();
        }

        public KeyValuePair<string,string> SelectedItem { get; set; }
        public ICommand SelectedItemDivChanged { get; set; }

        public ItemDiv1ViewModel()
        {
            SelectedItemDivChanged = new Command(pick_itemDiv1_SelectedIndexChanged);

        }

        public void pick_itemDiv1_SelectedIndexChanged()
        {
        }
    }
}
