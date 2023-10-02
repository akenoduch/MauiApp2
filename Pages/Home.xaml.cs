using System.ComponentModel;
using SeuProjeto.Services;  // Importe o namespace correto aqui
using Microsoft.Maui.Controls;
using System.Diagnostics;

namespace MauiApp2.Pages
{
    public partial class Home : ContentPage
    {
        public UserInfo User { get; private set; }  // Atualizado aqui

        public Home()
        {
            InitializeComponent();
            this.BindingContext = this;
        }

        public Home(UserInfo user)
        {
            InitializeComponent();
            UpdateUser();
            this.BindingContext = this;
        }

        private void UpdateUser()
        {
            User = UserService.Instance.CurrentUser;
        }
    }
}
