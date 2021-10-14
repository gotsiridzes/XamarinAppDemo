using MobileApp1.ViewModels;
using MobileApp1.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace MobileApp1
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

        private void OnMenuItemClicked(object sender, EventArgs e)
        {

            FlyoutIsPresented = false;
            DisplayAlert("Menu", "Hello World", "OK");
            //await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
