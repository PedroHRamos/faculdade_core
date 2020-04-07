using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Feedback_facul.Data
{
    public class ModelContext : DbContext
    {
        public ModelContext() : base("name=Feedback") { }
        public DbSet<Feedback_facul.Model.Aluno.Aluno> Alunos { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
