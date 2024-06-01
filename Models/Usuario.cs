using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace job_board.Models;

public partial class Usuario
{
    public int Id { get; set; }

    public int? IdEmpresa { get; set; }

    public int? IdAspirante { get; set; }

    public int? IdRol { get; set; }

    public string? Username { get; set; }

    public string? Password { get; set; }

    public string? Estado { get; set; }

    [JsonIgnore]
    public virtual Aspirante? IdAspiranteNavigation { get; set; }

    [JsonIgnore]
    public virtual Empresa? IdEmpresaNavigation { get; set; }

    [JsonIgnore]
    public virtual Rol? IdRolNavigation { get; set; }
}
