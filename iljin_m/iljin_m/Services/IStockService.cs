using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using iljin_m.Models;

namespace iljin_m.Services
{
    public interface IStockService
    {
        public Task<List<Stock>> SelectDataAsync(string itemName);
    }
}
