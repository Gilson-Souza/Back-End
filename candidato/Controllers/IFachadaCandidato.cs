using candidato.Models;

namespace candidato.Controllers
{
    public interface IFachadaCandidato
    {
        Task<List<Candidatoo>> ObterTodos();
        Task<Candidatoo> Adicionar(Candidatoo entidade);
        Task<Candidatoo> ObterPorId(long id);
        Task<Candidatoo> Atualizar(long id,Candidatoo entidade);
        Task<bool> Remover(long id);
    }
}
