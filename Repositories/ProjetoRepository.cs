using ExoAPI.Contexts;
using ExoAPI.Models;

namespace ExoAPI.Repositories
{
    public class ProjetoRepository
    {
        private readonly dbExoAPIContext _context;

        public ProjetoRepository(dbExoAPIContext context)
        {
            _context = context;
        }

        public List<Projeto> Listar()
        {
            return _context.Projetos.ToList();
        }
    }
}
