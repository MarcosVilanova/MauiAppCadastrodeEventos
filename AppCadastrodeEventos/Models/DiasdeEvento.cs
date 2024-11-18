namespace AppCadastrodeEventos.Models
{
    public class DiasdeEvento
    {
        
        public DadosEvento LocalSelecionado { get; set; } 
        
        public string NomeLocal {  get; set; }

        public int NumParticipantes {  get; set; }

        public DateTime DataInicio { get; set; }

        public DateTime DataFinal { get; set; }

        public int TotaldeDias
        {
            get => DataFinal.Subtract(DataInicio).Days;
        }

        public double Total_Participantes
        {
            get
            {
                double participantes01 = NumParticipantes * LocalSelecionado.ValorTotal;

                double total = (participantes01) * TotaldeDias;

                return total;
            }
        }
    }
}
