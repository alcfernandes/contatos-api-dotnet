using System.Collections.Generic;
using Contatos.Models;

namespace Contatos.Data
{
    public class MockContatosRepo : IContatosRepo
    {
        public Contato GetContatoById(int id)
        {
            return new Contato{Id=0, Nome="Alessandro", Telefone="(55) 555-5555", Email="teste@teste.com"};
        }

        public IEnumerable<Contato> GetContatos()
        {
            var contatos = new List<Contato>
            {
                new Contato{Id=0, Nome="Alessandro", Telefone="(55) 555-5555", Email="teste@teste.com"},
                new Contato{Id=1, Nome="Maria", Telefone="(55) 555-2222", Email="teste2@teste.com"},
                new Contato{Id=2, Nome="Rui", Telefone="(55) 555-3333", Email="teste3@teste.com"}
            };
            return contatos;
        }
    }
}