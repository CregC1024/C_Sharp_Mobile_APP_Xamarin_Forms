using C_Sharp_Mobile_APP_Xamarin_Forms.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace C_Sharp_Mobile_APP_Xamarin_Forms.Views
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