using MauiAppClubeDeCroche.Models;

namespace MauiAppClubeDeCroche.Views;

public partial class CadastroEvento : ContentPage
{
    private Evento evento;

    public CadastroEvento()
    {
        InitializeComponent();
    }

    private async void Btn_calcular_Clicked(object sender, EventArgs e)
    {

        if (string.IsNullOrWhiteSpace(ent_nome.Text))
        {
            await DisplayAlert("Atenção",
                "Informe o nome do participante.", "OK");
            return;
        }

        if (!int.TryParse(ent_participantes.Text, out int participantes)
            || participantes <= 0)
        {
            await DisplayAlert("Atenção",
                "Informe uma quantidade válida de participantes.", "OK");
            return;
        }


        if (!chk_dia20.IsChecked &&
            !chk_dia21.IsChecked &&
            !chk_dia22.IsChecked)
        {
            await DisplayAlert("Atenção",
                "Selecione pelo menos um dia.", "OK");
            return;
        }

        await DisplayAlert("Sucesso",
            "Dados preenchidos corretamente!", "OK");

        await Navigation.PushAsync(new InscricaoEvento(evento));
    }
}
