namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if(this.Suite != null && hospedes.Count <= this.Suite.Capacidade){
                this.Hospedes = hospedes;
                
            }
            else{
                throw new InvalidOperationException("Número de hóspedes excede a capacidade da suíte.");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            return this.Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            
            decimal valorDiaria = this.Suite?.ValorDiaria ?? 0;
            if(this.DiasReservados >= 10){
                valorDiaria *= 0.9M;
            }
            return valorDiaria;
        }
    }
}