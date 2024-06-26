﻿using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace job_board.Models;

public partial class Resultado
{
    public int Id { get; set; }

    public int? IdAspirante { get; set; }

    public string? TipoExamen { get; set; }

    public string? Resultado1 { get; set; }

    [JsonIgnore]
    public virtual Aspirante? IdAspiranteNavigation { get; set; }
}
