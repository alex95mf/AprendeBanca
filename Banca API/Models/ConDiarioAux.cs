using System;
using System.Collections.Generic;

namespace Banca_API.Models;

public partial class ConDiarioAux
{
    public int ConDiarauxId { get; set; }

    public int GenempId { get; set; }

    public int ConDiarcabId { get; set; }

    public int ConDiardetId { get; set; }

    public int ConDiarauxTipoId { get; set; }

    public string ConDiarauxCodigo { get; set; } = null!;

    public string ConDiarauxNombre { get; set; } = null!;

    public int ConccosId { get; set; }

    public string ConDiarauxGlosa { get; set; } = null!;

    public decimal ConDiarauxTotal { get; set; }

    public bool? ConDiarauxEstado { get; set; }

    public string AudUsuarioIngreso { get; set; } = null!;

    public DateTime AudFechaIngreso { get; set; }

    public string AudPcIngreso { get; set; } = null!;

    public string AudUsuarioModifica { get; set; } = null!;

    public DateTime AudFechaModifica { get; set; }

    public string AudPcModifica { get; set; } = null!;

    public virtual ConDiarioAuxTipo ConDiarauxTipo { get; set; } = null!;

    public virtual ConDiarioCab ConDiarcab { get; set; } = null!;

    public virtual ConDiarioDet ConDiardet { get; set; } = null!;

    public virtual ConCentroCosto Conccos { get; set; } = null!;

    public virtual GenEmpresa Genemp { get; set; } = null!;
}
