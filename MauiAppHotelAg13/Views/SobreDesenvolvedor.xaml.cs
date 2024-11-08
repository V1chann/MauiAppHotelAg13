namespace MauiAppHotelAg13.Views;

public partial class SobreDesenvolvedor : ContentPage
{
	public SobreDesenvolvedor()
	{
		InitializeComponent();
	}
    private async void OnVoltarButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}