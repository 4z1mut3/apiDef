using MinimalJwt.Models;
using MinimalJwt.Repositories;

namespace MinimalJwt.Services
{
    public class AssociadoService : IAssociadoService
    {
        public Associado Create(Associado Associado)
        {
            Associado.IdAssociado = AssociadoRepository.Associados.Count + 1;
            AssociadoRepository.Associados.Add(Associado);

            return Associado;
        }


        public List<Associado> Get()
        {
            var Associados = AssociadoRepository.Associados;

            return Associados;
        }

        public Associado Update(Associado newAssociado)
        {
            var oldAssociado = AssociadoRepository.Associados.FirstOrDefault(o => o.IdAssociado == newAssociado.IdAssociado);

            if (oldAssociado is null) return null;

            oldAssociado.Nome = newAssociado.Nome;
            oldAssociado.CPF = newAssociado.CPF;
            oldAssociado.NomeMae = newAssociado.NomeMae;

            return newAssociado;
        }

        public bool Delete(int id)
        {
            var oldAssociado = AssociadoRepository.Associados.FirstOrDefault(o => o.IdAssociado == id);

            if (oldAssociado is null) return false;

            AssociadoRepository.Associados.Remove(oldAssociado);

            return true;
        }
    }
}
