using System;
using System.Collections.Generic;

namespace Banca_API.Models;

public partial class ConCuentaNivel
{
    public int ConCtanivId { get; set; }

    public int GenempId { get; set; }

    public int ConCtanivNivel { get; set; }

    public string ConCtanivDescripcion { get; set; } = null!;

    public int ConCtanivCantCaracter { get; set; }

    public int ConCtanivSeparadorSn { get; set; }

    public string ConCtanivSeparadorCaracter { get; set; } = null!;

    public bool? ConCtanivEstado { get; set; }

    public string AudUsuarioIngreso { get; set; } = null!;

    public DateTime AudFechaIngreso { get; set; }

    public string AudPcIngreso { get; set; } = null!;

    public string AudUsuarioModifica { get; set; } = null!;

    public DateTime AudFechaModifica { get; set; }

    public string AudPcModifica { get; set; } = null!;

    public virtual SegEstadoSn ConCtanivSeparadorSnNavigation { get; set; } = null!;

    public virtual ICollection<ConCuentaPlan> ConCuentaPlans { get; set; } = new List<ConCuentaPlan>();

    public virtual GenEmpresa Genemp { get; set; } = null!;
}
