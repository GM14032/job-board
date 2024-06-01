using System;
using System.Collections.Generic;

namespace job_board.Models;

public partial class Experiencium
{
    public int Id { get; set; }

    public int? IdAspirante { get; set; }

    public string? Puesto { get; set; }

    public string? NombreOrganizacion { get; set; }

    public string? Funciones { get; set; }

    public string? Telefono { get; set; }

    public string? Periodo { get; set; }

    public virtual Aspirante? IdAspiranteNavigation { get; set; }
}
