using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ViewModels.Models
{
    public class Contexto : DbContext
    {
        public DbSet<Alunos> Alunos { get; set; }

        public DbSet<Materias> Materias { get; set; }

        public Contexto(DbContextOptions<Contexto> opcoes) : base(opcoes)
        {

        }
    }

}
