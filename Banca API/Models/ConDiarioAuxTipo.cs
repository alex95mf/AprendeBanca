using System;
using System.Collections.Generic;

namespace Banca_API.Models;

public partial class ConDiarioAuxTipo
{
    public int ConDiarauxTipoId { get; set; }

    public string ConDiarauxTipoDescripcion { get; set; } = null!;

    public bool? ConDiarauxTipoEstado { get; set; }

    public string AudUsuarioIngreso { get; set; } = null!;

    public DateTime AudFechaIngreso { get; set; }

    public string AudPcIngreso { get; set; } = null!;

    public string AudUsuarioModifica { get; set; } = null!;

    public DateTime AudFechaModifica { get; set; }

    public string AudPcModifica { get; set; } = null!;

    public virtual ICollection<ConDiarioAux> ConDiarioAuxes { get; set; } = new List<ConDiarioAux>();
}
