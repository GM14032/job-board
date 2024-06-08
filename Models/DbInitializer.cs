using Azure.Core;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Xml;

namespace job_board.Models
{
    public static class DbInitializer
    {
        public static void Initialize(SupertexDbContext? context)
        {
            if (context == null) throw new ArgumentNullException(nameof(context));
            context.Database.Migrate();
            // creating at least 3 roles (superuser, admin, applicant)

            if (context.Rols.Any()) // first we need to validate that there is no role yet
            {
                return;
            }

            Rol superUser = new Rol();
            superUser.Nombre = "Superuser";
            superUser.Descripcion = "This is the Admin equivalent for all the system";
            Rol admin = new Rol { Nombre = "Admin", Descripcion = "This is the Admin role for a company" };
            Rol applicant = new Rol { Nombre = "Applicant", Descripcion = "This is the role for a normal user" };
            context.Rols.Add(superUser);
            context.Rols.Add(admin);
            context.Rols.Add(applicant);
            context.SaveChanges();

            // maybe we will need a superuser
            Usuario usuario = new Usuario();
            usuario.Username = "superuser";
            usuario.Password = BCrypt.Net.BCrypt.HashPassword("root1234");
            usuario.IdRol = superUser.Id;
            context.Add(usuario);
            context.SaveChanges();

            // create work mode
            context.ModoTrabajos.Add(new ModoTrabajo { Nombre = "Trabajo Remoto", Descripcion = "Trabajo 100% remoto, desde casa" });
            context.ModoTrabajos.Add(new ModoTrabajo { Nombre = "Hibrido", Descripcion = "Trabajo hibrido, consultar dias a trabajar en empresa" });
            context.ModoTrabajos.Add(new ModoTrabajo { Nombre = "Trabajo en Oficina", Descripcion = "Trabajo 100% en oficina" });
            context.SaveChanges();
        }
    }

}
