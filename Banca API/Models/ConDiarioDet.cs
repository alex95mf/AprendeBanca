using System;
using System.Collections.Generic;

namespace Banca_API.Models;

public partial class ConDiarioDet
{
    public int ConDiardetId { get; set; }

    public int GenempId { get; set; }

    public int ConDiarcabId { get; set; }

    public int ConDiardetNumLin { get; set; }

    public int ConCtaplaId { get; set; }

    public string ConDiardetGlosa { get; set; } = null!;

    public decimal ConDiardetDebe { get; set; }

    public decimal ConDiardetHaber { get; set; }

    public int ConDiarioReqAuxSn { get; set; }

    public int ConDiarioReqCcoSn { get; set; }

    public decimal ConDiardetAuxTotal { get; set; }

    public string ConDiardetReferencia { get; set; } = null!;

    public bool? ConDiardetEstado { get; set; }

    public string AudUsuarioIngreso { get; set; } = null!;

    public DateTime AudFechaIngreso { get; set; }

    public string AudPcIngreso { get; set; } = null!;

    public string AudUsuarioModifica { get; set; } = null!;

    public DateTime AudFechaModifica { get; set; }

    public string AudPcModifica { get; set; } = null!;

    public virtual ConCuentaPlan ConCtapla { get; set; } = null!;

    public virtual ConDiarioCab ConDiarcab { get; set; } = null!;

    public virtual ICollection<ConDiarioAux> ConDiarioAuxes { get; set; } = new List<ConDiarioAux>();

    public virtual SegEstadoSn ConDiarioReqAuxSnNavigation { get; set; } = null!;

    public virtual SegEstadoSn ConDiarioReqCcoSnNavigation { get; set; } = null!;

    public virtual GenEmpresa Genemp { get; set; } = null!;
}
