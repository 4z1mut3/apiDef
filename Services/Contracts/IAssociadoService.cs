using MinimalJwt.Models;

namespace MinimalJwt.Services
{
    public interface IAssociadoService
    {
        public Associado Create(Associado Associado);
        public List<Associado> Get();
        public Associado Update(Associado Associado);
        public bool Delete(int id);
    }
}
