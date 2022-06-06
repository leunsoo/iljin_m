using System;
using System.Collections.Generic;
using System.Text;
using iljin_m.Views;
using iljin_m.Models;
using iljin_m.Services;
using System.Windows.Input;
using Xamarin.Forms;
using System.Threading.Tasks;

namespace iljin_m.ViewModels
{
    public class StockSchViewModel : Notify
    {
        private IStockService stockService; // 웹호출
        private StockSchView stockSch; // View
        private ItemDiv1ViewModel itemDiv1ViewModel;

        private List<KeyValuePair<string, string>> itemDiv1List; // 제품구분1 리스트
        private List<Stock> stockList;

        private string itemName; // 제품명
        private string minWidth; // 최소폭
        private string maxWidth; // 최대폭
        private string thickness; // 두께
        private string memo; // 비고
        private int itemDiv1; // 선택한 제품구분1 Index
        private int itemDiv2; // 선택한 제품구분2 Index

        public ICommand BtnCommand { get; set; }
        public ICommand testCommand { get; set; }
        public List<KeyValuePair<string, string>> ItemDiv1List { get => itemDiv1List; set => itemDiv1List = value; }
        public List<Stock> StockList { get => stockList; set => stockList = value; }

        public StockSchViewModel(IStockService _stockService, StockSchView _stockSch)
        {
            stockService = _stockService;
            stockSch = _stockSch;
            itemDiv1ViewModel = DependencyService.Get<ItemDiv1ViewModel>();

            itemDiv1List = itemDiv1ViewModel.ItemDiv1List;

            BtnCommand = new Command(Sch_Button_Clicked);
            testCommand = new Command(itemDiv1ViewModel.pick_itemDiv1_SelectedIndexChanged);
            //SetStockList();
        }

        private void Sch_Button_Clicked()
        {
            SetStockList();
        }                        

        // stockList Setting
        private void SetStockList()
        {
            stockList = stockService.SelectDataAsync("").Result;
        }
    }
}
