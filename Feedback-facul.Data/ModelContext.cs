using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Feedback_facul.Model.Alunos;

namespace Feedback_facul.Data
{
    public class ModelContext : DbContext
    {
        public ModelContext() { }
        public DbSet<Aluno> Alunos { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
