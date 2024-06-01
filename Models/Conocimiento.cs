using System;
using System.Collections.Generic;

namespace job_board.Models;

public partial class Conocimiento
{
    public int Id { get; set; }

    public int? IdOferta { get; set; }

    public int? IdAspirante { get; set; }

    public string? Nombre { get; set; }

    public string? Descripcion { get; set; }

    public string? Nivel { get; set; }

    public virtual Aspirante? IdAspiranteNavigation { get; set; }

    public virtual OfertaLaboral? IdOfertaNavigation { get; set; }
}
