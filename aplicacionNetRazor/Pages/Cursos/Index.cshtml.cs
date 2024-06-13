using aplicacionNetRazor.Datos;
using aplicacionNetRazor.Modelos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;


namespace aplicacionNetRazor.Pages.Cursos
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _contexto;

        public IndexModel(ApplicationDbContext contexto)
        {
           
            _contexto = contexto;
        }
        public IEnumerable<Curso> Cursos { get; set; }
        public async Task OnGet()
        {
            Cursos = await _contexto.Cursos.ToListAsync();
        }
    }
}
