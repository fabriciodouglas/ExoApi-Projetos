using System;
using Exo.WebApi.Models;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace Exo.WebApi.Contexts
{
    public class ExoContext : DbContext
    {
        public ExoContext()
        {     
        }
        public ExoContext(DbContextOptions<ExoContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
              // Essa string de conexão foi depende da SUA máquina.
                // Variável EXO_CONNECTION (usada no Codespaces) tem prioridade; senão usa a string padrão.
                string conexao = Environment.GetEnvironmentVariable("EXO_CONNECTION")
                    ?? "Server=localhost\\SQLEXPRESS01;Database=ExoApi;Trusted_Connection=True;";
                optionsBuilder.UseSqlServer(conexao);

              // Exemplo 1 de string de conexão:
              // User ID=sa;Password=admin;Server=localhost;Database=ExoApi;-
              // + Trusted_Connection=False;

              // Exemplo 2 de string de conexão:
              // Server=localhost\\SQLEXPRESS;Database=ExoApi;Trusted_Connection=True;
            }
        }
        public DbSet<Projeto> Projetos { get; set; }
    }
}
