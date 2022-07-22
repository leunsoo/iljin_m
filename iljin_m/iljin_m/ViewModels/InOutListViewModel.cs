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
    public class InOutListViewModel : Notify
    {
        #region Variable
        private InOutListView inOutListView;              // 입출고내ㅇ View
        private IInOut_Over_Service inOut_Over_Service;   // 입출고 내역 데이터
        private IInOut_Under_Service inOut_Under_Service; // 입항예정 / 입고확정 데이턴
        #endregion

        #region Property
        public List<InOut_Over> InOut_Over_List { private set; get; }   // 입출고 내역 List
        public List<InOut_Under> InOut_Under_List { private set; get; } // 입항예정 / 입고확 List
        #endregion 
        
        //생성자
        public InOutListViewModel(IInOut_Over_Service _inOut_Over_Service, IInOut_Under_Service _inOut_Under_Service, InOutListView _inOutListView)
        {
            inOutListView = _inOutListView;
            inOut_Over_Service = _inOut_Over_Service;
            inOut_Under_Service = _inOut_Under_Service;

            //입출고내역 최대 5건 
            InOut_Over_List = inOut_Over_Service.SelectDataAsync(inOutListView.ItemCode).Result;

            //입항예정 / 입고확정 최대 5건 
            InOut_Under_List = inOut_Under_Service.SelectDataAsync(inOutListView.ItemCode).Result;
        }
    }
}
