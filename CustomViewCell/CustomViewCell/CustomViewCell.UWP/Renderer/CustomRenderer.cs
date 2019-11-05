using CustomViewCell;
using CustomViewCell.UWP.Renderer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using Xamarin.Forms.Platform.UWP;

[assembly: ExportRenderer(typeof(AdView), typeof(AdViewRenderer))]
namespace CustomViewCell.UWP.Renderer
{
    #region ViewRenderer

    class AdViewRenderer : ViewRenderer<AdView, Border>
    {
        protected override void OnElementChanged(ElementChangedEventArgs<AdView> e)
        {
            base.OnElementChanged(e);

            if (Control == null)
            {
                var border = new Border();
                border.Background = new SolidColorBrush(Windows.UI.Colors.Red);
                var textBlock = new TextBlock();
                textBlock.Text = "Custom Ad Display " + new Random().Next(100, 999);
                textBlock.Height = 50;
                border.Child = textBlock;
                this.SetNativeControl(border);
            }
        }
    }
    #endregion
}
