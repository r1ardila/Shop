
namespace Shop.UIForms.ViewModels

{
    using GalaSoft.MvvmLight.Command;
    using System.Windows.Input;
    using Xamarin.Forms;

    public class LoginViewModule
    {

        public string Email { get; set; }

        public string Password { get; set; }

        public ICommand LoginCommand => new RelayCommand(Login);

        public LoginViewModule()
        {
            this.Email = "ardiladm@hotmail.com";
            this.Password = "123456";
        }

        private async void Login()
        {
            if (string.IsNullOrEmpty(this.Email))
            {
                await Application.Current.MainPage.DisplayAlert("Error", "You must enter an email", "Accept");

                return;
            }

            if (string.IsNullOrEmpty(this.Password))
            {
                await Application.Current.MainPage.DisplayAlert("Error", "You must enter a Password", "Accept");

                return;
            }

            if (!this.Email.Equals("ardiladm@hotmail.com") || !this.Password.Equals("123456"))
            {

                await Application.Current.MainPage.DisplayAlert("OK", "User or Password wrong", "Accept");

                return;

            }

            await Application.Current.MainPage.DisplayAlert("OK", "FUCK YEAH!!!", "Accept");

            return;

        }
    }
}
