using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Workshop
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListPage : ContentPage
	{
		public ListPage ()
		{
			InitializeComponent ();

            ToolbarItems.Add(new ToolbarItem("Add to list", "plus", () =>
            {
                Navigation.PushAsync(new AddNewListItem());
            }));
		}
	}
}