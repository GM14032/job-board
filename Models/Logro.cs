using System;
using System.Collections.Generic;

namespace job_board.Models;

public partial class Logro
{
    public int Id { get; set; }

    public int? IdAspirante { get; set; }

    public DateTime? Fecha { get; set; }

    public string? Descripcion { get; set; }

    public virtual Aspirante? IdAspiranteNavigation { get; set; }
}
