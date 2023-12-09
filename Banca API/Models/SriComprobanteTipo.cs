using System;
using System.Collections.Generic;

namespace Banca_API.Models;

public partial class SriComprobanteTipo
{
    public int SricomptipId { get; set; }

    public string SricomptipDecripcion { get; set; } = null!;

    public string? SricomptipCodigoSri { get; set; }

    public bool? SricomptipEstado { get; set; }

    public string AudUsuarioIngreso { get; set; } = null!;

    public DateTime AudFechaIngreso { get; set; }

    public string AudPcIngreso { get; set; } = null!;

    public string AudUsuarioModifica { get; set; } = null!;

    public DateTime AudFechaModifica { get; set; }

    public string AudPcModifica { get; set; } = null!;

    public virtual ICollection<SriTalonario> SriTalonarios { get; set; } = new List<SriTalonario>();
}
