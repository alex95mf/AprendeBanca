using System;
using System.Collections.Generic;

namespace Banca_API.Models;

public partial class ConCuentaTipo
{
    public int ConCtatipId { get; set; }

    public int GenempId { get; set; }

    public string ConCtatipDescripcion { get; set; } = null!;

    public bool? ConCtatipEstado { get; set; }

    public string AudUsuarioIngreso { get; set; } = null!;

    public DateTime AudFechaIngreso { get; set; }

    public string AudPcIngreso { get; set; } = null!;

    public string AudUsuarioModifica { get; set; } = null!;

    public DateTime AudFechaModifica { get; set; }

    public string AudPcModifica { get; set; } = null!;

    public virtual ICollection<ConCuentaClase> ConCuentaClases { get; set; } = new List<ConCuentaClase>();

    public virtual ICollection<ConCuentaPlan> ConCuentaPlans { get; set; } = new List<ConCuentaPlan>();

    public virtual GenEmpresa Genemp { get; set; } = null!;
}
