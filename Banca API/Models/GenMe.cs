using System;
using System.Collections.Generic;

namespace Banca_API.Models;

public partial class GenMe
{
    public int GenmesId { get; set; }

    public int GenempId { get; set; }

    public int? GenmesEstadoSn { get; set; }

    public string GenmesDescripcion { get; set; } = null!;

    public bool? GenempEstado { get; set; }

    public string AudUsuarioIngreso { get; set; } = null!;

    public DateTime AudFechaIngreso { get; set; }

    public string AudPcIngreso { get; set; } = null!;

    public string AudUsuarioModifica { get; set; } = null!;

    public DateTime AudFechaModifica { get; set; }

    public string AudPcModifica { get; set; } = null!;

    public virtual ICollection<ConDiarioCab> ConDiarioCabs { get; set; } = new List<ConDiarioCab>();

    public virtual ICollection<ConDiarioSecuencium> ConDiarioSecuencia { get; set; } = new List<ConDiarioSecuencium>();

    public virtual GenEmpresa Genemp { get; set; } = null!;

    public virtual SegEstadoSn? GenmesEstadoSnNavigation { get; set; }
}
