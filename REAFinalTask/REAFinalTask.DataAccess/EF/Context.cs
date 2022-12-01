using Microsoft.EntityFrameworkCore;
using REAFinalTask.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace REAFinalTask.DataAccess.EF
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=YASINLENOVO\SQLEXPRESS;Database=REAFinalTaskDb;Trusted_Connection=true");
        }

        public DbSet<Comment> Comments { get; set; }
        public DbSet<ToDo> ToDos { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
