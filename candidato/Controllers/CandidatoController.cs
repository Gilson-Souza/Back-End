
using candidato.Controllers.Fachadas;
using candidato.Data;
using candidato.DataAccess;
using candidato.DataAccess.daos;
using candidato.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace candidato.Controllers;


[EnableCors("AnotherPolicy")]
[Route("api/[controller]")]
[ApiController]
public class CandidatoController : ControllerBase
{

    private readonly IFachadaCandidato _fachadaCandidato;

    public CandidatoController(IFachadaCandidato fachadaCandidato)
    {
        _fachadaCandidato = fachadaCandidato;

    }

    [HttpGet]
    public async Task<ActionResult<List<Candidatoo>>> ExibirCandidatos()
    {
        List<Candidatoo> candidatos = await _fachadaCandidato.ObterTodos();

        return Ok(candidatos);
    }

    [HttpGet("display/{id}")]
    public async Task<ActionResult<Candidatoo>> BuscarPorID(long id)
    {
        Candidatoo candidato = await _fachadaCandidato.ObterPorId(id);
        return Ok(candidato);
    }

    [HttpPost]
    public async Task<ActionResult<Candidatoo>> CadastrarCandidato([FromBody] Candidatoo candidatoModel)
    {
        Candidatoo candidato = await _fachadaCandidato.Adicionar(candidatoModel);
        return Ok(candidato);
    }

    [HttpPut("edit/{id}")]
    public async Task<ActionResult<Candidatoo>> AtualizarCandidato(long id,[FromBody] Candidatoo candidatoModel)
    {
        candidatoModel.Id = id;
        Candidatoo candidato = await _fachadaCandidato.Atualizar(id, candidatoModel);
        return Ok(candidato);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<Candidatoo>> DeletarCandidato(long id)
    {
        bool apagado = await _fachadaCandidato.Remover(id);
        return Ok(apagado);
    }
}