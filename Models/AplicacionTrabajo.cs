using System;
using System.Collections.Generic;

namespace job_board.Models;

public partial class AplicacionTrabajo
{
    public int Id { get; set; }

    public int? IdOferta { get; set; }

    public int? IdAspirante { get; set; }

    public DateTime? Fecha { get; set; }

    public string? Estado { get; set; }

    public string? Comentario { get; set; }

    public virtual Aspirante? IdAspiranteNavigation { get; set; }

    public virtual OfertaLaboral? IdOfertaNavigation { get; set; }
}
