using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace candidato.Models;

public class Cidade
{
    public long Id { get; set; }
    public String? Nome { get; set; }
    public virtual Estado? Estado { get;  set; }
    public long EstadoId { get; internal set; }
}
