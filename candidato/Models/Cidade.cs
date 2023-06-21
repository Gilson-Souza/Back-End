using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace candidato.Models;

public class Cidade
{
    public long Id { get; set; }
    public String? Nome { get; set; }


    [ForeignKey("Estado")]
    public long EstadoId { get;  set; }   
    public Estado? Estado { get;  set; }



    }
