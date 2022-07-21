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
    public partial class IncomeStatusView : ContentPage
    {
        public string ItemName { get => txt_itemName.Text; } // 제품명
        public string MinWidth { get => txt_width1.Text; } // 최소폭
        public string MaxWidth { get => txt_width2.Text; } // 최대폭
        public string Thickness { get => txt_thickness.Text; } // 두께
        public string Memo { get => txt_memo.Text; } // 비고
        public int ItemDiv1 { get => pick_itemDiv1.SelectedIndex; } // 선택한 제품구분1 Index
        public int ItemDiv2 { get => pick_itemDiv2.SelectedIndex; } // 선택한 제품구분2 Index

        public IncomeStatusView()
        {
            BindingContext = new IncomeStatusViewModel(new IncomeService(), this);

            InitializeComponent();
        }
    }
}