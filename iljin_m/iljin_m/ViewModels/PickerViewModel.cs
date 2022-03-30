using System;
using System.Collections.Generic;
using System.Text;
using iljin_m.Models;
using iljin_m.Services;
using System.Windows.Input;
using Xamarin.Forms;
using System.Threading.Tasks;

namespace iljin_m.ViewModels
{
    public class PickerViewModel : Notify
    {
        private IStockService stockService;

        private List<Stock> stockList;
        private string _content;

        public List<Stock> StockList { get => stockList; set => stockList = value; }
        public ICommand BtnCommand { get; set; }

        public string Content
        {
            get => _content;
            set
            {
                _content = value;
                OnPropertyChanged(nameof(Content));
            }
        }

        public PickerViewModel(IStockService _stockService)
        {
            stockService = _stockService;

            stockList = stockService.SelectDataAsync().Result;
            BtnCommand = new Command(Sch_Button_Clicked);
        }

        private void Sch_Button_Clicked()
        {
            stockList = stockService.SelectDataAsync().Result;
        }                        
    }
}
