using System;
using System.Collections.Generic;

namespace Banca_API.Models;

public partial class SriFormaPago
{
    public int SriformpagId { get; set; }

    public string SriformpagNombre { get; set; } = null!;

    public string? SriformpagCodigoSri { get; set; }

    public DateTime SriformpagVigenciaIni { get; set; }

    public DateTime SriformpagVigenciaFin { get; set; }

    public bool? SriformpagEstado { get; set; }

    public string AudUsuarioIngreso { get; set; } = null!;

    public DateTime AudFechaIngreso { get; set; }

    public string AudPcIngreso { get; set; } = null!;

    public string AudUsuarioModifica { get; set; } = null!;

    public DateTime AudFechaModifica { get; set; }

    public string AudPcModifica { get; set; } = null!;

    public virtual ICollection<VentaFacturaCab> VentaFacturaCabs { get; set; } = new List<VentaFacturaCab>();
}
