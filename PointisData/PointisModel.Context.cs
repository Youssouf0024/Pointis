﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PointisData
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PointisEntities : DbContext
    {
        public PointisEntities()
            : base("name=PointisEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Connexion> Connexion { get; set; }
        public virtual DbSet<Employes> Employes { get; set; }
        public virtual DbSet<Pointage> Pointage { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}
