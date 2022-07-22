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
    public class IncomeStatusViewModel : Notify
    {
        #region Variable
        private IncomeStatusView incomeStatusView; // 입고현황 View
        private IIncomeService incomeService;      // 입고현황 조회 데이터
        private ItemDiv1Service itemDiv1Service;   // 제품구분1 데이터
        #endregion

        #region Property
        public ICommand SearchBtnOnClickEvent { private set; get; }  // 조회 버튼 이벤트
        public INavigation Navigation { private set; get;  }          // 화면 전환
        public List<KeyValuePair<string, string>> ItemDiv1List { get => itemDiv1Service.ItemDiv1List; } // 제품구분1 List
        public List<Income> IncomeList { private set; get; } // 입고현화 List(DB)
        #endregion 
        
        //생성자
        public IncomeStatusViewModel(IIncomeService _incomeService, IncomeStatusView _incomeStatusView)
        {
            incomeService = _incomeService;
            incomeStatusView = _incomeStatusView;
            Navigation = _incomeStatusView.Navigation;
            itemDiv1Service = new ItemDiv1Service();

            SearchBtnOnClickEvent = new Command(Sch_Button_Clicked);

            //전체 IncomeList, 최대 100건
            IncomeList = incomeService.SelectDataAsync("", "", "", "", "", "", "").Result;
        }
        
        //검색 조건에 맞는 IncomeList 불러오기, 최대 100건
        private void SetIncomeListFromParams()
        {
            IncomeList = incomeService.SelectDataAsync(incomeStatusView.ItemName, incomeStatusView.MinWidth, incomeStatusView.MaxWidth, incomeStatusView.Thickness, incomeStatusView.Memo, "","").Result;
            OnPropertyChanged(nameof(IncomeList));
        }

        //조회 버튼 클릭
        private void Sch_Button_Clicked()
        {
            SetIncomeListFromParams();
        }
    }
}
