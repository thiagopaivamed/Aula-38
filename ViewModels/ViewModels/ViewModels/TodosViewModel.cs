using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewModels.Models;

namespace ViewModels.ViewModels
{
    public class TodosViewModel
    {
        public IEnumerable<Alunos> Alunos { get; set; }
        public IEnumerable<Materias> Materias { get; set; }
    }
}
