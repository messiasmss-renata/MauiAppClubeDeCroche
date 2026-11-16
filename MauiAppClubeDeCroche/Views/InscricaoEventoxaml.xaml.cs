
using MauiAppClubeDeCroche.Models;

namespace MauiAppClubeDeCroche.Views;

public partial class InscricaoEvento : ContentPage
{
    public InscricaoEvento(Evento evento)
    {
        InitializeComponent();

        BindingContext = evento;
    }

}
