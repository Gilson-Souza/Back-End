﻿using System.ComponentModel.DataAnnotations;
namespace candidato.Models;

public class Telefone
{
    public long Id { get;  set; }
    public string? Numero { get;  set; }
    public virtual TipoTelefone Tipo { get;  set; }

}

