namespace OperacoesBasicas.src.Entities
{
    public class Operacoes
    {
        double resultado;

        public void Somar (double valorUm, double valorDois)
        { 
            this.resultado = valorUm + valorDois;
            Console.WriteLine($"O Resultado da Soma é: {resultado}");
        }
        public void Subtrair (double valorUm, double valorDois)
        { 
            this.resultado = valorUm - valorDois;
            Console.WriteLine($"O Resultado da Subtração é: {resultado}");
        }
        public void Multiplicar (double valorUm, double valorDois)
        { 
            this.resultado = valorUm * valorDois;
            Console.WriteLine($"O Resultado da Multiplicação é: {resultado}");
        }
        public void Dividir (double valorUm, double valorDois)
        {
            this.resultado = valorUm / valorDois;
            Console.WriteLine($"O Resultado da Divisão é: {resultado}");
        }
    }
}