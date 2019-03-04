
namespace Shop.UIForms.ViewModels
{
    public class MainViewModel
    {
        private static MainViewModel instance;

        public LoginViewModule Login { get; set; }

        public ProductsViewModel Products { get; set; }


        public MainViewModel()
        {
            instance = this;
        }

        public static MainViewModel GetInstance()
        {
            if (instance == null)
            {
                return new MainViewModel();
            }
            return instance;
        }
    }
}
