using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Workshop.CustomControl
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DateCell : ViewCell
	{
        public static BindableProperty EnterTextProperty = BindableProperty.Create("EnterText", typeof(string), typeof(string));

        public string EnterText
        {
            get { return (string)GetValue(EnterTextProperty); }
            set { SetValue(EnterTextProperty, value); }
        }
        public DateCell ()
		{
			InitializeComponent ();

            BindingContext = this;
        }
    }
}