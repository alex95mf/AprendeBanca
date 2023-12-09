using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Banca_API.Models;

public partial class ApplicationDbContext : DbContext
{
    public ApplicationDbContext()
    {
    }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ConCentroCosto> ConCentroCostos { get; set; }

    public virtual DbSet<ConCentroCostosTipo> ConCentroCostosTipos { get; set; }

    public virtual DbSet<ConCuentaClase> ConCuentaClases { get; set; }

    public virtual DbSet<ConCuentaNivel> ConCuentaNivels { get; set; }

    public virtual DbSet<ConCuentaPlan> ConCuentaPlans { get; set; }

    public virtual DbSet<ConCuentaTipo> ConCuentaTipos { get; set; }

    public virtual DbSet<ConDiarioAux> ConDiarioAuxes { get; set; }

    public virtual DbSet<ConDiarioAuxTipo> ConDiarioAuxTipos { get; set; }

    public virtual DbSet<ConDiarioCab> ConDiarioCabs { get; set; }

    public virtual DbSet<ConDiarioDet> ConDiarioDets { get; set; }

    public virtual DbSet<ConDiarioSecuencium> ConDiarioSecuencia { get; set; }

    public virtual DbSet<ConDiarioTipo> ConDiarioTipos { get; set; }

    public virtual DbSet<ConEstadoContab> ConEstadoContabs { get; set; }

    public virtual DbSet<GenAnio> GenAnios { get; set; }

    public virtual DbSet<GenCategorium> GenCategoria { get; set; }

    public virtual DbSet<GenCliente> GenClientes { get; set; }

    public virtual DbSet<GenEmpresa> GenEmpresas { get; set; }

    public virtual DbSet<GenMarca> GenMarcas { get; set; }

    public virtual DbSet<GenMe> GenMes { get; set; }

    public virtual DbSet<GenMedida> GenMedidas { get; set; }

    public virtual DbSet<GenProducto> GenProductos { get; set; }

    public virtual DbSet<GenProductoPresent> GenProductoPresents { get; set; }

    public virtual DbSet<GenProductoTipo> GenProductoTipos { get; set; }

    public virtual DbSet<GenStockCab> GenStockCabs { get; set; }

    public virtual DbSet<GenStockDet> GenStockDets { get; set; }

    public virtual DbSet<MigrationHistory> MigrationHistories { get; set; }

    public virtual DbSet<SegAutoregistro> SegAutoregistros { get; set; }

    public virtual DbSet<SegEstadoSn> SegEstadoSns { get; set; }

    public virtual DbSet<SegPermisosMnu> SegPermisosMnus { get; set; }

    public virtual DbSet<SegRole> SegRoles { get; set; }

    public virtual DbSet<SegRolpermiso> SegRolpermisos { get; set; }

    public virtual DbSet<SegUsuario> SegUsuarios { get; set; }

    public virtual DbSet<SriComprobanteTipo> SriComprobanteTipos { get; set; }

    public virtual DbSet<SriFormaPago> SriFormaPagos { get; set; }

    public virtual DbSet<SriIce> SriIces { get; set; }

    public virtual DbSet<SriIdentificacion> SriIdentificacions { get; set; }

    public virtual DbSet<SriIva> SriIvas { get; set; }

    public virtual DbSet<SriTalonario> SriTalonarios { get; set; }

    public virtual DbSet<VentaFacturaCab> VentaFacturaCabs { get; set; }

