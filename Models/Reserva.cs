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
            // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
            if (Suite == null)
            {
                throw new ArgumentException("A suíte não foi cadastrada.");
            }

            if (hospedes == null)
            {
                throw new ArgumentNullException(nameof(hospedes), "A lista de hóspedes não pode ser nula.");
            }
            if (Suite.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {
                // TODO: Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido
                throw new ArgumentException("O número de hóspedes não pode ser maior que a capacidade da suite.");
            }
        }
        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // TODO: Retorna a quantidade de hóspedes (propriedade Hospedes)
            if (Hospedes == null)
            {
                return 0;
            }

            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            // TODO: Retorna o valor da diária
            if (Suite == null)
            {
                throw new ArgumentException("A suíte não foi cadastrada.");
            }

            decimal valor = DiasReservados * Suite.ValorDiaria * (DiasReservados >= 10 ? 0.9M : 1);

            return valor;
        }
    }
}