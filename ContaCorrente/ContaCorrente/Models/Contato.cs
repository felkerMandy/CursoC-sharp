using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoConta.Models
{
    public class Contato
    {
        public string Email {get; set;}
        public string Telefone {get; set;}

        public Contato(string email, string telefone)
        {
            Email = email;
            Telefone = telefone;
        }

        public void AtualizarEmail(string email)
        {
            Email = email;
        }

        public void AtualizarTelefone(string telefone)
        {
            Telefone = telefone;
        }
        public override string ToString()
        {
            return $"Email: {Email}\n Telefone: {Telefone}";
        }
    }
}

 
