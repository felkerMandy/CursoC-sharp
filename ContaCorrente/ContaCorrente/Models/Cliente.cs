using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoConta.Models
{
    public class Cliente
    {
        public string Nome {  get; set; }
        public string Cpf { get; set; }
        public Endereco Endereco { get; set; }
        public Contato Contato { get; set; }
        public DateTime DataNascimento { get; set; }
        public List<ContaCorrente> ContasCorrentes { get; set; }


        public Cliente(string nome, string cpf, Endereco endereco, Contato contato, DateTime dataNascimento)
        {
            Nome = nome;
            Cpf = cpf;
            this.Endereco = endereco;
            this.Contato = contato;
            this.DataNascimento = dataNascimento;
            ContasCorrentes = new List<ContaCorrente>();
        }

        public void AdicionarContaCorrente(ContaCorrente conta)
        {
            ContasCorrentes.Add(conta);
        }

        public void RemoverContaCorrente(ContaCorrente conta)
        {
            ContasCorrentes.Remove(conta);
        }

        public string ObterDataNascimentoFormatada()
        {
            return DataNascimento.ToString("dd/MM/yyyy");
        }

        public override string ToString()
        {
            return $"Nome: {Nome}, CPF: {Cpf}, Endereço: {Endereco}, Contato: {Contato}, Data de nascimento: {DataNascimento}, Contas: {ContasCorrentes}";
        }

    }
}
