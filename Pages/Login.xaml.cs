using Microsoft.Maui.Controls;
using System;
using System.Threading.Tasks;
using MauiApp2.Pages;
using System.Diagnostics;
using Microsoft.Extensions.Logging.Abstractions;
using SeuProjeto.Services;

namespace MauiApp2.Pages
{
    public partial class Login : ContentPage
    {
        private readonly MockApiService _apiService;

        public Login()
        {
            InitializeComponent();
            _apiService = new MockApiService();
        }


        private async void OnLoginButtonClicked(object sender, EventArgs e)
        {
            var loginToken = LoginEntry.Text;
            bool isLoginSuccessful = await _apiService.LoginAsync(loginToken);

            if (isLoginSuccessful)
            {
                var userInfo = _apiService.GetUserInfo(loginToken);
                if (userInfo is not null)
                {
                    UserService.Instance.CurrentUser = userInfo;
                    await DisplayAlert("Sucesso", $"Login bem-sucedido! Bem-vindo, {userInfo.Name}", "OK");
                    var homePage = new Home(userInfo);
                    await Shell.Current.GoToAsync("//Home");
                    await Shell.Current.Navigation.PushAsync(homePage);
                }
                else
                {
                    await DisplayAlert("Erro", "Informações do usuário não disponíveis.", "OK");
                }
            }
            else
            {
                await DisplayAlert("Erro", "Login falhou. Por favor, tente novamente.", "OK");
            }

        }


    }
}