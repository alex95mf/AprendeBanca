using System;
using System.Collections.Generic;

namespace Banca_API.Models;

public partial class GenEmpresa
{
    public int GenempId { get; set; }

    public string GenempRuc { get; set; } = null!;

    public string GenempNomComercial { get; set; } = null!;

    public string GenempRazonSocial { get; set; } = null!;

    public string GenempDireccionMatriz { get; set; } = null!;

    public string GenempCorreoElectronico { get; set; } = null!;

    public string GenempTelefono1 { get; set; } = null!;

    public string GenempTelefono2 { get; set; } = null!;

    public bool? GenempEstado { get; set; }

    public string AudUsuarioIngreso { get; set; } = null!;

    public DateTime AudFechaIngreso { get; set; }

    public string AudPcIngreso { get; set; } = null!;

    public string AudUsuarioModifica { get; set; } = null!;

    public DateTime AudFechaModifica { get; set; }

    public string AudPcModifica { get; set; } = null!;

    public virtual ICollection<ConCentroCosto> ConCentroCostos { get; set; } = new List<ConCentroCosto>();

    public virtual ICollection<ConCentroCostosTipo> ConCentroCostosTipos { get; set; } = new List<ConCentroCostosTipo>();

    public virtual ICollection<ConCuentaClase> ConCuentaClases { get; set; } = new List<ConCuentaClase>();

    public virtual ICollection<ConCuentaNivel> ConCuentaNivels { get; set; } = new List<ConCuentaNivel>();

    public virtual ICollection<ConCuentaPlan> ConCuentaPlans { get; set; } = new List<ConCuentaPlan>();

    public virtual ICollection<ConCuentaTipo> ConCuentaTipos { get; set; } = new List<ConCuentaTipo>();

    public virtual ICollection<ConDiarioAux> ConDiarioAuxes { get; set; } = new List<ConDiarioAux>();

    public virtual ICollection<ConDiarioCab> ConDiarioCabs { get; set; } = new List<ConDiarioCab>();

    public virtual ICollection<ConDiarioDet> ConDiarioDets { get; set; } = new List<ConDiarioDet>();

    public virtual ICollection<ConDiarioSecuencium> ConDiarioSecuencia { get; set; } = new List<ConDiarioSecuencium>();

    public virtual ICollection<ConDiarioTipo> ConDiarioTipos { get; set; } = new List<ConDiarioTipo>();

    public virtual ICollection<ConEstadoContab> ConEstadoContabs { get; set; } = new List<ConEstadoContab>();

    public virtual ICollection<GenAnio> GenAnios { get; set; } = new List<GenAnio>();

    public virtual ICollection<GenCliente> GenClientes { get; set; } = new List<GenCliente>();

    public virtual ICollection<GenMe> GenMes { get; set; } = new List<GenMe>();

    public virtual ICollection<GenProducto> GenProductos { get; set; } = new List<GenProducto>();

    public virtual ICollection<GenStockCab> GenStockCabs { get; set; } = new List<GenStockCab>();

    public virtual ICollection<GenStockDet> GenStockDets { get; set; } = new List<GenStockDet>();

    public virtual ICollection<SegAutoregistro> SegAutoregistros { get; set; } = new List<SegAutoregistro>();

    public virtual ICollection<SegUsuario> SegUsuarios { get; set; } = new List<SegUsuario>();

    public virtual ICollection<SriTalonario> SriTalonarios { get; set; } = new List<SriTalonario>();

    public virtual ICollection<VentaFacturaCab> VentaFacturaCabs { get; set; } = new List<VentaFacturaCab>();

    public virtual ICollection<VentaFacturaDet> VentaFacturaDets { get; set; } = new List<VentaFacturaDet>();
}
