using System;
using System.Collections.Generic;

namespace job_board.Models;

public partial class Publicacione
{
    public int Id { get; set; }

    public int? IdAspirante { get; set; }

    public string? Nombre { get; set; }

    public string? TipoPublicacion { get; set; }

    public DateTime? Fecha { get; set; }

    public string? Lugar { get; set; }

    public string? Isbn { get; set; }

    public virtual Aspirante? IdAspiranteNavigation { get; set; }
}
