using candidato.Models;

namespace candidato.Controllers
{
    public interface IFachadaCandidato
    {
        Task<List<Candidatoo>> ObterTodos();
        Task<Candidatoo> Adicionar(Candidatoo entidade);
        Task<Candidatoo> ObterPorId(long id);
        Task<Candidatoo> Atualizar(Candidatoo entidade, long id);
        Task<bool> Remover(long id);
    }
}
