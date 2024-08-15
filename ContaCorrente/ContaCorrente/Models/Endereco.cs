using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProjetoConta.Models
{
    public class Endereco
    {
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Cep { get; set; }

        public Endereco(string rua, string numero, string cidade, string estado, string cep)
        {
            Rua = rua;
            Numero = numero;
            Cidade = cidade;
            Estado = estado;
            Cep = cep;
        }

        public void AtualizarEndereco(string rua, string numero, string cidade, string estado, string cep)
        {
            Rua = rua;
            Numero = numero;
            Cidade = cidade;
            Estado = estado;
            Cep = cep;
        }
        public override string ToString()
        {
            return $"Rua: {Rua}, Número: {Numero}, Cidade: {Cidade}, Estado: {Estado}, CEP: {Cep}";
        }
    }
}
