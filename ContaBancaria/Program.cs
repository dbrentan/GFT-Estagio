using System;
using ContaBancaria.src.Entities;

namespace ContaBancaria
{
    class Program
    {
        static void Main (string[] args)
        {
            ContaCorrente contaDoBruno = new ContaCorrente();
            contaDoBruno.titular = "Bruno";
            contaDoBruno.saldo = 100;

            ContaPoupanca contaDaAmanda = new ContaPoupanca();
            contaDaAmanda.titular = "Amanda";
            contaDaAmanda.saldo = 200;

            contaDoBruno.Rendimento(contaDoBruno.saldo);
            contaDaAmanda.Rendimento(contaDaAmanda.saldo);

        }
    }
}