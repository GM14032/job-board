﻿using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace job_board.Models;

public partial class Evento
{
    public int Id { get; set; }

    public int? IdAspirante { get; set; }

    public string? TipoEvento { get; set; }

    public string? Pais { get; set; }

    public DateTime? Fecha { get; set; }

    public string? Lugar { get; set; }

    public string? Anfitrion { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public virtual Aspirante? IdAspiranteNavigation { get; set; }
}
