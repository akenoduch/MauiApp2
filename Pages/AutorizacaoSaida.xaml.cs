using Microsoft.Maui.Controls;
using System;
using MauiApp2.Services;
// using System.Net.Http;  // Descomente esta linha quando a API estiver dispon�vel
// using Newtonsoft.Json;  // Descomente esta linha quando a API estiver dispon�vel

namespace MauiApp2.Pages
{
    public partial class AutorizacaoSaida : ContentPage
    {
        public UserInfo User { get; set; }
        public AutorizacaoSaida()
        {
            InitializeComponent();
            User = UserService.Instance.CurrentUser;
            BindingContext = this;
            // Adicione um handler para mudan�as no CheckBox
            AlunoCheckBox.CheckedChanged += OnCheckBoxChanged;
        }

        private void OnCheckBoxChanged(object sender, CheckedChangedEventArgs e)
        {
            // Ative o bot�o Confirmar se o CheckBox estiver selecionado
            ConfirmarButton.IsEnabled = AlunoCheckBox.IsChecked;
        }

        async void OnConfirmarButtonClicked(object sender, EventArgs e)
        {
            // Suponha que o nome do aluno � obtido com base no CheckBox selecionado
            var alunoNome = AlunoCheckBox.IsChecked ? "Aluno 1" : string.Empty;

            if (!string.IsNullOrEmpty(alunoNome))
            {
                /*
                // Solicita��o POST
                */
                await DisplayAlert("Sucesso", $"O aluno {alunoNome} foi liberado com sucesso!", "OK");
            }
            else
            {
                await DisplayAlert("Erro", "Nenhum aluno foi selecionado.", "OK");
            }
        }
    }
}
