﻿using API.Data.Map;
using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class SistemaDeTarefasDBContext : DbContext
    {
        public SistemaDeTarefasDBContext(DbContextOptions<SistemaDeTarefasDBContext> options) 
            : base(options)
        {
            
        }

        public DbSet<UsuarioModel> Usuarios { get; set; }
        public DbSet<TarefaModel> Tarefas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new TarefaMap());
            base.OnModelCreating(modelBuilder);
        }

    }
}
