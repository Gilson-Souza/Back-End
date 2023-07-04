using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace candidato.Models;

public class Estado
{
    public long Id { get; set; }
    public String? Nome { get; set; }
    public String? Sigla { get; set; }

}
   
