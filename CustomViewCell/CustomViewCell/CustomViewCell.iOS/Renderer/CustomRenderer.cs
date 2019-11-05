using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using CustomViewCell;
using CustomViewCell.iOS.Renderer;
using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(AdView), typeof(AdViewRenderer))]
namespace CustomViewCell.iOS.Renderer
{
    #region ViewRenderer
    class AdViewRenderer : ViewRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<View> e)
        {
            base.OnElementChanged(e);

            if(Control == null)
            {
                var label = new UILabel();
                label.Text = "Custom Ad Display " + new Random().Next(100, 999);
                label.BackgroundColor = UIColor.Red;
                this.SetNativeControl(label);
            }
        }
    }
    #endregion
}