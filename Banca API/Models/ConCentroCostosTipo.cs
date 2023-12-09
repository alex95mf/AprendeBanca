using System;
using System.Collections.Generic;

namespace Banca_API.Models;

public partial class ConCentroCostosTipo
{
    public int ConccosTipId { get; set; }

    public int GenempId { get; set; }

    public string ConccosTipNombre { get; set; } = null!;

    public bool? ConccosTipEstado { get; set; }

    public string AudUsuarioIngreso { get; set; } = null!;

    public DateTime AudFechaIngreso { get; set; }

    public string AudPcIngreso { get; set; } = null!;

    public string AudUsuarioModifica { get; set; } = null!;

    public DateTime AudFechaModifica { get; set; }

    public string AudPcModifica { get; set; } = null!;

    public virtual ICollection<ConCentroCosto> ConCentroCostos { get; set; } = new List<ConCentroCosto>();

    public virtual GenEmpresa Genemp { get; set; } = null!;
}
