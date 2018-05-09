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
    public partial class ListPage : ContentPage
    {
        public ListPage()
        {
            InitializeComponent();

            ToolbarItems.Add(new ToolbarItem("Add to list", "plus", () =>
            {
                Navigation.PushAsync(new AddNewListItem());
            }));
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            using (var connection = DependencyService.Get<ISQLiteDb>().GetSqliteConnection())
            {
                connection.CreateTable<Post>();
                var postList = connection.Table<Post>().ToList();

                postListView.ItemsSource = postList;
            }
        }

        private void EditContextAction_Clicked(object sender, EventArgs e)
        {
            // get post

            var menuItem = sender as MenuItem;
            var post = menuItem.CommandParameter as Post;

            Navigation.PushAsync(new EditListItem(post));
        }

        private void DeleteContextAction_Clicked(object sender, EventArgs e)
        {
            //Do Delete Logic
        }

        private void ListViewItem_Selected(object sender, SelectedItemChangedEventArgs e)
        {
            var selectedPost = e.SelectedItem as Post;
            Navigation.PushAsync(new EditListItem(selectedPost));
        }
    }
}