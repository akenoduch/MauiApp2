using Microsoft.Maui.Controls;
using System;

namespace MauiApp2.Pages
{
    public partial class HistoricoAcessos : ContentPage
    {
        public HistoricoAcessos()
        {
            InitializeComponent();
        }

        async void OnFecharButtonClicked(object sender, EventArgs e)
        {
            // Fechar a página de popup
            await Navigation.PopAsync();
        }
    }
}
