﻿using RestSharp;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Workshop.Interfaces;
using Workshop.Model;
using Xamarin.Forms;

namespace Workshop
{
    public partial class MainPage : TabbedPage
    {

        SQLiteAsyncConnection _connection;

        public MainPage()
        {
            InitializeComponent();

            Children.Add(new ListPage
            {
                Title = "List",
                Icon = "list.png"
            });
            Children.Add(new MapPage
            {
                Title = "Map",
                Icon = "map.png"

            });
            Children.Add(new RestPage
            {
                Title = "Rest",
                Icon = "rest.png"
                
            });

            CurrentPage = Children[1];

        }

        protected override void OnAppearing()
        {
            _connection = DependencyService.Get<ISQLiteDb>().GetSqliteConnection();

            base.OnAppearing();

            
        }
    }
}
