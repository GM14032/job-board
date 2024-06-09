using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace job_board.Models;

public partial class Aspirante
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public string? Apellido { get; set; }

    public DateTime? FechaNacimiento { get; set; }

    public string? Genero { get; set; }

    public string? Nit { get; set; }

    public string? Nup { get; set; }

    public string? Documento { get; set; }

    public string? Telefono { get; set; }

    public string? Direccion { get; set; }

    public string? Correo { get; set; }

    public string? RedesSociales { get; set; }

    [JsonIgnore]
    public virtual ICollection<AplicacionTrabajo> AplicacionTrabajos { get; set; } = new List<AplicacionTrabajo>();

    public virtual ICollection<Certificacion> Certificacions { get; set; } = new List<Certificacion>();

    public virtual ICollection<Conocimiento> Conocimientos { get; set; } = new List<Conocimiento>();

    public virtual ICollection<Educacion> Educacions { get; set; } = new List<Educacion>();

    [JsonIgnore]
    public virtual ICollection<Evento> Eventos { get; set; } = new List<Evento>();

    public virtual ICollection<Experiencium> Experiencia { get; set; } = new List<Experiencium>();

    public virtual ICollection<Habilidade> Habilidades { get; set; } = new List<Habilidade>();

    public virtual ICollection<Idioma> Idiomas { get; set; } = new List<Idioma>();

    public virtual ICollection<Logro> Logros { get; set; } = new List<Logro>();

    public virtual ICollection<Publicacione> Publicaciones { get; set; } = new List<Publicacione>();

    public virtual ICollection<Resultado> Resultados { get; set; } = new List<Resultado>();

    [JsonIgnore]
    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
