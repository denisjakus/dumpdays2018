using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workshop.Interfaces;
using Workshop.Model.Db;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Workshop
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AddNewListItem : ContentPage
	{
		public AddNewListItem ()
		{
			InitializeComponent ();
		}

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            Post post = new Post
            {
                Headline = txtHeadline.Text,
                Text = txtText.Text
            };


            using (var connection = DependencyService.Get<ISQLiteDb>().GetSqliteConnection())
            {
                connection.CreateTable<Post>();
                var rows = connection.Insert(post);

                if (rows > 0)
                {
                    DisplayAlert("Success", "Insert successful", "Ok");
                }
                else
                {
                    DisplayAlert("Error", "Insert NOT successful", "Ok");
                }
            }
        }
    }
}