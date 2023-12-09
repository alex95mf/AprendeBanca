using System;
using System.Collections.Generic;

namespace Banca_API.Models;

public partial class GenAnio
{
    public int GenanioId { get; set; }

    public int GenempId { get; set; }

    public int? GenanioEstadoSn { get; set; }

    public string GenanioDescripcion { get; set; } = null!;

    public bool? GenempEstado { get; set; }

    public string AudUsuarioIngreso { get; set; } = null!;

    public DateTime AudFechaIngreso { get; set; }

    public string AudPcIngreso { get; set; } = null!;

    public string AudUsuarioModifica { get; set; } = null!;

    public DateTime AudFechaModifica { get; set; }

    public string AudPcModifica { get; set; } = null!;

    public virtual ICollection<ConCentroCosto> ConCentroCostos { get; set; } = new List<ConCentroCosto>();

    public virtual ICollection<ConCuentaPlan> ConCuentaPlans { get; set; } = new List<ConCuentaPlan>();

    public virtual ICollection<ConDiarioCab> ConDiarioCabs { get; set; } = new List<ConDiarioCab>();

    public virtual ICollection<ConDiarioSecuencium> ConDiarioSecuencia { get; set; } = new List<ConDiarioSecuencium>();

    public virtual ICollection<ConDiarioTipo> ConDiarioTipos { get; set; } = new List<ConDiarioTipo>();

    public virtual SegEstadoSn? GenanioEstadoSnNavigation { get; set; }

    public virtual GenEmpresa Genemp { get; set; } = null!;
}
