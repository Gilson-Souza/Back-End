using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace candidato.Models;


public class Endereco
{
    public long Id { get; set; }
    public string? Logradouro { get; set; }
    public string? Cep { get; set; }
    public string? Numero { get; set; }


    [ForeignKey("Cidade")]
    public long CidadeId { get; set; }
    public Cidade? Cidade { get; set; }

}
    