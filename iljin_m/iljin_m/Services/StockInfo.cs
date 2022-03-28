using System;
using System.Collections.Generic;
using System.Text;
using iljin_m.Models;

namespace iljin_m.Services
{
    public static class StockInfo
    {
        //재고 정보 가져오기
        public static List<Stock> GetStockInfos()
        {
            List<Stock> stockList = new List<Stock>();

            Stock test = new Stock()
            {
                ItemCode = "test1",
                ItemDiv = "PET_단면",
                ItemThickness = "12",
                ItemWidth = "450",
                ItemLength = "12000",
                ItemQty = "10"
            };

            for(int i = 0; i < 8; i ++)
            {
                stockList.Add(test);
            }

            return stockList;
        }
    }
}
