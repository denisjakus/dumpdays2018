using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workshop.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Workshop
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class RestPage : ContentPage
	{
        private List<User> _users;
		public RestPage ()
		{
			InitializeComponent ();
        }


        protected override void OnAppearing()
        {
            base.OnAppearing();

            var client = new RestClient("http://jsonplaceholder.typicode.com");
            var request = new RestRequest("/users", Method.GET);

            var response = client.Execute<List<User>>(request).Data;
            
            listView.ItemsSource = _users = response;
        }

        private void On_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            listView.SelectedItem = null;
        }

        private void On_TextChanged(object sender, TextChangedEventArgs e)
        {
            listView.ItemsSource = GetUsers(e.NewTextValue);
        }

        private List<User> GetUsers(string searchText = null)
        {
            if (string.IsNullOrWhiteSpace(searchText))
            {
                return _users;
            }

            return _users.Where(u => u.Name.StartsWith(searchText)).ToList();
        }
    }
}