using System;
using System.Collections.Generic;

namespace Banca_API.Models;

public partial class SriIdentificacion
{
    public int SriidentId { get; set; }

    public string SriidentDecripcion { get; set; } = null!;

    public string? SriidentCodigoSri { get; set; }

    public bool? SriidentEstado { get; set; }

    public string AudUsuarioIngreso { get; set; } = null!;

    public DateTime AudFechaIngreso { get; set; }

    public string AudPcIngreso { get; set; } = null!;

    public string AudUsuarioModifica { get; set; } = null!;

    public DateTime AudFechaModifica { get; set; }

    public string AudPcModifica { get; set; } = null!;

    public virtual ICollection<GenCliente> GenClientes { get; set; } = new List<GenCliente>();
}
