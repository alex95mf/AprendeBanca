using System;
using System.Collections.Generic;

namespace Banca_API.Models;

public partial class ConCentroCosto
{
    public int ConccosId { get; set; }

    public int GenempId { get; set; }

    public int GenanioId { get; set; }

    public int ConccosTipId { get; set; }

    public string ConccosCodigo { get; set; } = null!;

    public string ConccosNombre { get; set; } = null!;

    public int? ConCtaplaId { get; set; }

    public bool? ConccosTipEstado { get; set; }

    public string AudUsuarioIngreso { get; set; } = null!;

    public DateTime AudFechaIngreso { get; set; }

    public string AudPcIngreso { get; set; } = null!;

    public string AudUsuarioModifica { get; set; } = null!;

    public DateTime AudFechaModifica { get; set; }

    public string AudPcModifica { get; set; } = null!;

    public virtual ConCuentaPlan? ConCtapla { get; set; }

    public virtual ICollection<ConDiarioAux> ConDiarioAuxes { get; set; } = new List<ConDiarioAux>();

    public virtual ConCentroCostosTipo ConccosTip { get; set; } = null!;

    public virtual GenAnio Genanio { get; set; } = null!;

    public virtual GenEmpresa Genemp { get; set; } = null!;
}
