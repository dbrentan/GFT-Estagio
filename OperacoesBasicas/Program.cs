using System;
using OperacoesBasicas.src.Entities;

namespace OperacoesBasicas
{
    class Program
    {
        static void Main (string[] args)
        {
            Operacoes calculo = new Operacoes();

            calculo.Somar (20, 10);
            calculo.Subtrair(198, 99);
            calculo.Multiplicar(11549, 9284);
            calculo.Dividir (99999,9);

        }
    }
}