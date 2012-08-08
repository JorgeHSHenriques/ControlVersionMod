using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JsonAula01.Entity
{
    public class Pessoa
    {
        private int idPessoa;

        public int IdPessoa
        {
            get { return idPessoa; }
            set { idPessoa = value; }
        }
        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public override string ToString()
        {
            return this.idPessoa + this.nome + this.email;
        }

        public Pessoa()
        {


        }
        public Pessoa(int idPessoa, string nome, string email)
        {
            this.idPessoa = idPessoa;
            this.nome = nome;
            this.email = email;
        }
    }
}
