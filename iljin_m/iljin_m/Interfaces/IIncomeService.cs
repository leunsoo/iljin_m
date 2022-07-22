using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using iljin_m.Models;

namespace iljin_m.Interfaces
{
    public interface IIncomeService
    {
        public Task<List<Income>> SelectDataAsync(string itemName, string itemDivCode1, string itemDivCode2, string itemThickness,
                                                 string itemMinWidth, string itemMaxWidth, string itemMemo);
    }
}
