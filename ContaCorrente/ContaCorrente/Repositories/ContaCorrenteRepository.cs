using ProjetoConta.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoConta.Repositories
{
    public class ContaCorrenteRepository : ContaCorrente
    {
        public ContaCorrenteRepository(string numero, string agencia, decimal saldo, Cliente cliente) : base(numero, agencia, saldo, cliente)
        {
        }

        public void Depositar(decimal ValorDeposito)
        {
            Saldo = Saldo + ValorDeposito;
        }

        public void Sacar(decimal ValorDeposito)
        {
            Saldo = Saldo - ValorDeposito;
        }

        public void Transferir(decimal valorDeposito, ContaCorrente conta1, ContaCorrente conta2)
        {
            conta1.Saldo = Saldo - valorDeposito;
            conta2.Saldo = Saldo + valorDeposito;
            Console.WriteLine(conta2.Saldo);
        }
    }
}
