using MauiApp2.Pages;

namespace MauiApp2
{
    public partial class AppShell : Shell
    {
        private static UserInfo currentUser;
        public static UserInfo CurrentUser
        {
            get => currentUser;
            set
            {
                if (CurrentUser != value)
                {
                    currentUser = value;
                    OnCurrentUserChanged?.Invoke(null, currentUser);
                }
            }
        }
        public static event EventHandler<UserInfo> OnCurrentUserChanged;

        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("Login", typeof(Login));
        }
    }
}