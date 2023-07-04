using candidato.Models;
using Microsoft.AspNetCore.Mvc;

namespace candidato.DataAccess;

public interface IDao
{
    Task<List<Candidatoo>> ObterTodos();
    Task<Candidatoo> Adicionar(Candidatoo entidade);
    Task<Candidatoo> ObterPorId(long id);
    Task<Candidatoo> Atualizar(Candidatoo entidade, long id);
    Task<bool> Remover(long id);

}
