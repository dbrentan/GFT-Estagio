namespace ContaBancaria.src.Entities
{
    public class ContaCorrente : Conta
    {      
          public override void Rendimento(double valorRendimentoMensal)
        {
            
            this.saldo = saldo * valorRendimentoMensal ;
            Console.WriteLine($"O rendimento mensal na Conta Corrente é de {this.saldo}");
        }
    }
}