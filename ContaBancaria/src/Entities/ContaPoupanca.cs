namespace ContaBancaria.src.Entities
{
    public class ContaPoupanca : Conta
    {
          public override void Rendimento(double valorRendimentoMensal = 0.07)
        {
            
            this.saldo *= valorRendimentoMensal;
            Console.WriteLine($"O rendimento mensal na Conta Poupança é de {this.saldo}");
        }
        
    }
}