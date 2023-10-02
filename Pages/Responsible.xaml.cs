using Microsoft.Maui.Controls;
using System;

namespace MauiApp2.Pages
{
    public partial class Responsible : ContentPage
    {
        public Responsible()
        {
            InitializeComponent();
        }

        // Handler para o botão "Autorização de Saída"
        async void OnAutorizacaoSaidaButtonClicked(object sender, EventArgs e)
        {
            var autorizacaoSaida = new AutorizacaoSaida();
            await Navigation.PushAsync(autorizacaoSaida);
        }

        // Handler para o botão "Histórico de Acessos"
        void OnHistoricoAcessosButtonClicked(object sender, EventArgs e)
        {
            var historicoAcessosPage = new HistoricoAcessos();
            Navigation.PushAsync(historicoAcessosPage);
        }

    }
}
