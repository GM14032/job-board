using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace job_board.Models;

public partial class Conocimiento
{
    public int Id { get; set; }

    public int? IdOferta { get; set; }

    public int? IdAspirante { get; set; }

    public string? Nombre { get; set; }

    public string? Descripcion { get; set; }

    public string? Nivel { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public virtual Aspirante? IdAspiranteNavigation { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public virtual OfertaLaboral? IdOfertaNavigation { get; set; }
}
