using Microsoft.Maui.Controls;
using System;
// using System.Net.Http;  // Descomente esta linha quando a API estiver dispon�vel
// using Newtonsoft.Json;  // Descomente esta linha quando a API estiver dispon�vel

namespace MauiApp2.Pages
{
    public partial class AutorizacaoSaida : ContentPage
    {
        public AutorizacaoSaida()
        {
            InitializeComponent();
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
                HttpClient client = new HttpClient();
                var postData = new StringContent(JsonConvert.SerializeObject(new { Nome = alunoNome }), Encoding.UTF8, "application/json");
                var response = await client.PostAsync("https://api.com/liberar", postData);
                if (response.IsSuccessStatusCode)
                {
                    await DisplayAlert("Sucesso", $"O aluno {alunoNome} foi liberado com sucesso!", "OK");
                }
                else
                {
                    await DisplayAlert("Erro", "Ocorreu um erro ao liberar o aluno. Por favor, tente novamente.", "OK");
                }
                */
                // Como a API ainda n�o est� dispon�vel, mostrando uma mensagem de sucesso diretamente
                await DisplayAlert("Sucesso", $"O aluno {alunoNome} foi liberado com sucesso!", "OK");
            }
            else
            {
                await DisplayAlert("Erro", "Nenhum aluno foi selecionado.", "OK");
            }
        }
    }
}
