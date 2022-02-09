namespace ContaBancaria.src.Entities
{
    public abstract class Conta
    {
        public int numeroConta;
        public string? titular;
        public double saldo;

        public virtual void Rendimento(double valorRendimentoMensal)
        {
            this.saldo = valorRendimentoMensal;
        }


    }
}