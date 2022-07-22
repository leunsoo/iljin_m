using System;
using System.Collections.Generic;
using System.Text;

namespace iljin_m.Models
{
    //재고현황 
    public class Income
    {
        public string ItemName      { get; set; } // 제품명
        public string ItemQty       { get; set; } // 수량
        public string DepartureDate { get; set; } // 출발예정일
        public string ArrivalDate   { get; set; } // 입항일
        public string IncomeDate    { get; set; } // 입고일
        public string ContractNo    { get; set; } // 계약번호
    }
}
