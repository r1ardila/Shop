
namespace Shop.UIForms.ViewModels
{
    public class MainViewModel
    {
        public LoginViewModule Login { get; set; }

        public MainViewModel()
        {
            this.Login = new LoginViewModule();
        }

    }
}
