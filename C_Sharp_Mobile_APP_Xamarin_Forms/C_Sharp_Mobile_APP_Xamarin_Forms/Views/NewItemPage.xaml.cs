using C_Sharp_Mobile_APP_Xamarin_Forms.Models;
using C_Sharp_Mobile_APP_Xamarin_Forms.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace C_Sharp_Mobile_APP_Xamarin_Forms.Views
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