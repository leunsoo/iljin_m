using System;
using System.Collections.Generic;
using System.Text;

namespace iljin_m.Models
{
    //재고현황 
    public class InOut_Over
    {
        public string Date      { get; set; } // 일자 
        public string Manager   { get; set; } // 담당자
        public string Adjust    { get; set; } // 조정
        public string Income    { get; set; } // 입고
        public string Release   { get; set; } // 출고 
        public string StockQty  { get; set; } // 재고 
    }
}
