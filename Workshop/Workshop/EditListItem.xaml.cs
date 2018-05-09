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
	public partial class EditListItem : ContentPage
	{
        public static BindableProperty UserProperty = BindableProperty.Create("User", typeof(Model.User), typeof(Model.User));

        public Model.User User
        {
            get { return (Model.User)GetValue(UserProperty); }
            set { SetValue(UserProperty, value); }
        }

		public EditListItem ()
		{
			InitializeComponent ();

            BindingContext = this;

		}

        protected override void OnAppearing()
        {
            base.OnAppearing();

            DisplayAlert("User:", this.User.Name.ToString(), "ok");
        }
    }
}