    public virtual DbSet<VentaFacturaDet> VentaFacturaDets { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=NANDO-1201;Database=SYSCONTUNEMI;User Id=admin;Password=admin0admin;TrustServerCertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ConCentroCosto>(entity =>
        {
            entity.HasKey(e => e.ConccosId);

            entity.ToTable("CON_CENTRO_COSTOS");

            entity.Property(e => e.ConccosId).HasColumnName("CONCCOS_ID");
            entity.Property(e => e.AudFechaIngreso)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Aud_Fecha_Ingreso");
            entity.Property(e => e.AudFechaModifica)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Aud_Fecha_Modifica");
            entity.Property(e => e.AudPcIngreso)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("((((host_name()+'/')+isnull(CONVERT([varchar],connectionproperty('client_net_address')),'-'))+'/')+isnull(CONVERT([varchar],connectionproperty('local_net_address')),'-'))")
                .HasColumnName("Aud_PC_Ingreso");
            entity.Property(e => e.AudPcModifica)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("((((host_name()+'/')+isnull(CONVERT([varchar],connectionproperty('client_net_address')),'-'))+'/')+isnull(CONVERT([varchar],connectionproperty('local_net_address')),'-'))")
                .HasColumnName("Aud_PC_Modifica");
            entity.Property(e => e.AudUsuarioIngreso)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("(user_name())")
                .HasColumnName("Aud_Usuario_Ingreso");
            entity.Property(e => e.AudUsuarioModifica)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("(user_name())")
                .HasColumnName("Aud_Usuario_Modifica");
            entity.Property(e => e.ConCtaplaId).HasColumnName("CON_CTAPLA_ID");
            entity.Property(e => e.ConccosCodigo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CONCCOS_Codigo");
            entity.Property(e => e.ConccosNombre)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("CONCCOS_NOMBRE");
            entity.Property(e => e.ConccosTipEstado)
                .HasDefaultValueSql("((1))")
                .HasColumnName("CONCCOS_TIP_ESTADO");
            entity.Property(e => e.ConccosTipId).HasColumnName("CONCCOS_TIP_ID");
            entity.Property(e => e.GenanioId).HasColumnName("GENANIO_ID");
            entity.Property(e => e.GenempId).HasColumnName("GENEMP_ID");

            entity.HasOne(d => d.ConCtapla).WithMany(p => p.ConCentroCostos)
                .HasForeignKey(d => d.ConCtaplaId)
                .HasConstraintName("FK_CON_CENTRO_COSTOS_CTACONT");

            entity.HasOne(d => d.ConccosTip).WithMany(p => p.ConCentroCostos)
                .HasForeignKey(d => d.ConccosTipId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CON_CENTRO_COSTOS_CCTO");

            entity.HasOne(d => d.Genanio).WithMany(p => p.ConCentroCostos)
                .HasForeignKey(d => d.GenanioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CON_CENTRO_COSTOS_ANIO");

            entity.HasOne(d => d.Genemp).WithMany(p => p.ConCentroCostos)
                .HasForeignKey(d => d.GenempId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CON_CENTRO_COSTOS_EMP");
        });

        modelBuilder.Entity<ConCentroCostosTipo>(entity =>
        {
            entity.HasKey(e => e.ConccosTipId);

            entity.ToTable("CON_CENTRO_COSTOS_TIPO");

            entity.Property(e => e.ConccosTipId).HasColumnName("CONCCOS_TIP_ID");
            entity.Property(e => e.AudFechaIngreso)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Aud_Fecha_Ingreso");
            entity.Property(e => e.AudFechaModifica)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Aud_Fecha_Modifica");
            entity.Property(e => e.AudPcIngreso)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("((((host_name()+'/')+isnull(CONVERT([varchar],connectionproperty('client_net_address')),'-'))+'/')+isnull(CONVERT([varchar],connectionproperty('local_net_address')),'-'))")
                .HasColumnName("Aud_PC_Ingreso");
            entity.Property(e => e.AudPcModifica)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("((((host_name()+'/')+isnull(CONVERT([varchar],connectionproperty('client_net_address')),'-'))+'/')+isnull(CONVERT([varchar],connectionproperty('local_net_address')),'-'))")
                .HasColumnName("Aud_PC_Modifica");
            entity.Property(e => e.AudUsuarioIngreso)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("(user_name())")
                .HasColumnName("Aud_Usuario_Ingreso");
            entity.Property(e => e.AudUsuarioModifica)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("(user_name())")
                .HasColumnName("Aud_Usuario_Modifica");
            entity.Property(e => e.ConccosTipEstado)
                .HasDefaultValueSql("((1))")
                .HasColumnName("CONCCOS_TIP_ESTADO");
            entity.Property(e => e.ConccosTipNombre)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CONCCOS_TIP_NOMBRE");
            entity.Property(e => e.GenempId).HasColumnName("GENEMP_ID");

            entity.HasOne(d => d.Genemp).WithMany(p => p.ConCentroCostosTipos)
                .HasForeignKey(d => d.GenempId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CON_CENTRO_COSTOS_TIPO_EMP");
        });

        modelBuilder.Entity<ConCuentaClase>(entity =>
        {
            entity.HasKey(e => e.ConCtaclsId);

            entity.ToTable("CON_CUENTA_CLASE");

            entity.Property(e => e.ConCtaclsId).HasColumnName("CON_CTACLS_ID");
            entity.Property(e => e.AudFechaIngreso)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Aud_Fecha_Ingreso");
            entity.Property(e => e.AudFechaModifica)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Aud_Fecha_Modifica");
            entity.Property(e => e.AudPcIngreso)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("((((host_name()+'/')+isnull(CONVERT([varchar],connectionproperty('client_net_address')),'-'))+'/')+isnull(CONVERT([varchar],connectionproperty('local_net_address')),'-'))")
                .HasColumnName("Aud_PC_Ingreso");
            entity.Property(e => e.AudPcModifica)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("((((host_name()+'/')+isnull(CONVERT([varchar],connectionproperty('client_net_address')),'-'))+'/')+isnull(CONVERT([varchar],connectionproperty('local_net_address')),'-'))")
                .HasColumnName("Aud_PC_Modifica");
            entity.Property(e => e.AudUsuarioIngreso)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("(user_name())")
                .HasColumnName("Aud_Usuario_Ingreso");
            entity.Property(e => e.AudUsuarioModifica)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("(user_name())")
                .HasColumnName("Aud_Usuario_Modifica");
            entity.Property(e => e.ConCtaclsGrupo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CON_CTACLS_Grupo");
            entity.Property(e => e.ConCtaclsNombre)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CON_CTACLS_NOMBRE");
            entity.Property(e => e.ConCtatipEstado)
                .HasDefaultValueSql("((1))")
                .HasColumnName("CON_CTATIP_ESTADO");
            entity.Property(e => e.ConCtatipId).HasColumnName("CON_CTATIP_ID");
            entity.Property(e => e.GenempId).HasColumnName("GENEMP_ID");

            entity.HasOne(d => d.ConCtatip).WithMany(p => p.ConCuentaClases)
                .HasForeignKey(d => d.ConCtatipId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CON_CUENTA_CLASE");

            entity.HasOne(d => d.Genemp).WithMany(p => p.ConCuentaClases)
                .HasForeignKey(d => d.GenempId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CON_CUENTA_CLASE_EMP");
        });

        modelBuilder.Entity<ConCuentaNivel>(entity =>
        {
            entity.HasKey(e => e.ConCtanivId);

            entity.ToTable("CON_CUENTA_NIVEL");

            entity.Property(e => e.ConCtanivId).HasColumnName("CON_CTANIV_ID");
            entity.Property(e => e.AudFechaIngreso)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Aud_Fecha_Ingreso");
            entity.Property(e => e.AudFechaModifica)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Aud_Fecha_Modifica");
            entity.Property(e => e.AudPcIngreso)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("((((host_name()+'/')+isnull(CONVERT([varchar],connectionproperty('client_net_address')),'-'))+'/')+isnull(CONVERT([varchar],connectionproperty('local_net_address')),'-'))")
                .HasColumnName("Aud_PC_Ingreso");
            entity.Property(e => e.AudPcModifica)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("((((host_name()+'/')+isnull(CONVERT([varchar],connectionproperty('client_net_address')),'-'))+'/')+isnull(CONVERT([varchar],connectionproperty('local_net_address')),'-'))")
                .HasColumnName("Aud_PC_Modifica");
            entity.Property(e => e.AudUsuarioIngreso)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("(user_name())")
                .HasColumnName("Aud_Usuario_Ingreso");
            entity.Property(e => e.AudUsuarioModifica)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("(user_name())")
                .HasColumnName("Aud_Usuario_Modifica");
            entity.Property(e => e.ConCtanivCantCaracter).HasColumnName("CON_CTANIV_Cant_Caracter");
            entity.Property(e => e.ConCtanivDescripcion)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CON_CTANIV_DESCRIPCION");
            entity.Property(e => e.ConCtanivEstado)
                .HasDefaultValueSql("((1))")
                .HasColumnName("CON_CTANIV_ESTADO");
            entity.Property(e => e.ConCtanivNivel).HasColumnName("CON_CTANIV_Nivel");
            entity.Property(e => e.ConCtanivSeparadorCaracter)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CON_CTANIV_Separador_Caracter");
            entity.Property(e => e.ConCtanivSeparadorSn).HasColumnName("CON_CTANIV_Separador_SN");
            entity.Property(e => e.GenempId).HasColumnName("GENEMP_ID");

            entity.HasOne(d => d.ConCtanivSeparadorSnNavigation).WithMany(p => p.ConCuentaNivels)
                .HasForeignKey(d => d.ConCtanivSeparadorSn)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CON_CUENTA_NIVEL");

            entity.HasOne(d => d.Genemp).WithMany(p => p.ConCuentaNivels)
                .HasForeignKey(d => d.GenempId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CON_CUENTA_NIVEL_EMP");
        });

        modelBuilder.Entity<ConCuentaPlan>(entity =>
        {
            entity.HasKey(e => e.ConCtaplaId);

            entity.ToTable("CON_CUENTA_PLAN");

            entity.Property(e => e.ConCtaplaId).HasColumnName("CON_CTAPLA_ID");
            entity.Property(e => e.AudFechaIngreso)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Aud_Fecha_Ingreso");
            entity.Property(e => e.AudFechaModifica)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Aud_Fecha_Modifica");
            entity.Property(e => e.AudPcIngreso)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("((((host_name()+'/')+isnull(CONVERT([varchar],connectionproperty('client_net_address')),'-'))+'/')+isnull(CONVERT([varchar],connectionproperty('local_net_address')),'-'))")
                .HasColumnName("Aud_PC_Ingreso");
            entity.Property(e => e.AudPcModifica)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("((((host_name()+'/')+isnull(CONVERT([varchar],connectionproperty('client_net_address')),'-'))+'/')+isnull(CONVERT([varchar],connectionproperty('local_net_address')),'-'))")
                .HasColumnName("Aud_PC_Modifica");
            entity.Property(e => e.AudUsuarioIngreso)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("(user_name())")
                .HasColumnName("Aud_Usuario_Ingreso");
            entity.Property(e => e.AudUsuarioModifica)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("(user_name())")
                .HasColumnName("Aud_Usuario_Modifica");
            entity.Property(e => e.ConCtaclsId).HasColumnName("CON_CTACLS_ID");
            entity.Property(e => e.ConCtanivId).HasColumnName("CON_CTANIV_ID");
            entity.Property(e => e.ConCtaplaCuenta)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CON_CTAPLA_Cuenta");
            entity.Property(e => e.ConCtaplaEstado)
                .HasDefaultValueSql("((1))")
                .HasColumnName("CON_CTAPLA_ESTADO");
            entity.Property(e => e.ConCtaplaNombre)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("CON_CTAPLA_NOMBRE");
            entity.Property(e => e.ConCtaplaReqCcSn).HasColumnName("CON_CTAPLA_Req_Cc_SN");
            entity.Property(e => e.ConCtatipId).HasColumnName("CON_CTATIP_ID");
            entity.Property(e => e.GenanioId).HasColumnName("GENANIO_ID");
            entity.Property(e => e.GenempId).HasColumnName("GENEMP_ID");

            entity.HasOne(d => d.ConCtacls).WithMany(p => p.ConCuentaPlans)
                .HasForeignKey(d => d.ConCtaclsId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CON_CUENTA_PLAN_CLC");

            entity.HasOne(d => d.ConCtaniv).WithMany(p => p.ConCuentaPlans)
                .HasForeignKey(d => d.ConCtanivId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CON_CUENTA_PLAN_CTA");

            entity.HasOne(d => d.ConCtaplaReqCcSnNavigation).WithMany(p => p.ConCuentaPlans)
                .HasForeignKey(d => d.ConCtaplaReqCcSn)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CON_CUENTA_PLAN_SNREQ");

            entity.HasOne(d => d.ConCtatip).WithMany(p => p.ConCuentaPlans)
                .HasForeignKey(d => d.ConCtatipId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CON_CUENTA_PLAN_CTA_TIP");

            entity.HasOne(d => d.Genanio).WithMany(p => p.ConCuentaPlans)
                .HasForeignKey(d => d.GenanioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CON_CUENTA_PLAN_ANIO");

            entity.HasOne(d => d.Genemp).WithMany(p => p.ConCuentaPlans)
                .HasForeignKey(d => d.GenempId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CON_CUENTA_PLAN_EMP");
        });

        modelBuilder.Entity<ConCuentaTipo>(entity =>
        {
            entity.HasKey(e => e.ConCtatipId);

            entity.ToTable("CON_CUENTA_TIPO");

            entity.Property(e => e.ConCtatipId).HasColumnName("CON_CTATIP_ID");
            entity.Property(e => e.AudFechaIngreso)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Aud_Fecha_Ingreso");
            entity.Property(e => e.AudFechaModifica)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Aud_Fecha_Modifica");
            entity.Property(e => e.AudPcIngreso)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("((((host_name()+'/')+isnull(CONVERT([varchar],connectionproperty('client_net_address')),'-'))+'/')+isnull(CONVERT([varchar],connectionproperty('local_net_address')),'-'))")
                .HasColumnName("Aud_PC_Ingreso");
            entity.Property(e => e.AudPcModifica)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("((((host_name()+'/')+isnull(CONVERT([varchar],connectionproperty('client_net_address')),'-'))+'/')+isnull(CONVERT([varchar],connectionproperty('local_net_address')),'-'))")
                .HasColumnName("Aud_PC_Modifica");
            entity.Property(e => e.AudUsuarioIngreso)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("(user_name())")
                .HasColumnName("Aud_Usuario_Ingreso");
            entity.Property(e => e.AudUsuarioModifica)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("(user_name())")
                .HasColumnName("Aud_Usuario_Modifica");
            entity.Property(e => e.ConCtatipDescripcion)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CON_CTATIP_DESCRIPCION");
            entity.Property(e => e.ConCtatipEstado)
                .HasDefaultValueSql("((1))")
                .HasColumnName("CON_CTATIP_ESTADO");
            entity.Property(e => e.GenempId).HasColumnName("GENEMP_ID");

            entity.HasOne(d => d.Genemp).WithMany(p => p.ConCuentaTipos)
                .HasForeignKey(d => d.GenempId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CON_CUENTA_TIPO_EMP");
        });

        modelBuilder.Entity<ConDiarioAux>(entity =>
        {
            entity.HasKey(e => e.ConDiarauxId);

            entity.ToTable("CON_DIARIO_AUX");

            entity.Property(e => e.ConDiarauxId).HasColumnName("CON_DIARAUX_ID");
            entity.Property(e => e.AudFechaIngreso)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Aud_Fecha_Ingreso");
            entity.Property(e => e.AudFechaModifica)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Aud_Fecha_Modifica");
            entity.Property(e => e.AudPcIngreso)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("((((host_name()+'/')+isnull(CONVERT([varchar],connectionproperty('client_net_address')),'-'))+'/')+isnull(CONVERT([varchar],connectionproperty('local_net_address')),'-'))")
                .HasColumnName("Aud_PC_Ingreso");
            entity.Property(e => e.AudPcModifica)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("((((host_name()+'/')+isnull(CONVERT([varchar],connectionproperty('client_net_address')),'-'))+'/')+isnull(CONVERT([varchar],connectionproperty('local_net_address')),'-'))")
                .HasColumnName("Aud_PC_Modifica");
            entity.Property(e => e.AudUsuarioIngreso)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("(user_name())")
                .HasColumnName("Aud_Usuario_Ingreso");
            entity.Property(e => e.AudUsuarioModifica)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("(user_name())")
                .HasColumnName("Aud_Usuario_Modifica");
            entity.Property(e => e.ConDiarauxCodigo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CON_DIARAUX_Codigo");
            entity.Property(e => e.ConDiarauxEstado)
                .HasDefaultValueSql("((1))")
                .HasColumnName("CON_DIARAUX_ESTADO");
            entity.Property(e => e.ConDiarauxGlosa)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("CON_DIARAUX_Glosa");
            entity.Property(e => e.ConDiarauxNombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CON_DIARAUX_NOMBRE");
            entity.Property(e => e.ConDiarauxTipoId).HasColumnName("CON_DIARAUX_TIPO_ID");
            entity.Property(e => e.ConDiarauxTotal)
                .HasColumnType("numeric(18, 8)")
                .HasColumnName("CON_DIARAUX_Total");
            entity.Property(e => e.ConDiarcabId).HasColumnName("CON_DIARCAB_ID");
            entity.Property(e => e.ConDiardetId).HasColumnName("CON_DIARDET_ID");
            entity.Property(e => e.ConccosId).HasColumnName("CONCCOS_ID");
            entity.Property(e => e.GenempId).HasColumnName("GENEMP_ID");

            entity.HasOne(d => d.ConDiarauxTipo).WithMany(p => p.ConDiarioAuxes)
                .HasForeignKey(d => d.ConDiarauxTipoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CON_DIARIO_AUX_AUXTIPO");

            entity.HasOne(d => d.ConDiarcab).WithMany(p => p.ConDiarioAuxes)
                .HasForeignKey(d => d.ConDiarcabId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CON_DIARIO_AUX_CABLOT");

            entity.HasOne(d => d.ConDiardet).WithMany(p => p.ConDiarioAuxes)
                .HasForeignKey(d => d.ConDiardetId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CON_DIARIO_AUX_DIARIODET");

            entity.HasOne(d => d.Conccos).WithMany(p => p.ConDiarioAuxes)
                .HasForeignKey(d => d.ConccosId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CON_DIARIO_AUX_CCOS");

            entity.HasOne(d => d.Genemp).WithMany(p => p.ConDiarioAuxes)
                .HasForeignKey(d => d.GenempId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CON_DIARIO_AUX_EMP");
        });

        modelBuilder.Entity<ConDiarioAuxTipo>(entity =>
        {
            entity.HasKey(e => e.ConDiarauxTipoId);

            entity.ToTable("CON_DIARIO_AUX_TIPO");

            entity.Property(e => e.ConDiarauxTipoId).HasColumnName("CON_DIARAUX_TIPO_ID");
            entity.Property(e => e.AudFechaIngreso)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Aud_Fecha_Ingreso");
            entity.Property(e => e.AudFechaModifica)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Aud_Fecha_Modifica");
            entity.Property(e => e.AudPcIngreso)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("((((host_name()+'/')+isnull(CONVERT([varchar],connectionproperty('client_net_address')),'-'))+'/')+isnull(CONVERT([varchar],connectionproperty('local_net_address')),'-'))")
                .HasColumnName("Aud_PC_Ingreso");
            entity.Property(e => e.AudPcModifica)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("((((host_name()+'/')+isnull(CONVERT([varchar],connectionproperty('client_net_address')),'-'))+'/')+isnull(CONVERT([varchar],connectionproperty('local_net_address')),'-'))")
                .HasColumnName("Aud_PC_Modifica");
            entity.Property(e => e.AudUsuarioIngreso)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("(user_name())")
                .HasColumnName("Aud_Usuario_Ingreso");
            entity.Property(e => e.AudUsuarioModifica)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("(user_name())")
                .HasColumnName("Aud_Usuario_Modifica");
            entity.Property(e => e.ConDiarauxTipoDescripcion)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CON_DIARAUX_TIPO_DESCRIPCION");
            entity.Property(e => e.ConDiarauxTipoEstado)
                .HasDefaultValueSql("((1))")
                .HasColumnName("CON_DIARAUX_TIPO_ESTADO");
        });

        modelBuilder.Entity<ConDiarioCab>(entity =>
        {
            entity.HasKey(e => e.ConDiarcabId);

            entity.ToTable("CON_DIARIO_CAB");

            entity.Property(e => e.ConDiarcabId).HasColumnName("CON_DIARCAB_ID");
            entity.Property(e => e.AudFechaIngreso)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Aud_Fecha_Ingreso");
            entity.Property(e => e.AudFechaModifica)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Aud_Fecha_Modifica");
            entity.Property(e => e.AudPcIngreso)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("((((host_name()+'/')+isnull(CONVERT([varchar],connectionproperty('client_net_address')),'-'))+'/')+isnull(CONVERT([varchar],connectionproperty('local_net_address')),'-'))")
                .HasColumnName("Aud_PC_Ingreso");
            entity.Property(e => e.AudPcModifica)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("((((host_name()+'/')+isnull(CONVERT([varchar],connectionproperty('client_net_address')),'-'))+'/')+isnull(CONVERT([varchar],connectionproperty('local_net_address')),'-'))")
                .HasColumnName("Aud_PC_Modifica");
            entity.Property(e => e.AudUsuarioIngreso)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("(user_name())")
                .HasColumnName("Aud_Usuario_Ingreso");
            entity.Property(e => e.AudUsuarioModifica)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("(user_name())")
                .HasColumnName("Aud_Usuario_Modifica");
            entity.Property(e => e.ConDiarcabDiarioDescripcion)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("CON_DIARCAB_Diario_DESCRIPCION");
            entity.Property(e => e.ConDiarcabDiarioNombre)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CON_DIARCAB_Diario_NOMBRE");
            entity.Property(e => e.ConDiarcabEstado)
                .HasDefaultValueSql("((1))")
                .HasColumnName("CON_DIARCAB_ESTADO");
            entity.Property(e => e.ConDiarcabFechaContable)
                .HasColumnType("date")
                .HasColumnName("CON_DIARCAB_Fecha_Contable");
            entity.Property(e => e.ConDiarcabFechaDigitado)
                .HasColumnType("date")
                .HasColumnName("CON_DIARCAB_FECHA_DIGITADO");
            entity.Property(e => e.ConDiarcabFechaProcesado)
                .HasColumnType("date")
                .HasColumnName("CON_DIARCAB_FECHA_PROCESADO");
            entity.Property(e => e.ConDiarcabNumero)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CON_DIARCAB_Numero");
            entity.Property(e => e.ConDiarcabTotalDebe)
                .HasColumnType("numeric(18, 8)")
                .HasColumnName("CON_DIARCAB_Total_Debe");
            entity.Property(e => e.ConDiarcabTotalHaber)
                .HasColumnType("numeric(18, 8)")
                .HasColumnName("CON_DIARCAB_Total_Haber");
            entity.Property(e => e.ConDiarcabUsuarioDigita)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CON_DIARCAB_USUARIO_DIGITA");
            entity.Property(e => e.ConDiarcabUsuarioProcesa)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CON_DIARCAB_USUARIO_PROCESA");
            entity.Property(e => e.ConDiartipId).HasColumnName("CON_DIARTIP_ID");
            entity.Property(e => e.ConEstcontId).HasColumnName("CON_ESTCONT_ID");
            entity.Property(e => e.GenanioId).HasColumnName("GENANIO_ID");
            entity.Property(e => e.GenempId).HasColumnName("GENEMP_ID");
            entity.Property(e => e.GenmesId).HasColumnName("GENMES_ID");

            entity.HasOne(d => d.ConDiartip).WithMany(p => p.ConDiarioCabs)
                .HasForeignKey(d => d.ConDiartipId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CON_DIARIO_CAB_TCO");

            entity.HasOne(d => d.ConEstcont).WithMany(p => p.ConDiarioCabs)
                .HasForeignKey(d => d.ConEstcontId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CON_DIARIO_CAB_ESTCont");

            entity.HasOne(d => d.Genanio).WithMany(p => p.ConDiarioCabs)
                .HasForeignKey(d => d.GenanioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CON_DIARIO_CAB_ANIO");

            entity.HasOne(d => d.Genemp).WithMany(p => p.ConDiarioCabs)
                .HasForeignKey(d => d.GenempId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CON_DIARIO_CAB_EMP");

            entity.HasOne(d => d.Genmes).WithMany(p => p.ConDiarioCabs)
                .HasForeignKey(d => d.GenmesId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CON_DIARIO_CAB_MES");
        });

        modelBuilder.Entity<ConDiarioDet>(entity =>
        {
            entity.HasKey(e => e.ConDiardetId);

            entity.ToTable("CON_DIARIO_DET");

            entity.Property(e => e.ConDiardetId).HasColumnName("CON_DIARDET_ID");
            entity.Property(e => e.AudFechaIngreso)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Aud_Fecha_Ingreso");
            entity.Property(e => e.AudFechaModifica)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Aud_Fecha_Modifica");
            entity.Property(e => e.AudPcIngreso)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("((((host_name()+'/')+isnull(CONVERT([varchar],connectionproperty('client_net_address')),'-'))+'/')+isnull(CONVERT([varchar],connectionproperty('local_net_address')),'-'))")
                .HasColumnName("Aud_PC_Ingreso");
            entity.Property(e => e.AudPcModifica)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("((((host_name()+'/')+isnull(CONVERT([varchar],connectionproperty('client_net_address')),'-'))+'/')+isnull(CONVERT([varchar],connectionproperty('local_net_address')),'-'))")
                .HasColumnName("Aud_PC_Modifica");
            entity.Property(e => e.AudUsuarioIngreso)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("(user_name())")
                .HasColumnName("Aud_Usuario_Ingreso");
            entity.Property(e => e.AudUsuarioModifica)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("(user_name())")
                .HasColumnName("Aud_Usuario_Modifica");
            entity.Property(e => e.ConCtaplaId).HasColumnName("CON_CTAPLA_ID");
            entity.Property(e => e.ConDiarcabId).HasColumnName("CON_DIARCAB_ID");
            entity.Property(e => e.ConDiardetAuxTotal)
                .HasColumnType("numeric(18, 8)")
                .HasColumnName("CON_DIARDET_Aux_Total");
            entity.Property(e => e.ConDiardetDebe)
                .HasColumnType("numeric(18, 8)")
                .HasColumnName("CON_DIARDET_Debe");
            entity.Property(e => e.ConDiardetEstado)
                .HasDefaultValueSql("((1))")
                .HasColumnName("CON_DIARDET_ESTADO");
            entity.Property(e => e.ConDiardetGlosa)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("CON_DIARDET_Glosa");
            entity.Property(e => e.ConDiardetHaber)
                .HasColumnType("numeric(18, 8)")
                .HasColumnName("CON_DIARDET_Haber");
            entity.Property(e => e.ConDiardetNumLin).HasColumnName("CON_DIARDET_NumLin");
            entity.Property(e => e.ConDiardetReferencia)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CON_DIARDET_Referencia");
            entity.Property(e => e.ConDiarioReqAuxSn).HasColumnName("Con_DiarioReqAux_SN");
            entity.Property(e => e.ConDiarioReqCcoSn).HasColumnName("Con_DiarioReqCCO_SN");
            entity.Property(e => e.GenempId).HasColumnName("GENEMP_ID");

            entity.HasOne(d => d.ConCtapla).WithMany(p => p.ConDiarioDets)
                .HasForeignKey(d => d.ConCtaplaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CON_DIARIO_DET_PLA");

            entity.HasOne(d => d.ConDiarcab).WithMany(p => p.ConDiarioDets)
                .HasForeignKey(d => d.ConDiarcabId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CON_DIARIO_DET_DIACAB");

            entity.HasOne(d => d.ConDiarioReqAuxSnNavigation).WithMany(p => p.ConDiarioDetConDiarioReqAuxSnNavigations)
                .HasForeignKey(d => d.ConDiarioReqAuxSn)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CON_DIARIO_DET_AUXSN");

            entity.HasOne(d => d.ConDiarioReqCcoSnNavigation).WithMany(p => p.ConDiarioDetConDiarioReqCcoSnNavigations)
                .HasForeignKey(d => d.ConDiarioReqCcoSn)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CON_DIARIO_DET_CCOSN");

            entity.HasOne(d => d.Genemp).WithMany(p => p.ConDiarioDets)
                .HasForeignKey(d => d.GenempId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CON_DIARIO_DET_EMP");
        });

        modelBuilder.Entity<ConDiarioSecuencium>(entity =>
        {
            entity.HasKey(e => e.ConDiarsecId);

            entity.ToTable("CON_DIARIO_SECUENCIA");

            entity.Property(e => e.ConDiarsecId).HasColumnName("CON_DIARSEC_ID");
            entity.Property(e => e.AudFechaIngreso)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Aud_Fecha_Ingreso");
            entity.Property(e => e.AudFechaModifica)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Aud_Fecha_Modifica");
            entity.Property(e => e.AudPcIngreso)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("((((host_name()+'/')+isnull(CONVERT([varchar],connectionproperty('client_net_address')),'-'))+'/')+isnull(CONVERT([varchar],connectionproperty('local_net_address')),'-'))")
                .HasColumnName("Aud_PC_Ingreso");
            entity.Property(e => e.AudPcModifica)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("((((host_name()+'/')+isnull(CONVERT([varchar],connectionproperty('client_net_address')),'-'))+'/')+isnull(CONVERT([varchar],connectionproperty('local_net_address')),'-'))")
                .HasColumnName("Aud_PC_Modifica");
            entity.Property(e => e.AudUsuarioIngreso)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("(user_name())")
                .HasColumnName("Aud_Usuario_Ingreso");
            entity.Property(e => e.AudUsuarioModifica)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("(user_name())")
                .HasColumnName("Aud_Usuario_Modifica");
            entity.Property(e => e.ConDiarsecEstado)
                .HasDefaultValueSql("((1))")
                .HasColumnName("CON_DIARSEC_ESTADO");
            entity.Property(e => e.ConDiarsecNumero)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CON_DIARSEC_Numero");
            entity.Property(e => e.ConDiartipId).HasColumnName("CON_DIARTIP_ID");
            entity.Property(e => e.GenanioId).HasColumnName("GENANIO_ID");
            entity.Property(e => e.GenempId).HasColumnName("GENEMP_ID");
            entity.Property(e => e.GenmesId).HasColumnName("GENMES_Id");

            entity.HasOne(d => d.ConDiartip).WithMany(p => p.ConDiarioSecuencia)
                .HasForeignKey(d => d.ConDiartipId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CON_DIARIO_SECUENCIA_TCO");

            entity.HasOne(d => d.Genanio).WithMany(p => p.ConDiarioSecuencia)
                .HasForeignKey(d => d.GenanioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CON_DIARIO_SECUENCIA_ANIO");

            entity.HasOne(d => d.Genemp).WithMany(p => p.ConDiarioSecuencia)
                .HasForeignKey(d => d.GenempId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CON_DIARIO_SECUENCIA_EMP");

            entity.HasOne(d => d.Genmes).WithMany(p => p.ConDiarioSecuencia)
                .HasForeignKey(d => d.GenmesId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CON_DIARIO_SECUENCIA_MES");
        });

        modelBuilder.Entity<ConDiarioTipo>(entity =>
        {
            entity.HasKey(e => e.ConDiartipId);

            entity.ToTable("CON_DIARIO_TIPO");

            entity.Property(e => e.ConDiartipId).HasColumnName("CON_DIARTIP_ID");
            entity.Property(e => e.AudFechaIngreso)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Aud_Fecha_Ingreso");
            entity.Property(e => e.AudFechaModifica)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Aud_Fecha_Modifica");
            entity.Property(e => e.AudPcIngreso)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("((((host_name()+'/')+isnull(CONVERT([varchar],connectionproperty('client_net_address')),'-'))+'/')+isnull(CONVERT([varchar],connectionproperty('local_net_address')),'-'))")
                .HasColumnName("Aud_PC_Ingreso");
            entity.Property(e => e.AudPcModifica)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("((((host_name()+'/')+isnull(CONVERT([varchar],connectionproperty('client_net_address')),'-'))+'/')+isnull(CONVERT([varchar],connectionproperty('local_net_address')),'-'))")
                .HasColumnName("Aud_PC_Modifica");
            entity.Property(e => e.AudUsuarioIngreso)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("(user_name())")
                .HasColumnName("Aud_Usuario_Ingreso");
            entity.Property(e => e.AudUsuarioModifica)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("(user_name())")
                .HasColumnName("Aud_Usuario_Modifica");
            entity.Property(e => e.ConComptipManualSn).HasColumnName("CON_COMPTIP_Manual_SN");
            entity.Property(e => e.ConDiartipEstado)
                .HasDefaultValueSql("((1))")
                .HasColumnName("CON_DIARTIP_ESTADO");
            entity.Property(e => e.ConDiartipNombre)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CON_DIARTIP_NOMBRE");
            entity.Property(e => e.GenanioId).HasColumnName("GENANIO_ID");
            entity.Property(e => e.GenempId).HasColumnName("GENEMP_ID");

            entity.HasOne(d => d.ConComptipManualSnNavigation).WithMany(p => p.ConDiarioTipos)
                .HasForeignKey(d => d.ConComptipManualSn)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CON_DIARIO_TIPO_SN");

            entity.HasOne(d => d.Genanio).WithMany(p => p.ConDiarioTipos)
                .HasForeignKey(d => d.GenanioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CON_DIARIO_TIPO_ANIO");

            entity.HasOne(d => d.Genemp).WithMany(p => p.ConDiarioTipos)
                .HasForeignKey(d => d.GenempId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CON_DIARIO_TIPO_EMP");
        });

        modelBuilder.Entity<ConEstadoContab>(entity =>
        {
            entity.HasKey(e => e.ConEstcontId);

            entity.ToTable("CON_ESTADO_CONTAB");

            entity.Property(e => e.ConEstcontId).HasColumnName("CON_ESTCONT_ID");
            entity.Property(e => e.AudFechaIngreso)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Aud_Fecha_Ingreso");
            entity.Property(e => e.AudFechaModifica)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Aud_Fecha_Modifica");
            entity.Property(e => e.AudPcIngreso)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("((((host_name()+'/')+isnull(CONVERT([varchar],connectionproperty('client_net_address')),'-'))+'/')+isnull(CONVERT([varchar],connectionproperty('local_net_address')),'-'))")
                .HasColumnName("Aud_PC_Ingreso");
            entity.Property(e => e.AudPcModifica)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("((((host_name()+'/')+isnull(CONVERT([varchar],connectionproperty('client_net_address')),'-'))+'/')+isnull(CONVERT([varchar],connectionproperty('local_net_address')),'-'))")
                .HasColumnName("Aud_PC_Modifica");
            entity.Property(e => e.AudUsuarioIngreso)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("(user_name())")
                .HasColumnName("Aud_Usuario_Ingreso");
            entity.Property(e => e.AudUsuarioModifica)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("(user_name())")
                .HasColumnName("Aud_Usuario_Modifica");
            entity.Property(e => e.ConEstcontDescripcion)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CON_ESTCONT_DESCRIPCION");
            entity.Property(e => e.ConEstcontEstado)
                .HasDefaultValueSql("((1))")
                .HasColumnName("CON_ESTCONT_ESTADO");
            entity.Property(e => e.GenempId).HasColumnName("GENEMP_ID");

            entity.HasOne(d => d.Genemp).WithMany(p => p.ConEstadoContabs)
                .HasForeignKey(d => d.GenempId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CON_ESTADO_CONTAB_EMP");
        });

        modelBuilder.Entity<GenAnio>(entity =>
        {
            entity.ToTable("GEN_ANIO");

            entity.Property(e => e.GenanioId).HasColumnName("GENANIO_ID");
            entity.Property(e => e.AudFechaIngreso)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Aud_Fecha_Ingreso");
            entity.Property(e => e.AudFechaModifica)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Aud_Fecha_Modifica");
            entity.Property(e => e.AudPcIngreso)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("((((host_name()+'/')+isnull(CONVERT([varchar],connectionproperty('client_net_address')),'-'))+'/')+isnull(CONVERT([varchar],connectionproperty('local_net_address')),'-'))")
                .HasColumnName("Aud_PC_Ingreso");
            entity.Property(e => e.AudPcModifica)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("((((host_name()+'/')+isnull(CONVERT([varchar],connectionproperty('client_net_address')),'-'))+'/')+isnull(CONVERT([varchar],connectionproperty('local_net_address')),'-'))")
                .HasColumnName("Aud_PC_Modifica");
            entity.Property(e => e.AudUsuarioIngreso)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("(user_name())")
                .HasColumnName("Aud_Usuario_Ingreso");
            entity.Property(e => e.AudUsuarioModifica)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("(user_name())")
                .HasColumnName("Aud_Usuario_Modifica");
            entity.Property(e => e.GenanioDescripcion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GENANIO_Descripcion");
            entity.Property(e => e.GenanioEstadoSn)
                .HasDefaultValueSql("((1))")
                .HasColumnName("GENANIO_ESTADO_SN");
            entity.Property(e => e.GenempEstado)
                .HasDefaultValueSql("((1))")
                .HasColumnName("GENEMP_ESTADO");
            entity.Property(e => e.GenempId).HasColumnName("GENEMP_ID");

            entity.HasOne(d => d.GenanioEstadoSnNavigation).WithMany(p => p.GenAnios)
                .HasForeignKey(d => d.GenanioEstadoSn)
                .HasConstraintName("FK_GENANIO_EST");

            entity.HasOne(d => d.Genemp).WithMany(p => p.GenAnios)
                .HasForeignKey(d => d.GenempId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GEN_ANIO_EMPRESA");
        });

        modelBuilder.Entity<GenCategorium>(entity =>
        {
            entity.HasKey(e => e.GencatId);

            entity.ToTable("GEN_CATEGORIA");

            entity.Property(e => e.GencatId).HasColumnName("GENCAT_ID");
            entity.Property(e => e.AudFechaIngreso)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Aud_Fecha_Ingreso");
            entity.Property(e => e.AudFechaModifica)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Aud_Fecha_Modifica");
            entity.Property(e => e.AudPcIngreso)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("((((host_name()+'/')+isnull(CONVERT([varchar],connectionproperty('client_net_address')),'-'))+'/')+isnull(CONVERT([varchar],connectionproperty('local_net_address')),'-'))")
                .HasColumnName("Aud_PC_Ingreso");
            entity.Property(e => e.AudPcModifica)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("((((host_name()+'/')+isnull(CONVERT([varchar],connectionproperty('client_net_address')),'-'))+'/')+isnull(CONVERT([varchar],connectionproperty('local_net_address')),'-'))")
                .HasColumnName("Aud_PC_Modifica");
            entity.Property(e => e.AudUsuarioIngreso)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("(user_name())")
                .HasColumnName("Aud_Usuario_Ingreso");
            entity.Property(e => e.AudUsuarioModifica)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("(user_name())")
                .HasColumnName("Aud_Usuario_Modifica");
            entity.Property(e => e.GencatDescripcion)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("GENCAT_DESCRIPCION");
            entity.Property(e => e.GencatEstado)
                .HasDefaultValueSql("((1))")
                .HasColumnName("GENCAT_ESTADO");
        });

        modelBuilder.Entity<GenCliente>(entity =>
        {
            entity.HasKey(e => e.GencliId);

            entity.ToTable("GEN_CLIENTES");

            entity.HasIndex(e => e.GencliIdentificaNum, "UQ__GEN_CLIE__4C25392CBFB52B52").IsUnique();

            entity.Property(e => e.GencliId).HasColumnName("GENCLI_ID");
            entity.Property(e => e.AudFechaIngreso)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Aud_Fecha_Ingreso");
            entity.Property(e => e.AudFechaModifica)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Aud_Fecha_Modifica");
            entity.Property(e => e.AudPcIngreso)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("((((host_name()+'/')+isnull(CONVERT([varchar],connectionproperty('client_net_address')),'-'))+'/')+isnull(CONVERT([varchar],connectionproperty('local_net_address')),'-'))")
                .HasColumnName("Aud_PC_Ingreso");
            entity.Property(e => e.AudPcModifica)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("((((host_name()+'/')+isnull(CONVERT([varchar],connectionproperty('client_net_address')),'-'))+'/')+isnull(CONVERT([varchar],connectionproperty('local_net_address')),'-'))")
                .HasColumnName("Aud_PC_Modifica");
            entity.Property(e => e.AudUsuarioIngreso)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("(user_name())")
                .HasColumnName("Aud_Usuario_Ingreso");
            entity.Property(e => e.AudUsuarioModifica)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("(user_name())")
                .HasColumnName("Aud_Usuario_Modifica");
            entity.Property(e => e.GencliApellidos)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GENCLI_APELLIDOS");
            entity.Property(e => e.GencliCorreo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GENCLI_CORREO");
            entity.Property(e => e.GencliDireccion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValueSql("('XXXXXXXXX')")
                .HasColumnName("GENCLI_DIRECCION");
            entity.Property(e => e.GencliEstado)
                .HasDefaultValueSql("((1))")
                .HasColumnName("GENCLI_ESTADO");
            entity.Property(e => e.GencliFechaDeNacimiento)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("date")
                .HasColumnName("GENCLI_FECHA_DE_NACIMIENTO");
            entity.Property(e => e.GencliIdentificaNum)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("GENCLI_IDENTIFICA_NUM");
            entity.Property(e => e.GencliIdentificaTip).HasColumnName("GENCLI_IDENTIFICA_TIP");
            entity.Property(e => e.GencliImagen)
                .HasMaxLength(500)
                .HasColumnName("GENCLI_IMAGEN");
            entity.Property(e => e.GencliNomImagen)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("GENCLI_NOM_IMAGEN");
            entity.Property(e => e.GencliNombres)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GENCLI_NOMBRES");
            entity.Property(e => e.GencliTelefono)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('9999999999')")
                .HasColumnName("GENCLI_TELEFONO");
            entity.Property(e => e.GenempId).HasColumnName("GENEMP_ID");

            entity.HasOne(d => d.GencliIdentificaTipNavigation).WithMany(p => p.GenClientes)
                .HasForeignKey(d => d.GencliIdentificaTip)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GEN_CLIENTES_GEN_EMPRESAS");

            entity.HasOne(d => d.Genemp).WithMany(p => p.GenClientes)
                .HasForeignKey(d => d.GenempId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GEN_CLIENTES_EMPRESA");
        });

        modelBuilder.Entity<GenEmpresa>(entity =>
        {
            entity.HasKey(e => e.GenempId);

            entity.ToTable("GEN_EMPRESAS");

            entity.HasIndex(e => e.GenempNomComercial, "UQ__GEN_EMPR__1B88AE58BB6B60DD").IsUnique();

            entity.HasIndex(e => e.GenempRuc, "UQ__GEN_EMPR__5AF4BCFC84A643BF").IsUnique();

            entity.Property(e => e.GenempId).HasColumnName("GENEMP_ID");
            entity.Property(e => e.AudFechaIngreso)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Aud_Fecha_Ingreso");
            entity.Property(e => e.AudFechaModifica)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Aud_Fecha_Modifica");
            entity.Property(e => e.AudPcIngreso)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("((((host_name()+'/')+isnull(CONVERT([varchar],connectionproperty('client_net_address')),'-'))+'/')+isnull(CONVERT([varchar],connectionproperty('local_net_address')),'-'))")
                .HasColumnName("Aud_PC_Ingreso");
            entity.Property(e => e.AudPcModifica)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("((((host_name()+'/')+isnull(CONVERT([varchar],connectionproperty('client_net_address')),'-'))+'/')+isnull(CONVERT([varchar],connectionproperty('local_net_address')),'-'))")
                .HasColumnName("Aud_PC_Modifica");
            entity.Property(e => e.AudUsuarioIngreso)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("(user_name())")
                .HasColumnName("Aud_Usuario_Ingreso");
            entity.Property(e => e.AudUsuarioModifica)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("(user_name())")
                .HasColumnName("Aud_Usuario_Modifica");
            entity.Property(e => e.GenempCorreoElectronico)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GENEMP_CORREO_ELECTRONICO");
            entity.Property(e => e.GenempDireccionMatriz)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GENEMP_DIRECCION_MATRIZ");
            entity.Property(e => e.GenempEstado)
                .HasDefaultValueSql("((1))")
                .HasColumnName("GENEMP_ESTADO");
            entity.Property(e => e.GenempNomComercial)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GENEMP_NOM_COMERCIAL");
            entity.Property(e => e.GenempRazonSocial)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GENEMP_RAZON_SOCIAL");
            entity.Property(e => e.GenempRuc)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("GENEMP_RUC");
            entity.Property(e => e.GenempTelefono1)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("GENEMP_TELEFONO_1");
            entity.Property(e => e.GenempTelefono2)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("GENEMP_TELEFONO_2");
        });

        modelBuilder.Entity<GenMarca>(entity =>
        {
            entity.HasKey(e => e.GenmarId);

            entity.ToTable("GEN_MARCA");

            entity.Property(e => e.GenmarId).HasColumnName("GENMAR_ID");
            entity.Property(e => e.AudFechaIngreso)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Aud_Fecha_Ingreso");
            entity.Property(e => e.AudFechaModifica)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Aud_Fecha_Modifica");
            entity.Property(e => e.AudPcIngreso)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("((((host_name()+'/')+isnull(CONVERT([varchar],connectionproperty('client_net_address')),'-'))+'/')+isnull(CONVERT([varchar],connectionproperty('local_net_address')),'-'))")
                .HasColumnName("Aud_PC_Ingreso");
            entity.Property(e => e.AudPcModifica)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("((((host_name()+'/')+isnull(CONVERT([varchar],connectionproperty('client_net_address')),'-'))+'/')+isnull(CONVERT([varchar],connectionproperty('local_net_address')),'-'))")
                .HasColumnName("Aud_PC_Modifica");
            entity.Property(e => e.AudUsuarioIngreso)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("(user_name())")
                .HasColumnName("Aud_Usuario_Ingreso");
            entity.Property(e => e.AudUsuarioModifica)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("(user_name())")
                .HasColumnName("Aud_Usuario_Modifica");
            entity.Property(e => e.GenmarDescripcion)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("GENMAR_DESCRIPCION");
            entity.Property(e => e.GenmarEstado)
                .HasDefaultValueSql("((1))")
                .HasColumnName("GENMAR_ESTADO");
        });

        modelBuilder.Entity<GenMe>(entity =>
        {
            entity.HasKey(e => e.GenmesId);

            entity.ToTable("GEN_MES");

            entity.Property(e => e.GenmesId).HasColumnName("GENMES_Id");
            entity.Property(e => e.AudFechaIngreso)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Aud_Fecha_Ingreso");
            entity.Property(e => e.AudFechaModifica)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Aud_Fecha_Modifica");
            entity.Property(e => e.AudPcIngreso)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("((((host_name()+'/')+isnull(CONVERT([varchar],connectionproperty('client_net_address')),'-'))+'/')+isnull(CONVERT([varchar],connectionproperty('local_net_address')),'-'))")
                .HasColumnName("Aud_PC_Ingreso");
            entity.Property(e => e.AudPcModifica)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("((((host_name()+'/')+isnull(CONVERT([varchar],connectionproperty('client_net_address')),'-'))+'/')+isnull(CONVERT([varchar],connectionproperty('local_net_address')),'-'))")
                .HasColumnName("Aud_PC_Modifica");
            entity.Property(e => e.AudUsuarioIngreso)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("(user_name())")
                .HasColumnName("Aud_Usuario_Ingreso");
            entity.Property(e => e.AudUsuarioModifica)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("(user_name())")
                .HasColumnName("Aud_Usuario_Modifica");
            entity.Property(e => e.GenempEstado)
                .HasDefaultValueSql("((1))")
                .HasColumnName("GENEMP_ESTADO");
            entity.Property(e => e.GenempId).HasColumnName("GENEMP_ID");
            entity.Property(e => e.GenmesDescripcion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GENMES_Descripcion");
            entity.Property(e => e.GenmesEstadoSn)
                .HasDefaultValueSql("((1))")
                .HasColumnName("GENMES_ESTADO_SN");

            entity.HasOne(d => d.Genemp).WithMany(p => p.GenMes)
                .HasForeignKey(d => d.GenempId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GENMES_EMP");

            entity.HasOne(d => d.GenmesEstadoSnNavigation).WithMany(p => p.GenMes)
                .HasForeignKey(d => d.GenmesEstadoSn)
                .HasConstraintName("FK_GENMES_EST");
        });

        modelBuilder.Entity<GenMedida>(entity =>
        {
            entity.HasKey(e => e.GenmedId);

            entity.ToTable("GEN_MEDIDAS");

            entity.Property(e => e.GenmedId).HasColumnName("GENMED_ID");
            entity.Property(e => e.AudFechaIngreso)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Aud_Fecha_Ingreso");
            entity.Property(e => e.AudFechaModifica)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Aud_Fecha_Modifica");
            entity.Property(e => e.AudPcIngreso)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("((((host_name()+'/')+isnull(CONVERT([varchar],connectionproperty('client_net_address')),'-'))+'/')+isnull(CONVERT([varchar],connectionproperty('local_net_address')),'-'))")
                .HasColumnName("Aud_PC_Ingreso");
            entity.Property(e => e.AudPcModifica)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("((((host_name()+'/')+isnull(CONVERT([varchar],connectionproperty('client_net_address')),'-'))+'/')+isnull(CONVERT([varchar],connectionproperty('local_net_address')),'-'))")
                .HasColumnName("Aud_PC_Modifica");
            entity.Property(e => e.AudUsuarioIngreso)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("(user_name())")
                .HasColumnName("Aud_Usuario_Ingreso");
            entity.Property(e => e.AudUsuarioModifica)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("(user_name())")
                .HasColumnName("Aud_Usuario_Modifica");
            entity.Property(e => e.GenmedDescripcion)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("GENMED_DESCRIPCION");
            entity.Property(e => e.GenmedEstado)
                .HasDefaultValueSql("((1))")
                .HasColumnName("GENMED_ESTADO");
        });

        modelBuilder.Entity<GenProducto>(entity =>
        {
            entity.HasKey(e => e.GenprodId);

            entity.ToTable("GEN_PRODUCTOS");

            entity.HasIndex(e => e.GenprodDescripcion, "UQ__GEN_PROD__9736E3AF3C5C5753").IsUnique();

            entity.HasIndex(e => e.GenprodCodigo, "UQ__GEN_PROD__FCF92267824E619E").IsUnique();

            entity.Property(e => e.GenprodId).HasColumnName("GENPROD_ID");
            entity.Property(e => e.AudFechaIngreso)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Aud_Fecha_Ingreso");
            entity.Property(e => e.AudFechaModifica)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Aud_Fecha_Modifica");
            entity.Property(e => e.AudPcIngreso)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("((((host_name()+'/')+isnull(CONVERT([varchar],connectionproperty('client_net_address')),'-'))+'/')+isnull(CONVERT([varchar],connectionproperty('local_net_address')),'-'))")
                .HasColumnName("Aud_PC_Ingreso");
            entity.Property(e => e.AudPcModifica)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("((((host_name()+'/')+isnull(CONVERT([varchar],connectionproperty('client_net_address')),'-'))+'/')+isnull(CONVERT([varchar],connectionproperty('local_net_address')),'-'))")
                .HasColumnName("Aud_PC_Modifica");
            entity.Property(e => e.AudUsuarioIngreso)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("(user_name())")
                .HasColumnName("Aud_Usuario_Ingreso");
            entity.Property(e => e.AudUsuarioModifica)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("(user_name())")
                .HasColumnName("Aud_Usuario_Modifica");
            entity.Property(e => e.GenempId).HasColumnName("GENEMP_ID");
            entity.Property(e => e.GenprodBarra)
                .HasMaxLength(500)
                .HasColumnName("GENPROD_BARRA");
            entity.Property(e => e.GenprodCatId).HasColumnName("GENPROD_CAT_ID");
            entity.Property(e => e.GenprodCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("GENPROD_CODIGO");
            entity.Property(e => e.GenprodDescripcion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GENPROD_DESCRIPCION");
            entity.Property(e => e.GenprodEstado)
                .HasDefaultValueSql("((1))")
                .HasColumnName("GENPROD_ESTADO");
            entity.Property(e => e.GenprodImagen)
                .HasMaxLength(500)
                .HasColumnName("GENPROD_IMAGEN");
            entity.Property(e => e.GenprodMarId).HasColumnName("GENPROD_MAR_ID");
            entity.Property(e => e.GenprodMedId).HasColumnName("GENPROD_MED_ID");
            entity.Property(e => e.GenprodNomImagen)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("GENPROD_NOM_IMAGEN");
            entity.Property(e => e.GenprodPresentId).HasColumnName("GENPROD_PRESENT_ID");
            entity.Property(e => e.GenprodTipId).HasColumnName("GENPROD_TIP_ID");

            entity.HasOne(d => d.Genemp).WithMany(p => p.GenProductos)
                .HasForeignKey(d => d.GenempId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GEN_PRODUCTOS_EMPRESA");

            entity.HasOne(d => d.GenprodCat).WithMany(p => p.GenProductos)
                .HasForeignKey(d => d.GenprodCatId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GEN_PRODUCTOS_GEN_CATEGORIA");

            entity.HasOne(d => d.GenprodMar).WithMany(p => p.GenProductos)
                .HasForeignKey(d => d.GenprodMarId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GEN_PRODUCTOS_GEN_MARCA");

            entity.HasOne(d => d.GenprodMed).WithMany(p => p.GenProductos)
                .HasForeignKey(d => d.GenprodMedId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GEN_PRODUCTOS_GEN_MEDIDAS");

            entity.HasOne(d => d.GenprodPresent).WithMany(p => p.GenProductos)
                .HasForeignKey(d => d.GenprodPresentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GEN_PRODUCTOS_GEN_PRODUCTO_PRESENT");

            entity.HasOne(d => d.GenprodTip).WithMany(p => p.GenProductos)
                .HasForeignKey(d => d.GenprodTipId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GEN_PRODUCTOS_GEN_PRODUCTO_TIPO");
        });

        modelBuilder.Entity<GenProductoPresent>(entity =>
        {
            entity.HasKey(e => e.GenprodpresId);

            entity.ToTable("GEN_PRODUCTO_PRESENT");

            entity.Property(e => e.GenprodpresId).HasColumnName("GENPRODPRES_ID");
            entity.Property(e => e.AudFechaIngreso)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Aud_Fecha_Ingreso");
            entity.Property(e => e.AudFechaModifica)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Aud_Fecha_Modifica");
            entity.Property(e => e.AudPcIngreso)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("((((host_name()+'/')+isnull(CONVERT([varchar],connectionproperty('client_net_address')),'-'))+'/')+isnull(CONVERT([varchar],connectionproperty('local_net_address')),'-'))")
                .HasColumnName("Aud_PC_Ingreso");
            entity.Property(e => e.AudPcModifica)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("((((host_name()+'/')+isnull(CONVERT([varchar],connectionproperty('client_net_address')),'-'))+'/')+isnull(CONVERT([varchar],connectionproperty('local_net_address')),'-'))")
                .HasColumnName("Aud_PC_Modifica");
            entity.Property(e => e.AudUsuarioIngreso)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("(user_name())")
                .HasColumnName("Aud_Usuario_Ingreso");
            entity.Property(e => e.AudUsuarioModifica)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("(user_name())")
                .HasColumnName("Aud_Usuario_Modifica");
            entity.Property(e => e.GenprodpresDescripcion)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("GENPRODPRES_DESCRIPCION");
            entity.Property(e => e.GenprodpresEstado)
                .HasDefaultValueSql("((1))")
                .HasColumnName("GENPRODPRES_ESTADO");
        });

        modelBuilder.Entity<GenProductoTipo>(entity =>
        {
            entity.HasKey(e => e.GenprodtipId);

            entity.ToTable("GEN_PRODUCTO_TIPO");

            entity.Property(e => e.GenprodtipId).HasColumnName("GENPRODTIP_ID");
            entity.Property(e => e.AudFechaIngreso)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Aud_Fecha_Ingreso");
            entity.Property(e => e.AudFechaModifica)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Aud_Fecha_Modifica");
            entity.Property(e => e.AudPcIngreso)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("((((host_name()+'/')+isnull(CONVERT([varchar],connectionproperty('client_net_address')),'-'))+'/')+isnull(CONVERT([varchar],connectionproperty('local_net_address')),'-'))")
                .HasColumnName("Aud_PC_Ingreso");
            entity.Property(e => e.AudPcModifica)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("((((host_name()+'/')+isnull(CONVERT([varchar],connectionproperty('client_net_address')),'-'))+'/')+isnull(CONVERT([varchar],connectionproperty('local_net_address')),'-'))")
                .HasColumnName("Aud_PC_Modifica");
            entity.Property(e => e.AudUsuarioIngreso)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("(user_name())")
                .HasColumnName("Aud_Usuario_Ingreso");
            entity.Property(e => e.AudUsuarioModifica)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("(user_name())")
                .HasColumnName("Aud_Usuario_Modifica");
            entity.Property(e => e.GenprodtipDescripcion)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("GENPRODTIP_DESCRIPCION");
            entity.Property(e => e.GenprodtipEstado)
                .HasDefaultValueSql("((1))")
                .HasColumnName("GENPRODTIP_ESTADO");
        });

        modelBuilder.Entity<GenStockCab>(entity =>
        {
            entity.HasKey(e => e.GenstkcabId);

            entity.ToTable("GEN_STOCK_CAB");

            entity.Property(e => e.GenstkcabId).HasColumnName("GENSTKCAB_ID");
            entity.Property(e => e.AudFechaIngreso)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Aud_Fecha_Ingreso");
            entity.Property(e => e.AudFechaModifica)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Aud_Fecha_Modifica");
            entity.Property(e => e.AudPcIngreso)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("((((host_name()+'/')+isnull(CONVERT([varchar],connectionproperty('client_net_address')),'-'))+'/')+isnull(CONVERT([varchar],connectionproperty('local_net_address')),'-'))")
                .HasColumnName("Aud_PC_Ingreso");
            entity.Property(e => e.AudPcModifica)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("((((host_name()+'/')+isnull(CONVERT([varchar],connectionproperty('client_net_address')),'-'))+'/')+isnull(CONVERT([varchar],connectionproperty('local_net_address')),'-'))")
                .HasColumnName("Aud_PC_Modifica");
            entity.Property(e => e.AudUsuarioIngreso)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("(user_name())")
                .HasColumnName("Aud_Usuario_Ingreso");
            entity.Property(e => e.AudUsuarioModifica)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("(user_name())")
                .HasColumnName("Aud_Usuario_Modifica");
            entity.Property(e => e.GenempId).HasColumnName("GENEMP_ID");
            entity.Property(e => e.GenstkcabCantDisp).HasColumnName("GENSTKCAB_CANT_DISP");
            entity.Property(e => e.GenstkcabCostMax)
                .HasDefaultValueSql("('0.00')")
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("GENSTKCAB_COST_MAX");
            entity.Property(e => e.GenstkcabCostMin)
                .HasDefaultValueSql("('0.00')")
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("GENSTKCAB_COST_MIN");
            entity.Property(e => e.GenstkcabCostProme)
                .HasDefaultValueSql("('0.00')")
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("GENSTKCAB_COST_PROME");
            entity.Property(e => e.GenstkcabEstado)
                .HasDefaultValueSql("((1))")
                .HasColumnName("GENSTKCAB_ESTADO");
            entity.Property(e => e.GenstkcabFechaAdqPrim)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("GENSTKCAB_FECHA_ADQ_PRIM");
            entity.Property(e => e.GenstkcabFechaAdqUlt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("GENSTKCAB_FECHA_ADQ_ULT");
            entity.Property(e => e.GenstkcabPrecVtaMax)
                .HasDefaultValueSql("('0.00')")
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("GENSTKCAB_PREC_VTA_MAX");
            entity.Property(e => e.GenstkcabPrecVtaMin)
                .HasDefaultValueSql("('0.00')")
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("GENSTKCAB_PREC_VTA_MIN");
            entity.Property(e => e.GenstkcabPrecVtaSugerido)
                .HasDefaultValueSql("('0.00')")
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("GENSTKCAB_PREC_VTA_SUGERIDO");
            entity.Property(e => e.GenstkcabPrecioVtaAplicar)
                .HasDefaultValueSql("('0.00')")
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("GENSTKCAB_PRECIO_VTA_APLICAR");
            entity.Property(e => e.GenstkcabProdId).HasColumnName("GENSTKCAB_PROD_ID");

            entity.HasOne(d => d.Genemp).WithMany(p => p.GenStockCabs)
                .HasForeignKey(d => d.GenempId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GEN_STOCK_CAB_EMPRESA");

            entity.HasOne(d => d.GenstkcabProd).WithMany(p => p.GenStockCabs)
                .HasForeignKey(d => d.GenstkcabProdId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GEN_STOCK_CAB_GEN_PRODUCTOS");
        });

        modelBuilder.Entity<GenStockDet>(entity =>
        {
            entity.HasKey(e => e.GenstkdetId);

            entity.ToTable("GEN_STOCK_DET");

            entity.Property(e => e.GenstkdetId).HasColumnName("GENSTKDET_ID");
            entity.Property(e => e.AudFechaIngreso)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Aud_Fecha_Ingreso");
            entity.Property(e => e.AudFechaModifica)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Aud_Fecha_Modifica");
            entity.Property(e => e.AudPcIngreso)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("((((host_name()+'/')+isnull(CONVERT([varchar],connectionproperty('client_net_address')),'-'))+'/')+isnull(CONVERT([varchar],connectionproperty('local_net_address')),'-'))")
                .HasColumnName("Aud_PC_Ingreso");
            entity.Property(e => e.AudPcModifica)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("((((host_name()+'/')+isnull(CONVERT([varchar],connectionproperty('client_net_address')),'-'))+'/')+isnull(CONVERT([varchar],connectionproperty('local_net_address')),'-'))")
                .HasColumnName("Aud_PC_Modifica");
            entity.Property(e => e.AudUsuarioIngreso)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("(user_name())")
                .HasColumnName("Aud_Usuario_Ingreso");
            entity.Property(e => e.AudUsuarioModifica)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("(user_name())")
                .HasColumnName("Aud_Usuario_Modifica");
            entity.Property(e => e.GenempId).HasColumnName("GENEMP_ID");
            entity.Property(e => e.GenstkcabId).HasColumnName("GENSTKCAB_ID");
            entity.Property(e => e.GenstkdetCantComp).HasColumnName("GENSTKDET_CANT_COMP");
            entity.Property(e => e.GenstkdetCantDisp).HasColumnName("GENSTKDET_CANT_DISP");
            entity.Property(e => e.GenstkdetCostCompTotal)
                .HasDefaultValueSql("('0.00')")
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("GENSTKDET_COST_COMP_TOTAL");
            entity.Property(e => e.GenstkdetCostCompUnidad)
                .HasDefaultValueSql("('0.00')")
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("GENSTKDET_COST_COMP_UNIDAD");
            entity.Property(e => e.GenstkdetEstado)
                .HasDefaultValueSql("((1))")
                .HasColumnName("GENSTKDET_ESTADO");
            entity.Property(e => e.GenstkdetFechaAdq)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("GENSTKDET_FECHA_ADQ");
            entity.Property(e => e.GenstkdetPorcentaje)
                .HasDefaultValueSql("('0.00')")
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("GENSTKDET_PORCENTAJE");
            entity.Property(e => e.GenstkdetPrecioVtaAplicar)
                .HasDefaultValueSql("('0.00')")
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("GENSTKDET_PRECIO_VTA_APLICAR");

            entity.HasOne(d => d.Genemp).WithMany(p => p.GenStockDets)
                .HasForeignKey(d => d.GenempId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GEN_STOCK_DET_EMPRESA");

            entity.HasOne(d => d.Genstkcab).WithMany(p => p.GenStockDets)
                .HasForeignKey(d => d.GenstkcabId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GEN_STOCK_DET_GEN_PRODUCTOS");
        });

        modelBuilder.Entity<MigrationHistory>(entity =>
        {
            entity.HasKey(e => new { e.MigrationId, e.ContextKey }).HasName("PK_dbo.__MigrationHistory");

            entity.ToTable("__MigrationHistory");

            entity.Property(e => e.MigrationId).HasMaxLength(150);
            entity.Property(e => e.ContextKey).HasMaxLength(300);
            entity.Property(e => e.ProductVersion).HasMaxLength(32);
        });

        modelBuilder.Entity<SegAutoregistro>(entity =>
        {
            entity.HasKey(e => e.SegautoregId);

            entity.ToTable("SEG_AUTOREGISTRO");

            entity.Property(e => e.SegautoregId).HasColumnName("SEGAUTOREG_ID");
            entity.Property(e => e.AudFechaIngreso)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Aud_Fecha_Ingreso");
            entity.Property(e => e.AudFechaModifica)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Aud_Fecha_Modifica");
            entity.Property(e => e.AudPcIngreso)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("((((host_name()+'/')+isnull(CONVERT([varchar],connectionproperty('client_net_address')),'-'))+'/')+isnull(CONVERT([varchar],connectionproperty('local_net_address')),'-'))")
                .HasColumnName("Aud_PC_Ingreso");
            entity.Property(e => e.AudPcModifica)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("((((host_name()+'/')+isnull(CONVERT([varchar],connectionproperty('client_net_address')),'-'))+'/')+isnull(CONVERT([varchar],connectionproperty('local_net_address')),'-'))")
                .HasColumnName("Aud_PC_Modifica");
            entity.Property(e => e.AudUsuarioIngreso)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("(user_name())")
                .HasColumnName("Aud_Usuario_Ingreso");
            entity.Property(e => e.AudUsuarioModifica)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("(user_name())")
                .HasColumnName("Aud_Usuario_Modifica");
            entity.Property(e => e.GenempId).HasColumnName("GENEMP_ID");
            entity.Property(e => e.SegautoregEstado)
                .HasDefaultValueSql("((1))")
                .HasColumnName("SEGAUTOREG_ESTADO");
            entity.Property(e => e.SegcodAutoregistro)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SEGCOD_AUTOREGISTRO");
            entity.Property(e => e.SegrolId).HasColumnName("SEGROL_ID");

            entity.HasOne(d => d.Genemp).WithMany(p => p.SegAutoregistros)
                .HasForeignKey(d => d.GenempId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SEG_AUTOREGISTRO_EMPRESA");

            entity.HasOne(d => d.Segrol).WithMany(p => p.SegAutoregistros)
                .HasForeignKey(d => d.SegrolId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SEG_AUTOREGISTRO_ROLID");
        });

        modelBuilder.Entity<SegEstadoSn>(entity =>
        {
            entity.ToTable("SEG_ESTADO_SN");

            entity.Property(e => e.SegestadoSnId).HasColumnName("SEGESTADO_SN_ID");
            entity.Property(e => e.AudFechaIngreso)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Aud_Fecha_Ingreso");
            entity.Property(e => e.AudFechaModifica)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Aud_Fecha_Modifica");
            entity.Property(e => e.AudPcIngreso)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("((((host_name()+'/')+isnull(CONVERT([varchar],connectionproperty('client_net_address')),'-'))+'/')+isnull(CONVERT([varchar],connectionproperty('local_net_address')),'-'))")
                .HasColumnName("Aud_PC_Ingreso");
            entity.Property(e => e.AudPcModifica)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("((((host_name()+'/')+isnull(CONVERT([varchar],connectionproperty('client_net_address')),'-'))+'/')+isnull(CONVERT([varchar],connectionproperty('local_net_address')),'-'))")
                .HasColumnName("Aud_PC_Modifica");
            entity.Property(e => e.AudUsuarioIngreso)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("(user_name())")
                .HasColumnName("Aud_Usuario_Ingreso");
            entity.Property(e => e.AudUsuarioModifica)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("(user_name())")
                .HasColumnName("Aud_Usuario_Modifica");
            entity.Property(e => e.SegestadoSnDescripcion)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SEGESTADO_SN_DESCRIPCION");
            entity.Property(e => e.SegestadoSnEstado)
                .HasDefaultValueSql("((1))")
                .HasColumnName("SEGESTADO_SN_ESTADO");
        });

        modelBuilder.Entity<SegPermisosMnu>(entity =>
        {
            entity.HasKey(e => e.SegpermnuId);

            entity.ToTable("SEG_PERMISOS_MNU");

            entity.Property(e => e.SegpermnuId).HasColumnName("SEGPERMNU_ID");
            entity.Property(e => e.AudFechaIngreso)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Aud_Fecha_Ingreso");
            entity.Property(e => e.AudFechaModifica)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Aud_Fecha_Modifica");
            entity.Property(e => e.AudPcIngreso)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("((((host_name()+'/')+isnull(CONVERT([varchar],connectionproperty('client_net_address')),'-'))+'/')+isnull(CONVERT([varchar],connectionproperty('local_net_address')),'-'))")
                .HasColumnName("Aud_PC_Ingreso");
            entity.Property(e => e.AudPcModifica)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("((((host_name()+'/')+isnull(CONVERT([varchar],connectionproperty('client_net_address')),'-'))+'/')+isnull(CONVERT([varchar],connectionproperty('local_net_address')),'-'))")
                .HasColumnName("Aud_PC_Modifica");
            entity.Property(e => e.AudUsuarioIngreso)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("(user_name())")
                .HasColumnName("Aud_Usuario_Ingreso");
            entity.Property(e => e.AudUsuarioModifica)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("(user_name())")
                .HasColumnName("Aud_Usuario_Modifica");
            entity.Property(e => e.SegpermnuDescripcion)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SEGPERMNU_DESCRIPCION");
            entity.Property(e => e.SegpermnuEstado)
                .HasDefaultValueSql("((1))")
                .HasColumnName("SEGPERMNU_ESTADO");
            entity.Property(e => e.SegpermnuObservaciones)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("SEGPERMNU_OBSERVACIONES");
        });

        modelBuilder.Entity<SegRole>(entity =>
        {
            entity.HasKey(e => e.SegrolId);

            entity.ToTable("SEG_ROLES");

            entity.Property(e => e.SegrolId).HasColumnName("SEGROL_ID");
            entity.Property(e => e.AudFechaIngreso)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Aud_Fecha_Ingreso");
            entity.Property(e => e.AudFechaModifica)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Aud_Fecha_Modifica");
            entity.Property(e => e.AudPcIngreso)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("((((host_name()+'/')+isnull(CONVERT([varchar],connectionproperty('client_net_address')),'-'))+'/')+isnull(CONVERT([varchar],connectionproperty('local_net_address')),'-'))")
                .HasColumnName("Aud_PC_Ingreso");
            entity.Property(e => e.AudPcModifica)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("((((host_name()+'/')+isnull(CONVERT([varchar],connectionproperty('client_net_address')),'-'))+'/')+isnull(CONVERT([varchar],connectionproperty('local_net_address')),'-'))")
                .HasColumnName("Aud_PC_Modifica");
            entity.Property(e => e.AudUsuarioIngreso)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("(user_name())")
                .HasColumnName("Aud_Usuario_Ingreso");
            entity.Property(e => e.AudUsuarioModifica)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("(user_name())")
                .HasColumnName("Aud_Usuario_Modifica");
            entity.Property(e => e.SegrolDescripcion)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SEGROL_DESCRIPCION");
            entity.Property(e => e.SegrolEstado)
                .HasDefaultValueSql("((1))")
                .HasColumnName("SEGROL_ESTADO");
            entity.Property(e => e.SegrolObservaciones)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("SEGROL_OBSERVACIONES");
        });

        modelBuilder.Entity<SegRolpermiso>(entity =>
        {
            entity.HasKey(e => e.SegrolperId);

            entity.ToTable("SEG_ROLPERMISOS");

            entity.Property(e => e.SegrolperId).HasColumnName("SEGROLPER_ID");
            entity.Property(e => e.AudFechaIngreso)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Aud_Fecha_Ingreso");
            entity.Property(e => e.AudFechaModifica)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Aud_Fecha_Modifica");
            entity.Property(e => e.AudPcIngreso)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("((((host_name()+'/')+isnull(CONVERT([varchar],connectionproperty('client_net_address')),'-'))+'/')+isnull(CONVERT([varchar],connectionproperty('local_net_address')),'-'))")
                .HasColumnName("Aud_PC_Ingreso");
            entity.Property(e => e.AudPcModifica)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("((((host_name()+'/')+isnull(CONVERT([varchar],connectionproperty('client_net_address')),'-'))+'/')+isnull(CONVERT([varchar],connectionproperty('local_net_address')),'-'))")
                .HasColumnName("Aud_PC_Modifica");
            entity.Property(e => e.AudUsuarioIngreso)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("(user_name())")
                .HasColumnName("Aud_Usuario_Ingreso");
            entity.Property(e => e.AudUsuarioModifica)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("(user_name())")
                .HasColumnName("Aud_Usuario_Modifica");
            entity.Property(e => e.SegpermnuId).HasColumnName("SEGPERMNU_ID");
            entity.Property(e => e.SegrolId).HasColumnName("SEGROL_ID");
            entity.Property(e => e.SegrolperEstado)
                .HasDefaultValueSql("((1))")
                .HasColumnName("SEGROLPER_ESTADO");
            entity.Property(e => e.SegrolperObservaciones)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("SEGROLPER_OBSERVACIONES");

            entity.HasOne(d => d.Segpermnu).WithMany(p => p.SegRolpermisos)
                .HasForeignKey(d => d.SegpermnuId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SEG_ROLPERMISOS_SEG_PERMISOS_MNU");

            entity.HasOne(d => d.Segrol).WithMany(p => p.SegRolpermisos)
                .HasForeignKey(d => d.SegrolId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SEG_ROLPERMISOS_SEG_ROLES");
        });

        modelBuilder.Entity<SegUsuario>(entity =>
        {
            entity.HasKey(e => e.SeguserId);

            entity.ToTable("SEG_USUARIOS");

            entity.HasIndex(e => e.SeguserUsuario, "UQ__SEG_USUA__CA248B9E20A28C03").IsUnique();

            entity.Property(e => e.SeguserId).HasColumnName("SEGUSER_ID");
            entity.Property(e => e.AudFechaIngreso)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Aud_Fecha_Ingreso");
            entity.Property(e => e.AudFechaModifica)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Aud_Fecha_Modifica");
            entity.Property(e => e.AudPcIngreso)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("((((host_name()+'/')+isnull(CONVERT([varchar],connectionproperty('client_net_address')),'-'))+'/')+isnull(CONVERT([varchar],connectionproperty('local_net_address')),'-'))")
                .HasColumnName("Aud_PC_Ingreso");
            entity.Property(e => e.AudPcModifica)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("((((host_name()+'/')+isnull(CONVERT([varchar],connectionproperty('client_net_address')),'-'))+'/')+isnull(CONVERT([varchar],connectionproperty('local_net_address')),'-'))")
                .HasColumnName("Aud_PC_Modifica");
            entity.Property(e => e.AudUsuarioIngreso)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("(user_name())")
                .HasColumnName("Aud_Usuario_Ingreso");
            entity.Property(e => e.AudUsuarioModifica)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("(user_name())")
                .HasColumnName("Aud_Usuario_Modifica");
            entity.Property(e => e.GenempId).HasColumnName("GENEMP_ID");
            entity.Property(e => e.SegcodAutoregistro).HasColumnName("SEGCOD_AUTOREGISTRO");
            entity.Property(e => e.SegrolId).HasColumnName("SEGROL_ID");
            entity.Property(e => e.SeguserApellidos)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SEGUSER_APELLIDOS");
            entity.Property(e => e.SeguserConfirmado)
                .HasDefaultValueSql("((1))")
                .HasColumnName("SEGUSER_CONFIRMADO");
            entity.Property(e => e.SeguserContraseña)
                .HasMaxLength(500)
                .HasColumnName("SEGUSER_CONTRASEÑA");
            entity.Property(e => e.SeguserCorreo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("SEGUSER_CORREO");
            entity.Property(e => e.SeguserDireccion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValueSql("('XXXXXXXXX')")
                .HasColumnName("SEGUSER_DIRECCION");
            entity.Property(e => e.SeguserEstado)
                .HasDefaultValueSql("((1))")
                .HasColumnName("SEGUSER_ESTADO");
            entity.Property(e => e.SeguserFechaNacimiento)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("date")
                .HasColumnName("SEGUSER_FECHA_NACIMIENTO");
            entity.Property(e => e.SeguserImagen)
                .HasMaxLength(500)
                .HasColumnName("SEGUSER_IMAGEN");
            entity.Property(e => e.SeguserNomImagen)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("SEGUSER_NOM_IMAGEN");
            entity.Property(e => e.SeguserNombres)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SEGUSER_NOMBRES");
            entity.Property(e => e.SeguserTelefono)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('9999999999')")
                .HasColumnName("SEGUSER_TELEFONO");
            entity.Property(e => e.SeguserUsuario)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("SEGUSER_USUARIO");

            entity.HasOne(d => d.Genemp).WithMany(p => p.SegUsuarios)
                .HasForeignKey(d => d.GenempId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SEG_USUARIOS_EMPRESA");

            entity.HasOne(d => d.Segrol).WithMany(p => p.SegUsuarios)
                .HasForeignKey(d => d.SegrolId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SEG_USUARIOS_SEG_ROLES");
        });

        modelBuilder.Entity<SriComprobanteTipo>(entity =>
        {
            entity.HasKey(e => e.SricomptipId);

            entity.ToTable("SRI_COMPROBANTE_TIPO");

            entity.Property(e => e.SricomptipId).HasColumnName("SRICOMPTIP_ID");
            entity.Property(e => e.AudFechaIngreso)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Aud_Fecha_Ingreso");
            entity.Property(e => e.AudFechaModifica)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Aud_Fecha_Modifica");
            entity.Property(e => e.AudPcIngreso)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("((((host_name()+'/')+isnull(CONVERT([varchar],connectionproperty('client_net_address')),'-'))+'/')+isnull(CONVERT([varchar],connectionproperty('local_net_address')),'-'))")
                .HasColumnName("Aud_PC_Ingreso");
            entity.Property(e => e.AudPcModifica)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("((((host_name()+'/')+isnull(CONVERT([varchar],connectionproperty('client_net_address')),'-'))+'/')+isnull(CONVERT([varchar],connectionproperty('local_net_address')),'-'))")
                .HasColumnName("Aud_PC_Modifica");
            entity.Property(e => e.AudUsuarioIngreso)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("(user_name())")
                .HasColumnName("Aud_Usuario_Ingreso");
            entity.Property(e => e.AudUsuarioModifica)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("(user_name())")
                .HasColumnName("Aud_Usuario_Modifica");
            entity.Property(e => e.SricomptipCodigoSri)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("SRICOMPTIP_CODIGO_SRI");
            entity.Property(e => e.SricomptipDecripcion)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("SRICOMPTIP_DECRIPCION");
            entity.Property(e => e.SricomptipEstado)
                .HasDefaultValueSql("((1))")
                .HasColumnName("SRICOMPTIP_ESTADO");
        });

        modelBuilder.Entity<SriFormaPago>(entity =>
        {
            entity.HasKey(e => e.SriformpagId);

            entity.ToTable("SRI_FORMA_PAGO");

            entity.HasIndex(e => e.SriformpagNombre, "UQ__SRI_FORM__F412C2E7F18FF083").IsUnique();

            entity.Property(e => e.SriformpagId).HasColumnName("SRIFORMPAG_ID");
            entity.Property(e => e.AudFechaIngreso)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Aud_Fecha_Ingreso");
            entity.Property(e => e.AudFechaModifica)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Aud_Fecha_Modifica");
            entity.Property(e => e.AudPcIngreso)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("((((host_name()+'/')+isnull(CONVERT([varchar],connectionproperty('client_net_address')),'-'))+'/')+isnull(CONVERT([varchar],connectionproperty('local_net_address')),'-'))")
                .HasColumnName("Aud_PC_Ingreso");
            entity.Property(e => e.AudPcModifica)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("((((host_name()+'/')+isnull(CONVERT([varchar],connectionproperty('client_net_address')),'-'))+'/')+isnull(CONVERT([varchar],connectionproperty('local_net_address')),'-'))")
                .HasColumnName("Aud_PC_Modifica");
            entity.Property(e => e.AudUsuarioIngreso)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("(user_name())")
                .HasColumnName("Aud_Usuario_Ingreso");
            entity.Property(e => e.AudUsuarioModifica)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("(user_name())")
                .HasColumnName("Aud_Usuario_Modifica");
            entity.Property(e => e.SriformpagCodigoSri)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SRIFORMPAG_CODIGO_SRI");
            entity.Property(e => e.SriformpagEstado)
                .HasDefaultValueSql("((1))")
                .HasColumnName("SRIFORMPAG_ESTADO");
            entity.Property(e => e.SriformpagNombre)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("SRIFORMPAG_NOMBRE");
            entity.Property(e => e.SriformpagVigenciaFin)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("SRIFORMPAG_VIGENCIA_FIN");
            entity.Property(e => e.SriformpagVigenciaIni)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("SRIFORMPAG_VIGENCIA_INI");
        });

        modelBuilder.Entity<SriIce>(entity =>
        {
            entity.ToTable("SRI_ICE");

            entity.Property(e => e.SriiceId).HasColumnName("SRIICE_ID");
            entity.Property(e => e.AudFechaIngreso)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Aud_Fecha_Ingreso");
            entity.Property(e => e.AudFechaModifica)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Aud_Fecha_Modifica");
            entity.Property(e => e.AudPcIngreso)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("((((host_name()+'/')+isnull(CONVERT([varchar],connectionproperty('client_net_address')),'-'))+'/')+isnull(CONVERT([varchar],connectionproperty('local_net_address')),'-'))")
                .HasColumnName("Aud_PC_Ingreso");
            entity.Property(e => e.AudPcModifica)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("((((host_name()+'/')+isnull(CONVERT([varchar],connectionproperty('client_net_address')),'-'))+'/')+isnull(CONVERT([varchar],connectionproperty('local_net_address')),'-'))")
                .HasColumnName("Aud_PC_Modifica");
            entity.Property(e => e.AudUsuarioIngreso)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("(user_name())")
                .HasColumnName("Aud_Usuario_Ingreso");
            entity.Property(e => e.AudUsuarioModifica)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("(user_name())")
                .HasColumnName("Aud_Usuario_Modifica");
            entity.Property(e => e.SriiceCodigoSri)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SRIICE_CODIGO_SRI");
            entity.Property(e => e.SriiceDecripcion)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("SRIICE_DECRIPCION");
            entity.Property(e => e.SriiceEstado)
                .HasDefaultValueSql("((1))")
                .HasColumnName("SRIICE_ESTADO");
            entity.Property(e => e.SriicePorcentajeImpuesto)
                .HasDefaultValueSql("('0.00')")
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("SRIICE_PORCENTAJE_IMPUESTO");
            entity.Property(e => e.SriiceVigenciaFin)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("SRIICE_VIGENCIA_FIN");
            entity.Property(e => e.SriiceVigenciaIni)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("SRIICE_VIGENCIA_INI");
        });

        modelBuilder.Entity<SriIdentificacion>(entity =>
        {
            entity.HasKey(e => e.SriidentId);

            entity.ToTable("SRI_IDENTIFICACION");

            entity.Property(e => e.SriidentId).HasColumnName("SRIIDENT_ID");
            entity.Property(e => e.AudFechaIngreso)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Aud_Fecha_Ingreso");
            entity.Property(e => e.AudFechaModifica)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Aud_Fecha_Modifica");
            entity.Property(e => e.AudPcIngreso)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("((((host_name()+'/')+isnull(CONVERT([varchar],connectionproperty('client_net_address')),'-'))+'/')+isnull(CONVERT([varchar],connectionproperty('local_net_address')),'-'))")
                .HasColumnName("Aud_PC_Ingreso");
            entity.Property(e => e.AudPcModifica)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("((((host_name()+'/')+isnull(CONVERT([varchar],connectionproperty('client_net_address')),'-'))+'/')+isnull(CONVERT([varchar],connectionproperty('local_net_address')),'-'))")
                .HasColumnName("Aud_PC_Modifica");
            entity.Property(e => e.AudUsuarioIngreso)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("(user_name())")
                .HasColumnName("Aud_Usuario_Ingreso");
            entity.Property(e => e.AudUsuarioModifica)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("(user_name())")
                .HasColumnName("Aud_Usuario_Modifica");
            entity.Property(e => e.SriidentCodigoSri)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SRIIDENT_CODIGO_SRI");
            entity.Property(e => e.SriidentDecripcion)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("SRIIDENT_DECRIPCION");
            entity.Property(e => e.SriidentEstado)
                .HasDefaultValueSql("((1))")
                .HasColumnName("SRIIDENT_ESTADO");
        });

        modelBuilder.Entity<SriIva>(entity =>
        {
            entity.ToTable("SRI_IVA");

            entity.Property(e => e.SriivaId).HasColumnName("SRIIVA_ID");
            entity.Property(e => e.AudFechaIngreso)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Aud_Fecha_Ingreso");
            entity.Property(e => e.AudFechaModifica)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Aud_Fecha_Modifica");
            entity.Property(e => e.AudPcIngreso)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("((((host_name()+'/')+isnull(CONVERT([varchar],connectionproperty('client_net_address')),'-'))+'/')+isnull(CONVERT([varchar],connectionproperty('local_net_address')),'-'))")
                .HasColumnName("Aud_PC_Ingreso");
            entity.Property(e => e.AudPcModifica)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("((((host_name()+'/')+isnull(CONVERT([varchar],connectionproperty('client_net_address')),'-'))+'/')+isnull(CONVERT([varchar],connectionproperty('local_net_address')),'-'))")
                .HasColumnName("Aud_PC_Modifica");
            entity.Property(e => e.AudUsuarioIngreso)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("(user_name())")
                .HasColumnName("Aud_Usuario_Ingreso");
            entity.Property(e => e.AudUsuarioModifica)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("(user_name())")
                .HasColumnName("Aud_Usuario_Modifica");
            entity.Property(e => e.SriivaCodigoSri)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SRIIVA_CODIGO_SRI");
            entity.Property(e => e.SriivaDecripcion)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SRIIVA_DECRIPCION");
            entity.Property(e => e.SriivaEstado)
                .HasDefaultValueSql("((1))")
                .HasColumnName("SRIIVA_ESTADO");
            entity.Property(e => e.SriivaPorcentajeImpuesto)
                .HasDefaultValueSql("('0.00')")
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("SRIIVA_PORCENTAJE_IMPUESTO");
            entity.Property(e => e.SriivaVigenciaFin)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("SRIIVA_VIGENCIA_FIN");
            entity.Property(e => e.SriivaVigenciaIni)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("SRIIVA_VIGENCIA_INI");
        });

        modelBuilder.Entity<SriTalonario>(entity =>
        {
            entity.HasKey(e => e.SritalId);

            entity.ToTable("SRI_TALONARIOS");

            entity.Property(e => e.SritalId).HasColumnName("SRITAL_ID");
            entity.Property(e => e.AudFechaIngreso)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Aud_Fecha_Ingreso");
            entity.Property(e => e.AudFechaModifica)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Aud_Fecha_Modifica");
            entity.Property(e => e.AudPcIngreso)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("((((host_name()+'/')+isnull(CONVERT([varchar],connectionproperty('client_net_address')),'-'))+'/')+isnull(CONVERT([varchar],connectionproperty('local_net_address')),'-'))")
                .HasColumnName("Aud_PC_Ingreso");
            entity.Property(e => e.AudPcModifica)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("((((host_name()+'/')+isnull(CONVERT([varchar],connectionproperty('client_net_address')),'-'))+'/')+isnull(CONVERT([varchar],connectionproperty('local_net_address')),'-'))")
                .HasColumnName("Aud_PC_Modifica");
            entity.Property(e => e.AudUsuarioIngreso)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("(user_name())")
                .HasColumnName("Aud_Usuario_Ingreso");
            entity.Property(e => e.AudUsuarioModifica)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("(user_name())")
                .HasColumnName("Aud_Usuario_Modifica");
            entity.Property(e => e.GenempId).HasColumnName("GENEMP_ID");
            entity.Property(e => e.SritalComprobanteTipo).HasColumnName("SRITAL_COMPROBANTE_TIPO");
            entity.Property(e => e.SritalDecripcion)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("SRITAL_DECRIPCION");
            entity.Property(e => e.SritalEmision)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("SRITAL_EMISION");
            entity.Property(e => e.SritalEstablecimiento)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("SRITAL_ESTABLECIMIENTO");
            entity.Property(e => e.SritalEstado)
                .HasDefaultValueSql("((1))")
                .HasColumnName("SRITAL_ESTADO");
            entity.Property(e => e.SritalFechaEmisionTal)
                .HasColumnType("date")
                .HasColumnName("SRITAL_FECHA_EMISION_TAL");
            entity.Property(e => e.SritalFechaExpiraTal)
                .HasColumnType("date")
                .HasColumnName("SRITAL_FECHA_EXPIRA_TAL");
            entity.Property(e => e.SritalSecuencia)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("SRITAL_SECUENCIA");
            entity.Property(e => e.SritalSecuenciaActual)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("SRITAL_SECUENCIA_ACTUAL");
            entity.Property(e => e.SritalSecuenciaFinal)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("SRITAL_SECUENCIA_FINAL");
            entity.Property(e => e.SritalSecuenciaInicial)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("SRITAL_SECUENCIA_INICIAL");

            entity.HasOne(d => d.Genemp).WithMany(p => p.SriTalonarios)
                .HasForeignKey(d => d.GenempId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SRI_TALONARIOS_EMP");

            entity.HasOne(d => d.SritalComprobanteTipoNavigation).WithMany(p => p.SriTalonarios)
                .HasForeignKey(d => d.SritalComprobanteTipo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SRI_TALONARIOS");
        });

        modelBuilder.Entity<VentaFacturaCab>(entity =>
        {
            entity.HasKey(e => e.VtafactCabId);

            entity.ToTable("VENTA_FACTURA_CAB");

            entity.Property(e => e.VtafactCabId).HasColumnName("VTAFACT_CAB_ID");
            entity.Property(e => e.AudFechaIngreso)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Aud_Fecha_Ingreso");
            entity.Property(e => e.AudFechaModifica)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Aud_Fecha_Modifica");
            entity.Property(e => e.AudPcIngreso)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("((((host_name()+'/')+isnull(CONVERT([varchar],connectionproperty('client_net_address')),'-'))+'/')+isnull(CONVERT([varchar],connectionproperty('local_net_address')),'-'))")
                .HasColumnName("Aud_PC_Ingreso");
            entity.Property(e => e.AudPcModifica)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("((((host_name()+'/')+isnull(CONVERT([varchar],connectionproperty('client_net_address')),'-'))+'/')+isnull(CONVERT([varchar],connectionproperty('local_net_address')),'-'))")
                .HasColumnName("Aud_PC_Modifica");
            entity.Property(e => e.AudUsuarioIngreso)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("(user_name())")
                .HasColumnName("Aud_Usuario_Ingreso");
            entity.Property(e => e.AudUsuarioModifica)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("(user_name())")
                .HasColumnName("Aud_Usuario_Modifica");
            entity.Property(e => e.GencliCorreo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GENCLI_CORREO");
            entity.Property(e => e.GencliIdentificaNum)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("GENCLI_IDENTIFICA_NUM");
            entity.Property(e => e.GencliTelefono)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("GENCLI_TELEFONO");
            entity.Property(e => e.GenempId).HasColumnName("GENEMP_ID");
            entity.Property(e => e.SriidentCodigoSri)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SRIIDENT_CODIGO_SRI");
            entity.Property(e => e.VtafactCabAmbienteTipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('1')")
                .HasColumnName("VTAFACT_CAB_AMBIENTE_TIPO");
            entity.Property(e => e.VtafactCabBarra)
                .HasMaxLength(49)
                .IsUnicode(false)
                .HasColumnName("VTAFACT_CAB_BARRA");
            entity.Property(e => e.VtafactCabClaveAcceso)
                .HasMaxLength(55)
                .IsUnicode(false)
                .HasColumnName("VTAFACT_CAB_CLAVE_ACCESO");
            entity.Property(e => e.VtafactCabCodNumerico)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("VTAFACT_CAB_COD_NUMERICO");
            entity.Property(e => e.VtafactCabComprobanteTipo)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("VTAFACT_CAB_COMPROBANTE_TIPO");
            entity.Property(e => e.VtafactCabDescuentoF)
                .HasDefaultValueSql("((0))")
                .HasColumnName("VTAFACT_CAB_DESCUENTO_F");
            entity.Property(e => e.VtafactCabDescuentoTt)
                .HasDefaultValueSql("('0,00')")
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("VTAFACT_CAB_DESCUENTO_TT");
            entity.Property(e => e.VtafactCabDigVerificador)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('1')")
                .HasColumnName("VTAFACT_CAB_DIG_VERIFICADOR");
            entity.Property(e => e.VtafactCabEmision)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("VTAFACT_CAB_EMISION");
            entity.Property(e => e.VtafactCabEstablecimiento)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("VTAFACT_CAB_ESTABLECIMIENTO");
            entity.Property(e => e.VtafactCabEstado)
                .HasDefaultValueSql("((1))")
                .HasColumnName("VTAFACT_CAB_ESTADO");
            entity.Property(e => e.VtafactCabFechaEmision)
                .HasColumnType("datetime")
                .HasColumnName("VTAFACT_CAB_FECHA_EMISION");
            entity.Property(e => e.VtafactCabFormpag).HasColumnName("VTAFACT_CAB_FORMPAG");
            entity.Property(e => e.VtafactCabNumFactura)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("VTAFACT_CAB_NUM_FACTURA");
            entity.Property(e => e.VtafactCabSecuencia)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("VTAFACT_CAB_SECUENCIA");
            entity.Property(e => e.VtafactCabSriiceTt)
                .HasDefaultValueSql("('0.00')")
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("VTAFACT_CAB_SRIICE_TT");
            entity.Property(e => e.VtafactCabSubtotal0)
                .HasDefaultValueSql("('0.00')")
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("VTAFACT_CAB_SUBTOTAL_0");
            entity.Property(e => e.VtafactCabSubtotal12)
                .HasDefaultValueSql("('0.00')")
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("VTAFACT_CAB_SUBTOTAL_12");
            entity.Property(e => e.VtafactCabSubtotalNoIva)
                .HasDefaultValueSql("('0.00')")
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("VTAFACT_CAB_SUBTOTAL_NO_IVA");
            entity.Property(e => e.VtafactCabSubtotalSinImpuestos)
                .HasDefaultValueSql("('0.00')")
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("VTAFACT_CAB_SUBTOTAL_SIN_IMPUESTOS");
            entity.Property(e => e.VtafactCabTalonario).HasColumnName("VTAFACT_CAB_TALONARIO");
            entity.Property(e => e.VtafactCabTipoEmision)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('1')")
                .HasColumnName("VTAFACT_CAB_TIPO_EMISION");
            entity.Property(e => e.VtafactCabTotal)
                .HasDefaultValueSql("('0,00')")
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("VTAFACT_CAB_TOTAL");
            entity.Property(e => e.VtafactCabTtIva)
                .HasDefaultValueSql("('0,00')")
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("VTAFACT_CAB_TT_IVA");

            entity.HasOne(d => d.GencliIdentificaNumNavigation).WithMany(p => p.VentaFacturaCabs)
                .HasPrincipalKey(p => p.GencliIdentificaNum)
                .HasForeignKey(d => d.GencliIdentificaNum)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VENTA_FACTURA_CAB_GEN_CLIENTES");

            entity.HasOne(d => d.Genemp).WithMany(p => p.VentaFacturaCabs)
                .HasForeignKey(d => d.GenempId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VENTA_FACTURA_CAB_EMPRESA");

            entity.HasOne(d => d.VtafactCabFormpagNavigation).WithMany(p => p.VentaFacturaCabs)
                .HasForeignKey(d => d.VtafactCabFormpag)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VENTA_FACTURA_CAB_FORMA_PAGO");
        });

        modelBuilder.Entity<VentaFacturaDet>(entity =>
        {
            entity.HasKey(e => e.VtafactDetId);

            entity.ToTable("VENTA_FACTURA_DET");

            entity.Property(e => e.VtafactDetId).HasColumnName("VTAFACT_DET_ID");
            entity.Property(e => e.AudFechaIngreso)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Aud_Fecha_Ingreso");
            entity.Property(e => e.AudFechaModifica)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Aud_Fecha_Modifica");
            entity.Property(e => e.AudPcIngreso)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("((((host_name()+'/')+isnull(CONVERT([varchar],connectionproperty('client_net_address')),'-'))+'/')+isnull(CONVERT([varchar],connectionproperty('local_net_address')),'-'))")
                .HasColumnName("Aud_PC_Ingreso");
            entity.Property(e => e.AudPcModifica)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("((((host_name()+'/')+isnull(CONVERT([varchar],connectionproperty('client_net_address')),'-'))+'/')+isnull(CONVERT([varchar],connectionproperty('local_net_address')),'-'))")
                .HasColumnName("Aud_PC_Modifica");
            entity.Property(e => e.AudUsuarioIngreso)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("(user_name())")
                .HasColumnName("Aud_Usuario_Ingreso");
            entity.Property(e => e.AudUsuarioModifica)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("(user_name())")
                .HasColumnName("Aud_Usuario_Modifica");
            entity.Property(e => e.GenempId).HasColumnName("GENEMP_ID");
            entity.Property(e => e.GenprodId)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("GENPROD_ID");
            entity.Property(e => e.VtafactCabId).HasColumnName("VTAFACT_CAB_ID");
            entity.Property(e => e.VtafactDetCantidad)
                .HasDefaultValueSql("('1.00')")
                .HasColumnName("VTAFACT_DET_CANTIDAD");
            entity.Property(e => e.VtafactDetDescuento)
                .HasDefaultValueSql("((0))")
                .HasColumnName("VTAFACT_DET_DESCUENTO");
            entity.Property(e => e.VtafactDetDescuentoTt)
                .HasDefaultValueSql("('0,00')")
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("VTAFACT_DET_DESCUENTO_TT");
            entity.Property(e => e.VtafactDetIvaTotal)
                .HasDefaultValueSql("('0,00')")
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("VTAFACT_DET_IVA_TOTAL");
            entity.Property(e => e.VtafactDetSriiceTotal)
                .HasDefaultValueSql("('0,00')")
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("VTAFACT_DET_SRIICE_TOTAL");
            entity.Property(e => e.VtafactDetSubtotal)
                .HasDefaultValueSql("('0,00')")
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("VTAFACT_DET_SUBTOTAL");
            entity.Property(e => e.VtafactDetTotal)
                .HasDefaultValueSql("('0,00')")
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("VTAFACT_DET_TOTAL");
            entity.Property(e => e.VtafactEstado)
                .HasDefaultValueSql("((1))")
                .HasColumnName("VTAFACT_ESTADO");
            entity.Property(e => e.VtafactSriiceId).HasColumnName("VTAFACT_SRIICE_ID");
            entity.Property(e => e.VtafactSriicePorcent).HasColumnName("VTAFACT_SRIICE_PORCENT");
            entity.Property(e => e.VtafactSriivaId).HasColumnName("VTAFACT_SRIIVA_ID");
            entity.Property(e => e.VtafactSriivaPorcent).HasColumnName("VTAFACT_SRIIVA_PORCENT");

            entity.HasOne(d => d.Genemp).WithMany(p => p.VentaFacturaDets)
                .HasForeignKey(d => d.GenempId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VENTA_FACTURA_DET_EMPRESA");

            entity.HasOne(d => d.Genprod).WithMany(p => p.VentaFacturaDets)
                .HasPrincipalKey(p => p.GenprodCodigo)
                .HasForeignKey(d => d.GenprodId)
                .HasConstraintName("FK_VENTA_FACTURA_DET_GEN_PRODUCTOS");

            entity.HasOne(d => d.VtafactCab).WithMany(p => p.VentaFacturaDets)
                .HasForeignKey(d => d.VtafactCabId)
                .HasConstraintName("FK_VENTA_FACTURA_DET_VENTA_FACTURA_CAB");

            entity.HasOne(d => d.VtafactSriice).WithMany(p => p.VentaFacturaDets)
                .HasForeignKey(d => d.VtafactSriiceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VENTA_FACTURA_DET_SRI_ICE");

            entity.HasOne(d => d.VtafactSriiva).WithMany(p => p.VentaFacturaDets)
                .HasForeignKey(d => d.VtafactSriivaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VENTA_FACTURA_DET_SRI_IVA");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
