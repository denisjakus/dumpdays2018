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
	public partial class EditListItem : ContentPage
	{
        private Post _editPost;

        public EditListItem (Post editPost)
		{
			InitializeComponent ();
            _editPost = editPost;
		}

        protected override void OnAppearing()
        {
            base.OnAppearing();
            lblId.Text = _editPost.Id.ToString();
            txtHeadline.Text = _editPost.Headline;
            txtText.Text = _editPost.Text;
        }

        private void Update_Clicked(object sender, EventArgs e)
        {
            using(var connection = DependencyService.Get<ISQLiteDb>().GetSqliteConnection())
            {
                connection.CreateTable<Post>();

                var postToUpdate = connection.Table<Post>().FirstOrDefault(p=>p.Id == _editPost.Id);

                postToUpdate.Headline = txtHeadline.Text;
                postToUpdate.Text = txtText.Text;

                connection.Update(postToUpdate);

                DisplayAlert("Success", "Post updated!", "Ok");
            }
        }
    }
}