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

    [JsonIgnore]
    public virtual ICollection<Certificacion> Certificacions { get; set; } = new List<Certificacion>();

    [JsonIgnore]
    public virtual ICollection<Conocimiento> Conocimientos { get; set; } = new List<Conocimiento>();

    [JsonIgnore]
    public virtual ICollection<Educacion> Educacions { get; set; } = new List<Educacion>();

    [JsonIgnore]
    public virtual ICollection<Evento> Eventos { get; set; } = new List<Evento>();

    [JsonIgnore]
    public virtual ICollection<Experiencium> Experiencia { get; set; } = new List<Experiencium>();

    [JsonIgnore]
    public virtual ICollection<Habilidade> Habilidades { get; set; } = new List<Habilidade>();

    [JsonIgnore]
    public virtual ICollection<Idioma> Idiomas { get; set; } = new List<Idioma>();

    [JsonIgnore]
    public virtual ICollection<Logro> Logros { get; set; } = new List<Logro>();

    [JsonIgnore]
    public virtual ICollection<Publicacione> Publicaciones { get; set; } = new List<Publicacione>();

    [JsonIgnore]
    public virtual ICollection<Resultado> Resultados { get; set; } = new List<Resultado>();

    [JsonIgnore]
    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
