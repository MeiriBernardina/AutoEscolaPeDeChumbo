using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AutoEscolaPeDeChumbo.Pages.Funcionarios;
using AutoEscolaPeDeChumbo.Pages.Alunos;
using AutoEscolaPeDeChumbo.Pages.Treinamentos;

namespace AutoEscolaPeDeChumbo.Data
{
    public class AutoEscolaPeDeChumboContext : DbContext
    {
        public AutoEscolaPeDeChumboContext (DbContextOptions<AutoEscolaPeDeChumboContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source = LAPTOP-TA8N3MS5\SQLEXPRESS; Initial Catalog=BDAutoEscola; Integrated Security = true");
        }



        public DbSet<AutoEscolaPeDeChumbo.Pages.Funcionarios.Funcionario> Funcionario { get; set; }

      

        public DbSet<AutoEscolaPeDeChumbo.Pages.Alunos.Alunos> Alunos { get; set; }

      

        public DbSet<AutoEscolaPeDeChumbo.Pages.Treinamentos.Treinamento> Treinamento { get; set; }
    }
}
