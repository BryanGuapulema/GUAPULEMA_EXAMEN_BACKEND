﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GUAPULEMA_EXAMEN
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Guapulema_Examen_CrudMvcAPIEntities : DbContext
    {
        public Guapulema_Examen_CrudMvcAPIEntities()
            : base("name=Guapulema_Examen_CrudMvcAPIEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<EmployeeActiviry> EmployeeActiviry { get; set; }
    }
}
