namespace MauiApp2.Pages;

public partial class Registry : ContentPage
{
	public Registry()
	{
		InitializeComponent();
	}

    private async void OnAdicionarButtonClicked(object sender, EventArgs e)
    {
        // Navegue para a página de Login
        await Shell.Current.GoToAsync("Login");
    }
}