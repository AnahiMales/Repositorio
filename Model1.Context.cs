//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EcuaDeliveryV3
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BD_EcuaDeliveryEntities : DbContext
    {
        public BD_EcuaDeliveryEntities()
            : base("name=BD_EcuaDeliveryEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CATEGORIA> CATEGORIAs { get; set; }
        public virtual DbSet<CIUDAD> CIUDADs { get; set; }
        public virtual DbSet<DETALLE_FACTURA> DETALLE_FACTURA { get; set; }
        public virtual DbSet<DIRECCION> DIRECCIONs { get; set; }
        public virtual DbSet<FACTURA_CABECERA> FACTURA_CABECERA { get; set; }
        public virtual DbSet<PRODUCTO> PRODUCTOS { get; set; }
        public virtual DbSet<PROVEEDOR> PROVEEDORs { get; set; }
        public virtual DbSet<USUARIO> USUARIOs { get; set; }
    }
}
