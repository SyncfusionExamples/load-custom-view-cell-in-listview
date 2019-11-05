using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CustomViewCell
{
    #region TemplateSelector
    public class BookTemplateSelector : Xamarin.Forms.DataTemplateSelector
    {
        public DataTemplate BookTemplate { get; set; }
        public DataTemplate AdTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            if (item == null)
                return AdTemplate;

            return BookTemplate;
        }
    }
    #endregion
}
