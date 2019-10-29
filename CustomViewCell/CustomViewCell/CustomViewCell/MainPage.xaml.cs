using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CustomViewCell
{
    public partial class MainPage : ContentPage
    {
        #region Fields

        List<string> itemsSource = new List<string>();

        #endregion

        #region Constructor

        public MainPage()
        {
            InitializeComponent();

            for (int i = 0; i < 50; i++)
                this.itemsSource.Add("ListView Item " + i);

            this.listView.ItemsSource = itemsSource;
            this.listView.ItemTemplate = new DataTemplate(typeof(ViewCellExt));
            this.listView.ItemGenerator = new ItemGeneratorExt(this.listView);
        }
        #endregion
    }

    #region ViewCell

    public class ViewCellExt : ViewCell
    {

    }
    #endregion
}
