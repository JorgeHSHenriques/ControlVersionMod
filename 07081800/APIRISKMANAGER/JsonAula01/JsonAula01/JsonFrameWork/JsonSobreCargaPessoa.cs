using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JsonAula01.Entity;
using Newtonsoft.Json;

namespace JsonAula01.JsonFrameWork
{
    class JsonSobreCargaPessoa
    {

        public Pessoa pessoa;

        public string SerializarJson(Pessoa p)
        {
            string JoinSerializado = JsonConvert.SerializeObject(p);

            Console.Write(JoinSerializado.ToString());

            return JoinSerializado;
        }
        public void DesesarializarJson(String json)
        {
            pessoa = new Pessoa();
            pessoa = JsonConvert.DeserializeObject<Pessoa>(json);
            Console.WriteLine(pessoa.ToString());
        }
    }
}
