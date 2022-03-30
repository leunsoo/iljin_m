using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using iljin_m.ViewStyles;
using iljin_m.Droid;
using Android.Content.Res;
using System.ComponentModel;

[assembly: ResolutionGroupName("RoutingEffectGroup")]
[assembly: ExportEffect(typeof(UnderlineRemover), "UnderlineRemove")]
namespace iljin_m.Droid
{
    public class UnderlineRemover : PlatformEffect
    {
        public UnderlineRemover() { }

        protected override void OnAttached()
        {
            try
            {
                if(Control != null)
                {
                    Android.Graphics.Color entryUnderLineColor = Android.Graphics.Color.Transparent;
                    Control.BackgroundTintList = ColorStateList.ValueOf(entryUnderLineColor);
                }
            }
            catch(Exception ex)
            {

            }
        }

        protected override void OnDetached() { }

        protected override void OnElementPropertyChanged(PropertyChangedEventArgs args)
        {
            base.OnElementPropertyChanged(args);
        }
    }
}