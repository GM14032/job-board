using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Policy;
using System.Text.Json.Serialization;

namespace job_board.Models;

[Index(nameof(Username), IsUnique = true)]
public partial class Usuario
{
    
    public int Id { get; set; }

    public int? IdEmpresa { get; set; }

    public int? IdAspirante { get; set; }

    [JsonRequired]
    public int? IdRol { get; set; }

    [JsonRequired]
    public string? Username { get; set; }

    public string? Password { get; set; }

    [DefaultValue(true)]
    public bool? Estado { get; set; }

    [JsonIgnore]
    public virtual Aspirante? IdAspiranteNavigation { get; set; }

    [JsonIgnore]
    public virtual Empresa? IdEmpresaNavigation { get; set; }

    [JsonIgnore]
    public virtual Rol? IdRolNavigation { get; set; }
}
