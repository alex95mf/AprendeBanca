using System;
using System.Collections.Generic;

namespace Banca_API.Models;

public partial class ConCuentaClase
{
    public int ConCtaclsId { get; set; }

    public int GenempId { get; set; }

    public string ConCtaclsGrupo { get; set; } = null!;

    public string ConCtaclsNombre { get; set; } = null!;

    public int ConCtatipId { get; set; }

    public bool? ConCtatipEstado { get; set; }

    public string AudUsuarioIngreso { get; set; } = null!;

    public DateTime AudFechaIngreso { get; set; }

    public string AudPcIngreso { get; set; } = null!;

    public string AudUsuarioModifica { get; set; } = null!;

    public DateTime AudFechaModifica { get; set; }

    public string AudPcModifica { get; set; } = null!;

    public virtual ConCuentaTipo ConCtatip { get; set; } = null!;

    public virtual ICollection<ConCuentaPlan> ConCuentaPlans { get; set; } = new List<ConCuentaPlan>();

    public virtual GenEmpresa Genemp { get; set; } = null!;
}
