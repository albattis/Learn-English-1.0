//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Learn_English_1._0
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class learnenglishEntities : DbContext
    {
        public learnenglishEntities()
            : base("name=learnenglishEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<users> users { get; set; }
        public virtual DbSet<words> words { get; set; }
        public virtual DbSet<wordsType> wordsType { get; set; }
        public virtual DbSet<grammar> grammar { get; set; }
    }
}
