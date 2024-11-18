
using AppCadastrodeEventos.Models;

namespace AppCadastrodeEventos
{
    public partial class App : Application
    {
        public List<DadosEvento> lista_local = new List<DadosEvento>
        {
           new DadosEvento
           {
                Descricao = "Local 01",
                ValorTotal = 150,
           },

            new DadosEvento
           {
                Descricao = "Local 02",
                ValorTotal = 150,
           },

            new DadosEvento
           {
                Descricao = "Local 03",
                ValorTotal = 150,
           },

            new DadosEvento
           {
                Descricao = "Local 04",
                ValorTotal = 150,
           },

        };

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new views.Page01());
        }
        
        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);

            window.Width = 370;
            window.Height = 600;


            return window;
        }
    }
}
