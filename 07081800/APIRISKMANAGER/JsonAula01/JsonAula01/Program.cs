using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JsonAula01.Entity;
using JsonAula01.JsonFrameWork;

namespace JsonAula01
{
    class Program
    {
        static void Main(string[] args)
        {
            String serializado;
            Pessoa pessoa = new Pessoa();
            pessoa.IdPessoa = 1;
            pessoa.Nome = "Jorge";
            pessoa.Email = "jor.hudson";
            JsonSobreCargaPessoa xxx = new JsonSobreCargaPessoa();
            serializado = xxx.SerializarJson(pessoa);

            xxx.DesesarializarJson(serializado);

            Console.ReadKey();
        }
    }
}
