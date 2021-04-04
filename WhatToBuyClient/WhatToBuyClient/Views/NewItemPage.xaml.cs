using System;
using System.Collections.Generic;
using System.ComponentModel;
using WhatToBuyClient.Models;
using WhatToBuyClient.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WhatToBuyClient.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}