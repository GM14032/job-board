using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace job_board.Models;

public partial class Empresa
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public string? Descripcion { get; set; }

    public string? Ubicacion { get; set; }

    public string? Telefono { get; set; }

    public string? Email { get; set; }

    [JsonIgnore]
    public virtual ICollection<OfertaLaboral> OfertaLaborals { get; set; } = new List<OfertaLaboral>();

    [JsonIgnore]
    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
