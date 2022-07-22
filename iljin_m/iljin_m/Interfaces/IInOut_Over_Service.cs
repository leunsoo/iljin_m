using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using iljin_m.Models;

namespace iljin_m.Interfaces
{
    public interface IInOut_Over_Service
    {
        public Task<List<InOut_Over>> SelectDataAsync(string itemCode);
    }
}
