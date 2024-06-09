﻿using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace job_board.Models;

public partial class Certificacion
{
    public int Id { get; set; }

    public int? IdAspirante { get; set; }

    public string? Nombre { get; set; }

    public string? TipoCertificacion { get; set; }

    public string? CodigoCertificacion { get; set; }

    public string? Periodo { get; set; }

    public string? Institucion { get; set; }

    [JsonIgnore]
    public virtual Aspirante? IdAspiranteNavigation { get; set; }
}
