using MinimalJwt.Controllers;
using MinimalJwt.Models;
using MinimalJwt.Repositories.Contracts;

namespace MinimalJwt.Repositories
{
    public class AssociadoRepository : IAssociadoRepository
    {
        public static List<Associado> Associados = new()
        {
            new() { IdAssociado = 1, Nome = "Eternals", CPF = "The saga of the Eternals, a race of immortal beings who lived on Earth and shaped its history and civilizations.", NomeMae = "" },
            new() { IdAssociado = 2, Nome = "Dune", CPF = "Feature adaptation of Frank Herbert's science fiction novel, about the son of a noble family entrusted with the protection of the most valuable asset and most vital element in the galaxy.", NomeMae=""},
            new() { IdAssociado = 3, Nome = "The Harder They Fall", CPF = "When an outlaw discovers his enemy is being released from prison, he reunites his gang to seek revenge in this Western.", NomeMae="" },
            new() { IdAssociado = 4, Nome = "Red Notice", CPF = "An Interpol agent tracks the world's most wanted art thief.", NomeMae = "" },
            new() { IdAssociado = 5, Nome = "No Time to Die", CPF = "James Bond has left active service. His peace is short-lived when Felix Leiter, an old friend from the CIA, turns up asking for help, leading Bond onto the trail of a mysterious villain armed with dangerous new technology.", NomeMae = "guajarina" },
        };

        public List<Associado> Get()
        {
            return Associados;
        }
    }
}

