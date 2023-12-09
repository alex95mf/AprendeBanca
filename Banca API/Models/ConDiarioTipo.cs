using System;
using System.Collections.Generic;

namespace Banca_API.Models;

public partial class ConDiarioTipo
{
    public int ConDiartipId { get; set; }

    public int GenempId { get; set; }

    public int GenanioId { get; set; }

    public string ConDiartipNombre { get; set; } = null!;

    public int ConComptipManualSn { get; set; }

    public bool? ConDiartipEstado { get; set; }

    public string AudUsuarioIngreso { get; set; } = null!;

    public DateTime AudFechaIngreso { get; set; }

    public string AudPcIngreso { get; set; } = null!;

    public string AudUsuarioModifica { get; set; } = null!;

    public DateTime AudFechaModifica { get; set; }

    public string AudPcModifica { get; set; } = null!;

    public virtual SegEstadoSn ConComptipManualSnNavigation { get; set; } = null!;

    public virtual ICollection<ConDiarioCab> ConDiarioCabs { get; set; } = new List<ConDiarioCab>();

    public virtual ICollection<ConDiarioSecuencium> ConDiarioSecuencia { get; set; } = new List<ConDiarioSecuencium>();

    public virtual GenAnio Genanio { get; set; } = null!;

    public virtual GenEmpresa Genemp { get; set; } = null!;
}
