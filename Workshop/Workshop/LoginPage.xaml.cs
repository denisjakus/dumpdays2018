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
	public partial class LoginPage : ContentPage
	{
		public LoginPage ()
		{
			InitializeComponent ();
		}

        private void btnLogin_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(userName.Text))
            {
                userName.PlaceholderColor = Color.Red;
                return;
            }
            if (string.IsNullOrWhiteSpace(password.Text))
            {
                password.PlaceholderColor = Color.Red;
                return;
            }
            this.Navigation.PushAsync(new MainPage());
        }
    }
}