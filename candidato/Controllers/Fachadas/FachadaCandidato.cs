﻿using candidato.Business;
using candidato.Business.Exception;
using candidato.DataAccess;
using candidato.DataAccess.daos;
using candidato.Models;
using System.Text;

namespace candidato.Controllers.Fachadas
{
    public class FachadaCandidato : IFachadaCandidato
    {
        private readonly IDao _candidatoDao;
        private readonly List<IStrategy> _strategies;

        public FachadaCandidato(IDao candidatoDao, List<IStrategy> strategies)
        {
            _candidatoDao = candidatoDao;
            _strategies = strategies;
        }

        public async Task<Candidatoo> Adicionar(Candidatoo entidade)
        {
            StringBuilder errors = new StringBuilder();

            foreach (var strategy in _strategies)
            {
                string error = strategy.Processar(entidade);
                if (error != null)
                {
                    errors.AppendLine(error);
                }
            }

            if (errors.Length > 0)
            {
                // Exibe as mensagens de erro
                Console.WriteLine(errors.ToString());
                throw new ValidacaoException(errors.ToString());
            }

            // As validações foram atendidas, envie a solicitação para o DAO
            return await _candidatoDao.Adicionar(entidade);
        }

        public async Task<Candidatoo> Atualizar(long id, Candidatoo entidade)
        {
            StringBuilder errors = new StringBuilder();

            foreach (var strategy in _strategies)
            {
                string error = strategy.Processar(entidade);
                if (error != null)
                {
                    errors.AppendLine(error);
                }
            }

            if (errors.Length > 0)
            {
                // Exibe as mensagens de erro
                Console.WriteLine(errors.ToString());
                throw new ValidacaoException(errors.ToString());
            }

            // As validações foram atendidas, envie a solicitação para o DAO
            return await _candidatoDao.Atualizar(entidade);
        }

        public async Task<Candidatoo> ObterPorId(long id)
        {
            return await _candidatoDao.ObterPorId(id);
        }

        public  async Task<List<Candidatoo>> ObterTodos()
        {
            return await _candidatoDao.ObterTodos();
        }

        public async Task<bool> Remover(long id)
        {
            return await _candidatoDao.Remover(id);
        }
    }
}
