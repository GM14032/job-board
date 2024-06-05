using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace job_board.Models;

public partial class Educacion
{
    public int Id { get; set; }

    public int? IdAspirante { get; set; }

    public string? Nombre { get; set; }

    public string? Periodo { get; set; }

    public string? Institucion { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public virtual Aspirante? IdAspiranteNavigation { get; set; }
}
