﻿using System;
using System.Collections.Generic;
using System.Text;
using iljin_m.Models;
using iljin_m.Services;
using System.Windows.Input;
using Xamarin.Forms;
using System.Threading.Tasks;

namespace iljin_m.ViewModels
{
    public class ItemDiv2ViewModel : Notify
    {
        ItemDiv1ViewModel test;

        public ItemDiv2ViewModel()
        {
            test = new ItemDiv1ViewModel();

            string testStr =  test.SelectedItem.Key;
        }
    }
}
