using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace job_board.Models;

public partial class OfertaLaboral
{
    public int Id { get; set; }

    public int? IdModoTrabajo { get; set; }

    public int? IdEmpresa { get; set; }

    public string? Nombre { get; set; }

    public string? Descripcion { get; set; }

    public double? SalarioMin { get; set; }

    public double? SalarioMax { get; set; }

    public string? PerfilAcademico { get; set; }

    public string? Experiencia { get; set; }

    [JsonIgnore]
    public virtual ICollection<AplicacionTrabajo> AplicacionTrabajos { get; set; } = new List<AplicacionTrabajo>();

    [JsonIgnore]
    public virtual ICollection<Conocimiento> Conocimientos { get; set; } = new List<Conocimiento>();

    [JsonIgnore]
    public virtual ICollection<Habilidade> Habilidades { get; set; } = new List<Habilidade>();

    [JsonIgnore]
    public virtual Empresa? IdEmpresaNavigation { get; set; }

    [JsonIgnore]
    public virtual ModoTrabajo? IdModoTrabajoNavigation { get; set; }
}
