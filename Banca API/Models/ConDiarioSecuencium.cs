using System;
using System.Collections.Generic;

namespace Banca_API.Models;

public partial class ConDiarioSecuencium
{
    public int ConDiarsecId { get; set; }

    public int GenempId { get; set; }

    public int GenanioId { get; set; }

    public int GenmesId { get; set; }

    public int ConDiartipId { get; set; }

    public string ConDiarsecNumero { get; set; } = null!;

    public bool? ConDiarsecEstado { get; set; }

    public string AudUsuarioIngreso { get; set; } = null!;

    public DateTime AudFechaIngreso { get; set; }

    public string AudPcIngreso { get; set; } = null!;

    public string AudUsuarioModifica { get; set; } = null!;

    public DateTime AudFechaModifica { get; set; }

    public string AudPcModifica { get; set; } = null!;

    public virtual ConDiarioTipo ConDiartip { get; set; } = null!;

    public virtual GenAnio Genanio { get; set; } = null!;

    public virtual GenEmpresa Genemp { get; set; } = null!;

    public virtual GenMe Genmes { get; set; } = null!;
}
