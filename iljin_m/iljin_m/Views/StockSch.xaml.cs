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
        public StockSch()
        {
            InitializeComponent();
            BindingContext = new StockSchViewModel(new StockService());
        }
    }
}