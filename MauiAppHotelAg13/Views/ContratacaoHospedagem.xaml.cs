using Microsoft.Maui.ApplicationModel.DataTransfer;

namespace MauiAppHotelAg13.Views;

public partial class ContratacaoHospedagem : ContentPage
{
	public ContratacaoHospedagem()
	{
		InitializeComponent();
	}
    private async void OnSobreButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new SobreDesenvolvedor());
    }
}