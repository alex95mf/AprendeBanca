using System;
using System.Collections.Generic;

namespace Banca_API.Models;

public partial class SriTalonario
{
    public int SritalId { get; set; }

    public int GenempId { get; set; }

    public int SritalComprobanteTipo { get; set; }

    public string SritalEmision { get; set; } = null!;

    public string SritalEstablecimiento { get; set; } = null!;

    public string SritalSecuencia { get; set; } = null!;

    public DateTime SritalFechaEmisionTal { get; set; }

    public DateTime SritalFechaExpiraTal { get; set; }

    public string SritalSecuenciaInicial { get; set; } = null!;

    public string SritalSecuenciaFinal { get; set; } = null!;

    public string SritalSecuenciaActual { get; set; } = null!;

    public string SritalDecripcion { get; set; } = null!;

    public bool? SritalEstado { get; set; }

    public string AudUsuarioIngreso { get; set; } = null!;

    public DateTime AudFechaIngreso { get; set; }

    public string AudPcIngreso { get; set; } = null!;

    public string AudUsuarioModifica { get; set; } = null!;

    public DateTime AudFechaModifica { get; set; }

    public string AudPcModifica { get; set; } = null!;

    public virtual GenEmpresa Genemp { get; set; } = null!;

    public virtual SriComprobanteTipo SritalComprobanteTipoNavigation { get; set; } = null!;
}
