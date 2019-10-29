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

[assembly: ExportRenderer(typeof(ListViewItemExt), typeof(ItemRendererExt))]
namespace CustomViewCell.Droid
{
    #region ItemRendererExt

    public class ItemRendererExt : ListViewItemRenderer
    {
        public ItemRendererExt(Context context) : base(context)
        {
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            if (e.PropertyName == "ItemData")
            {
                if (this.Control == null)
                {
                    var gridLayout = new GridLayout(this.Context);
                    var textView = new TextView(this.Context);
                    textView.Text = "Native View";
                    gridLayout.AddView(textView);
                    this.SetNativeControl(gridLayout);
                }
            }
        }
    }
    #endregion
}