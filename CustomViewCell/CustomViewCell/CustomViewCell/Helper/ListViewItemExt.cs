using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Syncfusion.ListView.XForms;

namespace CustomViewCell
{
    #region ListViewItemExt

    public class ListViewItemExt : ListViewItem
    {
        private object itemData;

        public object ItemData
        {
            get { return itemData; }
            set
            {
                itemData = value;
                OnPropertyChanged("ItemData");
            }
        }

        protected override void OnBindingContextChanged()
        {
            this.ItemData = this.BindingContext;
            base.OnBindingContextChanged();
        }
    }
    #endregion
}
