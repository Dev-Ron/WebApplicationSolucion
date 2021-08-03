using System;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Infracstructure.Entities
{
    public partial class RonalBDContext : DbContext
    {
        public RonalBDContext(DbContextOptions<RonalBDContext> options) : base(options)
        {

        }

        public virtual DbSet<Categoriasvehiculo> Categoriasvehiculos { get; set; }
        public virtual DbSet<Compañiasaseguradorasporpai> Compañiasaseguradorasporpais { get; set; }
        public virtual DbSet<Comunidadesautonoma> Comunidadesautonomas { get; set; }
        public virtual DbSet<Marcasvehiculo> Marcasvehiculos { get; set; }
        public virtual DbSet<Modelosvehiculo> Modelosvehiculos { get; set; }
        public virtual DbSet<Oficinacontactosdelorganismo> Oficinacontactosdelorganismos { get; set; }
        public virtual DbSet<Oficinacuentasbancariasdeladelorganismo> Oficinacuentasbancariasdeladelorganismos { get; set; }
        public virtual DbSet<Oficinaspororganismo> Oficinaspororganismos { get; set; }
        public virtual DbSet<Organismo> Organismos { get; set; }
        public virtual DbSet<Organismocontacto> Organismocontactos { get; set; }
        public virtual DbSet<Organismocuentasbancaria> Organismocuentasbancarias { get; set; }
        public virtual DbSet<Organismosporpai> Organismosporpais { get; set; }
        public virtual DbSet<Provinciaespana> Provinciaespanas { get; set; }
        public virtual DbSet<Subtipoorganismo> Subtipoorganismos { get; set; }
        public virtual DbSet<Tauxpai> Tauxpais { get; set; }
        public virtual DbSet<Tauxpais2> Tauxpais2s { get; set; }
        public virtual DbSet<Tipodecontacto> Tipodecontactos { get; set; }
        public virtual DbSet<Tipodeorganismo> Tipodeorganismos { get; set; }
        public virtual DbSet<Trepresentacione> Trepresentaciones { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Categoriasvehiculo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CATEGORIASVEHICULOS");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(255)
                    .HasColumnName("DESCRIPCION");

                entity.Property(e => e.Descripcioningles)
                    .HasMaxLength(255)
                    .HasColumnName("DESCRIPCIONINGLES");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("ID");
            });

            modelBuilder.Entity<Compañiasaseguradorasporpai>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("COMPAÑIASASEGURADORASPORPAIS");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("ID");

                entity.Property(e => e.Idpais)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("IDPAIS");

                entity.Property(e => e.Organismo)
                    .HasMaxLength(510)
                    .HasColumnName("ORGANISMO");

                entity.Property(e => e.Pais)
                    .HasMaxLength(510)
                    .HasColumnName("PAIS");
            });

            modelBuilder.Entity<Comunidadesautonoma>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("COMUNIDADESAUTONOMAS");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(38, 0)")
                    .HasColumnName("ID");

                entity.Property(e => e.Sdescripcion)
                    .HasMaxLength(510)
                    .HasColumnName("SDESCRIPCION");
            });

            modelBuilder.Entity<Marcasvehiculo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MARCASVEHICULOS");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(510)
                    .HasColumnName("DESCRIPCION");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("ID");
            });

            modelBuilder.Entity<Modelosvehiculo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MODELOSVEHICULOS");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(510)
                    .HasColumnName("DESCRIPCION");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("ID");

                entity.Property(e => e.Idmarca)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("IDMARCA");
            });

            modelBuilder.Entity<Oficinacontactosdelorganismo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OFICINACONTACTOSDELORGANISMO");

                entity.Property(e => e.Contacto).HasColumnName("CONTACTO");

                entity.Property(e => e.Email)
                    .HasMaxLength(200)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Fax).HasColumnName("FAX");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("ID");

                entity.Property(e => e.Idcategoria)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("IDCATEGORIA");

                entity.Property(e => e.Idoficina)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("IDOFICINA");

                entity.Property(e => e.Idorganismo)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("IDORGANISMO");

                entity.Property(e => e.Telefono).HasColumnName("TELEFONO");
            });

            modelBuilder.Entity<Oficinacuentasbancariasdeladelorganismo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OFICINACUENTASBANCARIASDELADELORGANISMO");

                entity.Property(e => e.Ccc)
                    .HasMaxLength(50)
                    .HasColumnName("CCC");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("ID");

                entity.Property(e => e.Idcategoria)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("IDCATEGORIA");

                entity.Property(e => e.Idoficina)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("IDOFICINA");

                entity.Property(e => e.Idorganismo)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("IDORGANISMO");

                entity.Property(e => e.Idpais)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("IDPAIS");

                entity.Property(e => e.Swift)
                    .HasMaxLength(20)
                    .HasColumnName("SWIFT");
            });

            modelBuilder.Entity<Oficinaspororganismo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OFICINASPORORGANISMO");

                entity.Property(e => e.Cif)
                    .HasMaxLength(50)
                    .HasColumnName("CIF");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(10)
                    .HasColumnName("CODIGO");

                entity.Property(e => e.Cp)
                    .HasMaxLength(20)
                    .HasColumnName("CP");

                entity.Property(e => e.Direccion)
                    .HasMaxLength(200)
                    .HasColumnName("DIRECCION");

                entity.Property(e => e.Fechaalta)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAALTA");

                entity.Property(e => e.Fechabaja)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHABAJA");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("ID");

                entity.Property(e => e.Idcomunidad)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("IDCOMUNIDAD");

                entity.Property(e => e.Iddependiente)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("IDDEPENDIENTE");

                entity.Property(e => e.Idpais)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("IDPAIS");

                entity.Property(e => e.Idpaisambito)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("IDPAISAMBITO");

                entity.Property(e => e.Idpasaa)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("IDPASAA");

                entity.Property(e => e.Idprovincia)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("IDPROVINCIA");

                entity.Property(e => e.Idsubtipoorganismo)
                    .HasMaxLength(50)
                    .HasColumnName("IDSUBTIPOORGANISMO");

                entity.Property(e => e.Idtipoorganismo)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("IDTIPOORGANISMO");

                entity.Property(e => e.Motivobaja)
                    .HasMaxLength(255)
                    .HasColumnName("MOTIVOBAJA");

                entity.Property(e => e.Nombre).HasColumnName("NOMBRE");

                entity.Property(e => e.Poblacion)
                    .HasMaxLength(200)
                    .HasColumnName("POBLACION");

                entity.Property(e => e.Web)
                    .HasMaxLength(200)
                    .HasColumnName("WEB");
            });

            modelBuilder.Entity<Organismo>(entity =>
            {
                //entity.HasNoKey();

                entity.ToTable("ORGANISMOS");

                entity.Property(e => e.Cif)
                    .HasMaxLength(50)
                    .HasColumnName("CIF");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(10)
                    .HasColumnName("CODIGO");

                entity.Property(e => e.Cp)
                    .HasMaxLength(20)
                    .HasColumnName("CP");

                entity.Property(e => e.Direccion)
                    .HasMaxLength(200)
                    .HasColumnName("DIRECCION");

                entity.Property(e => e.Fechaalta)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAALTA");

                entity.Property(e => e.Fechabaja)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHABAJA");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("ID");

                entity.Property(e => e.Idcomunidad)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("IDCOMUNIDAD");

                entity.Property(e => e.Iddependiente)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("IDDEPENDIENTE");

                entity.Property(e => e.Idpais)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("IDPAIS");

                entity.Property(e => e.Idpaisambito)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("IDPAISAMBITO");

                entity.Property(e => e.Idpasaa)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("IDPASAA");

                entity.Property(e => e.Idprovincia)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("IDPROVINCIA");

                entity.Property(e => e.Idsubtipoorganismo)
                    .HasMaxLength(50)
                    .HasColumnName("IDSUBTIPOORGANISMO");

                entity.Property(e => e.Idtipoorganismo)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("IDTIPOORGANISMO");

                entity.Property(e => e.Motivobaja)
                    .HasMaxLength(255)
                    .HasColumnName("MOTIVOBAJA");

                entity.Property(e => e.Nombre).HasColumnName("NOMBRE");

                entity.Property(e => e.Poblacion)
                    .HasMaxLength(200)
                    .HasColumnName("POBLACION");

                entity.Property(e => e.Web)
                    .HasMaxLength(200)
                    .HasColumnName("WEB");
            });

            modelBuilder.Entity<Organismocontacto>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ORGANISMOCONTACTOS");

                entity.Property(e => e.Contacto)
                    .HasMaxLength(200)
                    .HasColumnName("CONTACTO");

                entity.Property(e => e.Email)
                    .HasMaxLength(200)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Fax)
                    .HasMaxLength(200)
                    .HasColumnName("FAX");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("ID");

                entity.Property(e => e.Idcategoria)
                    .HasMaxLength(10)
                    .HasColumnName("IDCATEGORIA");

                entity.Property(e => e.Idorganismo)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("IDORGANISMO");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(200)
                    .HasColumnName("TELEFONO");
            });

            modelBuilder.Entity<Organismocuentasbancaria>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ORGANISMOCUENTASBANCARIAS");

                entity.Property(e => e.Ccc)
                    .HasMaxLength(30)
                    .HasColumnName("CCC");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("ID");

                entity.Property(e => e.Idcategoria)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("IDCATEGORIA");

                entity.Property(e => e.Idorganismo)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("IDORGANISMO");

                entity.Property(e => e.Idpais)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("IDPAIS");

                entity.Property(e => e.Swift)
                    .HasMaxLength(20)
                    .HasColumnName("SWIFT");
            });

            modelBuilder.Entity<Organismosporpai>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ORGANISMOSPORPAIS");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("ID");

                entity.Property(e => e.Idpais)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("IDPAIS");

                entity.Property(e => e.Organismo)
                    .HasMaxLength(510)
                    .HasColumnName("ORGANISMO");

                entity.Property(e => e.Pais)
                    .HasMaxLength(510)
                    .HasColumnName("PAIS");
            });

            modelBuilder.Entity<Provinciaespana>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PROVINCIAESPANA");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(38, 0)")
                    .HasColumnName("ID");

                entity.Property(e => e.Idcomunidadautonoma)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("IDCOMUNIDADAUTONOMA");

                entity.Property(e => e.Sdescripcion)
                    .HasMaxLength(510)
                    .HasColumnName("SDESCRIPCION");
            });

            modelBuilder.Entity<Subtipoorganismo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SUBTIPOORGANISMO");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("ID");

                entity.Property(e => e.Subtipo)
                    .HasMaxLength(500)
                    .HasColumnName("SUBTIPO");
            });

            modelBuilder.Entity<Tauxpai>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TAUXPAIS");

                entity.Property(e => e.Iban)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("IBAN");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Iso2)
                    .HasMaxLength(2)
                    .HasColumnName("ISO2");

                entity.Property(e => e.Iso3)
                    .HasMaxLength(3)
                    .HasColumnName("ISO3");

                entity.Property(e => e.Isonumber)
                    .HasMaxLength(3)
                    .HasColumnName("ISONUMBER");

                entity.Property(e => e.Longiban)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("LONGIBAN");

                entity.Property(e => e.Sepa)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("SEPA");

                entity.Property(e => e.Sid)
                    .HasMaxLength(100)
                    .HasColumnName("SID");

                entity.Property(e => e.Sname)
                    .HasMaxLength(510)
                    .HasColumnName("SNAME");

                entity.Property(e => e.Snombre)
                    .HasMaxLength(510)
                    .HasColumnName("SNOMBRE");

                entity.Property(e => e.Urlmatriculas)
                    .HasMaxLength(200)
                    .HasColumnName("URLMATRICULAS");
            });

            modelBuilder.Entity<Tauxpais2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TAUXPAIS2");

                entity.Property(e => e.Iban)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("IBAN");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Iso2)
                    .HasMaxLength(2)
                    .HasColumnName("ISO2");

                entity.Property(e => e.Iso3)
                    .HasMaxLength(3)
                    .HasColumnName("ISO3");

                entity.Property(e => e.Isonumber)
                    .HasMaxLength(3)
                    .HasColumnName("ISONUMBER");

                entity.Property(e => e.Longiban)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("LONGIBAN");

                entity.Property(e => e.Sepa)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("SEPA");

                entity.Property(e => e.Sid)
                    .HasMaxLength(100)
                    .HasColumnName("SID");

                entity.Property(e => e.Sname)
                    .HasMaxLength(510)
                    .HasColumnName("SNAME");

                entity.Property(e => e.Snombre)
                    .HasMaxLength(510)
                    .HasColumnName("SNOMBRE");

                entity.Property(e => e.Urlmatriculas)
                    .HasMaxLength(200)
                    .HasColumnName("URLMATRICULAS");
            });

            modelBuilder.Entity<Tipodecontacto>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TIPODECONTACTO");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(200)
                    .HasColumnName("DESCRIPCION");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("ID");
            });

            modelBuilder.Entity<Tipodeorganismo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TIPODEORGANISMO");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(200)
                    .HasColumnName("DESCRIPCION");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("ID");
            });

            modelBuilder.Entity<Trepresentacione>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TREPRESENTACIONES");

                entity.Property(e => e.Fechafin)
                    .HasColumnType("date")
                    .HasColumnName("FECHAFIN");

                entity.Property(e => e.Fechainicio)
                    .HasColumnType("date")
                    .HasColumnName("FECHAINICIO");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("ID");

                entity.Property(e => e.Idrepresentado)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("IDREPRESENTADO");

                entity.Property(e => e.Idrepresentante)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("IDREPRESENTANTE");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
