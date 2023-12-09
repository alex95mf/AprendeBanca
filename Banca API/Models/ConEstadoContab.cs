using System;
using System.Collections.Generic;

namespace Banca_API.Models;

public partial class ConEstadoContab
{
    public int ConEstcontId { get; set; }

    public int GenempId { get; set; }

    public string ConEstcontDescripcion { get; set; } = null!;

    public bool? ConEstcontEstado { get; set; }

    public string AudUsuarioIngreso { get; set; } = null!;

    public DateTime AudFechaIngreso { get; set; }

    public string AudPcIngreso { get; set; } = null!;

    public string AudUsuarioModifica { get; set; } = null!;

    public DateTime AudFechaModifica { get; set; }

    public string AudPcModifica { get; set; } = null!;

    public virtual ICollection<ConDiarioCab> ConDiarioCabs { get; set; } = new List<ConDiarioCab>();

    public virtual GenEmpresa Genemp { get; set; } = null!;
}
