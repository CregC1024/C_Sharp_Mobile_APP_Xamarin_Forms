using C_Sharp_Mobile_APP_Xamarin_Forms.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace C_Sharp_Mobile_APP_Xamarin_Forms.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        public Command LoginCommand { get; }

        public LoginViewModel()
        {
            LoginCommand = new Command(OnLoginClicked);
        }

        private async void OnLoginClicked(object obj)
        {
            // Prefixing with `//` switches to a different navigation stack instead of pushing to the active one
            await Shell.Current.GoToAsync($"//{nameof(AboutPage)}");
        }
    }
}
