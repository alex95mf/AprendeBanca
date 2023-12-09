using System;
using System.Collections.Generic;

namespace Banca_API.Models;

public partial class ConDiarioCab
{
    public int ConDiarcabId { get; set; }

    public int GenempId { get; set; }

    public int GenanioId { get; set; }

    public int GenmesId { get; set; }

    public int ConDiartipId { get; set; }

    public string ConDiarcabNumero { get; set; } = null!;

    public DateTime ConDiarcabFechaContable { get; set; }

    public string ConDiarcabDiarioNombre { get; set; } = null!;

    public string ConDiarcabDiarioDescripcion { get; set; } = null!;

    public int ConEstcontId { get; set; }

    public decimal ConDiarcabTotalDebe { get; set; }

    public decimal ConDiarcabTotalHaber { get; set; }

    public DateTime ConDiarcabFechaDigitado { get; set; }

    public string ConDiarcabUsuarioDigita { get; set; } = null!;

    public DateTime ConDiarcabFechaProcesado { get; set; }

    public string ConDiarcabUsuarioProcesa { get; set; } = null!;

    public bool? ConDiarcabEstado { get; set; }

    public string AudUsuarioIngreso { get; set; } = null!;

    public DateTime AudFechaIngreso { get; set; }

    public string AudPcIngreso { get; set; } = null!;

    public string AudUsuarioModifica { get; set; } = null!;

    public DateTime AudFechaModifica { get; set; }

    public string AudPcModifica { get; set; } = null!;

    public virtual ICollection<ConDiarioAux> ConDiarioAuxes { get; set; } = new List<ConDiarioAux>();

    public virtual ICollection<ConDiarioDet> ConDiarioDets { get; set; } = new List<ConDiarioDet>();

    public virtual ConDiarioTipo ConDiartip { get; set; } = null!;

    public virtual ConEstadoContab ConEstcont { get; set; } = null!;

    public virtual GenAnio Genanio { get; set; } = null!;

    public virtual GenEmpresa Genemp { get; set; } = null!;

    public virtual GenMe Genmes { get; set; } = null!;
}
