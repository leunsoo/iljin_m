using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using iljin_m.ViewModels;
using iljin_m.Services;
using iljin_m.Interfaces;

namespace iljin_m.Views
{
    //[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InOutListView : ContentPage
    {
        public string ItemCode { private set; get; }

        public InOutListView(string SelectedItemName)
        {
            Txt_ItemName.Text = SelectedItemName;
            //BindingContext = new InOutListViewModel(new InOut_Over_Service(), new InOut_Under_Service(), this);

            InitializeComponent();
        }
    }
}