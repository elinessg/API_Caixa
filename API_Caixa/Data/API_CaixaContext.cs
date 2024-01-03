using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using API_Caixa.Models;

namespace API_Caixa.Data
{
    public class API_CaixaContext : DbContext
    {
        public API_CaixaContext (DbContextOptions<API_CaixaContext> options)
            : base(options)
        {
        }

        public DbSet<API_Caixa.Models.TB_Fluxo_Caixa> TB_Fluxo_Caixa { get; set; }
    }
}
