﻿using System;
using System.Collections.Generic;
using System.Text;
using iljin_m.Models;
using iljin_m.Services;

namespace iljin_m.ViewModels
{
    public class StockViewModel
    {
        private List<Stock> stockList;

        public List<Stock> StockList
        {
            get => stockList;
            set => stockList = value;
        }

        public StockViewModel()
        {
            StockList = StockInfo.GetStockInfos();
        }
    }
}