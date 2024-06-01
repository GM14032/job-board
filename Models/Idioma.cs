using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace job_board.Models;

public partial class Idioma
{
    public int Id { get; set; }

    public int? IdAspirante { get; set; }

    public string? Nombre { get; set; }

    public string? NivelLectura { get; set; }

    public string? NivelHabla { get; set; }

    public string? NivelEscritura { get; set; }

    public string? NivelEscucha { get; set; }

    [JsonIgnore]
    public virtual Aspirante? IdAspiranteNavigation { get; set; }
}
