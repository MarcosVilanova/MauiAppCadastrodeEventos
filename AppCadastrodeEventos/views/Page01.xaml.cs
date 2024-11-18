using AppCadastrodeEventos.Models;
using Microsoft.Maui.Media;

namespace AppCadastrodeEventos.views;

public partial class Page01 : ContentPage


{

    App PropriedadesdoApp;


	public Page01()
	{
		InitializeComponent();

        PropriedadesdoApp = (App)Application.Current;
        pck_local.ItemsSource = PropriedadesdoApp.lista_local;


        inicio.MinimumDate = DateTime.Now;
        inicio.MaximumDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 1, DateTime.Now.Day);

        fim.MinimumDate = inicio.Date.AddDays(1);
        fim.MaximumDate = inicio.Date.AddDays(6);
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        try

        {
            DiasdeEvento h = new DiasdeEvento
            {
                LocalSelecionado = (DadosEvento)pck_local.SelectedItem,

                NumParticipantes = Convert.ToInt32(stp_participantes.Value),


                DataInicio = inicio.Date,

                DataFinal = fim.Date,

                NomeLocal = NomeLocal,



            };




            await Navigation.PushAsync(new Page02()
            {
                BindingContext = h
            });




        }
        catch (Exception ex)
        {
           await DisplayAlert("ops", ex.Message, "OK");
        }
      
            
        }

    

    private void inicio_DateSelected(object sender, DateChangedEventArgs e)
    {
        DatePicker elemento = sender as DatePicker;
        DateTime data_selecionada_inicio = elemento.Date;

        fim.MinimumDate = data_selecionada_inicio.AddDays(1);
        fim.MaximumDate = data_selecionada_inicio.AddDays(6);
    }
}
