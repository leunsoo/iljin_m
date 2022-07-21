using System;
using System.Collections.Generic;
using System.Text;
using iljin_m.Views;
using iljin_m.Models;
using iljin_m.Services;
using System.Windows.Input;
using Xamarin.Forms;
using System.Threading.Tasks;
using iljin_m.Interfaces;
using System.Collections.ObjectModel;

namespace iljin_m.ViewModels
{
    public class StockStatusViewModel : Notify
    {
        #region Variable
        private StockStatusView stockStatusView;        // 재고관리 View
        private IStockService stockService;      // 재고관리 조회 데이터
        private ItemDiv1Service itemDiv1Service; // 제품구분1 데이터
        #endregion

        #region Property
        public ICommand SearchBtnOnClickEvent { private set; get; }  // 조회 버튼 이벤트
        public ICommand GridBtnOnClickEvent { private set; get; }    // 입출고내역 클릭 이벤트
        public INavigation Navigation { private set; get;  }          // 화면 전환
        public List<KeyValuePair<string, string>> ItemDiv1List { get => itemDiv1Service.ItemDiv1List; } // 제품구분1 List
        public List<Stock> StockList { private set; get; } // 재고현황 List(DB)
        #endregion 
        
        //생성자
        public StockStatusViewModel(IStockService _stockService, StockStatusView _stockStatusView)
        {
            stockService = _stockService;
            stockStatusView = _stockStatusView;
            Navigation = _stockStatusView.Navigation;
            itemDiv1Service = new ItemDiv1Service();

            SearchBtnOnClickEvent = new Command(Sch_Button_Clicked);
            GridBtnOnClickEvent = new Command(async () => await InOutList_Button_Clicked());

            //전체 StockList, 최대 100건
            StockList = stockService.SelectDataAsync("", "", "", "", "", "", "").Result;
        }
        
        //검색 조건에 맞는 StockList 불러오기, 최대 100건
        private void SetStockListFromParams()
        {
            StockList = stockService.SelectDataAsync(stockStatusView.ItemName, stockStatusView.MinWidth, stockStatusView.MaxWidth, stockStatusView.Thickness, stockStatusView.Memo, "","").Result;
            OnPropertyChanged(nameof(StockList));
        }

        //조회 버튼 클릭
        private void Sch_Button_Clicked()
        {
            SetStockListFromParams();
        }

        //입출고내역 버튼 클릭 => 입출고내역 화면으로 전환
        private async Task InOutList_Button_Clicked()
        {
            await Navigation.PushAsync(new InOutListView());
        }

    }
}
