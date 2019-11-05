using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using CustomViewCell;
using CustomViewCell.Droid;
using Xamarin.Forms;
using Syncfusion.ListView.XForms.Android;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(AdView), typeof(AdViewRenderer))]
namespace CustomViewCell.Droid
{
    #region ViewRenderer
    public class AdViewRenderer : ViewRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.View> e)
        {
            base.OnElementChanged(e);

            if (Control == null)
            {
                var layout = new FrameLayout(this.Context);
                layout.SetMinimumHeight(100);
                layout.SetBackgroundColor(Android.Graphics.Color.Red);
                var textview = new TextView(Forms.Context);
                textview.Text = "Custom Ad Display " + new Random().Next(100, 999);
                layout.AddView(textview);
                SetNativeControl(layout);
            }
        }
    }
    #endregion
}