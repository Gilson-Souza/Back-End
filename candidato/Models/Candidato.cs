using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace candidato.Models;

public class Candidatoo
{

    public long Id { get;  set; }

    public string? Nome { get;  set; }


    [ForeignKey("Filiacao")]
    public long FiliacaoId { get; set; }
    public Filiacao? Filiacao { get; set; }


    [ForeignKey("Endereco")]
    public long EnderecoId { get; set; }
    public Endereco? Endereco { get; set; }

    public  List<Telefone>? Telefones { get; set; }
   
    public List<Curso>? Cursos { get;  set; }

    
}
