using System;
using System.Collections.Generic;
using System.Text;

namespace iljin_m.Models
{
    //재고현황 
    public class Stock
    {
        public string ItemCode      { get; set; } // 제품코드
        public string ItemDiv       { get; set; } // 제품구분 1 + 2
        public string ItemThickness { get; set; } // 제품두께
        public string ItemWidth     { get; set; } // 제품폭
        public string ItemLength    { get; set; } // 제품길이
        public string ItemQty       { get; set; } // 현재고
    }
}
