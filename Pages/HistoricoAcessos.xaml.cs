using Microsoft.Maui.Controls;
using System;
using MauiApp2.Services;

namespace MauiApp2.Pages
{
    public partial class HistoricoAcessos : ContentPage
    {
        public UserInfo User {  get; set; }
        public HistoricoAcessos()
        {
            InitializeComponent();
            User = UserService.Instance.CurrentUser;
            BindingContext = this;
        }

        async void OnFecharButtonClicked(object sender, EventArgs e)
        {
            // Fechar a página de popup
            await Navigation.PopAsync();
        }
    }
}
