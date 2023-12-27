using Microsoft.EntityFrameworkCore;
using WebAPI.Models;

namespace WebAPI.Data
{
    public class MeuContexto : DbContext
    {
        public DbSet<Cadastro> Cadastros { get; set; }

        public MeuContexto(DbContextOptions<MeuContexto> options) : base(options)
        {

        }
        
    }
}
