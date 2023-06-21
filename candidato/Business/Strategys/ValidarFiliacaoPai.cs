using candidato.Models;

namespace candidato.Business.Strategys
{
    public class ValidarFiliacaoPai : IStrategy
    {
        public string Processar(Candidatoo entidade)
        {
            if(string.IsNullOrEmpty(entidade.Filiacao.NomePai))
            {
                entidade.Filiacao.NomePai = "DESCONHECIDO";
            }

            return null;
        }
    }
}
