using System.Collections.Generic;
using Contatos.Models;

namespace Contatos.Data
{
    public interface IContatosRepo
    {
        IEnumerable<Contato> GetContatos();
        Contato GetContatoById(int id);
    }
}
