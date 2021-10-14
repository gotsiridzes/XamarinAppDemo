using MobileApp1.Models;
using MobileApp1.ViewModels;
using MobileApp1.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace MobileApp1.Services
{
    public class ItemSearchHandler : SearchHandler
    {
        protected override void OnQueryChanged(string oldValue, string newValue)
        {
            base.OnQueryChanged(oldValue, newValue);

            if (string.IsNullOrEmpty(newValue))
            {
                ItemsSource = null;
            }
            else
            {
                ItemsSource = new MockDataStore().GetItemsAsync().Result.Where(x => x.Text.ToLower().Contains(newValue.ToLower())).ToList<Item>();
            }
        }

        protected override async void OnItemSelected(object item)
        {
            if (item == null)
            {
                return;
            }

            await Shell.Current.GoToAsync($"{nameof(ItemDetailPage)}?{nameof(ItemDetailViewModel.ItemId)}={((Item)item).Id}");
        }
    }
}
