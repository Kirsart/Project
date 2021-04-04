using System.ComponentModel;
using WhatToBuyClient.ViewModels;
using Xamarin.Forms;

namespace WhatToBuyClient.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}