using aplicacionNetRazor.Modelos;
using Microsoft.EntityFrameworkCore;

namespace aplicacionNetRazor.Datos
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        //poner aqui los modelos

        public  DbSet<Curso> Cursos { get; set; }
    }
}
