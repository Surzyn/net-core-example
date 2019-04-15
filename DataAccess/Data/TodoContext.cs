using System;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Data
{
    public class TodoContext : DbContext
    {
        //Tutaj definiujemy jakie tabelki są w naszej bazie
        public DbSet<Todo> Todos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            throw new NotImplementedException();
            //Podaj swój connection string
            //optionsBuilder.UseSqlServer(@"CONNECTION_STRING");
        }
    }
}
