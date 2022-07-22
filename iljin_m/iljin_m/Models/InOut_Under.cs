using System;
using System.Collections.Generic;
using System.Text;

namespace iljin_m.Models
{
    //재고현황 
    public class InOut_Under
    {
        public string ItemQty      { get; set; } // 수량 
        public string EntryDate    { get; set; } // 입항예정 
        public string DispatchDate { get; set; } // 배차일 
        public string BLNo         { get; set; } // BL번호 
        public string ContainerNo  { get; set; } // 컨테이너번호
    }
}
