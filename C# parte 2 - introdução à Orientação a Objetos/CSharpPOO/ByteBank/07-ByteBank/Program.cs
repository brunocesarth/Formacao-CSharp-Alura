using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("O total de contas até o momento é de " + ContaCorrente.TotalDeContasCriadas + " contas");

            ContaCorrente conta = new ContaCorrente(867, 86712540);

            Console.WriteLine("O total de contas até o momento é de " + ContaCorrente.TotalDeContasCriadas + " contas");

            Console.WriteLine(conta.Agencia);
            Console.WriteLine(conta.Numero);

            ContaCorrente contaDaGabriela = new ContaCorrente(867, 86745820);

            Console.WriteLine("O total de contas até o momento é de " + ContaCorrente.TotalDeContasCriadas + " contas");



            Console.ReadLine();
        }
    }
}
