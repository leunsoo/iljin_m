using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using iljin_m.ViewModels;
using iljin_m.Services;

namespace iljin_m.Views
{
    //[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StockSch : ContentPage
    {
        public string ItemName { get => txt_itemName.Text; }
        public string MinWidth { get => txt_width1.Text; }
        public string MaxWidth { get => txt_width2.Text; }

        public StockSch()
        {

            InitializeComponent();
            BindingContext = new StockSchViewModel(new StockService());
        }
    }
}