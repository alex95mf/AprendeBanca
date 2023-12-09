using System;
using System.Collections.Generic;

namespace Banca_API.Models;

public partial class SriIva
{
    public int SriivaId { get; set; }

    public string SriivaDecripcion { get; set; } = null!;

    public decimal SriivaPorcentajeImpuesto { get; set; }

    public string? SriivaCodigoSri { get; set; }

    public DateTime SriivaVigenciaIni { get; set; }

    public DateTime SriivaVigenciaFin { get; set; }

    public bool? SriivaEstado { get; set; }

    public string AudUsuarioIngreso { get; set; } = null!;

    public DateTime AudFechaIngreso { get; set; }

    public string AudPcIngreso { get; set; } = null!;

    public string AudUsuarioModifica { get; set; } = null!;

    public DateTime AudFechaModifica { get; set; }

    public string AudPcModifica { get; set; } = null!;

    public virtual ICollection<VentaFacturaDet> VentaFacturaDets { get; set; } = new List<VentaFacturaDet>();
}
