using ProjetoConta.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoConta.Models
{
    public class ContaCorrente
    {
        private readonly Cliente cliente;

        public string Numero { get; set; }
        public string Agencia { get; set; }
        public decimal Saldo { get; set; }
        public Cliente Cliente { get; set; }

        public decimal ValorDeposito { get; set; }

        public ContaCorrente(string numero, string agencia, decimal saldo, Cliente cliente)
        {
            Numero = numero;
            Agencia = agencia;
            Saldo = saldo;
            Cliente = cliente;
        }
        
        public string ExibirExtrato(string numero, string agencia, Cliente cliente)
        {
            Numero = numero;
            Agencia = agencia;
            Cliente = cliente;
            return "a";
        }

    }
}
