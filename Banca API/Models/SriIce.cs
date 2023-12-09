using System;
using System.Collections.Generic;

namespace Banca_API.Models;

public partial class SriIce
{
    public int SriiceId { get; set; }

    public string SriiceDecripcion { get; set; } = null!;

    public decimal SriicePorcentajeImpuesto { get; set; }

    public string? SriiceCodigoSri { get; set; }

    public DateTime SriiceVigenciaIni { get; set; }

    public DateTime SriiceVigenciaFin { get; set; }

    public bool? SriiceEstado { get; set; }

    public string AudUsuarioIngreso { get; set; } = null!;

    public DateTime AudFechaIngreso { get; set; }

    public string AudPcIngreso { get; set; } = null!;

    public string AudUsuarioModifica { get; set; } = null!;

    public DateTime AudFechaModifica { get; set; }

    public string AudPcModifica { get; set; } = null!;

    public virtual ICollection<VentaFacturaDet> VentaFacturaDets { get; set; } = new List<VentaFacturaDet>();
}
