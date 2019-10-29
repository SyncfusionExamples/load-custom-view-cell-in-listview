using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Syncfusion.ListView.XForms;

namespace CustomViewCell
{
    #region ItemGeneratorExt

    public class ItemGeneratorExt : ItemGenerator
    {
        public ItemGeneratorExt(SfListView listview) : base(listview)
        {

        }

        protected override ListViewItem OnCreateListViewItem(int rowIndex, ItemType type, object data = null)
        {
            if (type == ItemType.Record)
            {
                return new ListViewItemExt();
            }
            return base.OnCreateListViewItem(rowIndex, type, data);
        }
    }
    #endregion
}
